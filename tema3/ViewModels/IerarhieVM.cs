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
    class IerarhieVM : BaseVM
    {
        MedieActions medieActions;
        public IerarhieVM()
        {
            medieActions = new MedieActions(this);
        }
        


        private ObservableCollection<Tuple<string, int>> mediiList;
        public ObservableCollection<Tuple<string, int>> MediiList
        {
            get
            {
                mediiList = medieActions.Ierarhie();
                return mediiList;
            }
            set
            {
                mediiList = value;
                NotifyPropertyChanged("IerarhieList");
            }
        }

        private ObservableCollection<Tuple<string, string>> premiantiList;
        public ObservableCollection<Tuple<string, string>> PremiantiList
        {
            get
            {
                premiantiList = medieActions.Premianti();
                return premiantiList;
            }
            set
            {
                premiantiList = value;
                NotifyPropertyChanged("PremiantiList");
            }
        }

        private ObservableCollection<Tuple<string, string>> corigentiList;
        public ObservableCollection<Tuple<string, string>> CorigentiList
        {
            get
            {
                corigentiList = medieActions.Corigenti();
                return corigentiList;
            }
            set
            {
                corigentiList = value;
                NotifyPropertyChanged("CorigentiList");
            }
        }

        private ObservableCollection<Tuple<string, int>> repetentiList;
        public ObservableCollection<Tuple<string, int>> RepetentiList
        {
            get
            {
                repetentiList = medieActions.Repetenti();
                return repetentiList;
            }
            set
            {
                repetentiList = value;
                NotifyPropertyChanged("RepetentiList");
            }
        }

        private ObservableCollection<Tuple<string, int>> exmatriculatiList;
        public ObservableCollection<Tuple<string, int>> ExmatriculatiList
        {
            get
            {
                exmatriculatiList = medieActions.Exmatriculati();
                return exmatriculatiList;
            }
            set
            {
                exmatriculatiList = value;
                NotifyPropertyChanged("ExmatriculatiList");
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