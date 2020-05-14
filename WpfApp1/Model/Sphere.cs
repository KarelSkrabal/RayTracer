using System.ComponentModel;

namespace RayTracerTest
{
    public class Sphere : INotifyPropertyChanged
    {
        double _radius;
        double _centerX;
        double _centerY;
        double _centerZ;
        string _color;

        public double Radius
        {
            get => _radius;
            set
            {
                if(_radius != value)
                {
                    _radius = value;
                    RaisePropertyChanged("Radius");
                }
            }
        }
        public double CenterX
        {
            get => _centerX;
            set
            {
                if (_centerX != value)
                {
                    _centerX = value;
                    RaisePropertyChanged("CenterX");
                }
            }
        }
        public double CenterY
        {
            get => _centerY;
            set
            {
                if (_centerY != value)
                {
                    _centerY = value;
                    RaisePropertyChanged("CenterY");
                }
            }
        }
        public double CenterZ
        {
            get => _centerZ;
            set
            {
                if(_centerZ != value)
                {
                    _centerZ = value;
                    RaisePropertyChanged("CenterZ");
                }
            }
        }
        public string Color
        {
            get => _color;
            set
            {
                if (_color != value)
                {
                    _color = value;
                    RaisePropertyChanged("Color");
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
