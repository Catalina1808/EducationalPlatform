using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using tema3.ViewModels;

namespace tema3.Converters
{
    class ProfesorConvert : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (values[0] != null && values[1] != null && values[2] != null && values[3] != null )
            {
                return new EditareProfesorVM()
                {
                    Nume = values[0].ToString(),
                    Prenume = values[1].ToString(),
                    Username = values[2].ToString(),
                    Password = values[3].ToString()
                };
            }
            else
            {
                return null;
            }
        }
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            EditareProfesorVM profesorVM = value as EditareProfesorVM;
            object[] result = new object[4] {profesorVM.Nume, profesorVM.Prenume,  profesorVM.Username,profesorVM.Password };
            return result;
        }
    }
}
