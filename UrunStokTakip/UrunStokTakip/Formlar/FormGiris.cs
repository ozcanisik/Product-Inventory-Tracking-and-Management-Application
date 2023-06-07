using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrunStokTakip
{
    public partial class FormGiris : Form
    {
        private DbStokTakipEntities5 db;
        private void BilgileriKaydet()
        {
            // Beni Hatırla butonu işaretlenmişse yazdığımız bilgileri kaydediyoruz ve checkboxu true yapıyoruz.
            if (checkBeniHatirla.Checked)
            {
                Properties.Settings.Default.KullaniciAdi = textKullaniciAdi.Text;
                Properties.Settings.Default.Sifre = textSifre.Text;
                Properties.Settings.Default.BeniHatirla = true;
                Properties.Settings.Default.Save();

            }
            //Beni Hatırla butonu işaretlenmemişse bilgileri kaydetmiyoruz Properties'e.
            else
            {
                Properties.Settings.Default.KullaniciAdi = null;
                Properties.Settings.Default.Sifre = null;
                Properties.Settings.Default.BeniHatirla = false;
                Properties.Settings.Default.Save();
            }
        }


        private void BilgileriGetir()
        {
            // Beni Hatırla butonu işaretlenmişse
            if (Properties.Settings.Default.BeniHatirla == true)
            {
                // Kullanıcı Adı ve Şifre bölümlerine Properties'e yazdığımız bilgileri aktarıyoruz. 
                textKullaniciAdi.Text = Properties.Settings.Default.KullaniciAdi;
                textSifre.Text = Properties.Settings.Default.Sifre;
                checkBeniHatirla.Checked = true;

            }// Beni Hatırla butonu işaretlenmemişse, Kullanıcı Adı ve Şifre bölümlerine bir şey yazılmayacak
            else
            {
                textKullaniciAdi.Text = null;
                textSifre.Text = null;
                checkBeniHatirla.Checked = false;
            }
        }
        
        public FormGiris()
        {
            InitializeComponent();
            BilgileriGetir();
            db = DbContextFactory.GetDbContext();
        }

        private void BtnGiris_Click_1(object sender, EventArgs e)
        {
            // Text'lere yazılanlar Admin tablosundaki değerlerle eşleşiyorsa yazılan değerler alınır. 
            var sorgu = from x in db.TABLE_ADMIN
                        where x.KULLANICIAD == textKullaniciAdi.Text &
                        x.SIFRE == textSifre.Text
                        select x;
            // Eğer sorgunun içerisinde bir şey varsa
            if (sorgu.Any())
            {
                BilgileriKaydet();// Beni Hatırla bilgilerini kaydet
                AnaForm frm = new AnaForm();
                frm.Show();
                this.Hide();
            }
            else
            {
                XtraMessageBox.Show("Hatalı Giriş!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSifremiUnuttum frm = new FormSifremiUnuttum();
            frm.Show();
            this.Hide();
        }
    }
}
