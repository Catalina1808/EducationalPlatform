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
    
    public partial class Profesor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Profesor()
        {
            this.Clasas = new HashSet<Clasa>();
            this.Profesor_Materie_Clasa = new HashSet<Profesor_Materie_Clasa>();
        }
    
        public int id { get; set; }
        public string nume { get; set; }
        public string prenume { get; set; }
        public int id_login { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Clasa> Clasas { get; set; }
        public virtual Login Login { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Profesor_Materie_Clasa> Profesor_Materie_Clasa { get; set; }
    }
}