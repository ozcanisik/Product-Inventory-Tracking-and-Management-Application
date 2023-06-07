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
    public partial class FormKategoriIslem : Form
    {
        private DbStokTakipEntities5 db;
        public FormKategoriIslem()
        {
            InitializeComponent();
            db = DbContextFactory.GetDbContext();
        }

        private void FormKategoriIslem_Load(object sender, EventArgs e)
        {
            Listele();
        }

        // Verilerin çekilmesi ve listelenmesi
        private void Listele()
        {
            var liste_degerler = from x in db.TABLE_KATEGORI
                                 select new
                                 {
                                     x.ID,
                                     x.KATEGORI_AD
                                 };
            gridControl1.DataSource = liste_degerler.ToList();
        }

        // Tıklandığında verileri çekme
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

            if (view != null)
            {
                var textEditColumnPairs = new List<KeyValuePair<DevExpress.XtraEditors.TextEdit, string>>
            {
            new KeyValuePair<DevExpress.XtraEditors.TextEdit, string>(textID, "ID"),
            new KeyValuePair<DevExpress.XtraEditors.TextEdit, string>(textKategori, "KATEGORI_AD"),
            };

                UpdateTextEditValues(view, textEditColumnPairs);
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

        // Kategori ekleme
        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            TABLE_KATEGORI kategori = new TABLE_KATEGORI();
            kategori.KATEGORI_AD = textKategori.Text;

            db.TABLE_KATEGORI.Add(kategori);
            db.SaveChanges();
            Listele();
            MessageBox.Show("Kategori başarı ile kaydedildi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Kategori silme
        private void buttonSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textID.Text);
            var kayit = db.TABLE_KATEGORI.Find(id);
            db.TABLE_KATEGORI.Remove(kayit);
            db.SaveChanges();
            Listele();
            MessageBox.Show("Kategori başarı ile silindi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Kategori güncelleme
        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textID.Text);
            var kayit = db.TABLE_KATEGORI.Find(id);

            kayit.KATEGORI_AD = textKategori.Text;

            db.SaveChanges();
            Listele();
            MessageBox.Show("Kategori başarı ile güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Listeleme
        private void buttonListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        // Texteditlerin temizlenmesi
        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            textID.Text = "";
            textKategori.Text = "";
        }
    }
}
