using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracerWPF.Model
{
    public class RayTracerModel : INotifyPropertyChanged
    {
        private string _canvasWidth;
        private string _canvasHeight;
        private string _lightPositionX;
        private string _lightPositionY;
        private string _lightPositionZ;
        private string _lightDirectionX;
        private string _lightDirectionY;
        private string _lightDirectionZ;
        private string _cameraPositionX;
        private string _cameraPositionY;
        private string _cameraPositionZ;

        public string CanvasWidth
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

        public string CanvasHeight
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

        public string LightPositionX
        {
            get => _lightPositionX;
            set
            {
                if (_lightPositionX != value)
                {
                    _lightPositionX = value;
                    RaisePropertyChanged(nameof(LightPositionX));
                }
            }
        }

        public string LightPositionY
        {
            get => _lightPositionY;
            set
            {
                if (_lightPositionY != value)
                {
                    _lightPositionY = value;
                    RaisePropertyChanged(nameof(LightPositionY));
                }
            }
        }

        public string LightPositionZ
        {
            get => _lightPositionZ;
            set
            {
                if (_lightPositionZ != value)
                {
                    _lightPositionZ = value;
                    RaisePropertyChanged(nameof(LightPositionZ));
                }
            }
        }
        
        public string LightDirectionX
        {
            get => _lightDirectionX;
            set
            {
                if (_lightDirectionX != value)
                {
                    _lightDirectionX = value;
                    RaisePropertyChanged(nameof(LightDirectionX));
                }
            }
        }

        public string LightDirectionY
        {
            get => _lightDirectionY;
            set
            {
                if (_lightDirectionY != value)
                {
                    _lightDirectionY = value;
                    RaisePropertyChanged(nameof(LightDirectionY));
                }
            }
        }

        public string LightDirectionZ
        {
            get => _lightDirectionZ;
            set
            {
                if (_lightDirectionZ != value)
                {
                    _lightDirectionZ = value;
                    RaisePropertyChanged(nameof(LightDirectionZ));
                }
            }
        }

        public string CameraPositionX
        {
            get => _cameraPositionX;
            set
            {
                if (_cameraPositionX != value)
                {
                    _cameraPositionX = value;
                    RaisePropertyChanged(nameof(CameraPositionX));
                }
            }
        }

        public string CameraPositionY
        {
            get => _cameraPositionY;
            set
            {
                if (_cameraPositionY != value)
                {
                    _cameraPositionY = value;
                    RaisePropertyChanged(nameof(CameraPositionY));
                }
            }
        }

        public string CameraPositionZ
        {
            get => _cameraPositionZ;
            set
            {
                if (_cameraPositionZ != value)
                {
                    _cameraPositionZ = value;
                    RaisePropertyChanged(nameof(CameraPositionZ));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string property) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
    }
}
