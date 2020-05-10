using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
using System.Windows;
using RayTracerWPF.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RayTracerLib;

namespace RayTracerWPF.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private readonly IDataService _dataService;
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel(IDataService dataService)
        {
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
            //commands  
            Page2Command = new RelayCommand(() => GoToPage2());

            _dataService = dataService;
            _dataService.GetData(
                (item, error) =>
                {
                    if (error != null)
                    {
                        return;
                    }
                    CanvasWidth = item.RayTracer.canvasWidth;
                    CanvasHeight = item.RayTracer.canvasHeight;
                    LightPositionX = item.RayTracer.lp.X;
                    LightPositionY = item.RayTracer.lp.Y;
                    LightPositionZ = item.RayTracer.lp.Z;
                    LightDirectionX = item.RayTracer.lv.X;
                    LightDirectionX = item.RayTracer.lv.Y;
                    LightDirectionX = item.RayTracer.lv.Z;
                    CameraPositionX = item.RayTracer.p.X;
                    CameraPositionX = item.RayTracer.p.Y;
                    CameraPositionX = item.RayTracer.p.Z;
                    Spheres = new ObservableCollection<Sphere>(item.RayTracer.objects.OfType<Sphere>());
                    Planes = new ObservableCollection<Plane>(item.RayTracer.objects.OfType<Plane>());
                    Triangles = new ObservableCollection<Triangle>(item.RayTracer.objects.OfType<Triangle>());
                });
        }

        int _exampleValue;
        public int ExampleValue
        {
            get
            {
                return _exampleValue;
            }
            set
            {
                if (_exampleValue == value)
                    return;
                _exampleValue = value;
                Set(ref _exampleValue, value);
                RaisePropertyChanged("ExampleValue");
            }
        }

        #region Binding Attributes

        private ObservableCollection<Sphere> _spheres;
        public ObservableCollection<Sphere> Spheres
        {
            get => _spheres;
            set
            {
                Set(ref _spheres, value);
                RaisePropertyChanged("Spheres");
            }
        }


        //private void lbTodoList_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        //{
        //    if (lbTodoList.SelectedItem != null)
        //        this.Title = (lbTodoList.SelectedItem as TodoItem).Title;
        //}

        private ObservableCollection<Triangle> _triangles;
        public ObservableCollection<Triangle> Triangles
        {
            get => _triangles;
            set
            {
                Set(ref _triangles, value);
                RaisePropertyChanged("Triangles");
            }
        }
        private ObservableCollection<Plane> _planes;
        public ObservableCollection<Plane> Planes
        {
            get => _planes;
            set
            {
                Set(ref _planes, value);
                RaisePropertyChanged("Planes");
            }
        }
        private int _canvasWidth;
        public int CanvasWidth
        {
            get => _canvasWidth;
            set => Set(ref _canvasWidth, value);
        }
        private int _canvasHeight;
        public int CanvasHeight
        {
            get => _canvasHeight;
            set => Set(ref _canvasHeight, value);
        }
        private double _lightPositionX;
        public double LightPositionX
        {
            get => _lightPositionX;
            set => Set(ref _lightPositionX, value);
        }
        private double _lightPositionY;
        public double LightPositionY
        {
            get => _lightPositionY;
            set => Set(ref _lightPositionY, value);
        }
        private double _lightPositionZ;
        public double LightPositionZ
        {
            get => _lightPositionZ;
            set => Set(ref _lightPositionZ, value);
        }
        private double _lightDirectionX;
        public double LightDirectionX
        {
            get => _lightDirectionX;
            set => Set(ref _lightDirectionX, value);
        }
        private double _lightDirectionY;
        public double LightDirectionY
        {
            get => _lightDirectionY;
            set => Set(ref _lightDirectionY, value);
        }
        private double _lightDirectionZ;
        public double LightDirectionZ
        {
            get => _lightDirectionZ;
            set => Set(ref _lightDirectionZ, value);
        }
        private double _cameraPositionX;
        public double CameraPositionX
        {
            get => _cameraPositionX;
            set => Set(ref _cameraPositionX, value);
        }
        private double _cameraPositionY;
        public double CameraPositionY
        {
            get => _cameraPositionY;
            set => Set(ref _cameraPositionY, value);
        }
        private double _cameraPositionZ;
        public double CameraPositionZ
        {
            get => _cameraPositionZ;
            set => Set(ref _cameraPositionZ, value);
        }
        private double _planeNormalVectorX;
        public double PlaneNormalVectorX
        {
            get => _planeNormalVectorX;
            set => Set(ref _planeNormalVectorX, value);
        }
        private double _planeNormalVectorY;
        public double PlaneNormalVectorY
        {
            get => _planeNormalVectorY;
            set => Set(ref _planeNormalVectorY, value);
        }
        private double _planeNormalVectorZ;
        public double PlaneNormalVectorZ
        {
            get => _planeNormalVectorZ;
            set => Set(ref _planeNormalVectorZ, value);
        }
        private double _planePointX;
        public double PlanePointX
        {
            get => _planePointX;
            set => Set(ref _planePointX, value);
        }
        private double _planePointY;
        public double PlanePointY
        {
            get => _planePointY;
            set => Set(ref _planePointY, value);
        }
        private double _planePointZ;
        public double PlanePointZ
        {
            get => _planePointZ;
            set => Set(ref _planePointZ, value);
        }
        private double _planeColor;
        public double PlaneColor
        {
            get => _planeColor;
            set => Set(ref _planeColor, value);
        }
        private double _triangleVertex1X;
        public double TriangleVertex1X
        {
            get => _triangleVertex1X;
            set => Set(ref _triangleVertex1X, value);
        }
        private double _triangleVertex1Y;
        public double TriangleVertex1Y
        {
            get => _triangleVertex1Y;
            set => Set(ref _triangleVertex1Y, value);
        }
        private double _triangleVertex1Z;
        public double TriangleVertex1Z
        {
            get => _triangleVertex1Z;
            set => Set(ref _triangleVertex1Z, value);
        }
        private double _triangleVertex2X;
        public double TriangleVertex2X
        {
            get => _triangleVertex2X;
            set => Set(ref _triangleVertex2X, value);
        }
        private double _triangleVertex2Y;
        public double TriangleVertex2Y
        {
            get => _triangleVertex2Y;
            set => Set(ref _triangleVertex2Y, value);
        }
        private double _triangleVertex2Z;
        public double TriangleVertex2Z
        {
            get => _triangleVertex2Z;
            set => Set(ref _triangleVertex2Z, value);
        }
        private double _triangleVertex3X;
        public double TriangleVertex3X
        {
            get => _triangleVertex3X;
            set => Set(ref _triangleVertex3X, value);
        }
        private double _triangleVertex3Y;
        public double TriangleVertex3Y
        {
            get => _triangleVertex3Y;
            set => Set(ref _triangleVertex3Y, value);
        }
        private double _triangleVertex3Z;
        public double TriangleVertex3Z
        {
            get => _triangleVertex3Z;
            set => Set(ref _triangleVertex3Z, value);
        }
        private double _triangleColor;
        public double TriangleColor
        {
            get => _triangleColor;
            set => Set(ref _triangleColor, value);
        }
        private double _sphereCenterX;
        public double SphereCenterX
        {
            get => _sphereCenterX;
            set => Set(ref _sphereCenterX, value);
        }
        private double _sphereCenterY;
        public double SphereCenterY
        {
            get => _sphereCenterY;
            set => Set(ref _sphereCenterY, value);
        }
        private double _sphereCenterZ;
        public double SphereCenterZ
        {
            get => _sphereCenterZ;
            set => Set(ref _sphereCenterZ, value);
        }
        private double _sphereRadius;
        public double SphereRadius
        {
            get => _sphereRadius;
            set => Set(ref _sphereRadius, value);
        }
        private double _sphereColor;
        public double SphereColor
        {
            get => _sphereColor;
            set => Set(ref _sphereColor, value);
        }
        #endregion

        #region Commands
        public RelayCommand Page2Command
        {
            get;
            private set;
        }
        private object GoToPage2()
        {
            //var msg = new GoToPageMessage() { PageName = "Page2View" };
            //Messenger.Default.Send<GoToPageMessage>(msg);

            System.Windows.MessageBox.Show("Navigate to Page 2!");
            return null;
        }
        #endregion
    }
}