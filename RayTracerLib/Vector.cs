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


        public static Vector cross (Vector v1, Vector v2)
        {
            return new Vector();
        }
    }
}
