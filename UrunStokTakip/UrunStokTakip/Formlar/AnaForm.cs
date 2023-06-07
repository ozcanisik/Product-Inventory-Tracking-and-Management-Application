using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrunStokTakip.Formlar;

namespace UrunStokTakip
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void button_urun_listesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormUrunIslem formUrunIslem = new Formlar.FormUrunIslem();
            formUrunIslem.MdiParent = this;
            formUrunIslem.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormKategoriIslem formKategoriIslem = new Formlar.FormKategoriIslem();
            formKategoriIslem.MdiParent = this;
            formKategoriIslem.Show();
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormUrunIstatistik formUrunIstatistik = new Formlar.FormUrunIstatistik();
            formUrunIstatistik.MdiParent = this;
            formUrunIstatistik.Show();
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormMarkaIstatistik formMarkaIstatistik = new Formlar.FormMarkaIstatistik();
            formMarkaIstatistik.MdiParent = this;
            formMarkaIstatistik.Show();
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormMusteriIslem formMusteriIslem = new Formlar.FormMusteriIslem();
            formMusteriIslem.MdiParent = this;
            formMusteriIslem.Show();
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormMusteriIstatistik formMusteriIstatistik = new Formlar.FormMusteriIstatistik();
            formMusteriIstatistik.MdiParent = this;
            formMusteriIstatistik.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Seven Classic");
            Formlar.FormAnaSayfa formAnaSayfa = new Formlar.FormAnaSayfa();
            formAnaSayfa.MdiParent = this;
            formAnaSayfa.Show();
        }

        private void barButtonItem24_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormDepartmanIslem formDepartmanIslem = new Formlar.FormDepartmanIslem();
            formDepartmanIslem.MdiParent = this;
            formDepartmanIslem.Show();
        }

        private void barButtonItem26_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void barButtonItem28_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormDovizKurlar formDovizKurlar = new Formlar.FormDovizKurlar();
            formDovizKurlar.MdiParent = this;
            formDovizKurlar.Show();
        }

        private void barButtonItem31_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void barButtonItem32_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }

        private void barButtonItem33_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            List<string> emailAddresses = new List<string>
            {
            "ozcan59isik@gmail.com",
            "032090110@ogr.uludag.edu.tr",
            "032090007@ogr.uludag.edu.tr",
            "032090020@ogr.uludag.edu.tr"
            };

            string message = "Fikir, öneri ve sorunlarınız için aşağıdaki e-posta adresleri üzerinden iletişime geçebilirsiniz.\n\n"
                             + String.Join("\n", emailAddresses);

            MessageBox.Show(message, "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormNotIslem formNot = new Formlar.FormNotIslem();
            formNot.MdiParent = this;
            formNot.Show();
        }

        private void barButtonItem27_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormYeniNot formYeniNot = new Formlar.FormYeniNot();
            formYeniNot.Show();
        }

        private void barButtonItem29_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormUrunSatis formUrunSatis = new Formlar.FormUrunSatis();
            formUrunSatis.Show();
        }

        private void barButtonItem30_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormAnaSayfa formAnaSayfa = new Formlar.FormAnaSayfa();
            formAnaSayfa.MdiParent = this;
            formAnaSayfa.Show();
        }

        private void barButtonItem25_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormYeniDepartman formYeniDepartman = new Formlar.FormYeniDepartman();
            formYeniDepartman.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormYeniKategori formYeniKategori = new Formlar.FormYeniKategori();
            formYeniKategori.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormYeniMusteri formYeniMusteri = new Formlar.FormYeniMusteri();
            formYeniMusteri.Show();
        }

        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormSorumluIslem formSorumluIslem = new Formlar.FormSorumluIslem();
            formSorumluIslem.MdiParent = this;
            formSorumluIslem.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormYeniUrun formYeniUrun = new Formlar.FormYeniUrun();
            formYeniUrun.Show();
        }

        private void barButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormYeniSorumlu formYeniSorumlu = new Formlar.FormYeniSorumlu();
            formYeniSorumlu.Show();
        }


        // Bu olay ana form'dan çıkış yapıldığında diğer tüm formların kapanmasını ve programın sonlanmasını sağlar.
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Açık olan tüm formları bir listeye kopyala
            List<Form> openForms = new List<Form>();
            foreach (Form frm in Application.OpenForms)
            {
                openForms.Add(frm);
            }

            // Bu listeyi döngüye al ve tüm formları kapat
            foreach (Form frm in openForms)
            {
                // Ana formu tekrar kapatmamak için kontrol et
                if (frm != this)
                {
                    frm.Close();
                }
            }

            // Ana form kapatıldıktan sonra uygulamanın tamamen kapanmasını sağlar
            Application.Exit();
        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormFaturaDetay formFaturaDetay = new Formlar.FormFaturaDetay();
            formFaturaDetay.MdiParent = this;
            formFaturaDetay.Show();
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormFaturaIslem formFaturaIslem = new Formlar.FormFaturaIslem();
            formFaturaIslem.MdiParent = this;
            formFaturaIslem.Show();
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormFaturaPopUp formFaturaPopUp = new Formlar.FormFaturaPopUp();
            formFaturaPopUp.Show();
        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormFaturaArama formFaturaArama = new Formlar.FormFaturaArama();
            formFaturaArama.Show();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormQRKod formQRKod = new Formlar.FormQRKod();
            formQRKod.Show();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormBarkod formBarkod = new Formlar.FormBarkod();
            formBarkod.Show();
        }

        private void BtnSatisIslem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormSatisIslem fr = new Formlar.FormSatisIslem();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnRaporlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormRaporlar fr = new Formlar.FormRaporlar();
            //fr.MdiParent = this;
            fr.Show();
        }
    }
}
