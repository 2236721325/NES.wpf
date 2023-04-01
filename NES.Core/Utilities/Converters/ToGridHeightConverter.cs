using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace NES.Core.Utilities.Converters
{
    public class ThicknessToGridHeightConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is Thickness thickness)
            {
                return new GridLength((thickness.Bottom + thickness.Left + thickness.Right + thickness.Top) / 4);
            }
            return Binding.DoNothing;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
