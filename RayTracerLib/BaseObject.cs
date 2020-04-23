using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracerLib
{
    public class BaseObject
    {
        public Vector position { get; set; }
        public Color color { get; set; }

        public BaseObject(Vector p, Color c)
        {
            position = p;
            color = c;
        }

        /// <summary>
        /// <para/>Checks if object is intersected by the ray.
        /// <para/>Ray is defined by from and to vector
        /// </summary>
        /// <param name="from">Origin position of the ray</param>
        /// <param name="to">Direction to which the ray's heading </param>
        /// <param name="normal">Normal vector to the ray vector at the intersection point</param>
        /// <returns>Returns true if intersected or false</returns>
        public virtual bool isRayIntersected(Vector from, Vector to, ref Vector normal) => true;

        public virtual double GetSphereIntersec(Vector from, Vector to)
            //(/*double cx, double cy, double cz,*/
            //                 /*double radius,*/ double px, double py, double pz,
            //                 Vector v/*double vx, double vy, double vz*/)
        {
            return 0.0;
        }
    }
}
