using RayTracerLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RayTracerApp1
{
    public partial class Form1 : Form
    {
        private static string _filePath = @"c:\Users\k.skrabal\Documents\testBackGround.png";
        private static string _filePath1 = @"c:\Users\k.skrabal\Documents\default.png";
        private IRaTracer _rayTracer;
        private System.Drawing.Color _color;

        public Form1()
        {
            InitializeComponent();
            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;
            _rayTracer = new RayTracer();
            DefaultData();
            picScene.Image = Image.FromFile(_filePath1);
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
                    System.Drawing.Brush brush1 = new SolidBrush(color);
                    g.FillRectangle(brush1, i, j, 1, 1);
                }
            }
            g.Dispose();
            bmp.Save(_filePath, System.Drawing.Imaging.ImageFormat.Png);

            picScene.Image = Image.FromFile(_filePath);
            bmp.Dispose();
            bw.CancelAsync();
        }

        private void DefaultData()
        {
            _color = new System.Drawing.Color();
            txtColor.Text = _color.Name;

            _rayTracer = new RayTracerLib.RayTracer();
            _rayTracer.canvasHeight = 300;
            _rayTracer.canvasWidth = 300;
            _rayTracer.lp = new RayTracerLib.Vector(0.0, 0.0, 100.0);
            _rayTracer.lv = new RayTracerLib.Vector(-1.0, -1.0, -1.0);
            _rayTracer.p = new RayTracerLib.Vector(0.0, 0.0, 500.0);

            picScene.Width = 500;
            picScene.Height = 500;
            _rayTracer.objects = new List<BaseObject>();
            _rayTracer.objects.Add(new RayTracerLib.Sphere(100.0, 100.0, 0.0, 40.0, new RayTracerLib.Color(250.0, 0.0, 50.0)));
            //_rayTracer.objects.Add(new RayTracerLib.Sphere(20.0, 20.0, 0.0, 20.0, new RayTracerLib.Color(30.0, 30.0, 200.0)));
            //_rayTracer.objects.Add(new RayTracerLib.Sphere(10.0, 180.0, 0.0, 30.0, new RayTracerLib.Color(255, 30.0, 200.0)));
            //_rayTracer.objects.Add(new RayTracerLib.Sphere(10.0, 30.0, 0.0, 40.0, new RayTracerLib.Color(255, 30.0, 200.0)));
            //_rayTracer.objects.Add(new RayTracerLib.Sphere(210.0, 230.0, 0.0, 40.0, new RayTracerLib.Color(255, 30.0, 200.0)));
            //RayTracerLib.Vector v0 = new RayTracerLib.Vector(0.0, 0.0, 0.0);
            //RayTracerLib.Vector v1 = new RayTracerLib.Vector(200.0, 0.0, 0.0);
            //RayTracerLib.Vector v2 = new RayTracerLib.Vector(0.0, 200.0, 0.0);
            //rayTracer.objects.Add(new RayTracerLib.Triangle(v0, v1, v2, new RayTracerLib.Color(200.0, 30.0, 30.0)));
            //RayTracerLib.Triangle tt = new RayTracerLib.Triangle(v0, v1, v2, new RayTracerLib.Color(200.0, 30.0, 30.0));

            PopulateSphereListBox();
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
                Convert.ToDouble(txtX.Text.SetDoubleFormat()),
                Convert.ToDouble(txtY.Text.SetDoubleFormat()),
                Convert.ToDouble(txtZ.Text.SetDoubleFormat()),
                Convert.ToDouble(txtRadius.Text.SetDoubleFormat()),
                new RayTracerLib.Color() { R = _color.R, B = _color.B, G = _color.G }
                ));

            PopulateSphereListBox();
            ClearSphereUI();
        }

        private void cmdStartRayTracing_Click(object sender, EventArgs e)
        {
            picScene.Image = Image.FromFile(_filePath1);
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
            //for (int i = 0; i < 10; i++)
            for (int i = 0; i < _rayTracer.canvasWidth * _rayTracer.canvasHeight; i++)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    StartTracing();
                    worker.ReportProgress(i);
                }
            }
        }

        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lbProgress.Text = (e.ProgressPercentage.ToString() + "%");
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (bw.WorkerSupportsCancellation)
                bw.CancelAsync();
        }

        private void cmdStopRayTracing_Click(object sender, EventArgs e)
        {
            picScene.Image = Image.FromFile(_filePath1);
            if (bw.WorkerSupportsCancellation)
                bw.CancelAsync();
        }

        private void cmdDeleteSphere_Click(object sender, EventArgs e)
        {
            var sphereToDelete = lstSphere.SelectedIndex;
            if(sphereToDelete >= 0 && sphereToDelete < _rayTracer.objects.Count)
            {
                _rayTracer.objects.RemoveAt(sphereToDelete);
                PopulateSphereListBox();
            }
        }

        private void cmdEditSphere_Click(object sender, EventArgs e)
        {
            if(lstSphere.SelectedIndex >= 0)
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

        }
    }
}
