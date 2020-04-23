using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Drawing;//has to be deleted
using System.IO;//has to be deleted

namespace RayTracerLib
{
    public class RayTracer : IRaTracer
    {
        private static string _filePath = @"c:\Users\k.skrabal\Documents\test.png";
        public Vector p { get; set; }
        public Vector lp { get; set; }
        public Vector lv { get; set; }

        public int canvasWidth { get; set; }
        public int canvasHeight { get; set; }

        public Color[,] RayTrace()
        {
            //Initializing the result
            Color[,] ret = InitializeOutput();
            System.Drawing.Bitmap newBitmap = new System.Drawing.Bitmap(150, 150, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(newBitmap);
            System.Drawing.Rectangle rect = new System.Drawing.Rectangle(0, 0, canvasWidth, canvasHeight/* 150, 150*/);
            List<BaseObject> objs = new List<BaseObject>();
            objs.Add(new RayTracerLib.Sphere(100.0, 20.0, 90.0, 50.0, new Color(250.0, 100.0, 0.0)/*250.0, 100.0, 0.0*/));
            objs.Add(new RayTracerLib.Sphere(0.0, 0.0, 90.0, 40.0, new Color(0.0, 100.0, 0.0)/*250.0, 100.0, 0.0*/));
            objs.Add(new RayTracerLib.Sphere(50.0, 60.0, 90.0, 40.0, new Color(100.0, 100.0, 100.0)/*250.0, 100.0, 0.0*/));
            double fMax = canvasWidth/* 150.0*/;
            for (int i = rect.Left; i <= rect.Right; i++)
            {
                for (int j = rect.Top; j <= rect.Bottom; j++)
                {
                    double x = RayTracerLib.Sphere.GetCoord(rect.Left, rect.Right, -fMax, fMax, i);
                    double y = RayTracerLib.Sphere.GetCoord(rect.Top, rect.Bottom, fMax, -fMax, j);
                    double t = 1.0E10;
                    //creating a unit vector of the ray going from eye to the point on 2Dview
                    Vector to = new Vector(x - p.X, y - p.Y, -p.Z);
                    to.normalize();
                    bool bShadow = false;
                    BaseObject spherehit1 = null;
                    for (int k = 0; k < objs.Count; k++)
                    {
                        BaseObject sphn1 = objs[k];
                        //Generate ray & sphere intersection, ray is originating from eye position through each point in the 2Dview screen, returning 0,1,2
                        double taux1 = sphn1.GetSphereIntersec(p, to);
                        if (taux1 < 0/*taux < 0*/)
                            continue;
                        if (taux1 > 0 && taux1 < t/*taux > 0 && taux < t*/)
                        {
                            t = taux1/*taux*/;
                            spherehit1 = sphn1;
                        }
                    }
                    System.Drawing.Color color = System.Drawing.Color.FromArgb(255, 255, 255);
                    if (spherehit1 != null/* spherehit != null*/)
                    {
                        //double itx = p.X/*px*/ + t * vx;
                        double itx = p.X + t * to.X;
                        //double ity = p.Y/*py*/ + t * vy;
                        double ity = p.Y/*py*/ + t * to.Y;
                        //double itz = p.Z/*pz*/ + t * vz;
                        double itz = p.Z/*pz*/ + t * to.Z;
                        //shadow
                        //lpx,lpy,lpz .. light position
                        //this is intersection of which line???????
                        //double tauxla = RayTracerLib.Sphere.GetSphereIntersec(spherehit.cx, spherehit.cy, spherehit.cz, spherehit.radius,
                        //    lp.X/*lpx*/, lp.Y/*lpy*/, lp.Z/*lpz*/,
                        //    itx - lp.X/*lpx*/, ity - lp.Y/*lpy*/, itz - lp.Z/*lpz*/);
                        double tauxla1 = spherehit1.GetSphereIntersec(lp/*lp.X, lp.Y, lp.Z*/, new Vector(itx - lp.X/*lpx*/, ity - lp.Y/*lpy*/, itz - lp.Z/*lpz*/));
                        //for (int k = 0; k < (int)obj3dArrayList.Count; k++)
                        for (int k = 0; k < objs.Count; k++)
                        {
                            BaseObject sphnb1 = objs[k];
                            if (sphnb1 != spherehit1/* sphnb != spherehit*/)
                            {
                                //double tauxlb = RayTracerLib.Sphere.GetSphereIntersec(sphnb.cx, sphnb.cy, sphnb.cz, sphnb.radius,
                                //    lp.X/*lpx*/, lp.Y/*lpy*/, lp.Z/*lpz*/,
                                //    itx - lp.X/*lpx*/, ity - lp.Y/*lpy*/, itz - lp.Z/*lpz*/);
                                double tauxlb1 = sphnb1.GetSphereIntersec(lp/*lp.X, lp.Y, lp.Z*/, new Vector(itx - lp.X/*lpx*/, ity - lp.Y/*lpy*/, itz - lp.Z/*lpz*/));
                                if (tauxlb1 > 0 && tauxla1 < tauxlb1 /*tauxlb > 0 && tauxla < tauxlb*/)
                                {
                                    bShadow = true;
                                    break;
                                }
                            }
                        }
                        //double cost = RayTracerLib.Sphere.GetCosAngleV1V2(lv.X/*lvx*/, lv.Y/*lvy*/, lv.Z/*lvz*/, itx - spherehit.cx, ity - spherehit.cy, itz - spherehit.cz);
                        Vector eyeVector = new Vector(itx - spherehit1.position.X/*cx*/, ity - spherehit1.position.Y/*.cy*/, itz - spherehit1.position.Z/*.cz*/);
                        double cost = Vector.GetCosAngleV1V2(lv, eyeVector /*itx - spherehit.cx, ity - spherehit.cy, itz - spherehit.cz*/);
                        if (cost < 0)
                            cost = 0;
                        double fact = 1.0;
                        if (bShadow == true)
                            fact = 0.5;
                        else
                            fact = 1.0;
                        double rgbR = spherehit1.color.R/* spherehit.clR*/ * cost * fact;
                        double rgbG = spherehit1.color.G/*spherehit.clG*/ * cost * fact;
                        double rgbB = spherehit1.color.B/*spherehit.clB */* cost * fact;
                        color = System.Drawing.Color.FromArgb((int)rgbR, (int)rgbG, (int)rgbB);
                        System.Drawing.Pen pen = new System.Drawing.Pen(color);
                        ret[i, j] = Color.GetShedowedColor(bShadow, spherehit1.color, cost);
                    }
                    System.Drawing.Brush brs = new SolidBrush(color);
                    g.FillRectangle(brs, i, j, 1, 1);
                    newBitmap.Save(_filePath, System.Drawing.Imaging.ImageFormat.Png);
                    brs.Dispose();
                }//lines
            }//columns
            MemoryStream tempStream = new MemoryStream();
            newBitmap.Save(tempStream, System.Drawing.Imaging.ImageFormat.Png);
            return ret;
        }

        /// <summary>
        /// Initalizing output array of colors by 255,255,255 value
        /// </summary>
        private Color[,] InitializeOutput()
        {
            Color[,] ret = new Color[canvasWidth + 1, canvasHeight + 1];
            for (int i = 0; i < canvasWidth + 1; i++)
            {
                for (int j = 0; j < canvasHeight + 1; j++)
                {
                    ret[i, j] = new Color(255, 255, 255);
                }
            }

            return ret;
        }

        //public Color[,] RayTrace()
        //{
        //    //defining the result
        //    Color[,] ret = new Color[canvasWidth, canvasHeight];

        //    System.Drawing.Bitmap newBitmap = new System.Drawing.Bitmap(150, 150, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
        //    Graphics g = Graphics.FromImage(newBitmap);

        //    System.Drawing.Rectangle rect = new System.Drawing.Rectangle(0, 0, 150, 150);
        //    ArrayList obj3dArrayList = new ArrayList();
        //    obj3dArrayList.Add(new RayTracerLib.Sphere(0.0, 0.0, 90.0, 70.0, 250.0, 100.0, 0.0));
        //    //Graphics graphics = g;
        //    //Eye position
        //    double px = 0.0;
        //    double py = 0.0;
        //    double pz = 500.0;
        //    //Light position
        //    double lpx = 100.0;
        //    double lpy = 100.0;
        //    double lpz = 200.0;
        //    //Light direction
        //    double lvx = -1.0;
        //    double lvy = -1.0;
        //    double lvz = -1.0;
        //    //????
        //    double fMax = 150.0;
        //    //lines
        //    for (int i = rect.Left; i <= rect.Right; i++)
        //    {
        //        //x coordination of the point inside the rectangle
        //        double x = RayTracerLib.Sphere.GetCoord(rect.Left, rect.Right, -fMax, fMax, i);
        //        //      GetCoord(double i1, double i2, double w1, double w2, double p)
        //        //      return ((p - i1) / (i2 - i1)) * (w2 - w1) + w1;
        //        //columns
        //        for (int j = rect.Top; j <= rect.Bottom; j++)
        //        {
        //            //y coordination of the point inside the rectangle
        //            double y = RayTracerLib.Sphere.GetCoord(rect.Top, rect.Bottom, fMax, -fMax, j);
        //            //t parameter to get all points of ray
        //            double t = 1.0E10;
        //            //vx,vy,vz parameters of the vector of the ray going from eye position to the x,y point inside the rectangle
        //            double vx = x - px, vy = y - py, vz = -pz;
        //            //magnitude of the direction vector of the ray
        //            double mod_v = RayTracerLib.Sphere.modv(vx, vy, vz);
        //            //normalizing the direction vector of the ray
        //            vx = vx / mod_v;
        //            vy = vy / mod_v;
        //            vz = vz / mod_v;
        //            bool bShadow = false;
        //            RayTracerLib.Sphere spherehit = null;
        //            //Going through objects collection
        //            for (int k = 0; k < obj3dArrayList.Count; k++)
        //            {
        //                RayTracerLib.Sphere sphn = (RayTracerLib.Sphere)obj3dArrayList[k];
        //                //Generate ray & sphere intersection, ray is originating from eye position, returning 0,1,2
        //                double taux = RayTracerLib.Sphere.GetSphereIntersec(sphn.cx, sphn.cy, sphn.cz, sphn.radius, px, py, pz, vx, vy, vz);
        //                //Decide if the ray hit the sphere
        //                if (taux < 0)
        //                    continue;
        //                if (taux > 0 && taux < t)
        //                {
        //                    t = taux;
        //                    spherehit = sphn;
        //                }
        //            }
        //            //Generate background color of the picture
        //            System.Drawing.Color color = System.Drawing.Color.FromArgb(255, 255, 255);
        //            //If a hit exists check shading
        //            //Lambertian shading or cosine shading
        //            //It determines the brightness of a point based on the normal vector at the point and the vector from the point to the light source.
        //            if (spherehit != null)
        //            {
        //                //px,py,pz eye position
        //                //vx,vy,vz ray's vector components
        //                //itx,ity,itz .. vector from eye toward object
        //                double itx = px + t * vx;
        //                double ity = py + t * vy;
        //                double itz = pz + t * vz;
        //                //shadow
        //                //lpx,lpy,lpz .. light position
        //                //this is intersection of which line???????
        //                double tauxla = RayTracerLib.Sphere.GetSphereIntersec(spherehit.cx, spherehit.cy, spherehit.cz, spherehit.radius,
        //                    lpx, lpy, lpz,
        //                    itx - lpx, ity - lpy, itz - lpz);
        //                for (int k = 0; k < (int)obj3dArrayList.Count; k++)
        //                {
        //                    RayTracerLib.Sphere sphnb = (RayTracerLib.Sphere)(obj3dArrayList[k]);
        //                    if (sphnb != spherehit)
        //                    {
        //                        double tauxlb = RayTracerLib.Sphere.GetSphereIntersec(sphnb.cx, sphnb.cy, sphnb.cz, sphnb.radius,
        //                            lpx, lpy, lpz,
        //                            itx - lpx, ity - lpy, itz - lpz);
        //                        if (tauxlb > 0 && tauxla < tauxlb)
        //                        {
        //                            bShadow = true;
        //                            break;
        //                        }
        //                    }
        //                }
        //                double cost = RayTracerLib.Sphere.GetCosAngleV1V2(lvx, lvy, lvz, itx - spherehit.cx, ity - spherehit.cy, itz - spherehit.cz);
        //                if (cost < 0)
        //                    cost = 0;
        //                double fact = 1.0;
        //                if (bShadow == true)
        //                    fact = 0.5;
        //                else
        //                    fact = 1.0;
        //                double rgbR = spherehit.clR * cost * fact;
        //                double rgbG = spherehit.clG * cost * fact;
        //                double rgbB = spherehit.clB * cost * fact;
        //                color = System.Drawing.Color.FromArgb((int)rgbR, (int)rgbG, (int)rgbB);
        //                System.Drawing.Pen pen = new System.Drawing.Pen(color);
        //                //assigning the result
        //                //in caller cast parameters to int because System.Drawing.Color will be used
        //                ret[i, j] = new Color(rgbR, rgbG, rgbB);
        //            }
        //            System.Drawing.Brush brs = new SolidBrush(color);
        //            g.FillRectangle(brs, i, j, 1, 1);

        //            //g = graphics;
        //            newBitmap.Save(_filePath, System.Drawing.Imaging.ImageFormat.Png);
        //            brs.Dispose();
        //        }//lines
        //    }//columns
        //    MemoryStream tempStream = new MemoryStream();
        //    newBitmap.Save(tempStream, System.Drawing.Imaging.ImageFormat.Png);
        //    return ret;
        //}


    }
}
