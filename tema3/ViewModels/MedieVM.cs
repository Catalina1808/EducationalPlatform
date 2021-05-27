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
    class MedieVM : BaseVM
    {
        MedieActions medieActions;
        public MedieVM()
        {
            medieActions = new MedieActions(this);
        }
        public int idMedie;
        public int IdMedie
        {
            get
            {
                return idMedie;
            }
            set
            {
                idMedie = value;
                NotifyPropertyChanged("IdMedie");
            }
        }
        private ObservableCollection<MedieVM> mediiListProf;
        public ObservableCollection<MedieVM> MediiListProf
        {
            get
            {
                mediiListProf = medieActions.ToateMediileProf();
                return mediiListProf;
            }
            set
            {
                mediiListProf = value;
                NotifyPropertyChanged("MediiListProf");
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

        public int medie;
        public int Medie
        {
            get
            {
                return medie;
            }
            set
            {
                medie = value;
                NotifyPropertyChanged("Medie");
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

        private ICommand addCommand;
        public ICommand AddCommand
        {
            get
            {
                if (addCommand == null)
                {
                    addCommand = new RelayCommand(medieActions.AddMethod);
                }
                return addCommand;
            }
        }



    }
}