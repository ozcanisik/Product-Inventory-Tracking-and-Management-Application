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
    public partial class FormFaturaArama : Form
    {
        private DbStokTakipEntities5 db;
        public FormFaturaArama()
        {
            InitializeComponent();
            db = DbContextFactory.GetDbContext();
        }

        // Verilerin çekilmesi ve fatura id verisine göre arama işlemi
        private void BtnFaturaAra_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TxtFaturaId.Text);

            var degerler = (from u in db.TABLE_FATURADETAY
                           select new
                           {
                               u.ID,
                               u.URUN,
                               u.ADET,
                               u.FIYAT,
                               u.TUTAR,
                               u.FATURAID
                           }).Where(x => x.FATURAID == id);

            gridControl1.DataSource = degerler.ToList();
        }
    }
}
