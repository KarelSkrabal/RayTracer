using System;
using System.Collections.ObjectModel;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Media.Imaging;
using RayTracerLib;
using SysDrawing = System.Drawing;

namespace RayTracerWPF.Model
{
    public class DataProvider : IDataProvider
    {
        private IRaTracer _rayTracer;
        private Color[,] Pixels;
        private string _imagePath;

        public ObservableCollection<Plane> _planes { get; set; }
        public ObservableCollection<Sphere> _spheres { get; set; }
        public ObservableCollection<Triangle> _triangles { get; set; }
        public Scene _scene { get; set; }

        public DataProvider(IRaTracer rayTracer)
        {
            _rayTracer = rayTracer;
            Initialize();
            GetData();
        }

        private void Initialize()
        {
            _planes = new ObservableCollection<Plane>();
            _spheres = new ObservableCollection<Sphere>();
            _triangles = new ObservableCollection<Triangle>();
            _scene = new Scene();
        }

        private void GetData()
        {
            GetPlanes();
            GetSpheres();
            GetTriangles();
            GetScene();
        }

        private void GetScene()
        {
            _scene = new Scene
            {
                CameraPositionX = _rayTracer.p.X,
                CameraPositionY = _rayTracer.p.Y,
                CameraPositionZ = _rayTracer.p.Z,
                CanvasHeight = _rayTracer.canvasHeight,
                CanvasWidth = _rayTracer.canvasWidth,
                LightDirectionX = _rayTracer.lv.X,
                LightDirectionY = _rayTracer.lv.Y,
                LightDirectionZ = _rayTracer.lv.Z,
                LightPositionX = _rayTracer.lp.X,
                LightPositionY = _rayTracer.lp.Y,
                LightPositionZ = _rayTracer.lp.Z,
                ImagePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments), "scene.png")
            };
        }

        private void GetPlanes()
        {
            _planes = _rayTracer.objects.OfType<RayTracerLib.Plane>().Select(p => new Plane
            {
                Color = SysDrawing.ColorTranslator.ToHtml(SysDrawing.Color.FromArgb((int)p.color.R, (int)p.color.G, (int)p.color.B)),
                NormalX = p.normal.X,
                NormalY = p.normal.Y,
                NormalZ = p.normal.Z,
                PointX = p.position.X,
                PointY = p.position.Y,
                PointZ = p.position.Z
            }).ToObservableCollection<Plane>();
        }

        private void GetSpheres()
        {
            _spheres = _rayTracer.objects.OfType<RayTracerLib.Sphere>().Select(s => new Sphere
            {
                Color = SysDrawing.ColorTranslator.ToHtml(SysDrawing.Color.FromArgb((int)s.color.R, (int)s.color.G, (int)s.color.B)),
                CenterX = s.cx,
                CenterY = s.cy,
                CenterZ = s.cz,
                Radius = s.radius
            }).ToObservableCollection<Sphere>();
        }

        private void GetTriangles()
        {
            _triangles = _rayTracer.objects.OfType<RayTracerLib.Triangle>().Select(t => new Triangle
            {
                Color = SysDrawing.ColorTranslator.ToHtml(SysDrawing.Color.FromArgb((int)t.color.R, (int)t.color.G, (int)t.color.B)),
                Vertex1X = t.v0.X,
                Vertex1Y = t.v0.Y,
                Vertex1Z = t.v0.Z,
                Vertex2X = t.v1.X,
                Vertex2Y = t.v1.Y,
                Vertex2Z = t.v1.Z,
                Vertex3X = t.v2.X,
                Vertex3Y = t.v2.Y,
                Vertex3Z = t.v2.Z,
            }).ToObservableCollection<Triangle>();
        }

        public void Run()
        {
            _rayTracer.objects.Clear();
            SetScene();
            SetSpheres();
            SetTriangles();
            SetPlanes();

            Pixels = new Color[_rayTracer.canvasWidth, _rayTracer.canvasHeight];
            _rayTracer.RayTraceScene(ref Pixels);
            DrawPicture(Pixels);
        }
        private void DrawPicture(Color[,] pixels)
        {
            SysDrawing.Bitmap bmp = new SysDrawing.Bitmap(_rayTracer.canvasWidth, _rayTracer.canvasHeight);
            SysDrawing.Graphics g = SysDrawing.Graphics.FromImage(bmp);
            for (int i = 0; i < _rayTracer.canvasWidth; i++)
            {
                for (int j = 0; j < _rayTracer.canvasHeight; j++)
                {
                    var color = SysDrawing.Color.FromArgb((Byte)pixels[i, j].R, (Byte)pixels[i, j].G, (Byte)pixels[i, j].B);
                    SysDrawing.Brush brush1 = new SysDrawing.SolidBrush(color);
                    g.FillRectangle(brush1, i, j, 1, 1);
                }
            }
            g.Dispose();
            //string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments), "scene" + string.Format("{0:yyyy-MM-dd_HH-mm-ss-fff}", DateTime.Now) + ".png");
            string path = _imagePath;
            string pattern = "scene*.png";
            string folderName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments));
            var matches = Directory.GetFiles(folderName, pattern);
            foreach (string file in Directory.GetFiles(folderName,pattern))
                File.Delete(file);

            //if (File.Exists(path))
            //{
            //    File.Delete(path);
            //}
            bmp.Save(path, SysDrawing.Imaging.ImageFormat.Png);


            using (var memory = new MemoryStream())
            {
                bmp.Save(memory, ImageFormat.Png);
                memory.Position = 0;

                var bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = memory;
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.EndInit();
                bitmapImage.Freeze();

                _scene.Image = bitmapImage;
            }
            bmp.Dispose();

        }

        private void SetPlanes()
        {
            var planes = _planes.Select(p => new RayTracerLib.Plane(
                new Vector(p.PointX, p.PointY, p.PointZ),
                new Vector(p.NormalX, p.NormalY, p.NormalZ),
                new Color(new Color(
                    (SysDrawing.ColorTranslator.FromHtml(p.Color)).R,
                    (SysDrawing.ColorTranslator.FromHtml(p.Color)).G,
                    (SysDrawing.ColorTranslator.FromHtml(p.Color)).B)
                ))).ToList();
            _rayTracer.objects.AddRange(planes);
        }

        private void SetTriangles()
        {
            var triangles = _triangles.Select(t => new RayTracerLib.Triangle
                        (
                            new Vector(t.Vertex1X, t.Vertex1Y, t.Vertex1Z),
                            new Vector(t.Vertex2X, t.Vertex2Y, t.Vertex2Z),
                            new Vector(t.Vertex3X, t.Vertex3Y, t.Vertex3Z),
                            new Color(new Color(
                                (SysDrawing.ColorTranslator.FromHtml(t.Color)).R,
                                (SysDrawing.ColorTranslator.FromHtml(t.Color)).G,
                                (System.Drawing.ColorTranslator.FromHtml(t.Color)).B)
                        ))).ToList();
            _rayTracer.objects.AddRange(triangles);
        }

        private void SetSpheres()
        {
            SysDrawing.Color t = SysDrawing.ColorTranslator.FromHtml(_spheres[0].Color);
            //SysDrawing.Color cc = SysDrawing.ColorConverter.
            var test = new Color(
                    (SysDrawing.ColorTranslator.FromHtml(_spheres[0].Color)).R,
                    (SysDrawing.ColorTranslator.FromHtml(_spheres[0].Color)).G,
                    (SysDrawing.ColorTranslator.FromHtml(_spheres[0].Color)).B);
            ;
            var spheres = _spheres.Select(s => new RayTracerLib.Sphere
            (
                s.CenterX,
                s.CenterY,
                s.CenterZ,
                s.Radius,
                new Color(
                    (SysDrawing.ColorTranslator.FromHtml(s.Color)).R,
                    (SysDrawing.ColorTranslator.FromHtml(s.Color)).G,
                    (SysDrawing.ColorTranslator.FromHtml(s.Color)).B)
            )).ToList();
            _rayTracer.objects.AddRange(spheres);
        }

        private void SetScene()
        {
            _rayTracer.lp = new Vector(_scene.LightPositionX, _scene.LightPositionY, _scene.LightPositionZ);
            _rayTracer.lv = new Vector(_scene.LightDirectionX, _scene.LightDirectionY, _scene.LightDirectionZ);
            _rayTracer.p = new Vector(_scene.CameraPositionX, _scene.CameraPositionY, _scene.CameraPositionZ);
            _imagePath = _scene.ImagePath;
        }
    }
}
