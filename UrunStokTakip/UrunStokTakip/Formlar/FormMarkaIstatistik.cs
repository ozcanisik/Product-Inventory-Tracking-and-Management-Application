using DevExpress.XtraGrid.EditForm.Helpers;
using DevExpress.XtraRichEdit.Model;
using DevExpress.XtraCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrunStokTakip.Formlar
{
    public partial class FormMarkaIstatistik : Form
    {
        private DbStokTakipEntities5 db;
        public FormMarkaIstatistik()
        {
            InitializeComponent();
            db = DbContextFactory.GetDbContext();
        }

        private void FormMarkaIstatistik_Load(object sender, EventArgs e)
        {
            Listele();
            IstatistikGetir();
        }

        // Verilerin çekilmesi ve listelenmesi
        private void Listele()
        {
            // Markaları ve ürün sayılarını ürün sayısına göre sıralayarak gridcontrole çeker
            var markalarVeUrunSayilari = db.TABLE_URUN
                .GroupBy(u => u.TABLE_MARKA.MARKA_AD)
                .Select(g => new
                {
                    Marka = g.Key,
                    UrunSayisi = g.Count()
                })
                .OrderByDescending(x => x.UrunSayisi)
                .ToList();

            // Markalar ve ürün sayılarının verisinin çekilmesi
            gridControl1.DataSource = markalarVeUrunSayilari;
        }

        // İstatistiklerin linq sorgularıyla getirilmesi
        private void IstatistikGetir()
        {
            // Toplam marka sayısı
            labelToplamMarka.Text = (from x in db.TABLE_URUN
                                     select x.TABLE_MARKA.MARKA_AD).Distinct().Count().ToString();
            
            // En fazla ürüne sahip markayı direkt olarak gridview'in ilk satırından çektim(Çünkü yukarıda sıralanmış listeliyorduk)
            object value = gridView1.GetRowCellValue(0, "Marka");
            labelEnFazlaUrun.Text = value.ToString();

            // En çok satış yapan marka ve satış sayısını gösterir.
            var mostSoldBrand = (from urunHareket in db.TABLE_URUNHAREKET
                                 join urun in db.TABLE_URUN on urunHareket.URUN equals urun.ID
                                 join marka in db.TABLE_MARKA on urun.MARKA equals marka.ID
                                 group urunHareket by marka.MARKA_AD into markaGroup
                                 orderby markaGroup.Count() descending
                                 select new { Marka = markaGroup.Key, ToplamSatis = markaGroup.Count() })
                     .FirstOrDefault();

            labelControl4.Text = mostSoldBrand.Marka + "\n" + mostSoldBrand.ToplamSatis;

            // En az satış yapan marka ve satış sayısını gösterir.
            var leastSoldBrand = (from urunHareket in db.TABLE_URUNHAREKET
                                 join urun in db.TABLE_URUN on urunHareket.URUN equals urun.ID
                                 join marka in db.TABLE_MARKA on urun.MARKA equals marka.ID
                                 group urunHareket by marka.MARKA_AD into markaGroup
                                 orderby markaGroup.Count() ascending
                                 select new { Marka = markaGroup.Key, ToplamSatis = markaGroup.Count() })
                     .FirstOrDefault();

            labelControl6.Text = leastSoldBrand.Marka + "\nAdet: " + leastSoldBrand.ToplamSatis;


            chartControl1.DataSource = gridControl1.DataSource;
            // Seriyi oluşturduk
            Series series = new Series("Markalar", ViewType.Pie3D);

            // ArgumentDataMember, marka isimlerini içeren sütunu belirtir
            series.ArgumentDataMember = "Marka";

            // ValueDataMember, ürün sayısını içeren sütunu belirtir
            series.ValueDataMembers.AddRange("UrunSayisi");

            // Legend kısmını(yani sağdaki renkleri belirten kısma markaların adını yazdırdım)
            series.LegendTextPattern = "{A}";

            // Seriyi ChartControl'a ekledik
            chartControl1.Series.Add(series);
        }
    }
}
