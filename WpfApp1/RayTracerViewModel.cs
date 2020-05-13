using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using RayTracerTest.MVVMCodeBase;

namespace RayTracerTest
{
    //this's like SongViewModel
    //will contain properties of all objects
    public class RayTracerViewModel : ObservableObject
    {
        private SphereObject _sphereObject;
        public SphereObject SphereObject
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
        public double RadiusXXXX
        {
            get => SphereObject.RadiusXX;
            set
            {
                if (SphereObject.RadiusXX != value)
                {
                    SphereObject.RadiusXX = value;
                    RaisePropertyChanged("RadiusXXXX");
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
                    RaisePropertyChanged("RadiusXXXX");
                }
            }
        }
        public RayTracerViewModel()
        {
            SphereObject = new SphereObject { RadiusXX = 0, CenterX = 0, CenterY = 0, CenterZ = 0, Color = "xx" };
        }
    }
}
