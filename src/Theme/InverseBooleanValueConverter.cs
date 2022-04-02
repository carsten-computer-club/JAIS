using System;
using System.Globalization;
using Avalonia.Data.Converters;

namespace Theme
{
    class InverseBooleanValueConverter : IValueConverter
    {
        public bool Default { get; set; }
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value is bool b ? !b : Default;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value is bool b ? !b : !Default;
        }
    }
}
