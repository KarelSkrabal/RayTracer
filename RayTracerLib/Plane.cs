using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracerLib
{
    public class Plane:BaseObject
    {
        Vector normal;
        public Plane(Vector position,Vector normal, Color color):base(position,color)
        {
            this.position = position;
            this.normal = normal;
            this.color = color;
        }

        public override double GetIntersection(Vector from, Vector to, ref Vector normalAtPoint)
        {
            // static Vector3D IntersectPoint(Vector3D rayVector, Vector3D rayPoint, Vector3D planeNormal, Vector3D planePoint) 
            //rayVector parameters from to, ray point calculate point , planeNormal..attribute, planePoint .. attribute
            return 1;
        }
        public override double GetIntersection(Vector from, Vector to) => 0.0;
    }
}
