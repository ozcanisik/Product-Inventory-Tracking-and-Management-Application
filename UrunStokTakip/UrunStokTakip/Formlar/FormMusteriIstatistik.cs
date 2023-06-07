using DevExpress.Mvvm.POCO;
using DevExpress.XtraCharts;
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
    public partial class FormMusteriIstatistik : Form
    {
        private DbStokTakipEntities5 db;
        public FormMusteriIstatistik()
        {
            InitializeComponent();
            db = DbContextFactory.GetDbContext();
        }

        private void FormMusteriIstatistik_Load(object sender, EventArgs e)
        {
            Listele();
            IstatistikGetir();
        }

        // Verilerin çekilmesi ve listelenmesi
        private void Listele()
        {
            var illerVeMusteriSayilari= db.TABLE_MUSTERI
                .GroupBy(u => u.TABLE_SEHIR.SEHIR)
                .Select(g => new
                {
                    Sehir = g.Key,
                    MusteriSayisi = g.Count()
                })
                .OrderByDescending(x => x.MusteriSayisi)
                .ToList();

            gridControl1.DataSource = illerVeMusteriSayilari;
        }

        // İstatistiklerin getirilmesi
        private void IstatistikGetir()
        {
            // Doughnut Chart ile ilgili istatistik kısmı
            // ----------------------------------------------------------------------------------------------------

            chartControl1.DataSource = gridControl1.DataSource;
            // Seriyi oluşturduk
            Series series = new Series("Sehirler", ViewType.Doughnut3D);

            // ArgumentDataMember, il isimlerini içeren sütunu belirtir
            series.ArgumentDataMember = "Sehir";

            // ValueDataMember, il sayısını içeren sütunu belirtir
            series.ValueDataMembers.AddRange("MusteriSayisi");

            // Legend kısmını(yani sağdaki renkleri belirten kısma şehirlerin adını yazdırdım)
            series.LegendTextPattern = "{A}";

            // Seriyi ChartControl'a ekledik
            chartControl1.Series.Add(series);

            // ----------------------------------------------------------------------------------------------------

            // Bar ile ilgili istatistik kısmı

            chartControl2.DataSource = gridControl1.DataSource;

            // Seriyi oluşturduk
            Series series2 = new Series("Sehirler", ViewType.Bar);

            // ArgumentDataMember, il isimlerini içeren sütunu belirtir
            series2.ArgumentDataMember = "Sehir";

            // ValueDataMember, il sayısını içeren sütunu belirtir
            series2.ValueDataMembers.AddRange("MusteriSayisi");

            // Legend kısmını(yani sağdaki renkleri belirten kısma şehirlerin adını yazdırdım)
            series2.LegendTextPattern = "{A}";

            // Seriyi ChartControl'a ekledik
            chartControl2.Series.Add(series2);

            // ----------------------------------------------------------------------------------------------------

            // Diğer renkli kart istatistiklerin çekildiği kısım

            labelToplamMusteri.Text = db.TABLE_MUSTERI.Count().ToString();
            labelToplamIl.Text = db.TABLE_MUSTERI.Select(x => x.SEHIR).Distinct().Count().ToString();

            // En fazla müşteriye sahip il direkt olarak gridview'in ilk satırından çektim(Çünkü yukarıda sıralanmış listeliyorduk)
            object value = gridView1.GetRowCellValue(0, "Sehir");
            labelEnFazlaMusteri.Text = value.ToString();

            // En az müşteriye sahip il direkt olarak gridview'in son satırından çektim(Çünkü yukarıda sıralanmış listeliyorduk)
            object value2 = gridView1.GetRowCellValue(gridView1.DataRowCount - 1, "Sehir");
            labelEnAzMusteri.Text = value2.ToString();
        }
    }
}
