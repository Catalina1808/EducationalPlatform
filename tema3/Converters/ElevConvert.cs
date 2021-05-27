using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using tema3.ViewModels;

namespace tema3.Converters
{
    class ElevConvert : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (values[0] != null && values[1] != null && values[2] != null && values[3] != null && values[4] != null)
            {
                return new EditareElevVM()
                {
                    Nume = values[0].ToString(),
                    Prenume = values[1].ToString(),
                    Clasa = values[2].ToString(),
                    Username = values[3].ToString(),
                    Password = values[4].ToString()
                };
            }
            else
            {
                return null;
            }
        }
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            EditareElevVM elevVM = value as EditareElevVM;
            object[] result = new object[5] { elevVM.Nume, elevVM.Prenume, elevVM.Clasa, elevVM.Username, elevVM.Password };
            return result;
        }
    }
}
