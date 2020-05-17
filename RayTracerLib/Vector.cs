using System;

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


        /// <summary>
        /// Unit vector of the vector defined by vector's components
        /// </summary>
        public Vector unitVector(double x, double y, double z)
        {
            Vector v = new Vector(x, y, z);
            v.normalize();
            return v;
        }

        /// <summary>
        /// Unit vector of the vector
        /// </summary>
        public Vector unitVector(Vector v)
        {
            v.normalize();
            return v;
        }

        public void normalize()
        {
            double length = Math.Sqrt(x * x + y * y + z * z);
            x /= length;
            y /= length;
            z /= length;
        }
        /// <summary>
        /// Magnitude of the given vector defined by vector's components
        /// <para/>Returns length of the vector
        /// </summary>
        public static double modv(double vx, double vy, double vz) => System.Math.Sqrt(vx * vx + vy * vy + vz * vz);

        /// <summary>
        /// Magnitude of the given vector
        /// <para/>Returns length of the vector
        /// </summary>
        public static double modv(Vector v) => System.Math.Sqrt(v.X * v.X + v.Y * v.Y + v.Z * v.Z);

        public static Vector operator *(Vector v, double d) => new Vector(v.X * d, v.Y * d, v.Z * d);

        /// <summary>
        /// Dot product
        /// </summary>
        public static double operator *(Vector v1, Vector v2) => v1.x * v2.x + v1.y * v2.y + v1.z * v2.z;

        public static bool operator ==(Vector v1, Vector v2) => v1.X == v2.X && v1.Y == v2.Y && v1.Z == v2.Z;

        public static bool operator !=(Vector v1, Vector v2) => v1.X != v2.X || v1.Y != v2.Y || v1.Z != v2.Z;

        public static double dot(Vector v1, Vector v2) => v1.x * v2.x + v1.y * v2.y + v1.z * v2.z;


        public static double GetCosAngleV1V2(Vector v1, Vector v2) => (v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z) / (modv(v1.X, v1.Y, v1.Z) * modv(v2.X, v2.Y, v2.Z));

        public static Vector operator +(Vector v1, Vector v2) => new Vector(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);

        public static Vector operator -(Vector v1, Vector v2) => new Vector(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
        /// <summary>
        /// soucin vektoru cislem
        /// </summary>
        /// <param name="v"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static Vector operator *(double d, Vector v) => new Vector(v.x * d, v.y * d, v.z * d);
        public static Vector CrossProd(Vector v1, Vector v2)
        {
            double x, y, z;
            x = v1.Y * v2.Z - v2.Y * v1.Z;
            y = (v1.X * v2.Z - v2.X * v1.Z) * -1;
            z = v1.X * v2.Y - v2.X * v1.Y;

            var rtnvector = new Vector(x, y, z);
            return rtnvector;
        }

        public override string ToString() => "(" + X + "," + Y + "," + Z + ")";
    }
}
