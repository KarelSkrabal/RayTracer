namespace RayTracerLib
{
    public class Plane : BaseObject
    {
        public Vector normal;
        public double d;
        public Plane(Vector position, Vector normal, Color color) : base(position, color)
        {
            this.position = position;
            this.normal = normal;
            this.color = color;
            d = -(normal.X * position.X + normal.Y * position.Y + normal.Z * position.Z);
        }

        public override double GetIntersection(Vector from, Vector to, ref Vector normalAtPoint)
        {
            double t = GetIntersection(from, to);
            Vector ret = new Vector();
            //ret = p + (t * v);
            ret = to * t + from;
            normalAtPoint = new Vector(ret.X, ret.Y, ret.Z);
            normalAtPoint.normalize();
            return t;
        }
        public override double GetIntersection(Vector from, Vector to)
        {
            Line line = new Line(to - from, from);
            Vector p = line.point;
            Vector v = line.direction;
            Vector n = normal;
            double dot1 = Vector.dot(n, v);
            double dot2 = Vector.dot(n, p);
            if (dot1 == 0)
                return 0;
            double t = -(dot2 + d) / dot1;
            return t;
        }

        public override string ToString() => "plane : position=" + position.ToString() + " , normal=" + normal.ToString() + " , color=" + color.ToString();
        class Line
        {
            public Vector direction { get; set; }
            public Vector point { get; set; }
            public Line(Vector direction, Vector point)
            {
                this.direction = direction;
                this.point = point;
            }
        }
    }
}
