using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using tema3.Helpers;
using tema3.Models.Actions;

namespace tema3.ViewModels
{
    class AbsentaElevVM : BaseVM
    {
        AbsentaActions absentaActions;
        public AbsentaElevVM()
        {
            absentaActions = new AbsentaActions(this);
        }
        public string elevN;
        public string ElevN
        {
            get
            {
                return elevN;
            }
            set
            {
                elevN = value;
                NotifyPropertyChanged("ElevN");
            }
        }
        public string elevP;
        public string ElevP
        {
            get
            {
                return elevP;
            }
            set
            {
                elevP = value;
                NotifyPropertyChanged("ElevP");
            }
        }
        public int idAbsenta;
        public int IdAbsenta
        {
            get
            {
                return idAbsenta;
            }
            set
            {
                idAbsenta = value;
                NotifyPropertyChanged("IdAbsenta");
            }
        }
        public int nrT;
        public int NrT
        {
            get
            {
                return nrT;
            }
            set
            {
                nrT = value;
                NotifyPropertyChanged("NrT");
            }
        }

        public int nrN;
        public int NrN
        {
            get
            {
                return nrN;
            }
            set
            {
                nrN = value;
                NotifyPropertyChanged("NrN");
            }
        }
        private ObservableCollection<AbsentaDirigVM> absenteListElev;
        public ObservableCollection<AbsentaDirigVM> AbsenteListElev
        {
            get
            {
                return absenteListElev;
            }
            set
            {
                absenteListElev = value;
                NotifyPropertyChanged("AbsenteListElev");
            }
        }

        public string errorMessage;
        public string ErrorMessage
        {
            get
            {
                return errorMessage;
            }
            set
            {
                errorMessage = value;
                NotifyPropertyChanged("ErrorMessage");
            }
        }

        private ICommand updateCommand;
        public ICommand UpdateCommand
        {
            get
            {
                if (updateCommand == null)
                {
                    updateCommand = new RelayCommand(absentaActions.UpdateAbsElev);
                }
                return updateCommand;
            }
        }


    }
}