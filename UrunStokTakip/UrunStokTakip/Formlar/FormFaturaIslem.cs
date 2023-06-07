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
    public partial class FormFaturaIslem : Form
    {
        private DbStokTakipEntities5 db;
        public FormFaturaIslem()
        {
            InitializeComponent();
            db = DbContextFactory.GetDbContext();
        }

        private void FormFaturaListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void buttonListele_Click(object sender, EventArgs e)
        {
            Listele();

        }

        // Fatura kaydetme
        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            TABLE_FATURABILGI t = new TABLE_FATURABILGI();
            
            t.SERI = textSeri.Text;
            t.SIRANO = textSiraNo.Text;
            t.TARIH = Convert.ToDateTime(textTarih.Text);
            t.SAAT = textSaat.Text;
            t.VERGIDAIRE = textVergiDairesi.Text;
            t.MUSTERI = int.Parse(lookUpMusteri.EditValue.ToString());
            t.SORUMLU = int.Parse(lookUpSorumlu.EditValue.ToString());
            db.TABLE_FATURABILGI.Add(t);
            db.SaveChanges();
            Listele();
            MessageBox.Show("Fatura sisteme kaydedilmistir, kalem girisi yapabilirsiniz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Verilerin çekilmesi ve listelenmesi
        private void Listele()
        {
            var degerler = from u in db.TABLE_FATURABILGI
                           select new
                           {
                               u.ID,
                               u.SERI,
                               u.SIRANO,
                               u.TARIH,
                               u.SAAT,
                               u.VERGIDAIRE,
                               MUSTERI = u.TABLE_MUSTERI.MUSTERI_AD + " " + u.TABLE_MUSTERI.MUSTERI_SOYAD,
                               SORUMLU = u.TABLE_SORUMLU.SORUMLU_AD + " " + u.TABLE_SORUMLU.SORUMLU_SOYAD

                           };

            gridControl1.DataSource = degerler.ToList();

            // Sorumlu veri kaynağını alma
            lookUpSorumlu.Properties.DataSource = (from x in db.TABLE_SORUMLU
                                                   select new
                                                   {
                                                       x.ID,
                                                       AD = x.SORUMLU_AD + " " + x.SORUMLU_SOYAD
                                                   }).ToList();

            // Musteri veri kaynağını alma
            lookUpMusteri.Properties.DataSource = (from x in db.TABLE_MUSTERI
                                                   select new
                                                   {
                                                       x.ID,
                                                       AD = x.MUSTERI_AD + " " + x.MUSTERI_SOYAD
                                                   }).ToList();

        }


        
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FormFaturaPopUp  fr = new FormFaturaPopUp();
            fr.id  = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            fr.Show();
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            //textID.Text = "";
            textSeri.Text = "";
            textSiraNo.Text = "";
            textTarih.Text = "";
            textSaat.Text = "";
            textVergiDairesi.Text = "";
            lookUpMusteri.Text = "";
            lookUpSorumlu.Text = "";
        }

        // Fatura silme işlemi
        private void buttonSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textID.Text);
            var kayit = db.TABLE_FATURABILGI.Find(id);
            db.TABLE_FATURABILGI.Remove(kayit);
            db.SaveChanges();
            Listele();
            MessageBox.Show("Fatura başarı ile silindi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        } 
    }
}
