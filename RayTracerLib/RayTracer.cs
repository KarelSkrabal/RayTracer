using System.Collections.Generic;
using System.Linq;

namespace RayTracerLib
{
    public class RayTracer : IRaTracer
    {
        public Vector p { get; set; }
        public Vector lp { get; set; }
        public Vector lv { get; set; }

        public int canvasWidth { get; set; }
        public int canvasHeight { get; set; }
        public List<BaseObject> objects { get; set; }

        public void RayTraceScene(ref Color[,] pixels)
        {
            InitializeOutput(ref pixels);
            
            for (int i = 0; i < canvasWidth; i++)
            {
                for (int j = 0; j < canvasHeight; j++)
                {
                    RayTrace(pixels, i, j);
                }//lines
            }//columns
        }

        private void RayTrace(Color[,] pixels, int i, int j)
        {
            Vector normalVectorAtPoint = new Vector();
            double t = 1.0E10;
            Vector to = new Vector(i - p.X, j - p.Y, -p.Z);
            to.normalize();
            bool bShadow = false;
            BaseObject obj = null;
            for (int k = 0; k < objects.Count(); k++)
            {
                double t1 = objects[k].GetIntersection(p, to, ref normalVectorAtPoint);
                if (t1 < 0)
                    continue;
                if (t1 > 0 && t1 < t)
                {
                    t = t1;
                    obj = objects[k];
                }
            }
            if (obj != null)
            {
                Vector hitPoint = p + t * to;
                double t2 = obj.GetIntersection(lp, normalVectorAtPoint);
                for (int k = 0; k < objects.Count(); k++)
                {
                    if (objects[k] != obj)
                    {
                        double t3 = obj.GetIntersection(lp, normalVectorAtPoint);
                        if (t3 > 0 && t2 < t3)
                        {
                            bShadow = true;
                            break;
                        }
                    }
                }
                double cost = Vector.GetCosAngleV1V2(lv, new Vector(hitPoint - obj.position));
                pixels[i, j] = Color.GetShedowedColor(bShadow, obj.color, cost);
            }
        }

        /// <summary>
        /// Initalizing output array of colors by 255,255,255 value
        /// </summary>
        private void InitializeOutput(ref Color[,] pixels)
        {
            //Color[,] ret = new Color[canvasWidth + 1, canvasHeight + 1];
            for (int i = 0; i < canvasWidth; i++)
            {
                for (int j = 0; j < canvasHeight; j++)
                {
                    pixels[i, j] = new Color(255, 255, 255);
                }
            }
        }
    }
}
