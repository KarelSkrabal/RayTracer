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
        /// <summary>
        /// Calculates ray and sphere intersection
        /// <para/> cx,cy,cz are sphere's center point
        /// <para/> px,py,pz are ray's point
        /// <para/> vx,vy,vz are ray's vector components
        /// <para/> Can result in 0 intersections, 1 intersection (if tangent) or at most 2 intersections
        /// </summary>
        /// <returns>Can result in 0 intersections, 1 intersection (if tangent) or at most 2 intersections</returns>
        public override double GetIntersection(Vector from, Vector to, ref Vector normalAtPoint)
        {
            double t = GetIntersection(from, to);
            Vector v1 = to * t + from;
            v1 = v1 - position;
            v1.normalize();
            normalAtPoint = v1;
            return t;
        }

        public bool isRayIntersected(Vector from, Vector to, ref Vector normal)
        {
            throw new NotImplementedException();
        }

        public double GetSphereIntersec(double cx, double cy, double cz, double radius, double px, double py, double pz, double vx, double vy, double vz)
        {
            double A = (vx * vx + vy * vy + vz * vz);
            double B = 2.0 * (px * vx + py * vy + pz * vz - vx * cx - vy *
                       cy - vz * cz);
            double C = px * px - 2 * px * cx + cx * cx + py * py - 2 * py *
                       cy + cy * cy + pz * pz - 2 * pz * cz + cz * cz -
                       radius * radius;
            double D = B * B - 4 * A * C;
            double t = -1.0;
            if (D >= 0)
            {
                double t1 = (-B - System.Math.Sqrt(D)) / (2.0 * A);
                double t2 = (-B + System.Math.Sqrt(D)) / (2.0 * A);
                if (t1 > t2)
                    t = t1;
                else
                    t = t2;
            }
            return t;
        }

        public override string ToString() => "radius = " + radius.ToString() + base.ToString();
    }
}
