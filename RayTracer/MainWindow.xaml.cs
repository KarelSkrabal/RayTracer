using System.Windows;
using System.Collections;
using System.IO;
using System.Windows.Media.Imaging;
using System.Drawing;
using System.Windows.Controls;
using System.Windows.Media;
using System;

namespace RayTracer
{
    
    

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private WriteableBitmap bitmap = new WriteableBitmap(1100, 1100, 96d, 96d, PixelFormats.Bgr24, null);
        public MainWindow()
        {
            InitializeComponent();
            Testtext.Text = new RayTracerLib.RayTracer().GetMessage();
        }
        //https://stackoverflow.com/questions/12764259/not-clear-unsafe-code-in-draw-pixel-method
        public void DrawRectangle(WriteableBitmap writeableBitmap, int left, int top, int width, int height, System.Windows.Media.Color color)
        {
            // Compute the pixel's color
            int colorData = color.R << 8; // R
            colorData |= color.G << 8; // G
            colorData |= color.B << 0; // B
            int bpp = writeableBitmap.Format.BitsPerPixel / 8;

            unsafe
            {
                for (int y = 0; y < height; y++)
                {
                    // Get a pointer to the back buffer
                    IntPtr pBackBuffer = (IntPtr)writeableBitmap.BackBuffer;

                    // Find the address of the pixel to draw
                    pBackBuffer += (top + y) * writeableBitmap.BackBufferStride;
                    pBackBuffer += left * bpp;

                    for (int x = 0; x < width; x++)
                    {
                        // Assign the color data to the pixel
                        *((int*)pBackBuffer) = colorData;

                        // Increment the address of the pixel to draw
                        pBackBuffer += bpp;
                    }
                }
            }

            writeableBitmap.AddDirtyRect(new Int32Rect(left, top, width, height));
        }
        private void AddPixel(double x, double y, System.Windows.Media.Color color)
        {
            
            System.Windows.Shapes.Rectangle rec = new System.Windows.Shapes.Rectangle();
            Canvas.SetTop(rec, y);
            Canvas.SetLeft(rec, x);
            rec.Width = 0.5;
            rec.Height = 0.5;
            rec.Fill = new SolidColorBrush(color);
            myCanvas.Children.Add(rec);
        }
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern bool DeleteObject(IntPtr hObject);
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            int size = 1;

            Random rnd = new Random(DateTime.Now.Millisecond);
            bitmap.Lock(); // Lock() and Unlock() could be moved to the DrawRectangle() method. Just do some performance tests.

            for (int y = 0; y < 200; y++)
            {
                for (int x = 0; x < 200; x++)
                {
                    byte colR = (byte)rnd.Next(256);
                    byte colG = (byte)rnd.Next(256);
                    byte colB = (byte)rnd.Next(256);

                    DrawRectangle(bitmap, (size + 1) * x, (size + 1) * y, size, size, System.Windows.Media.Color.FromRgb(colR, colG, colB));
                }
            }

            bitmap.Unlock(); // Lock() and Unlock() could be moved to the DrawRectangle() method. Just do some performance tests.

            image.Source = bitmap; // This should be done only once
            //unsafe
            //{
            //    System.Drawing.Point point = new System.Drawing.Point(320, 240);
            //    IntPtr hBmp;
            //    Bitmap bmp = new Bitmap(640, 480);
            //    Rectangle lockRegion = new Rectangle(0, 0, 640, 480);
            //    BitmapData data = bmp.LockBits(lockRegion, ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            //    byte* p;

            //    p = (byte*)data.Scan0 + (point.Y * data.Stride) + (point.X * 3);
            //    p[0] = 0; //B pixel
            //    p[1] = 255; //G pixel
            //    p[2] = 255; //R pixel

            //    bmp.UnlockBits(data);

            //    //Convert the bitmap to BitmapSource for use with WPF controls
            //    hBmp = bmp.GetHbitmap();
            //    Canvas.Source = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(hbmpCanvas, IntPtr.Zero, Int32Rect.Empty, System.Windows.Media.Imaging.BitmapSizeOptions.FromEmptyOptions());
            //    Canvas.Source.Freeze();
            //    DeleteObject(hBmp); //Clean up original bitmap
            //}

            //OK!!!!
            //for (int i = 10; i < 200; i++)
            //{
            //    for (int x = 0; x < 200; x++)
            //    {
            //        AddPixel(i, x,(i % 2 == 0) ? System.Windows.Media.Color.FromRgb(10,20,30) : System.Windows.Media.Color.FromRgb(50, 80, 50));
            //    }
            //}

            //    using (FileStream stream =
            //new FileStream("ColorSamples.png", FileMode.Create))
            //    {
            //        PngBitmapEncoder encoder = new PngBitmapEncoder();
            //        encoder.Frames.Add(BitmapFrame.Create(wbitmap));
            //        encoder.Save(stream);
            //    }

            //    // Tell the user we're done.
            //    MessageBox.Show("Done");
        }
    }
}
