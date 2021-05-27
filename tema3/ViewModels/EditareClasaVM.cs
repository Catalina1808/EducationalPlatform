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
    class EditareClasaVM : BaseVM
    {
        ClasaActions clasaActions;
        public EditareClasaVM()
        {
            clasaActions = new ClasaActions(this);
        }
        public int clasaId;
        public int ClasaId
        {
            get
            {
                return clasaId;
            }
            set
            {
                clasaId = value;
                NotifyPropertyChanged("ClasaId");
            }
        }
        private ObservableCollection<EditareClasaVM> claseList;
        public ObservableCollection<EditareClasaVM> ClaseList
        {
            get
            {
                claseList = clasaActions.ToateClasele();
                return claseList;
            }
            set
            {
                claseList = value;
                NotifyPropertyChanged("ClaseList");
            }
        }
        public string denumire;
        public string Denumire
        {
            get
            {
                return denumire;
            }
            set
            {
                denumire = value;
                NotifyPropertyChanged("Denumire");
            }
        }
        public string specializare;
        public string Specializare
        {
            get
            {
                return specializare;
            }
            set
            {
                specializare = value;
                NotifyPropertyChanged("Specializare");
            }
        }

        public string dirigN;
        public string DirigN
        {
            get
            {
                return dirigN;
            }
            set
            {
                dirigN = value;
                NotifyPropertyChanged("DirigN");
            }
        }
        public string dirigP;
        public string DirigP
        {
            get
            {
                return dirigP;
            }
            set
            {
                dirigP = value;
                NotifyPropertyChanged("DirigP");
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
                    addCommand = new RelayCommand(clasaActions.AddMethod);
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
                    updateCommand = new RelayCommand(clasaActions.UpdateMethod);
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
                    deleteCommand = new RelayCommand(clasaActions.DeleteMethod);
                }
                return deleteCommand;
            }
        }

    }
}