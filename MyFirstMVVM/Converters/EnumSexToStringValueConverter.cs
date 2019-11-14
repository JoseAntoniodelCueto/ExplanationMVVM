using MyFirstMVVM.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace MyFirstMVVM.Converters
{
    public class EnumSexToStringValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var enumSex = (EnumSex)value;

            if(enumSex == EnumSex.Female)
            {
                return "Mujer";
            }
            else
            {
                return "Hombre";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
