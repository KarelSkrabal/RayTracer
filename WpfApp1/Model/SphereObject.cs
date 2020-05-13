using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace RayTracerTest
{
    public class SphereObject
    {
        double _radius;
        double _centerX;
        double _centerY;
        double _centerZ;
        string _color;

        public double RadiusXX
        {
            get => _radius;
            set => _radius = value;
        }
        public double CenterX
        {
            get => _centerX;
            set => _centerX = value;
        }
        public double CenterY
        {
            get => _centerY;
            set => _centerY = value;
        }
        public double CenterZ
        {
            get => _centerZ;
            set => _centerZ = value;
        }
        public string Color
        {
            get => _color;
            set => _color = value;
        }
    }
}
