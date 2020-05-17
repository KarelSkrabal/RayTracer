using System;
using System.Globalization;
using System.IO;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace RayTracerWPF
{
    //class ImageConverter : IValueConverter
    //{
    //    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    //    {
    //        try
    //        {
    //            var CapturedImage = new BitmapImage();
    //            CapturedImage.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
    //            CapturedImage.UriSource = new Uri((string)value,UriKind.RelativeOrAbsolute);
    //            //using ( IRandomAccessStream fileStream = File.OpenAsync(FileAccessMode.Read).AsTask().Result)
    //            //{
    //            //    CapturedImage.SetSource(fileStream);
    //            //    return CapturedImage;

    //            //}
    //        }
    //        catch (Exception)
    //        {

    //            throw;
    //        }
    //    }

    //    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
