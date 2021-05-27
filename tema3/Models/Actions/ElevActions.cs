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
    class ElevActions : BaseVM
    {
        CatalogEntities context = new CatalogEntities();
        private EditareElevVM elevContext;
        private ElevVM elevContext2;
        private InformatiiElevVM elevContext3;
        public ElevActions(EditareElevVM elevVM)
        {
            this.elevContext = elevVM;
        }

        public ElevActions(InformatiiElevVM elevVM)
        {
            this.elevContext3 = elevVM;
        }

        public ElevActions(ElevVM elevVM)
        {
            this.elevContext2 = elevVM;
        }

        public void AddMethod(object obj)
        {
            //parametrul obj este cel dat prin CommandParameter cu MultipleBinding la Button in xaml
            EditareElevVM elevVM = obj as EditareElevVM;
            if (elevVM != null)
            {
                if (String.IsNullOrEmpty(elevVM.Nume))
                {
                    elevContext.ErrorMessage = "Numele trebuie precizat";
                }
                else
                if (String.IsNullOrEmpty(elevVM.Prenume))
                {
                    elevContext.ErrorMessage = "Prenumele trebuie precizat";
                }
                else
                if (String.IsNullOrEmpty(elevVM.Clasa))
                {
                    elevContext.ErrorMessage = "Clasa trebuie precizat";
                }
                else
                if (String.IsNullOrEmpty(elevVM.Username))
                {
                    elevContext.ErrorMessage = "Username-ul trebuie precizat";
                }
                else
                if (String.IsNullOrEmpty(elevVM.Password))
                {
                    elevContext.ErrorMessage = "Parola trebuie precizat";
                }
                else
                {
                    var idClasa = context.Clase.Where(i => i.denumire == elevVM.Clasa).ToList();

                    if(idClasa.Count()==0)
                        elevContext.ErrorMessage = "Clasa respectiva nu exista!";
                    else
                    {
                        context.InserareinLogin(elevVM.Username, elevVM.Password);
                        var login = context.CautareLogin(elevVM.Username, elevVM.Password);
                        context.InserareinElev(elevVM.Nume, elevVM.Prenume, idClasa.ElementAt(0).id, login.ElementAt(0).id);
                        context.SaveChanges();
                        elevContext.EleviList = TotiElevii();
                        elevContext.ErrorMessage = "";

                    }

                }
            }
        }

        public ObservableCollection<EditareElevVM> TotiElevii()
        {
            List<Elev> elevi = context.Elevi.ToList();
            ObservableCollection<EditareElevVM> result = new ObservableCollection<EditareElevVM>();
            foreach (Elev elev in elevi)
            {

                result.Add(new EditareElevVM()
                {
                   ElevId =elev.id,
                   Nume = elev.nume,
                   Prenume= elev.prenume,
                   Clasa =context.Clase.Where(i => i.id == elev.id_clasa).FirstOrDefault().denumire,
                   Username = context.Logins.Where(i => i.id == elev.id_login).FirstOrDefault().username,
                   Password = context.Logins.Where(i => i.id == elev.id_login).FirstOrDefault().parola,
                });
            }
            return result;
        }

        public void UpdateMethod(object obj)
        {
           EditareElevVM elevVM = obj as EditareElevVM;
            if (elevVM == null)
            {
                elevContext.ErrorMessage = "Selecteaza un elev";
            }
            if (String.IsNullOrEmpty(elevVM.Nume))
            {
                elevContext.ErrorMessage = "Numele trebuie precizat";
            }
            else
                if (String.IsNullOrEmpty(elevVM.Prenume))
            {
                elevContext.ErrorMessage = "Prenumele trebuie precizat";
            }
            else
                if (String.IsNullOrEmpty(elevVM.Clasa))
            {
                elevContext.ErrorMessage = "Clasa trebuie precizat";
            }
            else
                if (String.IsNullOrEmpty(elevVM.Username))
            {
                elevContext.ErrorMessage = "Username-ul trebuie precizat";
            }
            else
                if (String.IsNullOrEmpty(elevVM.Password))
            {
                elevContext.ErrorMessage = "Parola trebuie precizat";
            }
            else
            {
                var idClasa = context.Clase.Where(i => i.denumire == elevVM.Clasa).ToList();

                if (idClasa.Count() == 0)
                    elevContext.ErrorMessage = "Clasa respectiva nu exista!";
                else
                {
                    Elev elev = context.Elevi.Where(i => i.id == elevVM.elevId).FirstOrDefault();
                    int idLogin = elev.id_login;
                    context.ModificareElev(elevVM.elevId, elevVM.Nume, elevVM.Prenume, idClasa.ElementAt(0).id, idLogin);
                    context.ModificareLogin(idLogin, elevVM.Username, elevVM.Password);
                    context.SaveChanges();
                    elevContext.ErrorMessage =" ";
                }
            }
        }

        public void DeleteMethod(object obj)
        {
            EditareElevVM elevVM = obj as EditareElevVM;
            if (elevVM == null)
            {
                elevContext.ErrorMessage = "Selecteaza un elev";
            }
            if (String.IsNullOrEmpty(elevVM.Nume))
            {
                elevContext.ErrorMessage = "Numele trebuie precizat";
            }
            else
                if (String.IsNullOrEmpty(elevVM.Prenume))
            {
                elevContext.ErrorMessage = "Prenumele trebuie precizat";
            }
            else
                if (String.IsNullOrEmpty(elevVM.Clasa))
            {
                elevContext.ErrorMessage = "Clasa trebuie precizat";
            }
            else
                if (String.IsNullOrEmpty(elevVM.Username))
            {
                elevContext.ErrorMessage = "Username-ul trebuie precizat";
            }
            else
                if (String.IsNullOrEmpty(elevVM.Password))
            {
                elevContext.ErrorMessage = "Parola trebuie precizat";
            }
            else
            {
               // Elev elev = context.Elevi.Where(i => i.id== elevVM.ElevId).FirstOrDefault();
                 
               context.StergereElev(elevVM.ElevId);
                var login = context.CautareLogin(elevVM.Username, elevVM.Password);
                context.StergereLogin(login.ElementAt(0).id);
                context.SaveChanges();
                    elevContext.EleviList =TotiElevii();
                    elevContext.ErrorMessage = "";

            }
        }

        public int IdElev()
        {
            var id = context.Elevi.Where(i => i.id_login == ElevVM.IdLoginElev).ToList();
            if (id.Count() != 0)
                return id.ElementAt(0).id;
            else
                return -1;
        }

        public int MedieG()
        {
            int idElev = IdElev();
            var medii = context.Medii.Where(i => i.id_elev == idElev).ToList();
            float medieG = 0;
            int nrMedii = medii.Count();
            for (int i = 0; i < nrMedii; i++)
                medieG += medii.ElementAt(i).medie1;
            medieG = medieG / nrMedii;
            return (int)medieG;
        }

        public ObservableCollection<Tuple<string, int, bool, int>> Note( int idMaterie)
        {
            int idElev = IdElev();
            var note = context.Note.Where(i => i.id_elev == idElev && i.id_materie == idMaterie).ToList();
            ObservableCollection<Tuple<string, int, bool, int>> result = new ObservableCollection<Tuple<string, int, bool, int>>();
         
            foreach (var nota in note)
            {
                
                result.Add(new Tuple<string, int, bool, int>(context.Materii.Where(i => i.id==idMaterie).ToList().ElementAt(0).denumire, nota.nota1, nota.teza, nota.semestru));
            }
            return result;
        }

        public ObservableCollection<Tuple<string, string>> Absente(int idMaterie)
        {
            int idElev = IdElev();
            var absente = context.Absente.Where(i => i.id_elev == idElev && i.id_materie == idMaterie).ToList();
            ObservableCollection<Tuple<string, string>> result = new ObservableCollection<Tuple<string, string>>();
            foreach (var absenta in absente)
            {

                result.Add(new Tuple<string, string>(context.Materii.Where(i => i.id == idMaterie).ToList().ElementAt(0).denumire, absenta.data));
            }
            return result;
        }

        public ObservableCollection<Tuple<string, int, int>> Medii(int idMaterie)
        {
            int idElev = IdElev();
            var medii = context.Medii.Where(i => i.id_elev == idElev && i.id_materie == idMaterie).ToList();
            ObservableCollection<Tuple<string, int, int>> result = new ObservableCollection<Tuple<string, int, int>>();
            foreach (var medie in medii)
            {

                result.Add(new Tuple<string, int, int>(context.Materii.Where(i => i.id == idMaterie).ToList().ElementAt(0).denumire, medie.medie1, medie.semestru));
            }
            return result;
        }

        public void Update(object obj)
        {
            InformatiiElevVM infoVM = obj as InformatiiElevVM;

            if (String.IsNullOrEmpty(infoVM.Materie))
            {
                elevContext3.ErrorMessage = "Materia trebuie precizata";
            }
            else
            {
                var materie1 = context.Materii.Where(i => i.denumire == infoVM.Materie).ToList();
                if (materie1.Count() == 0)
                    elevContext3.ErrorMessage = "Nu exista materia respectiva!";
                else
                {
                    int idMaterie = materie1.ElementAt(0).id;
                    elevContext3.NoteList = Note(idMaterie);
                    elevContext3.AbsenteList = Absente(idMaterie);
                    elevContext3.MediiList = Medii(idMaterie);
                    elevContext3.MedieG = MedieG();
                    elevContext3.ErrorMessage = " ";
                }

            }
        }
    }
}
