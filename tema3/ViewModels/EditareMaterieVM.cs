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
    class EditareMaterieVM : BaseVM
    {
        MaterieActions materieActions;
        public EditareMaterieVM()
        {
            materieActions = new MaterieActions(this);
        }
        public int materieId;
        public int MaterieId
        {
            get
            {
                return materieId;
            }
            set
            {
                materieId = value;
                NotifyPropertyChanged("MaterieId");
            }
        }
        private ObservableCollection<EditareMaterieVM> materiiList;
        public ObservableCollection<EditareMaterieVM> MateriiList
        {
            get
            {
                materiiList = materieActions.ToateMateriile ();
                return materiiList;
            }
            set
            {
                materiiList = value;
                NotifyPropertyChanged("MateriiList");
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
                    addCommand = new RelayCommand(materieActions.AddMethod);
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
                    updateCommand = new RelayCommand(materieActions.UpdateMethod);
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
                    deleteCommand = new RelayCommand(materieActions.DeleteMethod);
                }
                return deleteCommand;
            }
        }

    }
}