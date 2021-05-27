//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace tema3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Clasa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Clasa()
        {
            this.Elevs = new HashSet<Elev>();
            this.Material_Didactic = new HashSet<Material_Didactic>();
            this.Profesor_Materie_Clasa = new HashSet<Profesor_Materie_Clasa>();
        }
    
        public int id { get; set; }
        public string denumire { get; set; }
        public string specializare { get; set; }
        public int id_diriginte { get; set; }
    
        public virtual Profesor Profesor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Elev> Elevs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Material_Didactic> Material_Didactic { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Profesor_Materie_Clasa> Profesor_Materie_Clasa { get; set; }
    }
}
