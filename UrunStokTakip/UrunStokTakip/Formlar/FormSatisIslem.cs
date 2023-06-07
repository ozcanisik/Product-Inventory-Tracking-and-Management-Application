using DevExpress.XtraRichEdit.Export.Doc;
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
    public partial class FormSatisIslem : Form
    {
        private DbStokTakipEntities5 db;
        public FormSatisIslem()
        {
            InitializeComponent();
            db = DbContextFactory.GetDbContext();
        }

        private void FormSatisIslem_Load(object sender, EventArgs e)
        {
            Listele();
        }

        // Verilerin çekilmesi ve listeleme işlemi
        private void Listele()
        {
            var degerler = from x in db.TABLE_URUNHAREKET
                           select new
                           {
                               x.ID,
                               x.TABLE_URUN.URUN_MODEL,
                               MUSTERI = x.TABLE_MUSTERI.MUSTERI_AD + " " + x.TABLE_MUSTERI.MUSTERI_SOYAD,
                               SORUMLU = x.TABLE_SORUMLU.SORUMLU_AD + " " + x.TABLE_SORUMLU.SORUMLU_SOYAD,
                               x.TARIH,
                               x.ADET,
                               x.FIYAT,
                               x.SERINO

                           };
            gridControl1.DataSource = degerler.ToList();

            // Urun veri kaynağını alma
            lookUpUrun.Properties.DataSource = (from x in db.TABLE_URUN
                                                    select new
                                                    {
                                                        x.ID,
                                                        x.URUN_MODEL
                                                    }).ToList();

            // Musteri veri kaynağını alma
            lookUpMusteri.Properties.DataSource = (from x in db.TABLE_MUSTERI
                                                 select new
                                                 {
                                                     x.ID,
                                                     AD = x.MUSTERI_AD + " " + x.MUSTERI_SOYAD
                                                 }).ToList();

            // Sorumlu veri kaynağını alma
            lookUpSorumlu.Properties.DataSource = (from x in db.TABLE_SORUMLU
                                                 select new
                                                 {
                                                     x.ID,
                                                     AD = x.SORUMLU_AD + " " + x.SORUMLU_SOYAD
                                                 }).ToList();
        }

        // Ürün satış işlemi
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TABLE_URUNHAREKET t = new TABLE_URUNHAREKET();
            
            t.URUN = int.Parse(lookUpUrun.EditValue.ToString());         
            t.MUSTERI = int.Parse(lookUpMusteri.EditValue.ToString());
            t.SORUMLU = int.Parse(lookUpSorumlu.EditValue.ToString());
            t.TARIH = Convert.ToDateTime(textTarih.Text);
            t.ADET = int.Parse(textAdet.Text);
            t.FIYAT = decimal.Parse(textSatisFiyat.Text);
            t.SERINO = textSeriNo.Text;
            db.TABLE_URUNHAREKET.Add(t);
            db.SaveChanges();
            MessageBox.Show("Urun satisi yapildi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        // Listeleme işlemi
        private void BtnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        // Texteditlerin temizlenmesi
        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            textID.Text = "";
            lookUpUrun.EditValue = "";
            lookUpMusteri.EditValue = "";
            lookUpSorumlu.EditValue = "";
            textTarih.Text = "";
            textAdet.Text = "";
            textSatisFiyat.Text = "";
            textSeriNo.Text = "";

        }

        // Satışların silinmesi
        private void buttonSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textID.Text);
            var kayit = db.TABLE_URUNHAREKET.Find(id);
            db.TABLE_URUNHAREKET.Remove(kayit);
            db.SaveChanges();
            Listele();
            MessageBox.Show("Satış başarı ile silindi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Veri listesindeki herhangi bir yere tıklandığında sağ taraftaki texteditlere ilgili sütunların verisinin çekilmesi
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

            if (view != null)
            {
                var textEditColumnPairs = new List<KeyValuePair<DevExpress.XtraEditors.TextEdit, string>>
            {
            new KeyValuePair<DevExpress.XtraEditors.TextEdit, string>(textID, "ID"),
            new KeyValuePair<DevExpress.XtraEditors.TextEdit, string>(textTarih, "TARIH"),
            new KeyValuePair<DevExpress.XtraEditors.TextEdit, string>(textAdet, "ADET"),
            new KeyValuePair<DevExpress.XtraEditors.TextEdit, string>(textSatisFiyat, "FIYAT"),
            new KeyValuePair<DevExpress.XtraEditors.TextEdit, string>(textSeriNo, "SERINO"),
            };

                UpdateTextEditValues(view, textEditColumnPairs);

                var lookUpEditColumnPairs = new List<KeyValuePair<DevExpress.XtraEditors.LookUpEdit, string>>
            {
            new KeyValuePair<DevExpress.XtraEditors.LookUpEdit, string>(lookUpUrun, "URUN_MODEL"),
            new KeyValuePair<DevExpress.XtraEditors.LookUpEdit, string>(lookUpMusteri, "MUSTERI"),
            new KeyValuePair<DevExpress.XtraEditors.LookUpEdit, string>(lookUpSorumlu, "SORUMLU")
            };

                UpdateLookUpEditValues(view, lookUpEditColumnPairs);
            }
        }

        // Textedit(textbox) için null olup olmadığını kontrol ederek tıklandığında verileri çekme
        private void UpdateTextEditValues(DevExpress.XtraGrid.Views.Grid.GridView view, List<KeyValuePair<DevExpress.XtraEditors.TextEdit, string>> textEditColumnPairs)
        {
            foreach (var pair in textEditColumnPairs)
            {
                var value = view.GetFocusedRowCellValue(pair.Value);
                pair.Key.Text = value != null ? value.ToString() : "";
            }
        }

        // LookUpEdit(combobox) için null olup olmadığını kontrol ederek tıklandığında verileri çekme
        private void UpdateLookUpEditValues(DevExpress.XtraGrid.Views.Grid.GridView view, List<KeyValuePair<DevExpress.XtraEditors.LookUpEdit, string>> lookUpEditColumnPairs)
        {
            foreach (var pair in lookUpEditColumnPairs)
            {
                var value = view.GetFocusedRowCellValue(pair.Value);
                pair.Key.Text = value.ToString();
            }
        }

        // Satış kayıtlarının güncellenmesi
        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textID.Text);
            var kayit = db.TABLE_URUNHAREKET.Find(id);
            kayit.URUN = int.Parse(lookUpUrun.EditValue.ToString());
            kayit.MUSTERI = int.Parse(lookUpMusteri.EditValue.ToString());
            kayit.SORUMLU = int.Parse(lookUpSorumlu.EditValue.ToString());
            kayit.TARIH = Convert.ToDateTime(textTarih.Text);
            kayit.ADET = int.Parse(textAdet.Text);
            kayit.FIYAT = decimal.Parse(textSatisFiyat.Text);
            kayit.SERINO = textSeriNo.Text;

            db.SaveChanges();
            Listele();
            MessageBox.Show("Satış kaydı başarı ile güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
