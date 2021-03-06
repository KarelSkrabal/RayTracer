﻿using System;

namespace RayTracerLib
{
    public class Triangle : BaseObject
    {
        Vector v0 { get; }
        Vector v1 { get; }
        Vector v2 { get; }


        public Triangle(Vector v0, Vector v1, Vector v2, Color c) : base(v0, c)
        {
            this.v0 = v0;
            this.v1 = v1;
            this.v2 = v2;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public bool Equals(Triangle triangle) => v0 == triangle.v0 && v1 == triangle.v1 && v2 == triangle.v2;

        public override int GetHashCode() => (int)(Vector.modv(v0) + Vector.modv(v1) + Vector.modv(v2));

        public override double GetIntersection(Vector from, Vector to)
        {
            Vector u = new Vector(v1 - v0);
            Vector v = new Vector(v2 - v0);
            Vector n = Vector.CrossProd(u, v);
            Vector dir = to - from;
            Vector w0 = from - v0;
            double a = -1 * Vector.dot(n, w0);
            double b = Vector.dot(n, dir);
            if (Math.Abs(b) < 0.000000001)
            {
                if (a == 0)
                    return 2;
                else return 0;
            }
            double r = a / b;
            if (r < 0)
                return 0;
            Vector I = from + r * dir;
            double uu, uv, vv, wu, wv, D;
            uu = Vector.dot(u, u);
            uv = Vector.dot(u, v);
            vv = Vector.dot(v, v);
            Vector w = I - v0;
            wu = Vector.dot(w, u);
            wv = Vector.dot(w, v);
            D = uv * uv - uu * vv;
            double s, t;
            s = (uv * wv - vv * wu) / D;
            if (s < 0.0 || s > 1.0)         // neni v trojuhelniku
                return 0;
            t = (uv * wu - uu * wv) / D;
            if (t < 0.0 || (s + t) > 1.0)  // neni v trojuhelniku
                return 0;
            //normalAtPoint = I;
            //normalAtPoint.normalize();
            return t;                       // je v trojuhelniku
        }
        public override double GetIntersection(Vector from, Vector to, ref Vector normalAtPoint)
        {
            Vector u = new Vector(v1 - v0);
            Vector v = new Vector(v2 - v0);
            Vector n = Vector.CrossProd(u, v);
            Vector dir = to - from;
            Vector w0 = from - v0;
            double a = -1 * Vector.dot(n, w0);
            double b = Vector.dot(n, dir);
            if (Math.Abs(b) < 0.000000001)
            {
                if (a == 0)
                    return 2;
                else return 0;
            }
            double r = a / b;
            if (r < 0)
                return 0;
            Vector I = from + r * dir;
            double uu, uv, vv, wu, wv, D;
            uu = Vector.dot(u, u);
            uv = Vector.dot(u, v);
            vv = Vector.dot(v, v);
            Vector w = I - v0;
            wu = Vector.dot(w, u);
            wv = Vector.dot(w, v);
            D = uv * uv - uu * vv;
            double s, t;
            s = (uv * wv - vv * wu) / D;
            if (s < 0.0 || s > 1.0)         // neni v trojuhelniku
                return 0;
            t = (uv * wu - uu * wv) / D;
            if (t < 0.0 || (s + t) > 1.0)  // neni v trojuhelniku
                return 0;
            normalAtPoint = I;
            normalAtPoint.normalize();
            return t;                       // je v trojuhelniku

            //returning point
            //V0 + s * u + t * v
            //u = V1 - V0 
            //v = V2 - V0
        }

        public override string ToString() => "triangle : v0=" + v0.ToString() + " , v1=" + v1.ToString() + " , v2=" + v2.ToString() + " , color=" + color.ToString();
    }
}
