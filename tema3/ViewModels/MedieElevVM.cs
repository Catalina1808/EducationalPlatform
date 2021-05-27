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
    class MedieElevVM: BaseVM
    {
        MedieActions medieActions;
        public MedieElevVM()
        {
            medieActions = new MedieActions(this);
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

        public int medieG;
        public int MedieG
        {
            get
            {
                return medieG;
            }
            set
            {
                medieG = value;
                NotifyPropertyChanged("MedieG");
            }
        }

       
        private ObservableCollection<MedieVM> mediiList;
        public ObservableCollection<MedieVM> MediiList
        {
            get
            {
                return mediiList;
            }
            set
            {
                mediiList = value;
                NotifyPropertyChanged("MediiList");
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
                    updateCommand = new RelayCommand(medieActions.UpdateMediiElev);
                }
                return updateCommand;
            }
        }


    }
}