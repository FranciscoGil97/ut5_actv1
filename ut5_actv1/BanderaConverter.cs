using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace ut5_actv1
{
    class BanderaConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //value --> String


            if (((string)value).ToLower() == "americana")
                return "united_states.png";
            else
                return ((string)value).ToLower() == "mexicana" ? "mexico.png": "china.png";
            //return ((string)value).ToLower() == "china" ? "china.png" : "mexico.png";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
