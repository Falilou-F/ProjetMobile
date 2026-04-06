using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace SicilyLinesMobile
{
    public class DateToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string dateStr && DateTime.TryParse(dateStr, out DateTime date))
            {
                return date < DateTime.Today ? Colors.LightGray : Color.FromArgb("#C8F5C8");
            }
            return Colors.White;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            => throw new NotImplementedException();
    }
}
