﻿using System;

namespace RayTracerLib
{
    public class Sphere : BaseObject
    {
        public double cx, cy, cz;
        public double radius;
        //public double clR, clG, clB;

        /// <summary>
        /// Sphere object
        /// <para/>defined by x,y,z of center position
        /// <para/>defined by r radius
        /// <para/>defined by r,g,b color parameters
        /// </summary>
        public Sphere(double x, double y, double z, double r, /*double clr, double clg, double clb*/Color color) : base(new Vector(x, y, z), color)
        {
            cx = x;
            cy = y;
            cz = z;
            position = new Vector(x, y, z);
            radius = r;
            this.color = new Color(color);
            //clR = clr;
            //clG = clg;
            //clB = clb;
        }

        public bool Equals(Sphere sphere) => cx == sphere.cx && cy == sphere.cy && cz == sphere.cz && radius == sphere.radius;

        public override int GetHashCode() => (int)(cx + cy + cz + radius);
        //public Sphere(BaseObject sphere)
        //{
        //    cx = sphere.position.X;
        //    cy = sphere.position.Y;
        //    cz = sphere.position.Z;
        //    position = new Vector(sphere.position.X, sphere.position.Y, sphere.position.Z);
        //    radius = sphere.radius;
        //    this.color = new Color(sphere.color);
        //    //clR = clr;
        //    //clG = clg;
        //    //clB = clb;
        //}

        public static double GetCoord(double i1, double i2, double w1, double w2, double p)
        {
            return ((p - i1) / (i2 - i1)) * (w2 - w1) + w1;
        }
        /// <summary>
        /// Magnitude of the vector
        /// <para/>Calculated by x,y,z parameters of the vector
        /// </summary>
        /// <param name="vx"></param>
        /// <param name="vy"></param>
        /// <param name="vz"></param>
        /// <returns></returns>
        //public static double modv(double vx, double vy, double vz)
        //{
        //    return System.Math.Sqrt(vx * vx + vy * vy + vz * vz);
        //}
        public override double GetIntersection(Vector from, Vector to)
        {
            //test
            // Determine initial position (Ro - Rc) = (origin of ray - sphere center)
            Vector vec = from - position;

            // Use Rd and vec to determine the b component of the quadratic for
            // the determinant
            double b = to * vec;

            // calculate the c component of the quadratic from (Ro-Rc)^2 - (radius of sphere)
            double c = vec * vec - radius * radius;

            //	calculate the discriminant
            double d = b * b - c;

            //	if the discriminant < 0 
            //  there is no intersection, return
            if (d < 0)
                return -1;

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

            // calculate the intersecting vector by substituting t back in
            Vector v1 = to * t + from;
            v1 = v1 - position;

            // normalize the vector
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
        //public static double GetCosAngleV1V2(double v1x, double v1y, double v1z,
        //                                     double v2x, double v2y, double v2z)
        //{
        //    /* incident angle
        //     intersection pt (i)
        //    double ix, iy, iz;
        //    ix = px+t*vx;
        //    iy = py+t*vy;
        //    iz = pz+t*vz;
        //    normal at i
        //    double nx, ny, nz;
        //    nx = ix - cx;
        //    ny = iy - cy;
        //    nz = iz - cz;

        //    cos(t) = (v.w) / (|v|.|w|)
        //    */
        //    return (v1x * v2x + v1y * v2y + v1z * v2z) / (modv(v1x, v1y, v1z) *
        //           modv(v2x, v2y, v2z));
        //}
    }
}
