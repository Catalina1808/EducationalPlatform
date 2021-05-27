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
    class MainWindowVM: BaseVM
    {
        LoginActions loginActions;

        public string Username { get; set; }
        public string Password { get; set; }
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
        public bool dirig;
        public bool Dirig
        {
            get
            {
                return dirig;
            }
            set
            {
                dirig = value;
                NotifyPropertyChanged("Dirig");
            }
        }
        public MainWindowVM()
        {
           loginActions = new LoginActions(this);
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
            LoginActions lAct = new LoginActions(this);
            int idLogin = lAct.UserId(this);
            if (idLogin!=-1)


            switch (nr)
            {
                case "1":
                        if (lAct.IsProfesor(idLogin))
                        {
                            ProfesorVM.IdLogin = idLogin;
                            DiriginteVM.IdLoginDirig = idLogin;
                            if (dirig)
                            {
                                DiriginteView diriginte = new DiriginteView();
                                for (int intCounter = App.Current.Windows.Count - 2; intCounter >= 0; intCounter--)
                                    App.Current.Windows[intCounter].Close();
                                diriginte.ShowDialog();
                            }
                            else
                            {
                                ProfesorView profesor = new ProfesorView();
                                for (int intCounter = App.Current.Windows.Count - 2; intCounter >= 0; intCounter--)
                                    App.Current.Windows[intCounter].Close();
                                profesor.ShowDialog();
                            }
                        }
                        else { ErrorMessage = "Username-ul si parola nu sunt de profesor."; }
                        break;
                case "2":
                        if (lAct.IsElev(idLogin))
                        {
                            ElevVM.IdLoginElev = idLogin;
                            ElevView elev = new ElevView();
                            for (int intCounter = App.Current.Windows.Count - 2; intCounter >= 0; intCounter--)
                                App.Current.Windows[intCounter].Close();
                            elev.ShowDialog();
                        }
                        else { ErrorMessage = "Username-ul si parola nu sunt de elev."; }
                        break;
                case "3":
                        if (!lAct.IsElev(idLogin) && !lAct.IsProfesor(idLogin))
                        {
                            AdminView admin = new AdminView();                           
                            Application.Current.Windows[0].Close();                          
                            admin.ShowDialog();
                        }
                        else { ErrorMessage = "Username-ul si parola nu sunt de admin"; }
                        break;
                case "4":
                    break;
            }   
        }
    }
}
