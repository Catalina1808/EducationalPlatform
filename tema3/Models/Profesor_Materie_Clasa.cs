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
    
    public partial class Profesor_Materie_Clasa
    {
        public int id_profesor { get; set; }
        public int id_materie { get; set; }
        public int id_clasa { get; set; }
        public bool teza { get; set; }
        public int id { get; set; }
    
        public virtual Clasa Clasa { get; set; }
        public virtual Materie Materie { get; set; }
        public virtual Profesor Profesor { get; set; }
    }
}
