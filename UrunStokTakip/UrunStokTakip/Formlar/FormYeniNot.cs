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
    public partial class FormYeniNot : Form
    {
        private DbStokTakipEntities5 db;
        public FormYeniNot()
        {
            InitializeComponent();
            db = DbContextFactory.GetDbContext();
        }

        // Yeni not ekleme işlemi
        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            TABLE_NOTLAR kayit = new TABLE_NOTLAR();
            kayit.BASLIK = textBaslik.Text;
            kayit.DURUM = checkDurum.Checked;
            kayit.TARIH = System.DateTime.Parse(textTarih.Text);
            kayit.ICERIK = textIcerik.Text;

            db.TABLE_NOTLAR.Add(kayit);
            db.SaveChanges();
            MessageBox.Show("Not başarı ile kaydedildi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
