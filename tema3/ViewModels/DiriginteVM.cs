using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using tema3.Helpers;
using tema3.Models.Actions;
using tema3.Views;

namespace tema3.ViewModels
{
    class DiriginteVM : BaseVM
    {
        public static int IdLoginDirig;
        ProfesorActions profesorActions;
        public DiriginteVM()
        {
            profesorActions = new ProfesorActions(this);
        }
        public int profesorId;
        public int ProfesorId
        {
            get
            {
                return profesorActions.IdProfesor();
            }
            set
            {
                profesorId = value;
                NotifyPropertyChanged("ProfesorId");
            }
        }

        private ICommand openWindowCommand;
        public ICommand OpenWindowCommand
        {
            get
            {
                if (openWindowCommand == null)
                {
                    openWindowCommand = new RelayCommand(OpenWindow);
                }
                return openWindowCommand;
            }
        }

        public void OpenWindow(object obj)
        {
            string nr = obj as string;
            switch (nr)
            {
                case "1":
                    AbsenteClasaView abs = new AbsenteClasaView();
                    Application.Current.Windows[0].Close();
                    abs.ShowDialog();
                    break;
                case "2":
                    AbsenteElevView abse = new AbsenteElevView();
                    Application.Current.Windows[0].Close();
                    abse.ShowDialog();
                    break;
                case "3":
                    MedieElevView med = new MedieElevView();
                    Application.Current.Windows[0].Close();
                    med.ShowDialog();

                    break;
                case "4":
                    IerarhieView i = new IerarhieView();
                    Application.Current.Windows[0].Close();
                    i.ShowDialog();
                    break;
                case "5":
                    MainWindow main = new MainWindow();
                    Application.Current.Windows[0].Close();
                    main.ShowDialog();
                    break;
            }
        }

    }
}