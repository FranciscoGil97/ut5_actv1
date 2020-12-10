using System;
using System.Globalization;
using System.Windows.Data;

namespace ut5_actv1
{
    class BanderaConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (((string)value).ToLower() == "americana")
                return "united_states.png";
            else
                return ((string)value).ToLower() == "mexicana" ? "mexico.png": "china.png";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
