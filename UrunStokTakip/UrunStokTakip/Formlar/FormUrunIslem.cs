using DevExpress.Internal.WinApi.Windows.UI.Notifications;
using DevExpress.Mvvm.POCO;
using DevExpress.XtraGrid;
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
    public partial class FormUrunIslem : Form
    {
        private DbStokTakipEntities5 db;
        public FormUrunIslem()
        {
            InitializeComponent();
            db = DbContextFactory.GetDbContext();
        }

        private void FormUrunListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void buttonListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        // Yeni ürün ekleme işlemi
        private void buttonKaydet_Click(object sender, EventArgs e)
        {

            TABLE_URUN kayit = new TABLE_URUN();
            kayit.URUN_MODEL = textModel.Text;
            kayit.MARKA = int.Parse(lookUpMarka.EditValue.ToString());
            kayit.ALIS_FIYAT = Decimal.Parse(textAlis_Fiyat.Text);
            kayit.SATIS_FIYAT = Decimal.Parse(textSatis_Fiyat.Text);
            kayit.STOK = int.Parse(textStok.Text);
            kayit.KATEGORI = int.Parse(lookUpKategori.EditValue.ToString());
            kayit.DURUM = CheckStock(kayit.STOK);

            // Özellikler başka tabloda olduğu için doğrudan ekleyemeyiz.
            OzellikEkle(kayit);

            db.TABLE_URUN.Add(kayit);
            db.SaveChanges();
            Listele();
            MessageBox.Show("Ürün başarı ile kaydedildi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            new KeyValuePair<DevExpress.XtraEditors.TextEdit, string>(textModel, "URUN_MODEL"),
            new KeyValuePair<DevExpress.XtraEditors.TextEdit, string>(textAlis_Fiyat, "ALIS_FIYAT"),
            new KeyValuePair<DevExpress.XtraEditors.TextEdit, string>(textSatis_Fiyat, "SATIS_FIYAT"),
            new KeyValuePair<DevExpress.XtraEditors.TextEdit, string>(textStok, "STOK"),
            new KeyValuePair<DevExpress.XtraEditors.TextEdit, string>(textOzellik, "OZELLIKLER")
            };

                UpdateTextEditValues(view, textEditColumnPairs);

                var lookUpEditColumnPairs = new List<KeyValuePair<DevExpress.XtraEditors.LookUpEdit, string>>
            {
            new KeyValuePair<DevExpress.XtraEditors.LookUpEdit, string>(lookUpKategori, "KATEGORI_AD"),
            new KeyValuePair<DevExpress.XtraEditors.LookUpEdit, string>(lookUpMarka, "MARKA_AD")
            };

                UpdateLookUpEditValues(view, lookUpEditColumnPairs);
            }

            // CheckEdit verisinin değerini tablodan alır
            checkDurum.Checked = Convert.ToBoolean(gridView1.GetRowCellValue(e.FocusedRowHandle, "DURUM"));
        }

        // Ürün silme işlemi
        private void buttonSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textID.Text);
            var kayit = db.TABLE_URUN.Find(id);
            db.TABLE_URUN.Remove(kayit);
            db.SaveChanges();
            Listele();
            MessageBox.Show("Ürün başarı ile silindi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);       
        }

        // Ürün güncelleme işlemi
        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textID.Text);
            var kayit = db.TABLE_URUN.Find(id);
            kayit.URUN_MODEL = textModel.Text;
            kayit.MARKA = int.Parse(lookUpMarka.EditValue.ToString());
            kayit.ALIS_FIYAT = decimal.Parse(textAlis_Fiyat.Text);
            kayit.SATIS_FIYAT = decimal.Parse(textSatis_Fiyat.Text);
            kayit.KATEGORI = int.Parse(lookUpKategori.EditValue.ToString());
            kayit.STOK = int.Parse(textStok.Text);
            kayit.DURUM = CheckStock(kayit.STOK);

            // Özellikler başka tabloda olduğu için doğrudan güncelleyemeyiz.
            OzellikEkle(kayit);

            db.SaveChanges();
            Listele();
            MessageBox.Show("Ürün başarı ile güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Ürünlerin listelenmesi ve verilerin çekilmesi
        private void Listele()
        {
            var liste_degerler = from x in db.TABLE_URUN
                                 select new
                                 {
                                     x.ID,
                                     x.URUN_MODEL,
                                     x.TABLE_MARKA.MARKA_AD,
                                     x.ALIS_FIYAT,
                                     x.SATIS_FIYAT,
                                     x.STOK,
                                     x.TABLE_KATEGORI.KATEGORI_AD,
                                     x.DURUM,
                                     x.TABLE_OZELLIKLER.OZELLIKLER
                                 };
            gridControl1.DataSource = liste_degerler.ToList();

            // Kategori veri kaynağını alma
            lookUpKategori.Properties.DataSource = (from x in db.TABLE_KATEGORI
                                                    select new
                                                    {
                                                        x.ID,
                                                        x.KATEGORI_AD
                                                    }).ToList();

            // Marka veri kaynağını alma
            lookUpMarka.Properties.DataSource = (from x in db.TABLE_MARKA
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.MARKA_AD
                                                 }).ToList();
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

        // Ürün özelliklerinin eklenmesi
        private void OzellikEkle(TABLE_URUN kayit)
        {
            string ozellikAciklama = textOzellik.Text;

            TABLE_OZELLIKLER mevcutOzellik = db.TABLE_OZELLIKLER.FirstOrDefault(o => o.OZELLIKLER == ozellikAciklama);

            if (mevcutOzellik == null)
            {
                // Özelliklerin veritabanında daha önce eklenmediğini tespit ettik
                TABLE_OZELLIKLER yeniOzellik = new TABLE_OZELLIKLER { OZELLIKLER = ozellikAciklama };

                // Yeni Ozellik nesnesini veritabanına kaydet
                db.TABLE_OZELLIKLER.Add(yeniOzellik);
                db.SaveChanges();

                // Şimdi yeni Ozellik nesnesinin ID'sini Urun nesnesinin Ozellik özelliğine atayabiliriz
                kayit.OZELLIK = yeniOzellik.ID;
            }
            else
            {
                // Ozellik_Aciklama'nın veritabanında zaten olduğunu tespit ettik,
                // bu yüzden mevcut Ozellik nesnesinin ID'sini kullanabiliriz
                kayit.OZELLIK = mevcutOzellik.ID;
            }

        }

        // Texteditlerin temizlenmesi
        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            textID.Text = "";
            textModel.Text = "";
            lookUpMarka.EditValue = "";
            textAlis_Fiyat.Text = "";
            textSatis_Fiyat.Text = "";
            textStok.Text = "";
            lookUpKategori.EditValue = "";
            checkDurum.Checked = false;
            textOzellik.Text = "";
        }

        // Stok durumunun kritik olup olmadığının kontrolü
        public bool CheckStock(int? stock)
        {
            if (stock != null)
            {
                return stock <= 50 ? true : false;
            }
            else
            {
                return false;
            }
        }
    }
}
