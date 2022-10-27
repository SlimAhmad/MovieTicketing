using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace jpr
{
    public class CollectionHasElementsConverter : BaseValueConverter<CollectionHasElementsConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            if (value == null)
                return false;

            return ((IEnumerable<object>)value).Any();
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
