using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using tema3.ViewModels;

namespace tema3.Converters
{
    class ClasaConvert : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (values[0] != null && values[1] != null && values[2] != null && values[3] != null)
            {
                return new EditareClasaVM()
                {
                    Denumire = values[0].ToString(),
                    Specializare = values[1].ToString(),
                    DirigN = values[2].ToString(),
                    DirigP = values[3].ToString(),
                };
            }
            else
            {
                return null;
            }
        }
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            EditareClasaVM clasaVM = value as EditareClasaVM;
            object[] result = new object[4] { clasaVM.Denumire, clasaVM.Specializare, clasaVM.DirigN, clasaVM.DirigP};
            return result;
        }
    }
}
