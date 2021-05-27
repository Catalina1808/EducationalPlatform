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
    class AbsentaActions : BaseVM
    {
        CatalogEntities context = new CatalogEntities();
        private AbsentaVM absentaContext;
        private AbsentaDirigVM absentaContext2;
        private AbsentaElevVM absentaContext3;

        public AbsentaActions(AbsentaVM absentaVM)
        {
            this.absentaContext = absentaVM;
        }
        public AbsentaActions(AbsentaDirigVM absentaVM)
        {
            this.absentaContext2 = absentaVM;
        }
        public AbsentaActions(AbsentaElevVM absentaVM)
        {
            this.absentaContext3 = absentaVM;
        }

        public void AddMethodProf(object obj)
        {
            AbsentaVM absentaVM = obj as AbsentaVM;
            if (absentaVM != null)
            {
                if (String.IsNullOrEmpty(absentaVM.ElevN))
                {
                    absentaContext.ErrorMessage = "Numele elevului trebuie precizat";
                }
                else
                if (String.IsNullOrEmpty(absentaVM.ElevP))
                {
                    absentaContext.ErrorMessage = "Prenumele elevului trebuie precizat";
                }
                else
                if (String.IsNullOrEmpty(absentaVM.Materie))
                {
                    absentaContext.ErrorMessage = "Materia trebuie precizata";
                }
                else
                if (absentaVM.Semestru != 1 && absentaVM.Semestru != 2)
                {
                    absentaContext.ErrorMessage = "Semestrul introdus nu este acceptat";
                }
                else
                {
                    var idElev = context.Elevi.Where(i => i.nume == absentaVM.ElevN && i.prenume == absentaVM.ElevP).ToList();
                    var idMaterie = context.Materii.Where(i => i.denumire == absentaVM.Materie).ToList();

                    var id = context.Profesori.Where(i => i.id_login == ProfesorVM.IdLogin).ToList().ElementAt(0).id;

                    if (idElev.Count() == 0 || idMaterie.Count() == 0)
                        absentaContext.ErrorMessage = "Elevul sau materia nu exista!";
                    else
                    {
                        int idElev2 = idElev.ElementAt(0).id;
                        int idMaterie2 = idMaterie.ElementAt(0).id;
                        var materii = context.MateriiElev(idElev2).ToList();
                        if (!materii.Contains(absentaVM.Materie))
                        {
                            absentaContext.ErrorMessage = "Elevul nu face materia respectiva!";
                        }
                        else
                        {
                            var materieProf = context.Profesori_Materii_Clase.Where(i => i.id_profesor == id && i.id_materie == idMaterie2);
                            if (materieProf.Count() == 0)
                                absentaContext.ErrorMessage = "Nu puteti pune absente la aceasta materie pentru ca nu o predati!";
                            else
                            {
                                context.InserareinAbsenta(idElev2, idMaterie2, absentaVM.Data, absentaVM.Motivata, absentaVM.Motivabila, absentaVM.Semestru);
                                context.SaveChanges();
                                absentaContext.AbsenteListProf = ToateAbsenteleProf();
                                absentaContext.ErrorMessage = "";
                            }
                        }

                    }

                }

            }
        }


        public ObservableCollection<AbsentaVM> ToateAbsenteleProf()
        {
            var id = context.Profesori.Where(i => i.id_login == ProfesorVM.IdLogin).ToList();
            var absente = context.AbsenteProfesor(id.ElementAt(0).id).ToList();
            ObservableCollection<AbsentaVM> result = new ObservableCollection<AbsentaVM>();
            foreach (var absenta in absente)
            {

                AbsentaVM absentaVM=new AbsentaVM()
                {
                    IdAbsenta = absenta.id,
                    Data = absenta.data,
                    ElevN = context.Elevi.Where(i => i.id == absenta.id_elev).FirstOrDefault().nume,
                    ElevP = context.Elevi.Where(i => i.id == absenta.id_elev).FirstOrDefault().prenume,
                    Materie = context.Materii.Where(i => i.id == absenta.id_materie).FirstOrDefault().denumire,
                    Motivata = absenta.motivata,
                    Motivabila = absenta.motivabila,
                    Semestru = absenta.semestru
                };
                if (result.Any(p => p.IdAbsenta == absentaVM.IdAbsenta && p.Materie == absentaVM.Materie && p.ElevN == absentaVM.ElevN && p.ElevP == absentaVM.ElevP && p.Data == absentaVM.Data && p.Semestru == absentaVM.Semestru && p.Motivata == absentaVM.Motivata && p.Motivabila == absentaVM.Motivabila) == false)
                {
                    result.Add(absentaVM);
                }
            }
            return result;
        }

        public ObservableCollection<AbsentaDirigVM> ToateAbsenteleDirig()
        {
            var id = context.Profesori.Where(i => i.id_login == DiriginteVM.IdLoginDirig).ToList();
            var absente = context.AbsenteDiriginte(id.ElementAt(0).id).ToList();
            ObservableCollection<AbsentaDirigVM> result = new ObservableCollection<AbsentaDirigVM>();
            foreach (var absenta in absente)
            {

                result.Add(new AbsentaDirigVM()
                {
                    IdAbsenta = absenta.id,
                    Data = absenta.data,
                    ElevN = context.Elevi.Where(i => i.id == absenta.id_elev).FirstOrDefault().nume,
                    ElevP = context.Elevi.Where(i => i.id == absenta.id_elev).FirstOrDefault().prenume,
                    Materie = context.Materii.Where(i => i.id == absenta.id_materie).FirstOrDefault().denumire,
                    Motivata = absenta.motivata,
                    Motivabila = absenta.motivabila,
                    Semestru = absenta.semestru
                });
            }
            return result;
        }

        public ObservableCollection<AbsentaDirigVM> ToateAbsenteleElev(int idElev)
        {
            ObservableCollection<AbsentaDirigVM> result = new ObservableCollection<AbsentaDirigVM>();
            var id = context.Profesori.Where(i => i.id_login == DiriginteVM.IdLoginDirig).ToList();
            var absente = context.AbsenteDiriginte(id.ElementAt(0).id).Where(i => i.id_elev == idElev).ToList();
            if (absente.Count() == 0)
                absentaContext3.errorMessage = "Elevul nu este in clasa la care sunteti diriginte sau nu are absente!";
            else
            {

                foreach (var absenta in absente)
                {

                    result.Add(new AbsentaDirigVM()
                    {
                        IdAbsenta = absenta.id,
                        Data = absenta.data,
                        ElevN = context.Elevi.Where(i => i.id == absenta.id_elev).FirstOrDefault().nume,
                        ElevP = context.Elevi.Where(i => i.id == absenta.id_elev).FirstOrDefault().prenume,
                        Materie = context.Materii.Where(i => i.id == absenta.id_materie).FirstOrDefault().denumire,
                        Motivata = absenta.motivata,
                        Motivabila = absenta.motivabila,
                        Semestru = absenta.semestru
                    });
                }

            }

            return result;
        }

        public int NrTAbs()
        {
            var id = context.Profesori.Where(i => i.id_login == DiriginteVM.IdLoginDirig).ToList();
            var absente = context.AbsenteDiriginte(id.ElementAt(0).id).ToList();
            return absente.Count();
        }

        public int NrNAbs()
        {
            var id = context.Profesori.Where(i => i.id_login == DiriginteVM.IdLoginDirig).ToList();
            var absente = context.AbsenteDiriginte(id.ElementAt(0).id).Where(i => i.motivata == false).ToList();
            return absente.Count();
        }

        public int NrTAbsE(int idElev)
        {
            var id = context.Profesori.Where(i => i.id_login == DiriginteVM.IdLoginDirig).ToList();
            var absente = context.AbsenteDiriginte(id.ElementAt(0).id).Where(i => i.id_elev == idElev).ToList();
            return absente.Count();
        }

        public int NrNAbsE(int idElev)
        {
            var id = context.Profesori.Where(i => i.id_login == DiriginteVM.IdLoginDirig).ToList();
            var absente = context.AbsenteDiriginte(id.ElementAt(0).id).Where(i => i.motivata == false && i.id_elev==idElev).ToList();
            return absente.Count();
        }

        public void Motivare(object obj)
        {
            AbsentaVM absentaVM = obj as AbsentaVM;
            if (absentaVM == null)
            {
                absentaContext.ErrorMessage = "Selecteaza o absenta";
            }
            if (String.IsNullOrEmpty(absentaVM.ElevN))
            {
                absentaContext.ErrorMessage = "Numele elevului trebuie precizat";
            }
            else
                if (String.IsNullOrEmpty(absentaVM.ElevP))
            {
                absentaContext.ErrorMessage = "Prenumele elevului trebuie precizat";
            }
            else
                if (String.IsNullOrEmpty(absentaVM.Materie))
            {
                absentaContext.ErrorMessage = "Materia trebuie precizata";
            }
            else
                if (absentaVM.Semestru != 1 && absentaVM.Semestru != 2)
            {
                absentaContext.ErrorMessage = "Semestrul introdus nu este acceptat";
            }
            else
            if (absentaVM.Motivabila == false)
            {
                absentaContext.ErrorMessage = "Absenta nu este motivabila!";
            }
            else
            {
                context.MotivareAbsenta(absentaVM.IdAbsenta, true);
                context.SaveChanges();
                absentaContext.ErrorMessage = " ";

            }
        }

        public void MotivareDirig(object obj)
        {
            AbsentaDirigVM absentaVM = obj as AbsentaDirigVM;
            if (absentaVM == null)
            {
                absentaContext2.ErrorMessage = "Selecteaza o absenta";
            }
            if (String.IsNullOrEmpty(absentaVM.ElevN))
            {
                absentaContext2.ErrorMessage = "Numele elevului trebuie precizat";
            }
            else
                if (String.IsNullOrEmpty(absentaVM.ElevP))
            {
                absentaContext2.ErrorMessage = "Prenumele elevului trebuie precizat";
            }
            else
                if (String.IsNullOrEmpty(absentaVM.Materie))
            {
                absentaContext2.ErrorMessage = "Materia trebuie precizata";
            }
            else
                if (absentaVM.Semestru != 1 && absentaVM.Semestru != 2)
            {
                absentaContext2.ErrorMessage = "Semestrul introdus nu este acceptat";
            }
            else
            if (absentaVM.Motivabila == false)
            {
                absentaContext2.ErrorMessage = "Absenta nu este motivabila!";
            }
            else
            {
                context.MotivareAbsenta(absentaVM.IdAbsenta, true);
                context.SaveChanges();
                absentaContext2.ErrorMessage = " ";

            }
        }

        public void UpdateAbsElev(object obj)
        {
            AbsentaElevVM absentaVM = obj as AbsentaElevVM;

            if (String.IsNullOrEmpty(absentaVM.ElevN))
            {
                absentaContext3.ErrorMessage = "Numele elevului trebuie precizat";
            }
            else
                if (String.IsNullOrEmpty(absentaVM.ElevP))
            {
                absentaContext3.ErrorMessage = "Prenumele elevului trebuie precizat";
            }

            else
            {
                var idElev1 = context.Elevi.Where(i => i.nume == absentaVM.ElevN && i.prenume == absentaVM.ElevP).ToList();
                if (idElev1.Count() == 0)
                    absentaContext3.errorMessage = "Nu exista elevul respectiv!";
                else
                { int idElev = idElev1.ElementAt(0).id;
                    absentaContext3.AbsenteListElev = ToateAbsenteleElev(idElev);
                    absentaContext3.NrN = NrNAbsE(idElev);
                    absentaContext3.NrT = NrTAbsE(idElev);
                    absentaContext3.ErrorMessage = " ";
                }

            }
        }

    }
}