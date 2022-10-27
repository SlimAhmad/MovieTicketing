using System;
using System.Globalization;

namespace jpr
{
    public class EmptyValueToBoolConverter : BaseValueConverter<EmptyValueToBoolConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return !string.IsNullOrEmpty($"{value}");
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
