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
    class EditarePMCVM : BaseVM
    {
        PMCActions PMCActions;
        public EditarePMCVM()
        {
            PMCActions = new PMCActions(this);
        }
        public int pmcId;
        public int PMCId
        {
            get
            {
                return pmcId;
            }
            set
            {
                pmcId = value;
                NotifyPropertyChanged("PMCId");
            }
        }
        private ObservableCollection<EditarePMCVM> pmcList;
        public ObservableCollection<EditarePMCVM> PMCList
        {
            get
            {
                pmcList = PMCActions.ToateCuplajele();
                return pmcList;
            }
            set
            {
                pmcList = value;
                NotifyPropertyChanged("PMCList");
            }
        }
        public string numeP;
        public string NumeP
        {
            get
            {
                return numeP;
            }
            set
            {
                numeP = value;
                NotifyPropertyChanged("NumeP");
            }
        }
        public string prenumeP;
        public string PrenumeP
        {
            get
            {
                return prenumeP;
            }
            set
            {
                prenumeP = value;
                NotifyPropertyChanged("PrenumeP");
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
        public bool teza;
        public bool Teza
        {
            get
            {
                return teza;
            }
            set
            {
                teza = value;
                NotifyPropertyChanged("Teza");
            }
        }
        public string clasa;
        public string Clasa
        {
            get
            {
                return clasa;
            }
            set
            {
                clasa = value;
                NotifyPropertyChanged("Clasa");
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
                    addCommand = new RelayCommand(PMCActions.AddMethod);
                }
                return addCommand;
            }
        }

        private ICommand updateCommand;
        public ICommand UpdateCommand
        {
            get
            {
                if (updateCommand == null)
                {
                    updateCommand = new RelayCommand(PMCActions.UpdateMethod);
                }
                return updateCommand;
            }
        }

        private ICommand deleteCommand;
        public ICommand DeleteCommand
        {
            get
            {
                if (deleteCommand == null)
                {
                    deleteCommand = new RelayCommand(PMCActions.DeleteMethod);
                }
                return deleteCommand;
            }
        }

    }
}