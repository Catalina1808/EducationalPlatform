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
    class NotaActions : BaseVM
    {
        CatalogEntities context = new CatalogEntities();
        private NotaVM notaContext;

        public NotaActions(NotaVM notaVM)
        {
            this.notaContext = notaVM;
        }

        public void AddMethod(object obj)
        {
            NotaVM notaVM = obj as NotaVM;
            if (notaVM != null)
            {
                if (String.IsNullOrEmpty(notaVM.ElevN))
                {
                    notaContext.ErrorMessage = "Numele elevului trebuie precizat";
                }
                else
                if (String.IsNullOrEmpty(notaVM.ElevP))
                {
                    notaContext.ErrorMessage = "Prenumele elevului trebuie precizat";
                }
                else
                if (String.IsNullOrEmpty(notaVM.Materie))
                {
                    notaContext.ErrorMessage = "Materia trebuie precizata";
                }
                else
                if (notaVM.Semestru != 1 && notaVM.Semestru != 2)
                {
                    notaContext.ErrorMessage = "Semestrul trebuie precizat";
                }
                else
                if (notaVM.Nota <1 || notaVM.Nota>10)
                {
                    notaContext.ErrorMessage = "Nota introdusa nu este acceptata";
                }
                else
                {
                    var idElev = context.Elevi.Where(i => i.nume == notaVM.ElevN && i.prenume == notaVM.ElevP).ToList();
                    var idMaterie = context.Materii.Where(i => i.denumire == notaVM.Materie).ToList();

                    var id = context.Profesori.Where(i => i.id_login == ProfesorVM.IdLogin).ToList().ElementAt(0).id;

                    if (idElev.Count() == 0 || idMaterie.Count() == 0)
                        notaContext.ErrorMessage = "Elevul sau materia nu exista!";
                    else
                    {
                        var idElev2 = idElev.ElementAt(0).id;
                        var idMaterie2 = idMaterie.ElementAt(0).id;

                        var materii = context.MateriiElev(idElev2).ToList();
                        if (!materii.Contains(notaVM.Materie))
                        {
                            notaContext.ErrorMessage = "Elevul nu face materia respectiva!";
                        }
                        else
                        {

                            var materieProf = context.Profesori_Materii_Clase.Where(i => i.id_profesor == id && i.id_materie == idMaterie2);
                            if (materieProf.Count() == 0)
                                notaContext.ErrorMessage = "Nu puteti pune note la aceasta materie pentru ca nu o predati!";
                            else
                            {
                                context.InserareinNota(idElev2, idMaterie2, notaVM.Nota, notaVM.Teza, notaVM.Semestru);
                                context.SaveChanges();
                                notaContext.NoteListProf = ToateNoteleProf();
                                notaContext.ErrorMessage = "";
                            }
                        }

                    }

                }

            }
        }


        public ObservableCollection<NotaVM> ToateNoteleProf()
        {
            var id = context.Profesori.Where(i => i.id_login == ProfesorVM.IdLogin).ToList();
            var note = context.NoteProfesor(id.ElementAt(0).id).ToList();
            ObservableCollection<NotaVM> result = new ObservableCollection<NotaVM>();
            foreach (var nota in note)
            {

               NotaVM notaVM=new NotaVM()
                {
                    IdNota = nota.id,
                    Materie = context.Materii.Where(i => i.id == nota.id_materie).FirstOrDefault().denumire,
                    ElevN = context.Elevi.Where(i => i.id == nota.id_elev).FirstOrDefault().nume,
                    ElevP = context.Elevi.Where(i => i.id == nota.id_elev).FirstOrDefault().prenume,
                    Nota =(int) nota.nota,
                    Teza = nota.teza,
                    Semestru = nota.semestru
                };
                if (result.Any(p => p.IdNota == notaVM.IdNota && p.Materie == notaVM.Materie && p.ElevN == notaVM.ElevN && p.ElevP == notaVM.ElevP && p.Nota == notaVM.Nota && p.Semestru == notaVM.Semestru && p.Teza == notaVM.Teza) == false)
                {
                    result.Add(notaVM);
                }
            }
            return result;
        }

        public void DeleteMethod(object obj)
        {
            NotaVM notaVM = obj as NotaVM;
            if (notaVM == null)
            {
                notaContext.ErrorMessage = "Selecteaza o nota";
            }
            if (String.IsNullOrEmpty(notaVM.ElevN))
            {
                notaContext.ErrorMessage = "Numele elevului trebuie precizat";
            }
            else
               if (String.IsNullOrEmpty(notaVM.ElevP))
            {
                notaContext.ErrorMessage = "Prenumele elevului trebuie precizat";
            }
            else
               if (String.IsNullOrEmpty(notaVM.Materie))
            {
                notaContext.ErrorMessage = "Materia trebuie precizata";
            }
            else
               if (notaVM.Semestru != 1 && notaVM.Semestru != 2)
            {
                notaContext.ErrorMessage = "Semestrul trebuie precizat";
            }
            else
               if (notaVM.Nota < 1 || notaVM.Nota > 10)
            {
                notaContext.ErrorMessage = "Nota introdusa nu este acceptata";
            }
            else
            {
                var idElev = context.Elevi.Where(i => i.nume == notaVM.ElevN && i.prenume == notaVM.ElevP).ToList().ElementAt(0).id;
                var idMaterie = context.Materii.Where(i => i.denumire == notaVM.Materie).ToList().ElementAt(0).id;
                var medie = context.Medii.Where(i => i.id_elev == idElev && i.id_materie == idMaterie).ToList();
                if (medie.Count() != 0)
                    notaContext.ErrorMessage = "Media a fost calculata! Nu mai puteti modifica nota!";
                else
                {
                    context.StergereNota(notaVM.idNota);
                    context.SaveChanges();
                    notaContext.NoteListProf = ToateNoteleProf();
                    notaContext.ErrorMessage = " ";
                }

            }
        }


    }
}