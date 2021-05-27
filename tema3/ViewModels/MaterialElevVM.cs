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
    class MaterialElevVM : BaseVM
    {
        MaterialActions materialActions;
        public MaterialElevVM()
        {
            materialActions = new MaterialActions(this);
        }
        public int idMaterial;
        public int IdMaterial
        {
            get
            {
                return idMaterial;
            }
            set
            {
                idMaterial = value;
                NotifyPropertyChanged("IdMaterial");
            }
        }
        private ObservableCollection<MaterialVM> materialList;
        public ObservableCollection<MaterialVM> MaterialList
        {
            get
            {
                return materialList;
            }
            set
            {
                materialList = value;
                NotifyPropertyChanged("MaterialList");
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
                    updateCommand = new RelayCommand(materialActions.Update);
                }
                return updateCommand;
            }
        }



    }
}

