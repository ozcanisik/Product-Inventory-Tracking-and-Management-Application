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
    public partial class FormFaturaDetay : Form
    {
        private DbStokTakipEntities5 db;
        public FormFaturaDetay()
        {
            InitializeComponent();
            db = DbContextFactory.GetDbContext();
        }

        private void FormFaturaDetay_Load(object sender, EventArgs e)
        {
            Listele();
        }

        // Verilerin çekilmesi ve listeleme işlevi
        private void Listele()
        {
            var degerler = from u in db.TABLE_FATURADETAY
                           select new
                           {
                               u.ID,
                               u.URUN,
                               u.ADET,
                               u.FIYAT,
                               u.TUTAR,
                               u.FATURAID
                           };

            gridControl1.DataSource = degerler.ToList();

            // Urun veri kaynağını alma
            //lookUpUrun.Properties.DataSource = (from x in db.TABLE_URUN
            //                                        select new
            //                                        {
            //                                            x.ID,
            //                                            x.URUN_MODEL
            //                                        }).ToList();
        }

        
        // Fatura kalem girişi işlemi
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TABLE_FATURADETAY t = new TABLE_FATURADETAY();
            t.URUN = textUrun.Text;
            t.ADET = int.Parse(textAdet.Text);
            t.FIYAT = decimal.Parse(textFiyat.Text);
            t.TUTAR = decimal.Parse(textTutar.Text);
            t.FATURAID = int.Parse(textFaturaId.Text);
            db.TABLE_FATURADETAY.Add(t);
            db.SaveChanges();
            MessageBox.Show("Faturaya ait kalem girişi başarıyla yapildi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Listeleme
        private void BtnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        // Silme fonksiyonu
        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textID.Text);
            var kayit = db.TABLE_FATURADETAY.Find(id);
            db.TABLE_FATURADETAY.Remove(kayit);
            db.SaveChanges();
            Listele();
            MessageBox.Show("Ürün başarı ile silindi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Texteditlerdeki verilerin temizlenmesi
        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            textID.Text = "";
            textUrun.Text = "";
            textAdet.Text = "";
            textFiyat.Text = "";
            textTutar.Text = "";
            textFaturaId.Text = "";
        }
    }
}
