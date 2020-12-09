using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ut5_actv1
{
    class NombrePlatoConversor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (((string)value).ToLower() == "americana")
                return "Slim Summer";
            else
                return ((string)value).ToLower() == "china" ? "Chinese Wok Food St" : "Taco Salad";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
