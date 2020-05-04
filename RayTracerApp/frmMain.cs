using RayTracerLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace RayTracerApp
{
    public partial class frmMain : Form
    {
        private IRaTracer _rayTracer;
        private System.Drawing.Color _color;

        public frmMain()
        {
            InitializeComponent();
            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;
            _rayTracer = new RayTracer();
            DefaultData();
            picScene.Image = Properties.Resources.defaultPic;
        }

        private void DrawPicture(RayTracerLib.Color[,] pixels)
        {
            Bitmap bmp = new Bitmap(_rayTracer.canvasWidth, _rayTracer.canvasHeight);
            Graphics g = Graphics.FromImage(bmp);
            for (int i = 0; i < _rayTracer.canvasWidth; i++)
            {
                for (int j = 0; j < _rayTracer.canvasHeight; j++)
                {
                    var color = System.Drawing.Color.FromArgb((Byte)pixels[i, j].R, (Byte)pixels[i, j].G, (Byte)pixels[i, j].B);
                    Brush brush1 = new SolidBrush(color);
                    g.FillRectangle(brush1, i, j, 1, 1);
                }
            }
            g.Dispose();
            string path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments), "scene.png");
            if(File.Exists(path))
            {
                File.Delete(path);
            }
            bmp.Save(path, System.Drawing.Imaging.ImageFormat.Png);
            picScene.Image = Image.FromFile(path);
            bmp.Dispose();
            bw.CancelAsync();
        }

        private void DefaultData()
        {
            _color = new System.Drawing.Color();
            txtColor.Text = _color.Name;

            _rayTracer = new RayTracer();
            _rayTracer.canvasHeight = 600;
            _rayTracer.canvasWidth = 600;
            _rayTracer.lp = new Vector(0.0, 100.0, 300.0);
            _rayTracer.lv = new Vector(-1.0, 1.0, -1.0);
            _rayTracer.p = new Vector(100.0, 50.0, 500.0);

            picScene.Width = picScene.Height = 500;
            _rayTracer.objects = new List<BaseObject>();
            //_rayTracer.objects.Add(new Plane(new Vector(10.0, 10.0, -10), new Vector(10.0, 10.0, 10.0), new RayTracerLib.Color(255.0, 0.0, 0.0)));
            _rayTracer.objects.Add(new Sphere(60.0, 60.0, 0.0, 60.0, new RayTracerLib.Color(0.0, 0.0, 255.0)));
            _rayTracer.objects.Add(new Sphere(300.0, 300.0, 0.0, 40.0, new RayTracerLib.Color(255.0, 0.0, 255.0)));
            Vector v0 = new Vector(100.0, 100.0, 0.0);
            Vector v1 = new Vector(100.0, 80.0, 0.0);
            Vector v2 = new Vector(80.0, 100.0, 0.0);
            Triangle tt = new Triangle(v0, v1, v2, new RayTracerLib.Color(200.0, 30.0, 30.0));
            _rayTracer.objects.Add(tt);
            SaveDefaultSceneSettings();
            PopulateSphereListBox();
            PopulateSceneSettings();
        }
        private void SaveDefaultSceneSettings()
        {
            txtSceneCanvasWidth.Tag = _rayTracer.canvasWidth.ToString();
            txtSceneCanvasHeight.Tag = _rayTracer.canvasHeight.ToString();
            txtSceneCameraX.Tag = _rayTracer.p.X.ToString();
            txtSceneCameraY.Tag = _rayTracer.p.Y.ToString();
            txtSceneCameraZ.Tag = _rayTracer.p.Z.ToString();
            txtSceneLightDirectionX.Tag = _rayTracer.lv.X.ToString();
            txtSceneLightDirectionY.Tag = _rayTracer.lv.Y.ToString();
            txtSceneLightDirectionZ.Tag = _rayTracer.lv.Z.ToString();
            txtSceneLightPositionX.Tag = _rayTracer.lp.X.ToString();
            txtSceneLightPositionY.Tag = _rayTracer.lp.Y.ToString();
            txtSceneLightPositionZ.Tag = _rayTracer.lp.Z.ToString();
        }

        private void PopulateSceneSettings()
        {
            txtSceneCanvasWidth.Text = _rayTracer.canvasWidth.ToString();
            txtSceneCanvasHeight.Text = _rayTracer.canvasHeight.ToString();
            txtSceneCameraX.Text = _rayTracer.p.X.ToString();
            txtSceneCameraY.Text = _rayTracer.p.Y.ToString();
            txtSceneCameraZ.Text = _rayTracer.p.Z.ToString();
            txtSceneLightDirectionX.Text = _rayTracer.lv.X.ToString();
            txtSceneLightDirectionY.Text = _rayTracer.lv.Y.ToString();
            txtSceneLightDirectionZ.Text = _rayTracer.lv.Z.ToString();
            txtSceneLightPositionX.Text = _rayTracer.lp.X.ToString();
            txtSceneLightPositionY.Text = _rayTracer.lp.Y.ToString();
            txtSceneLightPositionZ.Text = _rayTracer.lp.Z.ToString();
        }

        private void PopulateSphereListBox()
        {
            lstSphere.Items.Clear();
            foreach (var sphere in _rayTracer.objects)
            {
                lstSphere.Items.Add(sphere.ToString());
            }
        }

        private void cmdColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                _color = colorDialog1.Color;
                txtColor.Text = _color.Name;
            }
        }

        private void cmdAddSphere_Click(object sender, EventArgs e)
        {
            _rayTracer.objects.Add(new Sphere(
                txtX.Text.SetDoubleValue(),
                txtY.Text.SetDoubleValue(),
                txtZ.Text.SetDoubleValue(),
                txtRadius.Text.SetDoubleValue(),
                new RayTracerLib.Color() { R = _color.R, B = _color.B, G = _color.G }
                ));

            PopulateSphereListBox();
            ClearSphereUI();
        }

        private void cmdStartRayTracing_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            //this.Cursor = Cursors.WaitCursor;
            picScene.Image = Properties.Resources.ProcessingDefaultPic;
            if (bw.IsBusy != true)
                bw.RunWorkerAsync();
            ClearSphereUI();
        }

        private void ClearSphereUI()
        {
            txtRadius.Text = string.Empty;
            txtColor.Text = string.Empty;
            txtX.Text = string.Empty;
            txtY.Text = string.Empty;
            txtZ.Text = string.Empty;
        }

        private void StartTracing()
        {
            RayTracerLib.Color[,] pixels = new RayTracerLib.Color[_rayTracer.canvasWidth, _rayTracer.canvasHeight];
            _rayTracer.RayTraceScene(ref pixels);
            DrawPicture(pixels);
        }

        private void ValidateDoubleInput(TextBox textBox)
        {
            var value = textBox.Text;
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                textBox.Text = "0.0";
            }
            textBox.Text.Trim().SetDoubleFormat();
        }

        private void txtRadius_Validating(object sender, CancelEventArgs e) => ValidateDoubleInput(sender as TextBox);

        private void txtX_Validating(object sender, CancelEventArgs e) => ValidateDoubleInput(sender as TextBox);

        private void txtY_Validating(object sender, CancelEventArgs e) => ValidateDoubleInput(sender as TextBox);

        private void txtZ_Validating(object sender, CancelEventArgs e) => ValidateDoubleInput(sender as TextBox);

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            worker.WorkerReportsProgress = true;
            if (worker.CancellationPending)
            {
                e.Cancel = true;
            }
            else
            {
                StartTracing();
            }
        }

        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //lbProgress.Text = (e.ProgressPercentage.ToString() + "%");
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (bw.WorkerSupportsCancellation)
            {
                bw.CancelAsync();
                Cursor.Current = Cursors.Default;
            }
        }

        private void cmdStopRayTracing_Click(object sender, EventArgs e)
        {
            picScene.Image = Properties.Resources.defaultPic;
            if (bw.WorkerSupportsCancellation)
                bw.CancelAsync();
        }

        private void cmdDeleteSphere_Click(object sender, EventArgs e)
        {
            var sphereToDelete = lstSphere.SelectedIndex;
            if (sphereToDelete >= 0 && sphereToDelete < _rayTracer.objects.Count)
            {
                _rayTracer.objects.RemoveAt(sphereToDelete);
                PopulateSphereListBox();
            }
        }

        private void cmdEditSphere_Click(object sender, EventArgs e)
        {
            if (lstSphere.SelectedIndex >= 0)
            {
                var selectedSphere = _rayTracer.objects.ElementAt(lstSphere.SelectedIndex) as Sphere;
                txtRadius.Text = selectedSphere.radius.ToString();
                txtX.Text = selectedSphere.position.X.ToString();
                txtY.Text = selectedSphere.position.Y.ToString();
                txtZ.Text = selectedSphere.position.Z.ToString();
                txtColor.Text = System.Drawing.Color.FromArgb(
                    (int)selectedSphere.color.R,
                    (int)selectedSphere.color.G,
                    (int)selectedSphere.color.B).Name;
            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdSaveSceneSettings_Click(object sender, EventArgs e)
        {
            _rayTracer.canvasWidth = txtSceneCanvasWidth.Text.SetIntValue();
            _rayTracer.canvasHeight = txtSceneCanvasHeight.Text.SetIntValue();
            _rayTracer.p = new Vector(
                txtSceneCameraX.Text.SetDoubleValue(),
                txtSceneCameraY.Text.SetDoubleValue(),
                txtSceneCameraZ.Text.SetDoubleValue()
                );
            _rayTracer.lv = new Vector(
                txtSceneLightDirectionX.Text.SetDoubleValue(),
                txtSceneLightDirectionY.Text.SetDoubleValue(),
                txtSceneLightDirectionZ.Text.SetDoubleValue()
                );
            _rayTracer.lp = new Vector(
                txtSceneLightPositionX.Text.SetDoubleValue(),
                txtSceneLightPositionY.Text.SetDoubleValue(),
                txtSceneLightPositionZ.Text.SetDoubleValue()
                );
        }

        private void cmdLoadSceneDefaults_Click(object sender, EventArgs e)
        {
            _rayTracer.canvasWidth = Convert.ToInt16(txtSceneCanvasWidth.Tag);
            _rayTracer.canvasHeight = Convert.ToInt16(txtSceneCanvasHeight.Tag);
            _rayTracer.p = new Vector(
                Convert.ToDouble(txtSceneCameraX.Tag),
                Convert.ToDouble(txtSceneCameraY.Tag),
                Convert.ToDouble(txtSceneCameraZ.Tag));
            _rayTracer.lv = new Vector(
                Convert.ToDouble(txtSceneLightDirectionX.Tag), 
                Convert.ToDouble(txtSceneLightDirectionY.Tag),
                Convert.ToDouble(txtSceneLightDirectionZ.Tag));
            _rayTracer.lp = new Vector(
                Convert.ToDouble(txtSceneLightPositionX.Tag), 
                Convert.ToDouble(txtSceneLightPositionY.Tag),
                Convert.ToDouble(txtSceneLightPositionZ.Tag));
            PopulateSceneSettings();
        }
    }
}
