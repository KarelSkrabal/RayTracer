using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using RayTracerTest.MVVMCodeBase;

namespace RayTracerTest
{
    public class RayTracerViewModel : ObservableObject
    {
        private Sphere _sphereObject;
        public Sphere SphereObject
        {
            get => _sphereObject;
            set => _sphereObject = value;
        }
        public double CenterX
        {
            get => SphereObject.CenterX;
            set
            {
                if(SphereObject.CenterX != value)
                {
                    SphereObject.CenterX = value;
                    RaisePropertyChanged("CenterX");
                }
            }
        }
        public double CenterY
        {
            get => SphereObject.CenterY;
            set
            {
                if (SphereObject.CenterY != value)
                {
                    SphereObject.CenterY = value;
                    RaisePropertyChanged("CenterY");
                }
            }
        }
        public double CenterZ
        {
            get => SphereObject.CenterZ;
            set
            {
                if (SphereObject.CenterZ != value)
                {
                    SphereObject.CenterZ = value;
                    RaisePropertyChanged("CenterZ");
                }
            }
        }
        public double Radius
        {
            get => SphereObject.Radius;
            set
            {
                if (SphereObject.Radius != value)
                {
                    SphereObject.Radius = value;
                    RaisePropertyChanged("Radius");
                }
            }
        }
        public string Color
        {
            get => SphereObject.Color;
            set
            {
                if (SphereObject.Color != value)
                {
                    SphereObject.Color = value;
                    RaisePropertyChanged("Color");
                }
            }
        }
        public RayTracerViewModel()
        {
            SphereObject = new Sphere { Radius = 0, CenterX = 0, CenterY = 0, CenterZ = 0, Color = "xx" };
        }
    }
}
