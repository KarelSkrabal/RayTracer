using RayTracerLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracerApp.Model
{
    public class ObjectModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Sphere Sphere = new Sphere();

        private double radius;
        public double Radius
        {
            get => radius;
            set
            {
                if(radius != value)
                {
                    radius = value;
                    Sphere.radius = value;
                    RaisePropertyChanged("Radius");
                }
            }
        }
        private double x;
        public double X
        {
            get => x;
            set
            {
                if(x != value)
                {
                    x = value;
                    Sphere.cx = value;
                    RaisePropertyChanged("X");
                }
            }
        }
        private double y;
        public double Y
        {
            get => y;
            set
            {
                if (y != value)
                {
                    y = value;
                    Sphere.cy = value;
                    RaisePropertyChanged("Y");
                }
            }
        }
        private double z;
        public double Z
        {
            get => z;
            set
            {
                if (z != value)
                {
                    z = value;
                    Sphere.cz = value;
                    RaisePropertyChanged("Z");
                }
            }
        }

        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
