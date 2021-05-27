using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tema3.Helpers;
using tema3.ViewModels;

namespace tema3.Models.Actions
{
    class ProfesorActions : BaseVM
    {
        CatalogEntities context = new CatalogEntities();
        private EditareProfesorVM profesorContext;
        private ProfesorVM profesorContext2;
        private DiriginteVM profesorContext3;

        public ProfesorActions(EditareProfesorVM profesorVM)
        {
            this.profesorContext = profesorVM;
        }
        public ProfesorActions(ProfesorVM profesorVM)
        {
            this.profesorContext2 = profesorVM;
        }
        public ProfesorActions(DiriginteVM profesorVM)
        {
            this.profesorContext3 = profesorVM;
        }
        public void AddMethod(object obj)
        {
            EditareProfesorVM profesorVM = obj as EditareProfesorVM;
            if (profesorVM != null)
            {
                if (String.IsNullOrEmpty(profesorVM.Nume))
                {
                    profesorContext.ErrorMessage = "Numele trebuie precizat";
                }
                else
                if (String.IsNullOrEmpty(profesorVM.Prenume))
                {
                    profesorContext.ErrorMessage = "Prenumele trebuie precizat";
                }
                else
                if (String.IsNullOrEmpty(profesorVM.Username))
                {
                    profesorContext.ErrorMessage = "Username-ul trebuie precizat";
                }
                else
                if (String.IsNullOrEmpty(profesorVM.Password))
                {
                    profesorContext.ErrorMessage = "Parola trebuie precizat";
                }
                else
                {
                    context.InserareinLogin(profesorVM.Username, profesorVM.Password);
                    var login = context.CautareLogin(profesorVM.Username, profesorVM.Password);
                    context.InserareinProfesor(profesorVM.Nume, profesorVM.Prenume, login.ElementAt(0).id);
                    context.SaveChanges();
                    profesorContext.ProfesoriList = TotiProfesorii();
                    profesorContext.ErrorMessage = "";

                }

            }
        }
    

        public ObservableCollection<EditareProfesorVM> TotiProfesorii()
        {
            List<Profesor> profesori = context.Profesori.ToList();
            ObservableCollection<EditareProfesorVM> result = new ObservableCollection<EditareProfesorVM>();
            foreach (Profesor profesor in profesori)
            {

                result.Add(new EditareProfesorVM()
                {
                    ProfesorId = profesor.id,
                    Nume = profesor.nume,
                    Prenume = profesor.prenume,
                    Username = context.Logins.Where(i => i.id == profesor.id_login).FirstOrDefault().username,
                    Password = context.Logins.Where(i => i.id == profesor.id_login).FirstOrDefault().parola,
                });
            }
            return result;
        }

        public void UpdateMethod(object obj)
        {
            EditareProfesorVM profesorVM = obj as EditareProfesorVM;
            if (profesorVM == null)
            {
                profesorContext.ErrorMessage = "Selecteaza un profesor";
            }
            if (String.IsNullOrEmpty(profesorVM.Nume))
            {
                profesorContext.ErrorMessage = "Numele trebuie precizat";
            }
            else
                if (String.IsNullOrEmpty(profesorVM.Prenume))
            {
                profesorContext.ErrorMessage = "Prenumele trebuie precizat";
            }
            else
                if (String.IsNullOrEmpty(profesorVM.Username))
            {
                profesorContext.ErrorMessage = "Username-ul trebuie precizat";
            }
            else
                if (String.IsNullOrEmpty(profesorVM.Password))
            {
                profesorContext.ErrorMessage = "Parola trebuie precizat";
            }
            else
            {              
                    Profesor profesor = context.Profesori.Where(i => i.id == profesorVM.profesorId).FirstOrDefault();
                    int idLogin = profesor.id_login;
                    context.ModificareProfesor(profesorVM.profesorId, profesorVM.Nume, profesorVM.Prenume,  idLogin);
                    context.ModificareLogin(idLogin, profesorVM.Username, profesorVM.Password);
                    context.SaveChanges();
                    profesorContext.ErrorMessage = " ";
                
            }
        }

        public void DeleteMethod(object obj)
        {
            EditareProfesorVM profesorVM = obj as EditareProfesorVM;
            if (profesorVM == null)
            {
                profesorContext.ErrorMessage = "Selecteaza un profesor!";
            }
            if (String.IsNullOrEmpty(profesorVM.Nume))
            {
                profesorContext.ErrorMessage = "Numele trebuie precizat";
            }
            else
                if (String.IsNullOrEmpty(profesorVM.Prenume))
            {
                profesorContext.ErrorMessage = "Prenumele trebuie precizat";
            }
            else
                if (String.IsNullOrEmpty(profesorVM.Username))
            {
                profesorContext.ErrorMessage = "Username-ul trebuie precizat";
            }
            else
                if (String.IsNullOrEmpty(profesorVM.Password))
            {
                profesorContext.ErrorMessage = "Parola trebuie precizat";
            }
            else
            {
                context.StergereProfesor(profesorVM.ProfesorId);
                var login = context.CautareLogin(profesorVM.Username, profesorVM.Password);
                context.StergereLogin(login.ElementAt(0).id);
                context.SaveChanges();
                profesorContext.ProfesoriList = TotiProfesorii();
                profesorContext.ErrorMessage = "";

            }
        }

        public int IdProfesor()
        {
            var id = context.Profesori.Where(i => i.id_login == ProfesorVM.IdLogin).ToList();
            if (id.Count() != 0)
                return id.ElementAt(0).id;
            else
                return -1;
        }
    }
}