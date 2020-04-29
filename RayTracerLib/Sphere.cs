using System;

namespace RayTracerLib
{
    public class Sphere : BaseObject
    {
        public double cx, cy, cz;
        public double radius;

        /// <summary>
        /// Sphere object
        /// <para/>defined by x,y,z of center position
        /// <para/>defined by r radius
        /// <para/>defined by r,g,b color parameters
        /// </summary>
        public Sphere(double x, double y, double z, double r, Color color) : base(new Vector(x, y, z), color)
        {
            cx = x;
            cy = y;
            cz = z;
            position = new Vector(x, y, z);
            radius = r;
            this.color = new Color(color);
        }
        public Sphere() : base(new Vector(0.0, 0.0, 0.0), new Color())
        {
            cx = 0.0;
            cy = 0.0;
            cz = 0.0;
            position = new Vector(0.0, 0.0, 0.0);
            radius = 0.0;
            this.color = new Color();
        }

        public bool Equals(Sphere sphere) => cx == sphere.cx && cy == sphere.cy && cz == sphere.cz && radius == sphere.radius;

        public override int GetHashCode() => (int)(cx + cy + cz + radius);
 
        public override double GetIntersection(Vector from, Vector to)
        {
            Vector vec = from - position;
            double b = to * vec;
            double c = vec * vec - radius * radius;
            double d = b * b - c;
            if (d < 0)
            {
                return -1;
            }
            double det = Math.Sqrt(d);
            double t1 = -b - det;
            double t2 = -b + det;

            return t1 > t2 ? t1 : t2;
        }

        public override double GetIntersection(Vector from, Vector to, ref Vector normalAtPoint)
        {
            double t = GetIntersection(from, to);
            Vector v1 = to * t + from;
            v1 = v1 - position;
            v1.normalize();
            normalAtPoint = v1;
            return t;
        }

        public override string ToString() => "radius = " + radius.ToString() + base.ToString();
    }
}
