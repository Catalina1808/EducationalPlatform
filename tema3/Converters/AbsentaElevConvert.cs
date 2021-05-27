using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using tema3.ViewModels;

namespace tema3.Converters
{
    class AbsentaElevConvert : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (values[0] != null && values[1] != null)
            {

                return new AbsentaElevVM()
                {
                    ElevN = values[0].ToString(),
                    ElevP = values[1].ToString()
                };
            }
            else
            {
                return null;
            }
        }
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            AbsentaElevVM absentaVM = value as AbsentaElevVM;
            object[] result = new object[2] { absentaVM.ElevN, absentaVM.ElevP};
            return result;
        }
    }
}