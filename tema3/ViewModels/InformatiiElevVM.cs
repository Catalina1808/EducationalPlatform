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
    class InformatiiElevVM : BaseVM
    {
        ElevActions elevActions;
        public InformatiiElevVM()
        {
            elevActions = new ElevActions(this);
        }


        private string materie;
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

        private ObservableCollection<Tuple<string, int, bool, int>> noteList;
        public ObservableCollection<Tuple<string, int, bool, int>> NoteList
        {
            get
            {
                return noteList;
            }
            set
            {
                noteList = value;
                NotifyPropertyChanged("NoteList");
            }
        }

        private ObservableCollection<Tuple<string, string>> absenteList;
        public ObservableCollection<Tuple<string, string>> AbsenteList
        {
            get
            {
                return absenteList;
            }
            set
            {
                absenteList = value;
                NotifyPropertyChanged("AbsenteList");
            }
        }

        private ObservableCollection<Tuple<string, int, int>> mediiList;
        public ObservableCollection<Tuple<string, int, int>> MediiList
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
                    updateCommand = new RelayCommand(elevActions.Update);
                }
                return updateCommand;
            }
        }


    }
} 
