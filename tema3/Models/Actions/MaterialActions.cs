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
    class MaterialActions : BaseVM
    {
        CatalogEntities context = new CatalogEntities();
        private MaterialVM materialContext;
        private MaterialElevVM materialContext2;

        public MaterialActions(MaterialVM materialVM)
        {
            this.materialContext = materialVM;
        }

        public MaterialActions(MaterialElevVM materialVM)
        {
            this.materialContext2 = materialVM;
        }

        public void AddMethod(object obj)
        {
            MaterialVM materialVM = obj as MaterialVM;
            if (materialVM != null)
            {
                if (String.IsNullOrEmpty(materialVM.Path))
                {
                    materialContext.ErrorMessage = "Calea trebuie precizata";
                }
                else
                if (String.IsNullOrEmpty(materialVM.Clasa))
                {
                    materialContext.ErrorMessage = "Clasa trebuie precizata";
                }
                else
                if (String.IsNullOrEmpty(materialVM.Materie))
                {
                    materialContext.ErrorMessage = "Materia trebuie precizata";
                }
                else
                {
                    var idClasa = context.Clase.Where(i => i.denumire == materialVM.Clasa).ToList();
                    var idMaterie = context.Materii.Where(i => i.denumire == materialVM.Materie).ToList();

                    var id = context.Profesori.Where(i => i.id_login == ProfesorVM.IdLogin).ToList().ElementAt(0).id;

                    if (idClasa.Count() == 0 || idMaterie.Count() == 0)
                        materialContext.ErrorMessage = "Clasa sau materia nu exista!";
                    else
                    {
                     
                        var idClasa2 = idClasa.ElementAt(0).id;
                        var idMaterie2 = idMaterie.ElementAt(0).id;
                            var pmc = context.Profesori_Materii_Clase.Where(i => i.id_clasa == idClasa2 && i.id_materie == idMaterie2 && i.id_profesor == id);

                            if (pmc.Count() == 0)
                                materialContext.ErrorMessage = "Nu puteti incarca materiale la aceasta materie pentru ca nu o predati!";
                            else
                            {
                                context.Materiale_Didactice.Add(new Material_Didactic() { id_materie=idMaterie2, id_clasa=idClasa2, path=materialVM.Path});
                                context.SaveChanges();
                                materialContext.MaterialList = ToateMaterialele();
                                materialContext.ErrorMessage = "";
                            }
                        

                    }

                }

            }
        }


        public ObservableCollection<MaterialVM> ToateMaterialele()
        {
            var id = context.Profesori.Where(i => i.id_login == ProfesorVM.IdLogin).ToList();
            var materiale = context.MaterialProfesor(id.ElementAt(0).id).ToList();
            ObservableCollection<MaterialVM> result = new ObservableCollection<MaterialVM>();
            foreach (var material in materiale)
            {

                result.Add(new MaterialVM()
                {
                    IdMaterial = material.id,
                    Materie = context.Materii.Where(i => i.id == material.id_materie).FirstOrDefault().denumire,
                    Path = material.path,
                    Clasa = context.Clase.Where(i => i.id == material.id_clasa).FirstOrDefault().denumire
                });
            }
            return result;
        }

        public int IdElev()
        {
            var id = context.Elevi.Where(i => i.id_login == ElevVM.IdLoginElev).ToList();
            if (id.Count() != 0)
                return id.ElementAt(0).id;
            else
                return -1;
        }

        public ObservableCollection<MaterialVM> ToateMaterialeleElev(int idMaterie)
        {
            var id = IdElev();
            var materiale = context.MaterialElev(id).Where(i => i.id_materie==idMaterie).ToList();
            ObservableCollection<MaterialVM> result = new ObservableCollection<MaterialVM>();
            foreach (var material in materiale)
            {

                result.Add(new MaterialVM()
                {
                    IdMaterial = material.id,
                    Materie = context.Materii.Where(i => i.id == material.id_materie).FirstOrDefault().denumire,
                    Path = material.path,
                    Clasa = context.Clase.Where(i => i.id == material.id_clasa).FirstOrDefault().denumire
                });
            }
            return result;
        }

        public void Update(object obj)
        {
            MaterialElevVM materialVM = obj as MaterialElevVM;

            if (String.IsNullOrEmpty(materialVM.Materie))
            {
                materialContext2.ErrorMessage = "Materia trebuie precizata";
            }
            else
            {
                var materie1 = context.Materii.Where(i => i.denumire == materialVM.Materie).ToList();
                if (materie1.Count() == 0)
                    materialContext.ErrorMessage = "Nu exista materia respectiva!";
                else
                {
                    int idMaterie = materie1.ElementAt(0).id;
                    materialContext2.MaterialList = ToateMaterialeleElev(idMaterie);
                    materialContext2.ErrorMessage = " ";
                }

            }
        }



    }
}