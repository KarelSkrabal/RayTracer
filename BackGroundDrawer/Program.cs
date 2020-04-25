using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using TIHUNTER;
using RayTracerLib;

namespace BackGroundDrawer
{
    class Program
    {
        private static string _filePath = @"c:\Users\k.skrabal\Documents\testBackGround.png";
        private static IRaTracer _rayTracer;
        public static IRaTracer rayTracer { get; set; }
        //private static RayTracerLib.Color[,] pixels;

        static void Main(string[] args)
        {
            rayTracer = new RayTracerLib.RayTracer();
            rayTracer.canvasHeight = 200;
            rayTracer.canvasWidth = 200;
            rayTracer.lp = new RayTracerLib.Vector(200.0, 200.0, -100.0);
            rayTracer.lv = new RayTracerLib.Vector(0.0, -1.0, -1.0);
            rayTracer.p = new RayTracerLib.Vector(0.0, 200.0, 500.0);


            rayTracer.objects = new List<BaseObject>();
            rayTracer.objects.Add (new RayTracerLib.Sphere(100.0, 100.0, 0.0, 40.0, new RayTracerLib.Color(250.0, 0.0, 50.0)));
            rayTracer.objects.Add(new RayTracerLib.Sphere(20.0, 20.0, 0.0, 20.0, new RayTracerLib.Color(30.0, 30.0, 200.0)));
            //RayTracerLib.Vector v0 = new RayTracerLib.Vector(0.0, 0.0, 10.0);
            //RayTracerLib.Vector v1 = new RayTracerLib.Vector(10.0, 0.0, 10.0);
            //RayTracerLib.Vector v2 = new RayTracerLib.Vector(0.0, 10.0, 10.0);
            //rayTracer.objects.Add(new RayTracerLib.Triangle(v0, v1, v2, new RayTracerLib.Color(200.0, 30.0, 30.0)));
            //RayTracerLib.Triangle tt = new RayTracerLib.Triangle(v0, v1, v2, new RayTracerLib.Color(200.0, 30.0, 30.0));

            RayTracerLib.Color[,] pixels = new RayTracerLib.Color[rayTracer.canvasWidth, rayTracer.canvasHeight];
            rayTracer.RayTrace(ref pixels);
            DrawPicture(pixels);
        }

        private static void DrawPicture(RayTracerLib.Color[,] pixels)
        {
            Bitmap bmp = new Bitmap(rayTracer.canvasWidth,rayTracer.canvasHeight);
            Graphics g = Graphics.FromImage(bmp);
            for (int i = 0; i < rayTracer.canvasWidth; i++)
            {
                for (int j = 0; j < rayTracer.canvasHeight; j++)
                {
                    var color = System.Drawing.Color.FromArgb((Byte)pixels[i,j].R, (Byte)pixels[i, j].G, (Byte)pixels[i, j].B);
                    System.Drawing.Brush brush1 = new SolidBrush(color);
                    g.FillRectangle(brush1, i, j, 1, 1);
                }
            }
            g.Dispose();
            bmp.Save(_filePath, System.Drawing.Imaging.ImageFormat.Png);
            bmp.Dispose();
        }

        //private static void DrawPicture1()
        //{
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
        //}
    }
}
