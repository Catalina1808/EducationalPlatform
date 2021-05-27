using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using tema3.ViewModels;

namespace tema3.Converters
{
    class MedieConvert : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (values[0] != null && values[1] != null && values[2] != null && values[3] != null && values[4] != null )
            {
                bool succes = int.TryParse(values[3].ToString(), out int nota);
                bool succes2 = int.TryParse(values[4].ToString(), out int sem);
                if (!succes) nota = 0;
                if (!succes2) sem = 0;
                return new MedieVM()
                {
                    Materie = values[0].ToString(),
                    ElevN = values[1].ToString(),
                    ElevP = values[2].ToString(),
                    Medie = nota,
                    Semestru = sem

                };
            }
            else
            {
                return null;
            }
        }
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            MedieVM notaVM = value as MedieVM;
            object[] result = new object[5] { notaVM.Materie, notaVM.ElevN, notaVM.ElevP, notaVM.Medie, notaVM.Semestru };
            return result;
        }
    }
}