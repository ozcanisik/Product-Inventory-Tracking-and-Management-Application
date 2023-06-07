using DevExpress.DataAccess.Native;
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
    public partial class FormYeniSorumlu : Form
    {
        private DbStokTakipEntities5 db;
        public FormYeniSorumlu()
        {
            InitializeComponent();
            db = DbContextFactory.GetDbContext();
        }

        // Yeni sorumlu ekleme işlemi
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TABLE_SORUMLU sorumlu = new TABLE_SORUMLU();

            sorumlu.SORUMLU_AD = textSorumluAd.Text;
            sorumlu.SORUMLU_SOYAD = textSorumluSoyad.Text;
            sorumlu.TELEFON = textTelefon.Text;
            sorumlu.DEPARTMAN = int.Parse(lookUpDepartman.EditValue.ToString());
            sorumlu.MAIL = textMail.Text;

            db.TABLE_SORUMLU.Add(sorumlu);
            db.SaveChanges();
           
            MessageBox.Show("Sorumlu Başarı İle Kaydedildi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Vazgeç butonu
        private void BtnVazgeç_Click(object sender, EventArgs e)
        {
            FormYeniSorumlu fr = new FormYeniSorumlu();
            this.Close();
        }

        private void FormYeniSorumlu_Load(object sender, EventArgs e)
        {
            DataLoad();
        }

        // LookupEdit'e departmanların çekilmesi
        private void DataLoad()
        {
            lookUpDepartman.Properties.DataSource = (from x in db.TABLE_DEPARTMAN
                                                     select new
                                                     {
                                                         x.ID,
                                                         x.DEPARTMAN_AD,
                                                     }).ToList();
        }
    }
}
