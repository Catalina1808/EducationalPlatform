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
    class MedieActions : BaseVM
    {
        CatalogEntities context = new CatalogEntities();
        private MedieVM medieContext;
        private MedieElevVM medieContext2;
        private IerarhieVM medieContext3;

        public MedieActions(MedieVM notaVM)
        {
            this.medieContext = notaVM;
        }

        public MedieActions(MedieElevVM notaVM)
        {
            this.medieContext2 = notaVM;
        }

        public MedieActions(IerarhieVM notaVM)
        {
            this.medieContext3 = notaVM;
        }

        public void AddMethod(object obj)
        {
            MedieVM medieVM = obj as MedieVM;
            if (medieVM != null)
            {
                if (String.IsNullOrEmpty(medieVM.ElevN))
                {
                    medieContext.ErrorMessage = "Numele elevului trebuie precizat";
                }
                else
                if (String.IsNullOrEmpty(medieVM.ElevP))
                {
                    medieContext.ErrorMessage = "Prenumele elevului trebuie precizat";
                }
                else
                if (String.IsNullOrEmpty(medieVM.Materie))
                {
                    medieContext.ErrorMessage = "Materia trebuie precizata";
                }
                else
                if (medieVM.Semestru != 1 && medieVM.Semestru != 2)
                {
                    medieContext.ErrorMessage = "Semestrul trebuie precizat";
                }
                else
                {
                    var idElev = context.Elevi.Where(i => i.nume == medieVM.ElevN && i.prenume == medieVM.ElevP).ToList();
                    int idClasa = idElev.ElementAt(0).id_clasa;
                    var idMaterie = context.Materii.Where(i => i.denumire == medieVM.Materie).ToList();

                    var id = context.Profesori.Where(i => i.id_login == ProfesorVM.IdLogin).ToList().ElementAt(0).id;

                    if (idElev.Count() == 0 || idMaterie.Count() == 0)
                        medieContext.ErrorMessage = "Elevul sau materia nu exista!";
                    else
                    {
                        var idElev2 = idElev.ElementAt(0).id;
                        var idMaterie2 = idMaterie.ElementAt(0).id;

                        var materii = context.MateriiElev(idElev2).ToList();
                        if (!materii.Contains(medieVM.Materie))
                        {
                            medieContext.ErrorMessage = "Elevul nu face materia respectiva!";
                        }
                        else
                        {

                            var materieProf = context.Profesori_Materii_Clase.Where(i => i.id_profesor == id && i.id_materie == idMaterie2);
                            if (materieProf.Count() == 0)
                                medieContext.ErrorMessage = "Nu puteti pune note la aceasta materie pentru ca nu o predati!";
                            else
                            {
                                var note = context.NoteMedie(idElev2, idMaterie2).Where(i => i.semestru == medieVM.semestru).ToList();
                                int nrNote = note.Count();
                                if (nrNote < 3)
                                    medieContext.ErrorMessage = "Elevul trebuie sa aiba minim 3 note!";
                                else
                                {
                                    double m = 0;
                                    int teza = 0;
                                    for (int i = 0; i < nrNote; i++)
                                        if (note.ElementAt(i).teza)
                                            teza = note.ElementAt(i).nota;
                                        else
                                            m += note.ElementAt(i).nota;

                                    if (teza == 0 && context.Profesori_Materii_Clase.Where(i => i.id_profesor == id && i.id_materie == idMaterie2 && i.id_clasa == idClasa).ToList().ElementAt(0).teza)
                                        medieContext.ErrorMessage = "Elevul nu are nota la teza!";
                                    else
                                    {

                                        if (teza != 0)
                                        {
                                            m = m / (nrNote - 1);
                                            m = (m + teza) / 2;
                                        }
                                        else
                                        {
                                            m = m / nrNote;
                                        }

                                        int medie = (int)Math.Round(m);
                                        context.Medii.Add(new Medie() { id_elev = idElev2, id_materie = idMaterie2, medie1 = medie, semestru = medieVM.Semestru });
                                        context.SaveChanges();
                                        medieContext.MediiListProf = ToateMediileProf();
                                        medieContext.ErrorMessage = "";
                                        medieContext.Medie = medie;
                                    }
                                }
                            }
                        }

                    }

                }

            }
        }


        public ObservableCollection<MedieVM> ToateMediileProf()
        {
            var id = context.Profesori.Where(i => i.id_login == ProfesorVM.IdLogin).ToList();
            var medii = context.AfisareMediiProf(id.ElementAt(0).id).ToHashSet();
            ObservableCollection<MedieVM> result = new ObservableCollection<MedieVM>();

            foreach (var medie in medii)
            {
                MedieVM medieVM = new MedieVM()
                {
                    IdMedie = medie.id,
                    Materie = context.Materii.Where(i => i.id == medie.id_materie).FirstOrDefault().denumire,
                    ElevN = context.Elevi.Where(i => i.id == medie.id_elev).FirstOrDefault().nume,
                    ElevP = context.Elevi.Where(i => i.id == medie.id_elev).FirstOrDefault().prenume,
                    Medie = (int)medie.medie,
                    Semestru = medie.semestru
                };
                if (result.Any(p => p.IdMedie == medieVM.IdMedie && p.Materie==medieVM.Materie && p.ElevN==medieVM.ElevN && p.ElevP == medieVM.ElevP && p.Medie == medieVM.Medie && p.Semestru == medieVM.Semestru) == false)
                {
                    result.Add(medieVM);
                }
            }
            return result;
        }

        public ObservableCollection<MedieVM> ToateMediileElev(int idElev)
        {
            var id = context.Profesori.Where(i => i.id_login == DiriginteVM.IdLoginDirig).ToList();
            var medii = context.AfisareMediiDirig(id.ElementAt(0).id).Where(i => i.id_elev == idElev).ToList();
            ObservableCollection<MedieVM> result = new ObservableCollection<MedieVM>();
            if (medii.Count() == 0)
                medieContext2.errorMessage = "Elevul nu este in clasa la care sunteti diriginte sau nu are absente!";
            else
            {
                foreach (var medie in medii)
                {

                    result.Add(new MedieVM()
                    {
                        IdMedie = medie.id,
                        Materie = context.Materii.Where(i => i.id == medie.id_materie).FirstOrDefault().denumire,
                        ElevN = context.Elevi.Where(i => i.id == medie.id_elev).FirstOrDefault().nume,
                        ElevP = context.Elevi.Where(i => i.id == medie.id_elev).FirstOrDefault().prenume,
                        Medie = (int)medie.medie,
                        Semestru = medie.semestru
                    });
                }
            }
            return result;
        }


        public int MedieG(int idElev)
        {
            var id = context.Profesori.Where(i => i.id_login == DiriginteVM.IdLoginDirig).ToList();
            var medii = context.AfisareMediiDirig(id.ElementAt(0).id).Where(i => i.id_elev == idElev).ToList();
            float medieG = 0;
            int nrMedii = medii.Count();
            for (int i = 0; i < nrMedii; i++)
                medieG += medii.ElementAt(i).medie;
            medieG = medieG / nrMedii;
            return (int)medieG;
        }

        public void UpdateMediiElev(object obj)
        {
            MedieElevVM medieVM = obj as MedieElevVM;

            if (String.IsNullOrEmpty(medieVM.ElevN))
            {
                medieContext2.ErrorMessage = "Numele elevului trebuie precizat";
            }
            else
                if (String.IsNullOrEmpty(medieVM.ElevP))
            {
                medieContext2.ErrorMessage = "Prenumele elevului trebuie precizat";
            }

            else
            {
                var idElev1 = context.Elevi.Where(i => i.nume == medieVM.ElevN && i.prenume == medieVM.ElevP).ToList();
                if (idElev1.Count() == 0)
                    medieContext2.errorMessage = "Nu exista elevul respectiv!";
                else
                {
                    int idElev = idElev1.ElementAt(0).id;
                    medieContext2.MediiList = ToateMediileElev(idElev);
                    medieContext2.MedieG = MedieG(idElev);
                    medieContext2.ErrorMessage = " ";
                }

            }
        }

        public ObservableCollection<Tuple<string, int>> Ierarhie()
        {
            var id = context.Profesori.Where(i => i.id_login == DiriginteVM.IdLoginDirig).ToList();
            var elevi = context.AfisareEleviDirig(id.ElementAt(0).id).ToList();
            ObservableCollection<Tuple<string, int>> result = new ObservableCollection<Tuple<string, int>>();
            foreach (var elev in elevi)
            {
                if (MedieG(elev.id) > 10 || MedieG(elev.id) < 0)
                {
                    medieContext3.errorMessage = "Nu a fost calculata media pentru toti elevii!";
                    return result;
                }
                result.Add(new Tuple<string, int>(elev.nume + " " + elev.prenume, MedieG(elev.id)));
            }
            result = new ObservableCollection<Tuple<string, int>>(result.OrderByDescending(x => x.Item2).ToList());

            return result;
        }

        public ObservableCollection<Tuple<string, string>> Premianti()
        {
            ObservableCollection<Tuple<string, string>> result = new ObservableCollection<Tuple<string, string>>();
            ObservableCollection<Tuple<string, int>> ierarhie = Ierarhie();
            if (ierarhie.Count() >= 1)
            {
                result.Add(new Tuple<string, string>(ierarhie.ElementAt(0).Item1, "Premiul I"));
                if (ierarhie.Count() >= 2)
                {
                    result.Add(new Tuple<string, string>(ierarhie.ElementAt(1).Item1, "Premiul II"));
                    if (ierarhie.Count() >= 3)
                    {
                        result.Add(new Tuple<string, string>(ierarhie.ElementAt(2).Item1, "Premiul III"));
                        if (ierarhie.Count() >= 4)
                            result.Add(new Tuple<string, string>(ierarhie.ElementAt(3).Item1, "Mentiune"));
                    }
                }

            }

            return result;
        }

        public ObservableCollection<Tuple<string, string>> Corigenti()
        {
            ObservableCollection<Tuple<string, string>> result = new ObservableCollection<Tuple<string, string>>();
            var id = context.Profesori.Where(i => i.id_login == DiriginteVM.IdLoginDirig).ToList();
            var medii = context.AfisareMediiDirig(id.ElementAt(0).id).ToList();

            foreach (var medie in medii)
            {
                if (medie.medie < 5)
                {
                    Elev elev = context.Elevi.Where(i => i.id == medie.id_elev).FirstOrDefault();
                    Materie materie = context.Materii.Where(i => i.id == medie.id_materie).FirstOrDefault();
                    result.Add(new Tuple<string, string>(elev.nume + " " + elev.prenume, materie.denumire));
                }

            }

            return result;
        }

        public ObservableCollection<Tuple<string, int>> Repetenti()
        {
            ObservableCollection<Tuple<string, int>> result = new ObservableCollection<Tuple<string, int>>();
            ObservableCollection<Tuple<string, string>> corigenti = Corigenti();
            var id = context.Profesori.Where(i => i.id_login == DiriginteVM.IdLoginDirig).ToList();
            var elevi = context.AfisareEleviDirig(id.ElementAt(0).id).ToList();
            foreach (var elev in elevi)
            {
                int nrCorigente = corigenti.Count(i => i.Item1 == elev.nume + " " + elev.prenume);
                if (nrCorigente >= 3)
                    result.Add(new Tuple<string, int>(elev.nume + " " + elev.prenume, MedieG(elev.id)));
            }

            return result;
        }

        public ObservableCollection<Tuple<string, int>> Exmatriculati()
        {
            ObservableCollection<Tuple<string, int>> result = new ObservableCollection<Tuple<string, int>>();
            var id = context.Profesori.Where(i => i.id_login == DiriginteVM.IdLoginDirig).ToList();
            var elevi = context.AfisareEleviDirig(id.ElementAt(0).id).ToList();
            foreach (var elev in elevi)
            {
                var abs = context.Absente.Where(i => i.id_elev == elev.id).ToList();
                int nrAbs = abs.Count();
                if (nrAbs >= 10)
                    result.Add(new Tuple<string, int>(elev.nume + " " + elev.prenume, nrAbs));
            }

            return result;
        }


    }


}
