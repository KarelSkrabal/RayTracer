using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
using System.Windows;
using RayTracerWPF.Model;


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
                    CanvasWidth = item.CanvasWidth;
                });
            ExampleValue = 10;
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
        private double _canvasWidth;
        public double CanvasWidth
        {
            get => _canvasWidth;
            set => Set(ref _canvasWidth, value);
        }
        private double _canvasHeight;
        public double CanvasHeight
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
        private double _triangleVertex1;
        public double TriangleVertex1
        {
            get => _triangleVertex1;
            set => Set(ref _triangleVertex1, value);
        }
        private double _triangleVertex2;
        public double TriangleVertex2
        {
            get => _triangleVertex2;
            set => Set(ref _triangleVertex2, value);
        }
        private double _triangleVertex3;
        public double TriangleVertex3
        {
            get => _triangleVertex3;
            set => Set(ref _triangleVertex3, value);
        }
        private double _triangleColor;
        public double TriangleColor
        {
            get => _triangleColor;
            set => Set(ref _triangleColor, value);
        }
        private double _sphereCenter;
        public double SphereCenter
        {
            get => _sphereCenter;
            set => Set(ref _sphereCenter, value);
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