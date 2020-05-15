using System.Windows.Forms;
using RayTracerWPF.Model;
using RayTracerWPF.MVVMCodeBase;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Plane = RayTracerWPF.Model.Plane;
using Sphere = RayTracerWPF.Model.Sphere;
using Triangle = RayTracerWPF.Model.Triangle;
using System.Windows.Media;

namespace RayTracerWPF.ViewModel
{
    public class MainViewModel
    {
        private ColorDialog dlgColor = new ColorDialog();
        public ICommand cmdPlanePickColor { get { return new RelayCommand(PlanePickColorExecute, CanPlanePickColorExecute); } }

        private bool CanPlanePickColorExecute() => SelectedPlane != null && Planes.Contains(SelectedPlane);

        private void PlanePickColorExecute()
        {
            int index = Planes.IndexOf(SelectedPlane);

            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                Planes[index].Color = dlgColor.Color.Name;
                SelectedPlane = null;
            }
        }

        public ICommand cmdTrianglePickColor { get { return new RelayCommand(TrianglePickColorExecute, CanTrianglePickColorExecute); } }

        private bool CanTrianglePickColorExecute() => SelectedTriangle != null && Triangles.Contains(SelectedTriangle);

        private void TrianglePickColorExecute()
        {
            int index = Triangles.IndexOf(SelectedTriangle);

            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                Triangles[index].Color = dlgColor.Color.Name;
                SelectedTriangle = null;
            }
        }
        public ICommand cmdSpherePickColor { get { return new RelayCommand(SpherePickColorExecute, CanSpherePickColorExecute); } }

        private bool CanSpherePickColorExecute() => SelectedSphere != null && Spheres.Contains(SelectedSphere);

        private void SpherePickColorExecute()
        {
            int index = Spheres.IndexOf(SelectedSphere);

            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                Spheres[index].Color = dlgColor.Color.Name;
                SelectedSphere = null;
            }
        }

        //TODO-implement generic command
        private void PlanePickColorExecute<T>(ObservableCollection<T> collection, T item)
        {
            int index = collection.IndexOf(item);
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                (collection[index] as RayTracerLib.BaseObject).color = new RayTracerLib.Color
                {
                    R = dlgColor.Color.R,
                    G = dlgColor.Color.G,
                    B = dlgColor.Color.B
                };
                SelectedPlane = null;
            }
        }

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
        private Plane _selectedPlane = new Plane();
        private Triangle _selectedTriangle = new Triangle();
        private Sphere _selectedSphere = new Sphere();

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

        public Plane SelectedPlane
        {
            get => _selectedPlane;
            set => _selectedPlane = value;
        }

        public Triangle SelectedTriangle
        {
            get => _selectedTriangle;
            set => _selectedTriangle = value;
        }

        public Sphere SelectedSphere
        {
            get => _selectedSphere;
            set => _selectedSphere = value;
        }
        public ICommand AddSphere { get { return new RelayCommand(AddSphereExecute, CanAddSphereExecute); } }

        private bool CanAddSphereExecute() => true;

        private void AddSphereExecute()
        {

        }
    }
}