using System.ComponentModel;

namespace RayTracerTest.Model
{
    public class Triangle : INotifyPropertyChanged
    {
        double _vertex1X;
        double _vertex1Y;
        double _vertex1Z;
        double _vertex2X;
        double _vertex2Y;
        double _vertex2Z;
        double _vertex3X;
        double _vertex3Y;
        double _vertex3Z;
        string _color;

        public double Vertex1X
        {
            get => _vertex1X;
            set
            {
                if(_vertex1X != value)
                {
                    _vertex1X = value;
                    RaisePropertyChanged("Vertex1X");
                }
            }
        }
        public double Vertex1Y
        {
            get => _vertex1Y;
            set
            {
                if (_vertex1Y != value)
                {
                    _vertex1Y = value;
                    RaisePropertyChanged("Vertex1Y");
                }
            }
        }
        public double Vertex1Z
        {
            get => _vertex1Z;
            set
            {
                if (_vertex1Z != value)
                {
                    _vertex1Z = value;
                    RaisePropertyChanged("Vertex1Z");
                }
            }
        }
        public double Vertex2X
        {
            get => _vertex2X;
            set
            {
                if (_vertex2X != value)
                {
                    _vertex2X = value;
                    RaisePropertyChanged("Vertex2X");
                }
            }
        }
        public double Vertex2Y
        {
            get => _vertex2Y;
            set
            {
                if (_vertex2Y != value)
                {
                    _vertex2Y = value;
                    RaisePropertyChanged("Vertex2Y");
                }
            }
        }
        public double Vertex2Z
        {
            get => _vertex2Z;
            set
            {
                if (_vertex2Z != value)
                {
                    _vertex2Z = value;
                    RaisePropertyChanged("Vertex2Z");
                }
            }
        }
        public double Vertex3X
        {
            get => _vertex3X;
            set
            {
                if (_vertex3X != value)
                {
                    _vertex3X = value;
                    RaisePropertyChanged("Vertex3X");
                }
            }
        }
        public double Vertex3Y
        {
            get => _vertex3Y;
            set
            {
                if (_vertex3Y != value)
                {
                    _vertex3Y = value;
                    RaisePropertyChanged("Vertex3Y");
                }
            }
        }
        public double Vertex3Z
        {
            get => _vertex3Z;
            set
            {
                if (_vertex3Z != value)
                {
                    _vertex3Z = value;
                    RaisePropertyChanged("Vertex3Z");
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
