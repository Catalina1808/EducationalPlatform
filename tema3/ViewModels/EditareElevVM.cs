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
    class EditareElevVM : BaseVM
    {
        ElevActions elevActions;
        public EditareElevVM()
        {
            elevActions = new ElevActions(this);
        }
        public int elevId;
        public int ElevId
        {
            get
            {
                return elevId;
            }
            set
            {
                elevId = value;
                NotifyPropertyChanged("ElevId");
            }
        }
        private ObservableCollection<EditareElevVM> eleviList;
        public ObservableCollection<EditareElevVM> EleviList
        {
            get
            {
                eleviList = elevActions.TotiElevii();
                return eleviList;
            }
            set
            {
                eleviList = value;
                NotifyPropertyChanged("EleviList");
            }
        }
        public string username;
        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
                NotifyPropertyChanged("Username");
            }
        }
        public string password;
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
                NotifyPropertyChanged("Password");
            }
        }

        public string nume;
        public string Nume
        {
            get
            {
                return nume;
            }
            set
            {
                nume = value;
                NotifyPropertyChanged("Nume");
            }
        }
        public string prenume;
        public string Prenume
        {
            get
            {
                return prenume;
            }
            set
            {
                prenume = value;
                NotifyPropertyChanged("Prenume");
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
                    addCommand = new RelayCommand(elevActions.AddMethod);
                }
                return addCommand;
            }
        }

        //asta este pt butonul Update
        private ICommand updateCommand;
        public ICommand UpdateCommand
        {
            get
            {
                if (updateCommand == null)
                {
                    updateCommand = new RelayCommand(elevActions.UpdateMethod);
                }
                return updateCommand;
            }
        }

        //asta este pt butonul Delete
        private ICommand deleteCommand;
        public ICommand DeleteCommand
        {
            get
            {
                if (deleteCommand == null)
                {
                    deleteCommand = new RelayCommand(elevActions.DeleteMethod);
                }
                return deleteCommand;
            }
        }

    }
}
