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
    public partial class FormSorumluIslem : Form
    {
        private DbStokTakipEntities5 db;
        public FormSorumluIslem()
        {
            InitializeComponent();
            db = DbContextFactory.GetDbContext();
        }

        // Verilerin çekilmesi ve listelenmesi
        private void Listele()
        {
            var liste_degerler = from x in db.TABLE_SORUMLU
                                 select new
                                 {
                                     x.ID,
                                     x.SORUMLU_AD,
                                     x.SORUMLU_SOYAD,
                                     x.TABLE_DEPARTMAN.DEPARTMAN_AD,
                                     x.TELEFON,
                                     x.MAIL,
                                 };
           
            gridControl1.DataSource = liste_degerler.ToList();

            lookUpDepartman.Properties.DataSource = (from x in db.TABLE_DEPARTMAN
                                                     select new
                                                     {
                                                         x.ID,
                                                         x.DEPARTMAN_AD,
                                                     }).ToList();
        }

        private void FrmSorumlu_Load(object sender, EventArgs e)
        {
            Listele();
        }

        // Sorumlu ekleme işlemi
        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            TABLE_SORUMLU kayit = new TABLE_SORUMLU();

            kayit.SORUMLU_AD = textSorumluAd.Text;
            kayit.SORUMLU_SOYAD = textSorumluSoyad.Text;
            kayit.TELEFON = textTelefon.Text;
            kayit.DEPARTMAN = int.Parse(lookUpDepartman.EditValue.ToString());
            kayit.MAIL = textMail.Text;
            
            db.TABLE_SORUMLU.Add(kayit);
            db.SaveChanges();
            Listele();
            MessageBox.Show("Sorumlu Başarı İle Kaydedildi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Sorumlu silme işlemi
        private void buttonSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textID.Text);
            var kayit = db.TABLE_SORUMLU.Find(id);
            db.TABLE_SORUMLU.Remove(kayit);
            db.SaveChanges();
            Listele();
            MessageBox.Show("Sorumlu başarı ile silindi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        // Sorumlu güncelleme işlemi
        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textID.Text);
            var kayit = db.TABLE_SORUMLU.Find(id);

            kayit.SORUMLU_AD = textSorumluAd.Text;
            kayit.SORUMLU_SOYAD = textSorumluSoyad.Text;
            kayit.DEPARTMAN = int.Parse(lookUpDepartman.EditValue.ToString());
            kayit.MAIL = textMail.Text;
            kayit.TELEFON = textTelefon.Text;
 
            db.SaveChanges();
            Listele();
            MessageBox.Show("Sorumlu başarı ile güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            new KeyValuePair<DevExpress.XtraEditors.TextEdit, string>(textSorumluAd, "SORUMLU_AD"),
            new KeyValuePair<DevExpress.XtraEditors.TextEdit, string>(textSorumluSoyad, "SORUMLU_SOYAD"),
            new KeyValuePair<DevExpress.XtraEditors.TextEdit, string>(textTelefon, "TELEFON"),
            new KeyValuePair<DevExpress.XtraEditors.TextEdit, string>(textMail, "MAIL"),
            };

                UpdateTextEditValues(view, textEditColumnPairs);

                var lookUpEditColumnPairs = new List<KeyValuePair<DevExpress.XtraEditors.LookUpEdit, string>>
            {
            new KeyValuePair<DevExpress.XtraEditors.LookUpEdit, string>(lookUpDepartman, "DEPARTMAN_AD"),
            };

                UpdateLookUpEditValues(view, lookUpEditColumnPairs);
            }
        }

        // LookUpEdit(combobox) için null olup olmadığını kontrol ederek tıklandığında verileri çekme
        private void UpdateLookUpEditValues(DevExpress.XtraGrid.Views.Grid.GridView view, List<KeyValuePair<DevExpress.XtraEditors.LookUpEdit, string>> lookUpEditColumnPairs)
        {
            foreach (var pair in lookUpEditColumnPairs)
            {
                var value = view.GetFocusedRowCellValue(pair.Value);
                pair.Key.Text = value != null ? value.ToString() : ""; 
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

        // Texteditlerin temizlenmesi
        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            textID.Text = "";
            textSorumluAd.Text = "";
            textSorumluSoyad.Text = "";
            lookUpDepartman.Text = "";
            textMail.Text = "";
            textTelefon.Text = "";
        }
    }  
}
