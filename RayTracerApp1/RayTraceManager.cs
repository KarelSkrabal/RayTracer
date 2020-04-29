using RayTracerLib;
using System;
using System.Drawing;

namespace RayTracerApp1
{
    public class RayTraceManager
    {
        private static string _filePath = @"c:\Users\k.skrabal\Documents\testBackGround.png";
        private  IRaTracer _rayTracer;
        public RayTraceManager()
        {
            _rayTracer = new RayTracer();
        }

        private  void DrawPicture(RayTracerLib.Color[,] pixels)
        {
            Bitmap bmp = new Bitmap(_rayTracer.canvasWidth, _rayTracer.canvasHeight);
            Graphics g = Graphics.FromImage(bmp);
            for (int i = 0; i < _rayTracer.canvasWidth; i++)
            {
                for (int j = 0; j < _rayTracer.canvasHeight; j++)
                {
                    var color = System.Drawing.Color.FromArgb((Byte)pixels[i, j].R, (Byte)pixels[i, j].G, (Byte)pixels[i, j].B);
                    System.Drawing.Brush brush1 = new SolidBrush(color);
                    g.FillRectangle(brush1, i, j, 1, 1);
                }
            }
            g.Dispose();
            bmp.Save(_filePath, System.Drawing.Imaging.ImageFormat.Png);
            bmp.Dispose();

            //var path = Path.Combine(@"c:\Users\k.skrabal\Documents\testBackGround.png");
            //var uri = new Uri(path);
            //var bitmap = new BitmapImage(uri);
        }
    }
}
