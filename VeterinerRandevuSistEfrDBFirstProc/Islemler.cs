//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VeterinerRandevuSistEfrDBFirstProc
{
    using System;
    using System.Collections.Generic;
    
    public partial class Islemler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Islemler()
        {
            this.Randevulars = new HashSet<Randevular>();
        }
    
        public int islemNo { get; set; }
        public string islemAd { get; set; }
        public Nullable<decimal> islemUcret { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Randevular> Randevulars { get; set; }
    }
}
