using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using tema3.ViewModels;

namespace tema3.Converters
{
    class PMCConvert : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (values[0] != null && values[1] != null && values[2] != null && values[3] != null && values[4] != null)
            {
                return new EditarePMCVM()
                {
                    NumeP = values[0].ToString(),
                    PrenumeP = values[1].ToString(),
                    Clasa = values[2].ToString(),
                    Materie = values[3].ToString(),
                    Teza = System.Convert.ToBoolean(values[4])
                };
            }
            else
            {
                return null;
            }
        }
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            EditarePMCVM pmcVM = value as EditarePMCVM;
            object[] result = new object[5] { pmcVM.NumeP, pmcVM.PrenumeP, pmcVM.Clasa, pmcVM.Materie, pmcVM.Teza};
            return result;
        }
    }
}
