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
    class AbsentaDirigVM : BaseVM
    {
        AbsentaActions absentaActions;
        public AbsentaDirigVM()
        {
            absentaActions = new AbsentaActions(this);
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
                return absentaActions.NrTAbs();
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
                return absentaActions.NrNAbs();
            }
            set
            {
                nrN = value;
                NotifyPropertyChanged("NrN");
            }
        }
        private ObservableCollection<AbsentaDirigVM> absenteListDirig;
        public ObservableCollection<AbsentaDirigVM> AbsenteListDirig
        {
            get
            {
                absenteListDirig = absentaActions.ToateAbsenteleDirig();
                return absenteListDirig;
            }
            set
            {
                absenteListDirig = value;
                NotifyPropertyChanged("AbsenteListDirig");
            }
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

        public string materie;
        public string Materie
        {
            get
            {
                return materie;
            }
            set
            {
                materie = value;
                NotifyPropertyChanged("Materie");
            }
        }

        public string data;
        public string Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
                NotifyPropertyChanged("Data");
            }
        }

        public int semestru;
        public int Semestru
        {
            get
            {
                return semestru;
            }
            set
            {
                semestru = value;
                NotifyPropertyChanged("Semestru");
            }
        }
        public bool motivata;
        public bool Motivata
        {
            get
            {
                return motivata;
            }
            set
            {
                motivata = value;
                NotifyPropertyChanged("Motivata");
            }
        }
        public bool motivabila;
        public bool Motivabila
        {
            get
            {
                return motivabila;
            }
            set
            {
                motivabila = value;
                NotifyPropertyChanged("Motivabila");
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
                    updateCommand = new RelayCommand(absentaActions.MotivareDirig);
                }
                return updateCommand;
            }
        }


    }
}