using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using tema3.Helpers;
using tema3.Views;

namespace tema3.ViewModels
{
    class AdminVM : BaseVM
    {
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
            //LoginActions lAct = new LoginActions(this);


            switch (nr)
            {
                case "1":
                    EditareElev editareElev = new EditareElev();
                    Application.Current.Windows[0].Close();
                    editareElev.ShowDialog();
                    break;
                case "2":
                    EditareProfesor editareProfesor = new EditareProfesor();
                    Application.Current.Windows[0].Close();
                    editareProfesor.ShowDialog();
                    break;
                case "3":
                    EditareMaterie editareMaterie = new EditareMaterie();
                    Application.Current.Windows[0].Close();
                    editareMaterie.ShowDialog();
                    break;
                case "4":
                    EditareClasa editareClasa = new EditareClasa();
                    Application.Current.Windows[0].Close();
                    editareClasa.ShowDialog();
                    break;
                case "5":
                    EditarePMC editarePMC = new EditarePMC();
                    Application.Current.Windows[0].Close();
                    editarePMC.ShowDialog();
                    break;
                case "6":
                    MainWindow mainWindow = new MainWindow();
                    Application.Current.Windows[0].Close();
                    mainWindow.ShowDialog();
                    break;
            }
        }
    }
}