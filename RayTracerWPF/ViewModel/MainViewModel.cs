using RayTracerLib;
using RayTracerWPF.Model;
using RayTracerWPF.MVVMCodeBase;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using Plane = RayTracerWPF.Model.Plane;
using Sphere = RayTracerWPF.Model.Sphere;
using Triangle = RayTracerWPF.Model.Triangle;

namespace RayTracerWPF.ViewModel
{
    public class MainViewModel
    {
        private ColorDialog _dlgColor = new ColorDialog();
        private IRaTracer _raTracer = new RayTracer();
        private DataProvider _dataProvider = new DataProvider(new RayTracer());

        public RelayCommand<object> cmdClose;
        public RelayCommand<object> CmdClose
        {
            get
            {
                if(cmdClose == null)
                {
                    cmdClose = new RelayCommand<object>((param) => this.CloseExecute(param), null);
                }
                return cmdClose;
            }
        }

        private void CloseExecute(object obj) => (obj as Window).Close();

        public ICommand cmdPlanePickColor { get { return new RelayCommand(PlanePickColorExecute, CanPlanePickColorExecute); } }

        private bool CanPlanePickColorExecute() => SelectedPlane != null && Planes.Contains(SelectedPlane);

        private void PlanePickColorExecute()
        {
            int index = Planes.IndexOf(SelectedPlane);

            if (_dlgColor.ShowDialog() == DialogResult.OK)
            {
                Planes[index].Color = _dlgColor.Color.Name;
                SelectedPlane = null;
            }
        }

        public ICommand cmdTrianglePickColor { get { return new RelayCommand(TrianglePickColorExecute, CanTrianglePickColorExecute); } }

        private bool CanTrianglePickColorExecute() => SelectedTriangle != null && Triangles.Contains(SelectedTriangle);

        private void TrianglePickColorExecute()
        {
            int index = Triangles.IndexOf(SelectedTriangle);

            if (_dlgColor.ShowDialog() == DialogResult.OK)
            {
                Triangles[index].Color = _dlgColor.Color.Name;
                SelectedTriangle = null;
            }
        }
        public ICommand cmdSpherePickColor { get { return new RelayCommand(SpherePickColorExecute, CanSpherePickColorExecute); } }

        private bool CanSpherePickColorExecute() => SelectedSphere != null && Spheres.Contains(SelectedSphere);

        private void SpherePickColorExecute()
        {
            int index = Spheres.IndexOf(SelectedSphere);

            if (_dlgColor.ShowDialog() == DialogResult.OK)
            {
                Spheres[index].Color = _dlgColor.Color.Name;
                SelectedSphere = null;
            }
        }

        public ICommand cmdRun { get { return new RelayCommand(RunExecute, CanRunExecute); } }

        private bool CanRunExecute() => true;

        private void RunExecute()
        {
            this._dataProvider._planes = Planes;
            _dataProvider._scene = Scene;
            _dataProvider._triangles = Triangles;
            _dataProvider._spheres = Spheres;
            _dataProvider.Run();
        }

        //TODO-implement generic command
        private void PlanePickColorExecute<T>(ObservableCollection<T> collection, T item)
        {
            int index = collection.IndexOf(item);
            if (_dlgColor.ShowDialog() == DialogResult.OK)
            {
                (collection[index] as RayTracerLib.BaseObject).color = new RayTracerLib.Color
                {
                    R = _dlgColor.Color.R,
                    G = _dlgColor.Color.G,
                    B = _dlgColor.Color.B
                };
                SelectedPlane = null;
            }
        }

        public MainViewModel(/*IRaTracer rayTracer*/)
        {
            //Inject RayTracerLib default objects
            //_raTracer = rayTracer;

            _planes = _dataProvider._planes;
            _spheres = _dataProvider._spheres;
            _triangles = _dataProvider._triangles;
            _scene = _dataProvider._scene;
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
    }
}