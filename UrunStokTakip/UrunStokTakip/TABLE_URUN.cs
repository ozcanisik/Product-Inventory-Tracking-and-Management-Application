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
    
    public partial class TABLE_URUN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TABLE_URUN()
        {
            this.TABLE_URUNHAREKET = new HashSet<TABLE_URUNHAREKET>();
        }
    
        public int ID { get; set; }
        public string URUN_MODEL { get; set; }
        public Nullable<int> MARKA { get; set; }
        public Nullable<decimal> ALIS_FIYAT { get; set; }
        public Nullable<decimal> SATIS_FIYAT { get; set; }
        public Nullable<int> STOK { get; set; }
        public Nullable<int> KATEGORI { get; set; }
        public Nullable<bool> DURUM { get; set; }
        public Nullable<int> OZELLIK { get; set; }
    
        public virtual TABLE_KATEGORI TABLE_KATEGORI { get; set; }
        public virtual TABLE_MARKA TABLE_MARKA { get; set; }
        public virtual TABLE_OZELLIKLER TABLE_OZELLIKLER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TABLE_URUNHAREKET> TABLE_URUNHAREKET { get; set; }
    }
}
