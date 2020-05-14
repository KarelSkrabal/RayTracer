using System.Windows.Input;
using System.Windows;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RayTracerTest.MVVMCodeBase;
using RayTracerTest.Model;
using System;

namespace RayTracerTest
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            _spheresXX.Add(new RayTracerViewModel { Radius = 50.0, CenterX = 200.0, CenterY = 300.0, CenterZ = 10, Color = "xxx" });
            _spheresXX.Add(new RayTracerViewModel { Radius = 250.0, CenterX = 220.0, CenterY = 300.0, CenterZ = 20, Color = "aa" });
            _spheresXX.Add(new RayTracerViewModel { Radius = 150.0, CenterX = 250.0, CenterY = 30.0, CenterZ = 30, Color = "yyy" });
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

        public ICommand AddSphere { get { return new RelayCommand(AddSphereExecute, CanAddSphereExecute); } }

        private bool CanAddSphereExecute() => true;

        private void AddSphereExecute()
        {
            RayTracerViewModel newItem = new RayTracerViewModel
            {
                CenterX = SelectedSphere.CenterX,
                CenterY = SelectedSphere.CenterY,
                CenterZ = SelectedSphere.CenterZ,
                SphereObject = new Sphere
                {
                    CenterX = SelectedSphere.CenterX,
                    CenterY = SelectedSphere.CenterY,
                    CenterZ = SelectedSphere.CenterZ,
                    Color = SelectedSphere.Color,
                    Radius = SelectedSphere.Radius
                }
            };
            SpheresXX.Add(newItem);
        }

        public ICommand NewSphere { get { return new RelayCommand(NewSphereExecute, CanNewSphereExecute); } }

        private bool CanNewSphereExecute() => true;

        private void NewSphereExecute()
        {
            _newSphere = new RayTracerViewModel();
            SpheresXX.Insert(0, _newSphere);
            SelectedSphere = _newSphere;
        }

        public ICommand DeleteSphere { get { return new RelayCommand(DeleteSphereExecute, CanDeleteSphereExecute); } }

        private bool CanDeleteSphereExecute() => true;

        private void DeleteSphereExecute() => SpheresXX.Remove(SelectedSphere);

        private ObservableCollection<RayTracerViewModel> _spheresXX = new ObservableCollection<RayTracerViewModel>();
        private ObservableCollection<RayTracerViewModel> _spheresXX1 = new ObservableCollection<RayTracerViewModel>();
        private ObservableCollection<Plane> _planes = new ObservableCollection<Plane>();
        private ObservableCollection<Triangle> _triangles = new ObservableCollection<Triangle>();
        private ObservableCollection<Sphere> _spheres = new ObservableCollection<Sphere>();
        private Scene _scene = new Scene();
        public ObservableCollection<RayTracerViewModel> SpheresXX
        {
            get => _spheresXX;
            set => _spheresXX = value;
        }
        public ObservableCollection<RayTracerViewModel> SpheresXX1
        {
            get => _spheresXX1;
            set => _spheresXX1 = value;
        }
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

        private Sphere xxx = new Sphere();
        public Sphere Xxx
        {
            get; set;
        }

        private RayTracerViewModel _selectedSphere = new RayTracerViewModel();
        public RayTracerViewModel SelectedSphere
        {
            get => _selectedSphere;
            set
            {
                _selectedSphere = value;
                //_indexLastSelectedSphere = SpheresXX.IndexOf(_selectedSphere);
                Xxx = SelectedSphere.SphereObject;
            }
        }

        //private int _indexLastSelectedSphere = -1;
        private RayTracerViewModel _newSphere = null;
    }
}