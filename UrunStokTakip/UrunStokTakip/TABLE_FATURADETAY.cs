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
    
    public partial class TABLE_FATURADETAY
    {
        public int ID { get; set; }
        public string URUN { get; set; }
        public Nullable<int> ADET { get; set; }
        public Nullable<decimal> FIYAT { get; set; }
        public Nullable<decimal> TUTAR { get; set; }
        public Nullable<int> FATURAID { get; set; }
    
        public virtual TABLE_FATURABILGI TABLE_FATURABILGI { get; set; }
    }
}
