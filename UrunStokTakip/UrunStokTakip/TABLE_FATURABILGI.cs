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
    
    public partial class TABLE_FATURABILGI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TABLE_FATURABILGI()
        {
            this.TABLE_FATURADETAY = new HashSet<TABLE_FATURADETAY>();
        }
    
        public int ID { get; set; }
        public string SERI { get; set; }
        public string SIRANO { get; set; }
        public Nullable<System.DateTime> TARIH { get; set; }
        public string SAAT { get; set; }
        public string VERGIDAIRE { get; set; }
        public Nullable<int> MUSTERI { get; set; }
        public Nullable<int> SORUMLU { get; set; }
    
        public virtual TABLE_MUSTERI TABLE_MUSTERI { get; set; }
        public virtual TABLE_SORUMLU TABLE_SORUMLU { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TABLE_FATURADETAY> TABLE_FATURADETAY { get; set; }
    }
}
