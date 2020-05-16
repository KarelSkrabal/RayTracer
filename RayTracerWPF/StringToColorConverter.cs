using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Data;
using RTL = RayTracerLib;

namespace RayTracerWPF
{
    [ValueConversion(typeof(string), typeof(RTL.Color))]
    public class StringToColorConverter : BaseConverter, IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var colorName = value as string;
            if (string.IsNullOrEmpty(colorName))
            {
                //default value if something went wrong
                return new RTL.Color { R = 255, G = 255, B = 255 };
            }
            var color = ColorTranslator.FromHtml(colorName);
            return new RTL.Color { R = color.R, G = color.G, B = color.B };
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var rayTracerColor = value as RTL.Color;
            var color = Color.FromArgb((int)rayTracerColor.R, (int)rayTracerColor.G, (int)rayTracerColor.B);
            var colorName = ColorTranslator.ToHtml(color);
            return colorName;
        }
    }
}
