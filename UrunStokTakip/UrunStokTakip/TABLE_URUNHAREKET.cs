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
    
    public partial class TABLE_URUNHAREKET
    {
        public int ID { get; set; }
        public Nullable<int> URUN { get; set; }
        public Nullable<int> MUSTERI { get; set; }
        public Nullable<int> SORUMLU { get; set; }
        public Nullable<System.DateTime> TARIH { get; set; }
        public Nullable<int> ADET { get; set; }
        public Nullable<decimal> FIYAT { get; set; }
        public string SERINO { get; set; }
    
        public virtual TABLE_MUSTERI TABLE_MUSTERI { get; set; }
        public virtual TABLE_SORUMLU TABLE_SORUMLU { get; set; }
        public virtual TABLE_URUN TABLE_URUN { get; set; }
    }
}
