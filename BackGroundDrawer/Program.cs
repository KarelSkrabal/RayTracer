using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace BackGroundDrawer
{
    class Program
    {
        private static string _filePath = @"c:\Users\k.skrabal\Documents\test.png";
        static void Main(string[] args)
        {
            DrawPicture();
        }

        private static void DrawPicture()
        {
            Bitmap bmp = new Bitmap(1920, 1080);
            Graphics g = Graphics.FromImage(bmp);
            for (int i = 0; i < 1920; i++)
            {
                for (int y = 0; y < 1080; y++)
                {
                    var color = System.Drawing.Color.FromArgb(100, 150, 100);
                    System.Drawing.Brush brush1 = new SolidBrush(color);
                    g.FillRectangle(brush1, i, y, 1, 1);
                }
            }
            g.Dispose();
            bmp.Save(_filePath, System.Drawing.Imaging.ImageFormat.Png);
            bmp.Dispose();
        }
    }
}
