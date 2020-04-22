using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracerLib
{
    public struct Vector
    {
        double x;
        public double X => x;
        double y;
        public double Y => y;
        double z;
        public double Z => z;

        public Vector(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Vector(Vector vector)
        {
            x = vector.x;
            y = vector.y;
            z = vector.z;
        }

        public void normalize()
        {
            double length = Math.Sqrt(x * x + y * y + z * z);
            x /= length;
            y /= length;
            z /= length;
        }
        public static double modv(double vx, double vy, double vz)
        {
            return System.Math.Sqrt(vx * vx + vy * vy + vz * vz);
        }
        public static double GetCosAngleV1V2(Vector v1/*double v1x, double v1y, double v1z*/,
                                             Vector v2/*double v2x, double v2y, double v2z*/)
        {
            /* incident angle
             intersection pt (i)
            double ix, iy, iz;
            ix = px+t*vx;
            iy = py+t*vy;
            iz = pz+t*vz;
            normal at i
            double nx, ny, nz;
            nx = ix - cx;
            ny = iy - cy;
            nz = iz - cz;
            cos(t) = (v.w) / (|v|.|w|)
            */
            //return (v1x * v2x + v1y * v2y + v1z * v2z) / (modv(v1x, v1y, v1z) * modv(v2x, v2y, v2z));
            return (v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z) / (modv(v1.X, v1.Y, v1.Z) * modv(v2.X, v2.Y, v2.Z));
        }

        public static Vector operator +(Vector v1, Vector v2) => new Vector(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);

        public static Vector operator -(Vector v1, Vector v2) => new Vector(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
        /// <summary>
        /// soucin vektoru cislem
        /// </summary>
        /// <param name="v"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static Vector operator *(Vector v, double d) => new Vector(v.x * d, v.y * d, v.z * d);

        /// <summary>
        /// Skalarni soucin,0=>vektory kolme
        /// dot product
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static double operator *(Vector v1, Vector v2) => v1.x * v2.x + v1.y * v2.y + v1.z * v2.z;


        public static Vector cross(Vector v1, Vector v2)
        {
            return new Vector();
        }
    }
}
