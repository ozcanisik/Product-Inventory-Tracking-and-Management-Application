using DevExpress.DataAccess.Native;
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
    public partial class FormYeniUrun : Form
    {
        private DbStokTakipEntities5 db;
        public FormYeniUrun()
        {
            InitializeComponent();
            db = DbContextFactory.GetDbContext();
        }
        
        // Vazgeç butonu
        private void BtnVazgeç_Click(object sender, EventArgs e)
        {
            FormYeniUrun fr = new FormYeniUrun();
            this.Close();
        }

        // Yeni ürün ekleme işlemi
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TABLE_URUN kayit = new TABLE_URUN();

            kayit.URUN_MODEL = textModel.Text;
            kayit.MARKA = int.Parse(lookUpMarka.EditValue.ToString());
            kayit.ALIS_FIYAT = Decimal.Parse(textAlis_Fiyat.Text);
            kayit.SATIS_FIYAT = Decimal.Parse(textSatis_Fiyat.Text);
            kayit.STOK = int.Parse(textStok.Text);
            kayit.KATEGORI = int.Parse(lookUpKategori.EditValue.ToString());
            kayit.DURUM = CheckStock(kayit.STOK);

            // Özellikler başka tabloda olduğu için doğrudan ekleyemeyiz.
            OzellikEkle(kayit);

            db.TABLE_URUN.Add(kayit);
            db.SaveChanges();
            
            MessageBox.Show("Ürün başarı ile kaydedildi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Özelliklerin eklenmesi
        private void OzellikEkle(TABLE_URUN urun)
        {
            string ozellikAciklama = textOzellik.Text;

            TABLE_OZELLIKLER mevcutOzellik = db.TABLE_OZELLIKLER.FirstOrDefault(o => o.OZELLIKLER == ozellikAciklama);

            if (mevcutOzellik == null)
            {
                // Özelliklerin veritabanında daha önce eklenmediğini tespit ettik
                TABLE_OZELLIKLER yeniOzellik = new TABLE_OZELLIKLER { OZELLIKLER = ozellikAciklama };

                // Yeni Ozellik nesnesini veritabanına kaydet
                db.TABLE_OZELLIKLER.Add(yeniOzellik);
                db.SaveChanges();

                // Şimdi yeni Ozellik nesnesinin ID'sini Urun nesnesinin Ozellik özelliğine atayabiliriz
                urun.OZELLIK = yeniOzellik.ID;
            }
            else
            {
                // Ozellik_Aciklama'nın veritabanında zaten olduğunu tespit ettik,
                // bu yüzden mevcut Ozellik nesnesinin ID'sini kullanabiliriz
                urun.OZELLIK = mevcutOzellik.ID;
            }
        }

        // Stok durumunun kritik olup olmadığının kontrolü
        public bool CheckStock(int? stock)
        {
            if (stock != null)
            {
                return stock <= 50 ? true : false;
            }
            else
            {
                return false;
            }
        }

        private void FormYeniUrun_Load(object sender, EventArgs e)
        {
            DataLoad();
        }

        // LookUpEdit'lere kategori ve markaların çekilmesi
        private void DataLoad()
        {
            // Kategori veri kaynağını alma
            lookUpKategori.Properties.DataSource = (from x in db.TABLE_KATEGORI
                                                    select new
                                                    {
                                                        x.ID,
                                                        x.KATEGORI_AD
                                                    }).ToList();

            // Marka veri kaynağını alma
            lookUpMarka.Properties.DataSource = (from x in db.TABLE_MARKA
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.MARKA_AD
                                                 }).ToList();
        }
    }
}
