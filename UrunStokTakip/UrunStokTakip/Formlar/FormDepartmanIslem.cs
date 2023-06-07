using DevExpress.Utils.Behaviors;
using DevExpress.Utils.Text;
using DevExpress.XtraEditors;
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
    public partial class FormDepartmanIslem : Form
    {
        private DbStokTakipEntities5 db;
        public FormDepartmanIslem()
        {
            InitializeComponent();
            db = DbContextFactory.GetDbContext();
        }

        private void FormDepartmanIslem_Load(object sender, EventArgs e)
        {
            Listele();
            IstatistikGetir();
        }
        private void buttonListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        // Veri kaynağının çekilmesi ve listeleme işlemleri
        private void Listele()
        {
            var liste_degerler = from x in db.TABLE_DEPARTMAN
                                 select new
                                 {
                                     x.ID,
                                     x.DEPARTMAN_AD,
                                     x.ACIKLAMA
                                 };
            gridControl1.DataSource = liste_degerler.ToList();
        }

        // İstatistikleri getirmek için çağırdığımız fonksiyon
        private void IstatistikGetir()
        {
            ToplamDepartman();
            EnFazlaCalisan();
            EnAzCalisan();
        }

        // En az çalışana sahip departmanı bulan fonksiyon
        private void EnAzCalisan()
        {
            var leastResponsibleDepartment = (from sorumlu in db.TABLE_SORUMLU
                                              join departman in db.TABLE_DEPARTMAN on sorumlu.DEPARTMAN equals departman.ID
                                              group sorumlu by departman.DEPARTMAN_AD into departmanGroup
                                              orderby departmanGroup.Count() ascending
                                              select new { Departman = departmanGroup.Key, SorumluSayisi = departmanGroup.Count() })
                                                         .FirstOrDefault();

            labelEnAzCalisan.Text = leastResponsibleDepartment.Departman + "\nSorumlu Sayisi: " + leastResponsibleDepartment.SorumluSayisi;
        }

        // En fazla çalışana sahip departmanı bulan fonksiyon
        private void EnFazlaCalisan()
        {
            var mostResponsibleDepartment = (from sorumlu in db.TABLE_SORUMLU
                                             join departman in db.TABLE_DEPARTMAN on sorumlu.DEPARTMAN equals departman.ID
                                             group sorumlu by departman.DEPARTMAN_AD into departmanGroup
                                             orderby departmanGroup.Count() descending
                                             select new { Departman = departmanGroup.Key, SorumluSayisi = departmanGroup.Count() })
                                             .FirstOrDefault();

            labelEnFazlaCalisan.Text = mostResponsibleDepartment.Departman + "\nSorumlu Sayisi: " + mostResponsibleDepartment.SorumluSayisi;
        }

        // Toplam departman sayısını bulan fonksiyon
        private void ToplamDepartman()
        {
            labelToplamDepartman.Text = db.TABLE_DEPARTMAN.Count().ToString();
        }

        // Departman ekleme fonksiyonu
        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            TABLE_DEPARTMAN departman = new TABLE_DEPARTMAN();
            
            departman.DEPARTMAN_AD = textDepartman.Text;
            departman.ACIKLAMA = textAciklama.Text;
            
            db.TABLE_DEPARTMAN.Add(departman);
            db.SaveChanges();
            Listele();
            MessageBox.Show("Departman başarı ile kaydedildi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Departman silme fonksiyonu
        private void buttonSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textID.Text);
            var kayit = db.TABLE_DEPARTMAN.Find(id);
            db.TABLE_DEPARTMAN.Remove(kayit);
            db.SaveChanges();
            Listele();
            MessageBox.Show("Departman başarı ile silindi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Departman güncelleme fonksiyonu
        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textID.Text);
            var kayit = db.TABLE_DEPARTMAN.Find(id);
            
            kayit.DEPARTMAN_AD = textDepartman.Text;
            kayit.ACIKLAMA = textAciklama.Text;

            db.SaveChanges();
            Listele();
            MessageBox.Show("Departman başarı ile güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Liste üzerinde herhangi bir satıra tıklandığında o satırdaki bilgilerin sağ taraftaki texteditlere çekilmesi
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

            if (view != null)
            {
                var textEditColumnPairs = new List<KeyValuePair<DevExpress.XtraEditors.TextEdit, string>>
            {
            new KeyValuePair<DevExpress.XtraEditors.TextEdit, string>(textID, "ID"),
            new KeyValuePair<DevExpress.XtraEditors.TextEdit, string>(textDepartman, "DEPARTMAN_AD"),
            new KeyValuePair<DevExpress.XtraEditors.TextEdit, string>(textAciklama, "ACIKLAMA")
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

        // Sağ taraftaki texteditleri temizleme fonksiyonu
        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            textID.Text = "";
            textDepartman.Text = "";
            textAciklama.Text = "";
        }
    }
}
