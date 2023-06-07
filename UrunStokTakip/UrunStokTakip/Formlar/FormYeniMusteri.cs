using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrunStokTakip.Formlar
{
    public partial class FormYeniMusteri : Form
    {
        private DbStokTakipEntities5 db;
        public FormYeniMusteri()
        {
            InitializeComponent();
            db = DbContextFactory.GetDbContext();
        }

        // Yeni müşteri ekleme işlemi
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TABLE_MUSTERI kayit = new TABLE_MUSTERI();

            kayit.MUSTERI_AD = textMusteriAd.Text;
            kayit.MUSTERI_SOYAD = textMusteriSoyad.Text;
            kayit.TELEFON = textTelefon.Text;
            kayit.MAIL = textMail.Text;
            kayit.SEHIR = int.Parse(lookUpSehir.EditValue.ToString()); 
            kayit.BANKA = int.Parse(lookUpBanka.EditValue.ToString()); 
            kayit.VERGI_DAIRESI = textVergiDaire.Text;
            kayit.VERGI_NO = textVergiNo.Text;
            kayit.ADRES = textAdres.Text;

            db.TABLE_MUSTERI.Add(kayit);
            db.SaveChanges();
            
            MessageBox.Show("Müşteri başarı ile kaydedildi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Vazgeç butonu
        private void BtnVazgeç_Click(object sender, EventArgs e)
        {
            FormYeniMusteri fr = new FormYeniMusteri();
            this.Close();
        }

        private void FormYeniMusteri_Load(object sender, EventArgs e)
        {
            DataLoad();
        }

        // LookupEdit' lere şehir ve banka verilerinin çekilmesi
        private void DataLoad()
        {
            lookUpSehir.Properties.DataSource = (from x in db.TABLE_SEHIR
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.SEHIR
                                                 }).ToList();
            lookUpBanka.Properties.DataSource = (from x in db.TABLE_BANKA
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.BANKA
                                                 }).ToList();
        }
    }
}
