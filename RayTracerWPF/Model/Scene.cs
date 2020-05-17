using System.Drawing;
using System.ComponentModel;
using System.Windows.Media.Imaging;

namespace RayTracerWPF.Model
{
    public class Scene : INotifyPropertyChanged
    {
        int _canvasWidth;
        int _canvasHeight;
        double _lightPositionX;
        double _lightPositionY;
        double _lightPositionZ;
        double _lightDirectionX;
        double _lightDirectionY;
        double _lightDirectionZ;
        double _cameraPositionX;
        double _cameraPositionY;
        double _cameraPositionZ;
        BitmapImage _image;
   
        public BitmapImage Image
        {
            get => _image;
            set
            {
                if(_image != value)
                {
                    _image = value;
                    RaisePropertyChanged("Image");
                }
            }
        }

        public int CanvasWidth
        {
            get => _canvasWidth;
            set
            {
                if (_canvasWidth != value)
                {
                    _canvasWidth = value;
                    RaisePropertyChanged("CanvasWidth");
                }
            }
        }
        public int CanvasHeight
        {
            get => _canvasHeight;
            set
            {
                if (_canvasHeight != value)
                {
                    _canvasHeight = value;
                    RaisePropertyChanged("CanvasHeight");
                }
            }
        }
        public double LightPositionX
        {
            get => _lightPositionX;
            set
            {
                if (_lightPositionX != value)
                {
                    _lightPositionX = value;
                    RaisePropertyChanged("LightPositionX");
                }
            }
        }
        public double LightPositionY
        {
            get => _lightPositionY;
            set
            {
                if (_lightPositionY != value)
                {
                    _lightPositionY = value;
                    RaisePropertyChanged("LightPositionY");
                }
            }
        }
        public double LightPositionZ
        {
            get => _lightPositionZ;
            set
            {
                if (_lightPositionZ != value)
                {
                    _lightPositionZ = value;
                    RaisePropertyChanged("LightPositionZ");
                }
            }
        }
        public double LightDirectionX
        {
            get => _lightDirectionX;
            set
            {
                if (_lightDirectionX != value)
                {
                    _lightDirectionX = value;
                    RaisePropertyChanged("LightDirectionX");
                }
            }
        }
        public double LightDirectionY
        {
            get => _lightDirectionY;
            set
            {
                if (_lightDirectionY != value)
                {
                    _lightDirectionY = value;
                    RaisePropertyChanged("LightDirectionY");
                }
            }
        }
        public double LightDirectionZ
        {
            get => _lightDirectionZ;
            set
            {
                if (_lightDirectionZ != value)
                {
                    _lightDirectionZ = value;
                    RaisePropertyChanged("LightDirectionZ");
                }
            }
        }
        public double CameraPositionX
        {
            get => _cameraPositionX;
            set
            {
                if (_cameraPositionX != value)
                {
                    _cameraPositionX = value;
                    RaisePropertyChanged("CameraPositionX");
                }
            }
        }
        public double CameraPositionY
        {
            get => _cameraPositionY;
            set
            {
                if(_cameraPositionY != value)
                {
                    _cameraPositionY = value;
                    RaisePropertyChanged("CameraPositionY");
                }
            }
        }
        public double CameraPositionZ
        {
            get => _cameraPositionZ;
            set
            {
                if(_cameraPositionZ != value)
                {
                    _cameraPositionZ = value;
                    RaisePropertyChanged("CameraPositionZ");
                }
            }
        }

        void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(prop)); }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
