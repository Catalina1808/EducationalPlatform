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
    class MaterialVM : BaseVM
    {
        MaterialActions materialActions;
        public MaterialVM()
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
                materialList = materialActions.ToateMaterialele();
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
                NotifyPropertyChanged("ElevP");
            }
        }

        public string path;
        public string Path
        {
            get
            {
                return path;
            }
            set
            {
                path = value;
                NotifyPropertyChanged("Path");
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
                    addCommand = new RelayCommand(materialActions.AddMethod);
                }
                return addCommand;
            }
        }



    }
}

