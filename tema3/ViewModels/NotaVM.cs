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
    class NotaVM : BaseVM
    {
        NotaActions notaActions;
        public NotaVM()
        {
            notaActions = new NotaActions(this);
        }
        public int idNota;
        public int IdNota
        {
            get
            {
                return idNota;
            }
            set
            {
                idNota = value;
                NotifyPropertyChanged("IdNota");
            }
        }
        private ObservableCollection<NotaVM> noteListProf;
        public ObservableCollection<NotaVM> NoteListProf
        {
            get
            {
                noteListProf = notaActions.ToateNoteleProf();
                return noteListProf;
            }
            set
            {
                noteListProf = value;
                NotifyPropertyChanged("NoteListProf");
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

        public int nota;
        public int Nota
        {
            get
            {
                return nota;
            }
            set
            {
                nota = value;
                NotifyPropertyChanged("Nota");
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
                    addCommand = new RelayCommand(notaActions.AddMethod);
                }
                return addCommand;
            }
        }

        private ICommand deleteCommand;
        public ICommand DeleteCommand
        {
            get
            {
                if (deleteCommand == null)
                {
                    deleteCommand = new RelayCommand(notaActions.DeleteMethod);
                }
                return deleteCommand;
            }
        }


    }
}