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
    public partial class FormMusteriIslem : Form
    {
        private DbStokTakipEntities5 db;
        public FormMusteriIslem()
        {
            InitializeComponent();
            db = DbContextFactory.GetDbContext();
        }

        private void FormMusteriIslem_Load(object sender, EventArgs e)
        {
            Listele();
        }

        // Verilerin çekilmesi ve listelenmesi
        private void Listele()
        {
            var liste_degerler = from x in db.TABLE_MUSTERI
                                 select new
                                 {
                                     x.ID,
                                     x.MUSTERI_AD,
                                     x.MUSTERI_SOYAD,
                                     x.TELEFON,
                                     x.MAIL,
                                     x.TABLE_SEHIR.SEHIR,
                                     x.TABLE_BANKA.BANKA,
                                     x.VERGI_DAIRESI,
                                     x.VERGI_NO,
                                     x.ADRES
                                 };
            gridControl1.DataSource = liste_degerler.ToList();

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

        // Müşteri ekleme işlemi
        private void buttonKaydet_Click(object sender, EventArgs e)
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
            Listele();
            MessageBox.Show("Müşteri başarı ile kaydedildi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Listeleme
        private void buttonListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        // Müşteri silme işlemi
        private void buttonSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textID.Text);
            var kayit = db.TABLE_MUSTERI.Find(id);
            db.TABLE_MUSTERI.Remove(kayit);
            db.SaveChanges();
            Listele();
            MessageBox.Show("Müşteri başarı ile silindi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Müşteri güncelleme işlemi
        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textID.Text);
            var kayit = db.TABLE_MUSTERI.Find(id);
            kayit.MUSTERI_AD = textMusteriAd.Text;
            kayit.MUSTERI_SOYAD = textMusteriSoyad.Text;
            kayit.TELEFON = textTelefon.Text;
            kayit.MAIL = textMail.Text;
            kayit.SEHIR = int.Parse(lookUpSehir.EditValue.ToString());
            kayit.BANKA = int.Parse(lookUpBanka.EditValue.ToString());
            kayit.VERGI_DAIRESI = textVergiDaire.Text;
            kayit.VERGI_NO = textVergiNo.Text;
            kayit.ADRES = textAdres.Text;

            db.SaveChanges();
            Listele();
            MessageBox.Show("Müşteri başarı ile güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            new KeyValuePair<DevExpress.XtraEditors.TextEdit, string>(textMusteriAd, "MUSTERI_AD"),
            new KeyValuePair<DevExpress.XtraEditors.TextEdit, string>(textMusteriSoyad, "MUSTERI_SOYAD"),
            new KeyValuePair<DevExpress.XtraEditors.TextEdit, string>(textTelefon, "TELEFON"),
            new KeyValuePair<DevExpress.XtraEditors.TextEdit, string>(textMail, "MAIL"),
            new KeyValuePair<DevExpress.XtraEditors.TextEdit, string>(textVergiDaire, "VERGI_DAIRESI"),
            new KeyValuePair<DevExpress.XtraEditors.TextEdit, string>(textVergiNo, "VERGI_NO"),
            new KeyValuePair<DevExpress.XtraEditors.TextEdit, string>(textAdres, "ADRES")
            };

                UpdateTextEditValues(view, textEditColumnPairs);

                var lookUpEditColumnPairs = new List<KeyValuePair<DevExpress.XtraEditors.LookUpEdit, string>>
            {
            new KeyValuePair<DevExpress.XtraEditors.LookUpEdit, string>(lookUpSehir, "SEHIR"),
            new KeyValuePair<DevExpress.XtraEditors.LookUpEdit, string>(lookUpBanka, "BANKA")
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

        // Texteditlerin temizlenmesi
        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            textID.Text = "";
            textMusteriAd.Text = "";
            textMusteriSoyad.Text = "";
            textTelefon.Text = "";
            textMail.Text = "";
            lookUpSehir.EditValue = "";
            lookUpBanka.EditValue = "";
            textVergiDaire.Text = "";
            textVergiNo.Text = "";
            textAdres.Text = "";
        }
    }
}
