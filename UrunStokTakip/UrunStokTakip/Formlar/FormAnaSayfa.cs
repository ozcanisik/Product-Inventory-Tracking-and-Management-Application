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
    public partial class FormAnaSayfa : Form
    {
        private DbStokTakipEntities5 db;
        public FormAnaSayfa()
        {
            InitializeComponent();
            db = DbContextFactory.GetDbContext();
        }

        private void FormAnaSayfa_Load(object sender, EventArgs e)
        {
            Listele();
        }

        // Veri kaynağının çekilmesi ve listeleme işlemleri
        private void Listele()
        {
            gridControl1.DataSource = (from x in db.TABLE_URUN.
                                       Where(x => x.DURUM == true)
                                       select new
                                       {
                                           x.TABLE_MARKA.MARKA_AD,
                                           x.URUN_MODEL,
                                           x.STOK
                                       }).
                                       OrderBy(y => y.STOK).ToList();

            gridControl2.DataSource = (from x in db.TABLE_NOTLAR.
                                       Where(x => x.DURUM == false)
                                       select new
                                       {
                                           x.BASLIK,
                                           x.ICERIK,
                                           x.TARIH,
                                       }).
                                       OrderBy(y => y.TARIH).ToList();
        }
    }
}
