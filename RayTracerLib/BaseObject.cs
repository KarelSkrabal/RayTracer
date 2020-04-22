using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracerLib
{
    /// <summary>
    /// Base class of all ray traced shapes
    /// </summary>
    public class BaseObject
    {
        protected Vector position;
        protected Color color;

        /// <summary>
        /// <para/>Base class constructor of shapes that are ray traced.
        /// <para/>Class is defined by position vector and color
        /// </summary>
        /// <param name="position">Center position</param>
        /// <param name="color">Color</param>
        public BaseObject(Vector position, Color color)
        {
            this.position = position;
            this.color = color;
        }

        /// <summary>
        /// <para/>Checks if object is intersected by the ray.
        /// <para/>Ray is defined by from and to vector
        /// </summary>
        /// <param name="from">Origin position of the ray</param>
        /// <param name="to">Direction to which the ray's heading </param>
        /// <param name="normal">Normal vector to the ray vector at the intersection point</param>
        /// <returns>Returns true if intersected or false</returns>
        protected virtual bool isRayIntersected(Vector from, Vector to, ref Vector normal) => true;
    }
}
