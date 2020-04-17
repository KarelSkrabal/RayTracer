using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracerLib
{
    public class Light
    {
        Vector v;

        public Light() => v = new Vector(0.0, 0.0, 0.0);

        public Light(double x, double y, double z)
        {
            v = new Vector(x, y, z);
            v.normalize();
        }

        public Light(Light light) => v = new Vector(light.v);
    }
}
