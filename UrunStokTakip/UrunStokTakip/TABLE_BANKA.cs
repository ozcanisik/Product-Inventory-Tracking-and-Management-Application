//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UrunStokTakip
{
    using System;
    using System.Collections.Generic;
    
    public partial class TABLE_BANKA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TABLE_BANKA()
        {
            this.TABLE_MUSTERI = new HashSet<TABLE_MUSTERI>();
        }
    
        public int ID { get; set; }
        public string BANKA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TABLE_MUSTERI> TABLE_MUSTERI { get; set; }
    }
}