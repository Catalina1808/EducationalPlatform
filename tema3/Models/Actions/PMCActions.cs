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
    class PMCActions : BaseVM
    {
        CatalogEntities context = new CatalogEntities();
        private EditarePMCVM pmcContext;
        public PMCActions(EditarePMCVM pmcVM)
        {
            this.pmcContext = pmcVM;
        }
        public void AddMethod(object obj)
        {
            EditarePMCVM pmcVM = obj as EditarePMCVM;
            if (pmcVM != null)
            {
                if (String.IsNullOrEmpty(pmcVM.NumeP))
                {
                    pmcContext.ErrorMessage = "Numele profesorului trebuie precizat";
                }
                else
                if (String.IsNullOrEmpty(pmcVM.PrenumeP))
                {
                    pmcContext.ErrorMessage = "Prenumele profesorului trebuie precizat";
                }
                else
                if (String.IsNullOrEmpty(pmcVM.Clasa))
                {
                    pmcContext.ErrorMessage = "Clasa trebuie precizat";
                }
                else
                if (String.IsNullOrEmpty(pmcVM.Materie))
                {
                    pmcContext.ErrorMessage = "Materie trebuie precizat";
                }
                else
                {
                    var idProfesor = context.Profesori.Where(i => i.nume == pmcVM.NumeP && i.prenume==pmcVM.PrenumeP).ToList();
                    var idMaterie = context.Materii.Where(i => i.denumire == pmcVM.Materie).ToList();
                    var idClasa = context.Clase.Where(i => i.denumire == pmcVM.Clasa).ToList();

                    if (idProfesor.Count() == 0 || idMaterie.Count()==0 || idClasa.Count()==0)
                        pmcContext.ErrorMessage = "Profesorul, materia sau clasa nu exista!";
                    else
                    {
                        context.InserareinProfMatCls(idProfesor.ElementAt(0).id, idMaterie.ElementAt(0).id, idClasa.ElementAt(0).id, pmcVM.Teza);
                        context.SaveChanges();
                        pmcContext.PMCList = ToateCuplajele();
                        pmcContext.ErrorMessage = "";

                    }

                }
            }
        }

        public ObservableCollection<EditarePMCVM> ToateCuplajele()
        {
            List<Profesor_Materie_Clasa> cuplaje = context.Profesori_Materii_Clase.ToList();
            ObservableCollection<EditarePMCVM> result = new ObservableCollection<EditarePMCVM>();
            foreach (Profesor_Materie_Clasa pmc in cuplaje)
            {

                result.Add(new EditarePMCVM()
                {
                    PMCId = pmc.id,
                    NumeP = context.Profesori.Where(i => i.id == pmc.id_profesor).FirstOrDefault().nume,
                    PrenumeP = context.Profesori.Where(i => i.id == pmc.id_profesor).FirstOrDefault().prenume,
                    Clasa = context.Clase.Where(i => i.id == pmc.id_clasa).FirstOrDefault().denumire,
                    Materie = context.Materii.Where(i => i.id == pmc.id_materie).FirstOrDefault().denumire,
                    Teza = pmc.teza
                }) ;
            }
            return result;
        }

        public void UpdateMethod(object obj)
        {
            EditarePMCVM pmcVM = obj as EditarePMCVM;
            if (pmcVM == null)
            {
                pmcContext.ErrorMessage = "Selecteaza un cuplaj";
            }
            if (String.IsNullOrEmpty(pmcVM.NumeP))
            {
                pmcContext.ErrorMessage = "Numele profesorului trebuie precizat";
            }
            else
               if (String.IsNullOrEmpty(pmcVM.PrenumeP))
            {
                pmcContext.ErrorMessage = "Prenumele profesorului trebuie precizat";
            }
            else
               if (String.IsNullOrEmpty(pmcVM.Clasa))
            {
                pmcContext.ErrorMessage = "Clasa trebuie precizat";
            }
            else
               if (String.IsNullOrEmpty(pmcVM.Materie))
            {
                pmcContext.ErrorMessage = "Materie trebuie precizat";
            }
            else
            {
                var idProfesor = context.Profesori.Where(i => i.nume == pmcVM.NumeP && i.prenume == pmcVM.PrenumeP);
                var idMaterie = context.Materii.Where(i => i.denumire == pmcVM.Materie).ToList();
                var idClasa = context.Clase.Where(i => i.denumire == pmcVM.Clasa).ToList();

                if (idProfesor.Count() == 0 || idMaterie.Count() == 0 || idClasa.Count() == 0)
                    pmcContext.ErrorMessage = "Profesorul, materia sau clasa nu exista!";
                else
                {
                    context.ModificarePMC(pmcVM.PMCId, idProfesor.ElementAt(0).id, idMaterie.ElementAt(0).id, idClasa.ElementAt(0).id, pmcVM.Teza);
                    context.SaveChanges();
                    pmcContext.ErrorMessage = " ";
                }
            }
        }

        public void DeleteMethod(object obj)
        {
            EditarePMCVM pmcVM = obj as EditarePMCVM;
            if (pmcVM == null)
            {
                pmcContext.ErrorMessage = "Selecteaza un cuplaj";
            }
            if (String.IsNullOrEmpty(pmcVM.NumeP))
            {
                pmcContext.ErrorMessage = "Numele profesorului trebuie precizat";
            }
            else
               if (String.IsNullOrEmpty(pmcVM.PrenumeP))
            {
                pmcContext.ErrorMessage = "Prenumele profesorului trebuie precizat";
            }
            else
               if (String.IsNullOrEmpty(pmcVM.Clasa))
            {
                pmcContext.ErrorMessage = "Clasa trebuie precizat";
            }
            else
               if (String.IsNullOrEmpty(pmcVM.Materie))
            {
                pmcContext.ErrorMessage = "Materie trebuie precizat";
            }
            else
            {


                context.StergerePMC(pmcVM.PMCId);
                context.SaveChanges();
                pmcContext.PMCList = ToateCuplajele();
                pmcContext.ErrorMessage = "";

            }
        }
    }
}