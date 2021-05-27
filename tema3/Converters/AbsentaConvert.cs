using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using tema3.ViewModels;

namespace tema3.Converters
{
    class AbsentaConvert : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (values[0] != null && values[1] != null && values[2] != null && values[3] != null && values[4] != null && values[5] != null && values[6] != null)
            {
                int sem;
                bool succes = int.TryParse(values[6].ToString(), out sem);
                if (!succes) sem = 0;
                return new AbsentaVM()
                {
                    Materie = values[0].ToString(),
                    ElevN = values[1].ToString(),
                    ElevP = values[2].ToString(),
                    Data = values[3].ToString(),
                    Motivata = System.Convert.ToBoolean(values[4]),
                    Motivabila = System.Convert.ToBoolean(values[5]),
                    Semestru= sem
                };
            }
            else
            {
                return null;
            }
        }
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            AbsentaVM absentaVM = value as AbsentaVM;
            object[] result = new object[7] { absentaVM.Materie, absentaVM.ElevN, absentaVM.ElevP, absentaVM.Data, absentaVM.Motivata, absentaVM.Motivabila, absentaVM.Semestru };
            return result;
        }
    }
}
