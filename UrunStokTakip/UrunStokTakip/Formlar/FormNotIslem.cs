using DevExpress.Utils.Text;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraRichEdit.Layout;
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
    public partial class FormNotIslem : Form
    {
        private DbStokTakipEntities5 db;
        public FormNotIslem()
        {
            InitializeComponent();
            db = DbContextFactory.GetDbContext();
        }

        private void FormNot_Load(object sender, EventArgs e)
        {       
            Listele();
        }

        // Notların listelenmesi
        private void Listele()
        {
            gridControl1.DataSource = db.TABLE_NOTLAR.ToList();
        }

        // Listeleme butonu
        private void buttonListele_Click(object sender, EventArgs e)
        {
            Listele();
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
            new KeyValuePair<DevExpress.XtraEditors.TextEdit, string>(textBaslik, "BASLIK"),
            new KeyValuePair<DevExpress.XtraEditors.TextEdit, string>(textIcerik, "ICERIK"),
            new KeyValuePair<DevExpress.XtraEditors.TextEdit, string>(textTarih, "TARIH")
            };

                UpdateTextEditValues(view, textEditColumnPairs);
            }
            // CheckEdit verisinin değerini tablodan alır
            checkDurum.Checked = Convert.ToBoolean(gridView1.GetRowCellValue(e.FocusedRowHandle, "DURUM")); 
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

        // Not silme işlemi
        private void buttonSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textID.Text);
            var kayit = db.TABLE_NOTLAR.Find(id);
            db.TABLE_NOTLAR.Remove(kayit);
            db.SaveChanges();
            Listele();
            MessageBox.Show("Not başarı ile silindi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Not ekleme işlemi
        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            TABLE_NOTLAR kayit = new TABLE_NOTLAR();
            kayit.BASLIK = textBaslik.Text;
            kayit.DURUM = checkDurum.Checked;
            kayit.TARIH = System.DateTime.Parse(textTarih.Text);
            kayit.ICERIK = textIcerik.Text;

            db.TABLE_NOTLAR.Add(kayit);
            db.SaveChanges();
            Listele();
            MessageBox.Show("Not başarı ile kaydedildi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Not güncelleme işlemi
        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textID.Text);
            var kayit = db.TABLE_NOTLAR.Find(id);
            
            kayit.BASLIK = textBaslik.Text;
            kayit.DURUM = checkDurum.Checked;
            kayit.TARIH = System.DateTime.Parse(textTarih.Text);
            kayit.ICERIK = textIcerik.Text;

            db.SaveChanges();
            Listele();
            MessageBox.Show("Not başarı ile güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Sağ taraftaki texteditlerin temizlenmesi
        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            textID.Text = "";
            textBaslik.Text = "";
            textTarih.Text = "";
            checkDurum.Checked = false;
            textIcerik.Text = "";
        }
    }
}
