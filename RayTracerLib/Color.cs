using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracerLib
{
    public class Color
    {
        double r;
        double R
        {
            get
            {
                int rvalue = (int)(255 * r);
                rvalue = rvalue > 255 ? 255 : rvalue;
                return rvalue < 0 ? 0 : rvalue;
            }
        }
        double g;
        double G
        {
            get
            {
                int gvalue = (int)(255 * g);
                gvalue = gvalue > 255 ? 255 : gvalue;
                return gvalue < 0 ? 0 : gvalue;
            }
        }
        double b;
        double B
        {
            get
            {
                int bvalue = (int)(255 * b);
                bvalue = bvalue > 255 ? 255 : bvalue;
                return bvalue < 0 ? 0 : bvalue;
            }
        }
        public Color()
        {
            r = 0.0;
            g = 0.0;
            b = 0.0;
        }
        public Color(double r, double g, double b)
        {
            this.r = r;
            this.g = g;
            this.b = b;
        }

        public Color(Color color)
        {
            r = color.r;
            g = color.g;
            b = color.b;
        }
    }
}
