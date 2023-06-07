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
    public partial class FormUrunSatis : Form
    {
        private DbStokTakipEntities5 db;
        public FormUrunSatis()
        {
            InitializeComponent();
            db = DbContextFactory.GetDbContext();
        }

        // Satış işlemi
        private void BtnSatisYap_Click(object sender, EventArgs e)
        {
            TABLE_URUNHAREKET t = new TABLE_URUNHAREKET();
            t.URUN = int.Parse(lookUpEdit_Urun.EditValue.ToString());
            t.MUSTERI = int.Parse(lookUpEdit_Musteri.EditValue.ToString());
            t.SORUMLU = int.Parse(lookUpEdit_Sorumlu.EditValue.ToString());
            t.TARIH =DateTime.Parse(TxtTarih.Text);
            t.ADET = int.Parse(TxtAdet.Text);
            t.FIYAT = decimal.Parse(TxtSatisFiyat.Text);
            t.SERINO = TxtSeriNo.Text;
            db.TABLE_URUNHAREKET.Add(t);
            db.SaveChanges();
            MessageBox.Show("Urun satisi yapildi","Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        // Verilerin çekilmesi ve listelenmesi
        private void FormUrunSatis_Load(object sender, EventArgs e)
        {
            lookUpEdit_Urun.Properties.DataSource = (from x in db.TABLE_URUN
                                                     select new
                                                     {
                                                         x.ID,
                                                         x.URUN_MODEL
                                                     }).ToList();

            lookUpEdit_Musteri.Properties.DataSource = (from x in db.TABLE_MUSTERI
                                                     select new
                                                     {
                                                         x.ID,
                                                         AD = x.MUSTERI_AD + " " + x.MUSTERI_SOYAD  
                                                     }).ToList();

            lookUpEdit_Sorumlu.Properties.DataSource = (from x in db.TABLE_SORUMLU
                                                     select new
                                                     {
                                                         x.ID,
                                                         AD = x.SORUMLU_AD + " " + x.SORUMLU_SOYAD
                                                     }).ToList();
        }

        // Vazgeçme butonu
        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
