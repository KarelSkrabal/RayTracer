using System;

namespace RayTracerLib
{
    public class BaseObject : IEquatable<BaseObject>
    {
        public Vector position { get; set; }
        public Color color { get; set; }

        public BaseObject(Vector p, Color c)
        {
            position = p;
            color = c;
        }

        public virtual double GetIntersection(Vector from, Vector to, ref Vector normalAtPoint) => 0.0;
        public virtual double GetIntersection(Vector from, Vector to) => 0.0;

        public bool Equals(BaseObject obj) => (obj is BaseObject) ? this == (BaseObject)obj : false;

        public new virtual string ToString() => " , position = " + position.ToString() + " , color = " + color.ToString();
    }
}
