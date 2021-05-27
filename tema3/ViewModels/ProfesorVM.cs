using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using tema3.Helpers;
using tema3.Models.Actions;
using tema3.Views;

namespace tema3.ViewModels
{
    class ProfesorVM : BaseVM
    {
        public static int IdLogin;
        ProfesorActions profesorActions;
        public ProfesorVM()
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
                    AbsenteView absente = new AbsenteView();
                    for (int intCounter = App.Current.Windows.Count-2; intCounter >= 0; intCounter--)
                        App.Current.Windows[intCounter].Close();
                    absente.ShowDialog();

                        break;
                case "2":
                    NotaView nota = new NotaView();
                    for (int intCounter = App.Current.Windows.Count - 2; intCounter >= 0; intCounter--)
                        App.Current.Windows[intCounter].Close();
                    nota.ShowDialog();

                    break;
                case "3":
                    MaterialView material = new MaterialView();
                    for (int intCounter = App.Current.Windows.Count - 2; intCounter >= 0; intCounter--)
                        App.Current.Windows[intCounter].Close();
                    material.ShowDialog();
                    break;
                case "4":
                    MedieView medie = new MedieView();
                    for (int intCounter = App.Current.Windows.Count - 2; intCounter >= 0; intCounter--)
                        App.Current.Windows[intCounter].Close();
                    medie.ShowDialog();
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
