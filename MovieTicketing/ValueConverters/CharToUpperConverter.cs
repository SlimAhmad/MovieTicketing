using System;
using System.Globalization;

namespace jpr
{
    public class CharToUpperConverter : BaseValueConverter<CharToUpperConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var text = (string)value;

            if (text == null)
                return null;


            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text.ToLower());
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
