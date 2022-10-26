using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Data;

namespace EmployeeInformation.WPF.Converters
{
    public class StringToPhoneConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value == null)
                return string.Empty;

            string phoneNumber = value.ToString()
                .Replace("(", string.Empty)
                .Replace(")", string.Empty)
                .Replace(" ", string.Empty)
                .Replace("-", string.Empty)
                .Replace(".", string.Empty)
                .TrimStart('0');

            return Regex.Replace(phoneNumber, @"(\d{3})(\d{3})(\d{3})", "($1)-$2-$3");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
