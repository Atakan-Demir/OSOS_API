//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ososAPİ.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Secenek
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Secenek()
        {
            this.UyeCevap = new HashSet<UyeCevap>();
        }
    
        public int secenekId { get; set; }
        public string secenekText { get; set; }
        public int cevap { get; set; }
        public int secSoruId { get; set; }
    
        public virtual Soru Soru { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UyeCevap> UyeCevap { get; set; }
    }
}
