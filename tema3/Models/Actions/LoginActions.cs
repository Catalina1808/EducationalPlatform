using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using tema3.Helpers;
using tema3.ViewModels;

namespace tema3.Models.Actions
{
    class LoginActions : BaseVM
    {
        CatalogEntities context = new CatalogEntities();
        private MainWindowVM loginContext;
        public LoginActions(MainWindowVM mainWindowVM)
        {
            this.loginContext = mainWindowVM;
        }

        public bool IsProfesor(int id)
        {
            var profesorId = context.LoginProfesor(id);
            if (profesorId.Count() != 0)
                return true;
            return false;
        }

        public bool IsElev(int id)
        {
            var elevId = context.LoginElev(id);
            if (elevId.Count() != 0)
                return true;
            return false;
        }

        public int UserId(object obj)
        {
            MainWindowVM mainWindowVM = obj as MainWindowVM;
            if (mainWindowVM != null)
            {
                if (String.IsNullOrEmpty(mainWindowVM.Username))
                {
                    loginContext.ErrorMessage = "Nu ati introdus username!";
                }
                else
                 if (String.IsNullOrEmpty(mainWindowVM.Password))
                {
                    loginContext.ErrorMessage = "Nu ati introdus parola!";
                }
                else
                {
                    var login= context.CautareLogin(mainWindowVM.Username, mainWindowVM.Password);
                    try
                    {
                        loginContext.ErrorMessage = "";
                        return login.ElementAt(0).id;
                    }
                    catch
                    {
                        loginContext.ErrorMessage = "Parola sau username-ul sunt gresite!";
                    }
                }
            }
            return -1;
        }
       
    }
}
