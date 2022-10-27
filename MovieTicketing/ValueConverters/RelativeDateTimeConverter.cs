using System;
using System.Globalization;

namespace jpr
{
    public class RelativeDateTimeConverter : BaseValueConverter<RelativeDateTimeConverter>
    {

        const int SECOND = 1;
        const int MINUTE = 60 * SECOND;
        const int HOUR = 60 * MINUTE;
        const int DAY = 24 * HOUR;
        const int MONTH = 30 * DAY;

        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            if (value == null) return string.Empty;

            var current_day = DateTime.Today;
            var postedData = (DateTime)value;

            var ts = new TimeSpan(DateTime.Now.Ticks - postedData.Ticks);
            double delta = Math.Abs(ts.TotalSeconds);

            if (delta < 1 * MINUTE)
            {
                if (ts.Seconds < 0)
                {
                    return "sometime ago";
                }
                return ts.Seconds == 1 ? "One second ago" : ts.Seconds + " seconds ago";
            }

            if (delta < 2 * MINUTE)
                return "A minute ago";

            if (delta < 45 * MINUTE)
            {
                if (ts.Seconds < 0)
                {
                    return "Sometime ago";
                }
                return ts.Minutes + " Minutes ago";
            }

            if (delta <= 90 * MINUTE)
                return "An hour ago";

            if (delta < 24 * HOUR)
            {
                if (ts.Hours < 0)
                {
                    return "Sometime ago";
                }

                if (ts.Hours == 1)
                    return "1 hour ago";

                return ts.Hours + " Hours ago";
            }

            if (delta < 48 * HOUR)
                return $"Yesterday at {postedData.ToString("t")}";

            if (delta < 30 * DAY)
            {
                if (ts.Days == 1)
                    return "1 day ago";

                return ts.Days + " Days ago";
            }


            if (delta < 12 * MONTH)
            {
                int months = (int)(Math.Floor((double)ts.Days / 30));
                return months <= 1 ? "One month ago" : months + " Months ago";
            }
            else
            {
                int years = (int)(Math.Floor((double)ts.Days / 365));
                return years <= 1 ? "One year ago" : years + " Years ago";
            }
        }


        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
