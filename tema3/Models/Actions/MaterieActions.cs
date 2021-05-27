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
    class MaterieActions : BaseVM
    {
        CatalogEntities context = new CatalogEntities();
        private EditareMaterieVM materieContext;
        public MaterieActions(EditareMaterieVM materieVM)
        {
            this.materieContext = materieVM;
        }
        public void AddMethod(object obj)
        {
            EditareMaterieVM materieVM = obj as EditareMaterieVM;
            if (materieVM != null)
            {
                if (String.IsNullOrEmpty(materieVM.Denumire))
                {
                    materieContext.ErrorMessage = "Denumirea trebuie precizat";
                }
                else
                {
                    
                        context.InserareinMaterie(materieVM.Denumire);
                        context.SaveChanges();
                        materieContext.MateriiList = ToateMateriile();
                        materieContext.ErrorMessage = "";



                }
            }
        }

        public ObservableCollection<EditareMaterieVM> ToateMateriile()
        {
            List<Materie> materii = context.Materii.ToList();
            ObservableCollection<EditareMaterieVM> result = new ObservableCollection<EditareMaterieVM>();
            foreach (Materie materie in materii)
            {

                result.Add(new EditareMaterieVM()
                {
                    MaterieId = materie.id,
                    Denumire = materie.denumire
                });
            }
            return result;
        }

        public void UpdateMethod(object obj)
        {
            EditareMaterieVM materieVM = obj as EditareMaterieVM;
            if (materieVM == null)
            {
                materieContext.ErrorMessage = "Selecteaza o materie";
            }
            if (String.IsNullOrEmpty(materieVM.Denumire))
            {
                materieContext.ErrorMessage = "Denumirea trebuie precizat";
            }
            else
            {                                
                    context.ModificareMaterie(materieVM.materieId, materieVM.Denumire);
                    context.SaveChanges();
                    materieContext.ErrorMessage = " ";               
            }
        }

        public void DeleteMethod(object obj)
        {
            EditareMaterieVM materieVM = obj as EditareMaterieVM;
            if (materieVM == null)
            {
                materieContext.ErrorMessage = "Selecteaza o materie";
            }
            if (String.IsNullOrEmpty(materieVM.Denumire))
            {
                materieContext.ErrorMessage = "Denumirea trebuie precizat";
            }
            else
            {
                
                context.StergereMaterie(materieVM.MaterieId);
                context.SaveChanges();
                materieContext.MateriiList = ToateMateriile();
                materieContext.ErrorMessage = "";

            }
        }
    }
}