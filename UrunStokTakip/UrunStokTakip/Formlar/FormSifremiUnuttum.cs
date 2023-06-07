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
    public partial class FormSifremiUnuttum : Form
    {
        private DbStokTakipEntities5 db;
        public FormSifremiUnuttum()
        {
            InitializeComponent();
            db = DbContextFactory.GetDbContext();
        }
        
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = textKullaniciAdi.Text;
            string yeniParola = textYeniParola.Text;
            string yeniParolaKontrol = textYeniParolaKontrol.Text;

            // Kullanıcı adı ile eşleşen kullanıcıyı bulur
            var kullanici = db.TABLE_ADMIN.FirstOrDefault(x => x.KULLANICIAD == kullaniciAdi);

            if (kullanici != null)
            {
                // Yeni parolaların eşleşmesini kontrol eder
                if (yeniParola == yeniParolaKontrol)
                {
                    // Eşleşme doğruysa yeni parolayı SIFRE sütunuan aktarıyoruz ve kaydediyoruz.
                    kullanici.SIFRE = yeniParola;
                    db.SaveChanges();
                    MessageBox.Show("Yeni parolanız başarıyla yenilendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Parola yenilendikten sonra tekrar Giriş ekranına dönüyoruz.
                    FormGiris frm = new FormGiris();
                    frm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Yeni parolalar eşleşmiyor. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı adı eşleşmiyor. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void BtnVazgeç_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
