using RayTracerWPF.Model;
using System.Collections.ObjectModel;
using Plane = RayTracerWPF.Model.Plane;
using Sphere = RayTracerWPF.Model.Sphere;
using Triangle = RayTracerWPF.Model.Triangle;

namespace RayTracerWPF.ViewModel
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            _spheres.Add(new Sphere { Radius = 45, CenterX = 71, CenterY = 72, CenterZ = 73, Color = "sphere color" });
            _planes.Add(new Plane { NormalX = 33, NormalY = 34, NormalZ = 35, PointX = 43, PointY = 44, PointZ = 45, Color = "Plane color" });
            _triangles.Add(new Triangle
            {
                Vertex1X = 20,
                Vertex1Y = 21,
                Vertex1Z = 22,
                Vertex2X = 30,
                Vertex2Y = 31,
                Vertex2Z = 32,
                Vertex3X = 41,
                Vertex3Y = 42,
                Vertex3Z = 43
            });
            _scene = new Scene
            {
                CanvasWidth = 500,
                CanvasHeight = 300,
                CameraPositionX = 50,
                CameraPositionY = 51,
                CameraPositionZ = 52,
                LightDirectionX = -1,
                LightDirectionY = 0,
                LightDirectionZ = 1,
                LightPositionX = 60,
                LightPositionY = 61,
                LightPositionZ = 62
            };
        }

        private ObservableCollection<Plane> _planes = new ObservableCollection<Plane>();
        private ObservableCollection<Triangle> _triangles = new ObservableCollection<Triangle>();
        private ObservableCollection<Sphere> _spheres = new ObservableCollection<Sphere>();
        private Scene _scene = new Scene();

        public ObservableCollection<Plane> Planes
        {
            get => _planes;
            set => _planes = value;
        }

        public Scene Scene
        {
            get => _scene;
            set => _scene = value;
        }

        public ObservableCollection<Triangle> Triangles
        {
            get => _triangles;
            set => _triangles = value;
        }

        public ObservableCollection<Sphere> Spheres
        {
            get => _spheres;
            set => _spheres = value;
        }
    }
}