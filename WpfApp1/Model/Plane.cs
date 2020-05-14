using System.ComponentModel;

namespace RayTracerTest.Model
{
    public class Plane : INotifyPropertyChanged
    {
        double _normalX;
        double _normalY;
        double _normalZ;
        double _pointX;
        double _pointY;
        double _pointZ;
        string _color;

        public double NormalX
        {
            get => _normalX;
            set
            {
                if (_normalX != value)
                {
                    _normalX = value;
                    RaisePropertyChanged("NormalX");
                }
            }
        }
        public double NormalY
        {
            get => _normalY;
            set
            {
                if(_normalY != value)
                {
                    _normalY = value;
                    RaisePropertyChanged("NormalY");
                }
            }
        }
        
        public double NormalZ
        {
            get => _normalZ;
            set
            {
                if(_normalZ != value)
                {
                    _normalZ = value;
                }
                RaisePropertyChanged("NormalZ");
            }
        }
        public double PointX
        {
            get => _pointX;
            set
            {
                if(_pointX != value)
                {
                    _pointX = value;
                    RaisePropertyChanged("PointX");
                }
            }
        }
        public double PointY
        {
            get => _pointY;
            set
            {
                if(_pointY != value)
                {
                    _pointY = value;
                    RaisePropertyChanged("PointY");
                }
            }
        }
        public double PointZ
        {
            get => _pointZ;
            set
            {
                if(_pointZ != value)
                {
                    _pointZ = value;
                    RaisePropertyChanged("PointZ");
                }
            }
        }
        public string Color
        {
            get => _color;
            set
            {
                if(_color != value)
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
