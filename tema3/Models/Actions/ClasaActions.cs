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
    class ClasaActions : BaseVM
    {
        CatalogEntities context = new CatalogEntities();
        private EditareClasaVM clasaContext;
        public ClasaActions(EditareClasaVM clasaVM)
        {
            this.clasaContext = clasaVM;
        }
        public void AddMethod(object obj)
        {
            EditareClasaVM clasaVM = obj as EditareClasaVM;
            if (clasaVM != null)
            {
                if (String.IsNullOrEmpty(clasaVM.Denumire))
                {
                    clasaContext.ErrorMessage = "Denumirea trebuie precizata";
                }
                else
                if (String.IsNullOrEmpty(clasaVM.Specializare))
                {
                    clasaContext.ErrorMessage = "Specializarea trebuie precizata";
                }
                else
                if (String.IsNullOrEmpty(clasaVM.DirigN))
                {
                    clasaContext.ErrorMessage = "Numele dirigintelui trebuie precizat";
                }
                else
                if (String.IsNullOrEmpty(clasaVM.DirigP))
                {
                    clasaContext.ErrorMessage = "Prenumele dirigintelui trebuie precizat";
                }
                else
                {
                    var idDirig = context.Profesori.Where(i => i.nume == clasaVM.DirigN && i.prenume == clasaVM.DirigP).ToList();

                    if (idDirig.Count() == 0)
                        clasaContext.ErrorMessage = "Profesorul ales ca diriginte nu exista!";
                    else
                    {
                        context.InserareinClasa(clasaVM.Denumire, clasaVM.Specializare, idDirig.ElementAt(0).id);
                        context.SaveChanges();
                        clasaContext.ClaseList = ToateClasele();
                        clasaContext.ErrorMessage = "";

                    }

                }
            }
        }

        public ObservableCollection<EditareClasaVM> ToateClasele()
        {
            List<Clasa> clase = context.Clase.ToList();
            ObservableCollection<EditareClasaVM> result = new ObservableCollection<EditareClasaVM>();
            foreach (Clasa clasa in clase)
            {

                result.Add(new EditareClasaVM()
                {
                    ClasaId = clasa.id,
                    Denumire = clasa.denumire,
                    Specializare = clasa.specializare,
                    DirigN = context.Profesori.Where(i => i.id == clasa.id_diriginte).FirstOrDefault().nume,
                    DirigP = context.Profesori.Where(i => i.id == clasa.id_diriginte).FirstOrDefault().prenume
                });
            }
            return result;
        }

        public void UpdateMethod(object obj)
        {
            EditareClasaVM clasaVM = obj as EditareClasaVM;
            if (clasaVM == null)
            {
                clasaContext.ErrorMessage = "Selecteaza o clasa";
            }
            if (String.IsNullOrEmpty(clasaVM.Denumire))
            {
                clasaContext.ErrorMessage = "Denumirea trebuie precizata";
            }
            else
                if (String.IsNullOrEmpty(clasaVM.Specializare))
            {
                clasaContext.ErrorMessage = "Specializarea trebuie precizata";
            }
            else
                if (String.IsNullOrEmpty(clasaVM.DirigN))
            {
                clasaContext.ErrorMessage = "Numele dirigintelui trebuie precizat";
            }
            else
                if (String.IsNullOrEmpty(clasaVM.DirigP))
            {
                clasaContext.ErrorMessage = "Prenumele dirigintelui trebuie precizat";
            }
            else
            {
                var idDirig = context.Profesori.Where(i => i.nume == clasaVM.DirigN && i.prenume == clasaVM.DirigP).ToList();

                if (idDirig.Count() == 0)
                    clasaContext.ErrorMessage = "Profesorul ales ca diriginte nu exista!";
                else
                {
                    context.ModificareClasa(clasaVM.ClasaId, clasaVM.Denumire, clasaVM.Specializare, idDirig.ElementAt(0).id);
                    context.SaveChanges();
                    clasaContext.ErrorMessage = " ";
                }
            }

        }

        public void DeleteMethod(object obj)
        {
            EditareClasaVM clasaVM = obj as EditareClasaVM;
            if (clasaVM == null)
            {
                clasaContext.ErrorMessage = "Selecteaza o clasa";
            }
            if (String.IsNullOrEmpty(clasaVM.Denumire))
            {
                clasaContext.ErrorMessage = "Denumirea trebuie precizata";
            }
            else
                if (String.IsNullOrEmpty(clasaVM.Specializare))
            {
                clasaContext.ErrorMessage = "Specializarea trebuie precizata";
            }
            else
                if (String.IsNullOrEmpty(clasaVM.DirigN))
            {
                clasaContext.ErrorMessage = "Numele dirigintelui trebuie precizat";
            }
            else
                if (String.IsNullOrEmpty(clasaVM.DirigP))
            {
                clasaContext.ErrorMessage = "Prenumele dirigintelui trebuie precizat";
            }
            else
            {
                context.StergereClasa(clasaVM.ClasaId);
                context.SaveChanges();
                clasaContext.ClaseList = ToateClasele();
                clasaContext.ErrorMessage = "";

            }

        }
    }
}