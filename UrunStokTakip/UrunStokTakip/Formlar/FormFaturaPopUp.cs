using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace UrunStokTakip.Formlar
{
    public partial class FormFaturaPopUp : Form
    {
        private DbStokTakipEntities5 db;
        public FormFaturaPopUp()
        {
            InitializeComponent();
            db = DbContextFactory.GetDbContext();
        }
       
        public int id;
        private void FormFaturaPopUp_Load(object sender, EventArgs e)
        {
           
            // Fatura detayı listelenir
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


            // Fatura bilgisi listelenir
            var degerler2 = (from u in db.TABLE_FATURABILGI
                           select new
                           {
                               u.ID,
                               u.SERI,
                               u.SIRANO,
                               u.TARIH,
                               u.SAAT,
                               u.VERGIDAIRE,
                               MUSTERI = u.TABLE_MUSTERI.MUSTERI_AD + " " + u.TABLE_MUSTERI.MUSTERI_SOYAD,
                               SORUMLU = u.TABLE_SORUMLU.SORUMLU_AD + " " + u.TABLE_SORUMLU.SORUMLU_SOYAD

                           }).Where(x => x.ID == id);

            gridControl2.DataSource = degerler2.ToList();

        }

        // Fatura raporu oluşturma
        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            iTextSharp.text.Document fatura_raporu =new iTextSharp.text.Document();
            PdfWriter.GetInstance(fatura_raporu, new FileStream("c:FaturaRaporu.pdf", FileMode.Create));
            fatura_raporu.Add(new Paragraph(gridControl1.Text));
            fatura_raporu.Close();

            //string path = "Fatura.Pdf";
            //gridControl1.ExpertToPdf(path);
        }

        private void pictureEdit2_Click(object sender, EventArgs e)
        {
            //string path = "Fatura.Xls";
            //gridControl1.ExpertToXls(path);
        }

        // Pencereyi kapatır
        private void pictureEdit3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
