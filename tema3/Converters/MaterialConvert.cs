using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using tema3.ViewModels;

namespace tema3.Converters
{
    class MaterialConvert : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (values[0] != null && values[1] != null && values[2] != null)
            {
                return new MaterialVM()
                {
                    Materie = values[0].ToString(),
                    Clasa = values[1].ToString(),
                    Path = values[2].ToString()
                };
            }
            else
            {
                return null;
            }
        }
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            MaterialVM materialVM = value as MaterialVM;
            object[] result = new object[3] { materialVM.Materie, materialVM.Clasa, materialVM.Path};
            return result;
        }
    }
}
