using System.Collections.ObjectModel;
using System.Linq;
using RayTracerLib;
using SysDrawing = System.Drawing;

namespace RayTracerWPF.Model
{
    public class DataProvider
    {
        IRaTracer _rayTracer;
        internal ObservableCollection<Plane> _planes { get; set; }
        internal ObservableCollection<Sphere> _spheres { get; set; }
        internal ObservableCollection<Triangle> _triangles { get; set; }
        internal Scene _scene { get; set; }
        internal Color[,] Pixels;
        public DataProvider(IRaTracer rayTracer)
        {
            _rayTracer = rayTracer;
            _planes = new ObservableCollection<Plane>();
            _spheres = new ObservableCollection<Sphere>();
            _triangles = new ObservableCollection<Triangle>();
            _scene = new Scene();
        }

        //public GetData()
        //{

        //}
        public void Run()
        {
            SetScene();
            SetSpheres();
            SetTriangles();
            SetPlanes();
            _rayTracer.RayTraceScene(ref Pixels);
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
            var spheres = _spheres.Select(s => new RayTracerLib.Sphere
            {
                cx = s.CenterX,
                cy = s.CenterY,
                cz = s.CenterZ,
                radius = s.Radius,
                color = new Color(
                    (SysDrawing.ColorTranslator.FromHtml(s.Color)).R,
                    (SysDrawing.ColorTranslator.FromHtml(s.Color)).G,
                    (SysDrawing.ColorTranslator.FromHtml(s.Color)).B)
            }).ToList();
            _rayTracer.objects.AddRange(spheres);
        }

        private void SetScene()
        {
            _rayTracer.lp = new Vector(_scene.LightPositionX, _scene.LightPositionY, _scene.LightPositionZ);
            _rayTracer.lv = new Vector(_scene.LightDirectionX, _scene.LightDirectionY, _scene.LightDirectionZ);
            _rayTracer.p = new Vector(_scene.CameraPositionX, _scene.CameraPositionY, _scene.CameraPositionZ);
        }
    }
}
