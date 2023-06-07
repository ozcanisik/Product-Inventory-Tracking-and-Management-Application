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
    public partial class FormYeniDepartman : Form
    {
        private DbStokTakipEntities5 db;
        public FormYeniDepartman()
        {
            InitializeComponent();
            db = DbContextFactory.GetDbContext();
        }

        // Departman ekleme işlemi
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TABLE_DEPARTMAN departman = new TABLE_DEPARTMAN();

            departman.DEPARTMAN_AD = textDepartman.Text;
            departman.ACIKLAMA = textAciklama.Text;

            db.TABLE_DEPARTMAN.Add(departman);
            db.SaveChanges();

            MessageBox.Show("Departman başarı ile kaydedildi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Vazgeç butonu
        private void BtnVazgeç_Click(object sender, EventArgs e)
        {
            FormYeniDepartman fr = new FormYeniDepartman();
            this.Close();
        }
    }
}
