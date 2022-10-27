using System;
using System.Globalization;

namespace jpr
{
    public class BoolToActiveOrInActiveConverter : BaseValueConverter<BoolToActiveOrInActiveConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string text;
            var status = (bool)value;

            text = status ? "Active" : "Suspended";
            return text;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
