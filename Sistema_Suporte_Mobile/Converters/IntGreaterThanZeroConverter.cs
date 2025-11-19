using System;
using System.Globalization;
using Microsoft.Maui.Controls;

namespace Sistema_Suporte_Mobile.Converters
{
    public class IntGreaterThanZeroConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) =>
            value is int i && i > 0;

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) =>
            throw new NotImplementedException();
    }
}
