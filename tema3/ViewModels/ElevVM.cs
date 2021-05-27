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
    class ElevVM : BaseVM
    {
        public static int IdLoginElev;
        ElevActions elevActions;
        public ElevVM()
        {
            elevActions = new ElevActions(this);
        }
        public int elevId;
        public int ElevId
        {
            get
            {
                return elevActions.IdElev();
            }
            set
            {
                elevId = value;
                NotifyPropertyChanged("ElevId");
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
                    MaterialElevView mat = new MaterialElevView();
                    Application.Current.Windows[0].Close();
                    mat.ShowDialog();
                    break;
                case "2":
                    InformatiiElevView info = new InformatiiElevView();
                    Application.Current.Windows[0].Close();
                    info.ShowDialog();
                    break;
                case "3":
                    MainWindow main = new MainWindow();
                    Application.Current.Windows[0].Close();
                    main.ShowDialog();
                    break;
            }
        }

    }
}