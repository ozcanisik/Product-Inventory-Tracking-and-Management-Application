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
    public partial class FormYeniKategori : Form
    {
        private DbStokTakipEntities5 db;
        public FormYeniKategori()
        {
            InitializeComponent();
            db = DbContextFactory.GetDbContext();
        }

        // Vazgeçme butonu
        private void BtnVazgeç_Click(object sender, EventArgs e)
        {
            FormYeniKategori fr  = new FormYeniKategori();
            this.Close();
        }

        // Kategori ekleme işlemi
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            TABLE_KATEGORI kayit = new TABLE_KATEGORI();

            kayit.KATEGORI_AD = txtKategoriAd.Text;
            
            db.TABLE_KATEGORI.Add(kayit);
            db.SaveChanges();
            MessageBox.Show("Kategori başarı ile kaydedildi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
