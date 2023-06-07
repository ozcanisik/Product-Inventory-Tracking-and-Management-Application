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
    public partial class FormUrunIstatistik : Form
    {
        private DbStokTakipEntities5 db;
        public FormUrunIstatistik()
        {
            InitializeComponent();
            db = DbContextFactory.GetDbContext();
        }

        private void FormUrunIstatistik_Load(object sender, EventArgs e)
        {
            IstatistikGetir();
        }

        // İstatistiklerin çekilmesi
        private void IstatistikGetir()
        {
            ToplamUrun();
            ToplamKategori();
            ToplamStok();
            EnYuksekFiyat();
            EnDusukFiyat();
            EnFazlaStok();
            EnAzStok();
            EnCokSatan();
            EnAzSatan();
            KritikUrun();
            UrunSayisiEnFazlaKategori();
            EnPopulerKategori();
        }

        // En az stoğa sahip ürün
        private void EnAzStok()
        {
            labelEnAzStok.Text = (from x in db.TABLE_URUN
                                  orderby x.STOK ascending
                                  select x.URUN_MODEL).FirstOrDefault();
        }

        // En fazla stoğa sahip ürün
        private void EnFazlaStok()
        {
            labelEnFazlaStok.Text = (from x in db.TABLE_URUN
                                     orderby x.STOK descending
                                     select x.URUN_MODEL).FirstOrDefault();
        }

        // En düşük fiyatlı ürün
        private void EnDusukFiyat()
        {
            labelEnDusukFiyat.Text = (from x in db.TABLE_URUN
                                      orderby x.SATIS_FIYAT ascending
                                      select x.URUN_MODEL).FirstOrDefault();
        }

        // En yüksek fiyatlı ürün
        private void EnYuksekFiyat()
        {
            labelEnYuksekFiyat.Text = (from x in db.TABLE_URUN
                                       orderby x.SATIS_FIYAT descending
                                       select x.URUN_MODEL).FirstOrDefault();
        }

        // Mağaza toplam stok miktarı
        private void ToplamStok()
        {
            labelToplamStok.Text = db.TABLE_URUN.Sum(x => x.STOK).ToString();
        }

        // Toplam kategori sayısı
        private void ToplamKategori()
        {
            labelToplamKategori.Text = db.TABLE_KATEGORI.Count().ToString();
        }

        // Toplam ürün sayısı
        private void ToplamUrun()
        {
            labelToplamUrun.Text = db.TABLE_URUN.Count().ToString();
        }

        // Kritik stok miktarında olan ürün sayısı
        private void KritikUrun()
        {
            var kritikUrun = (from x in db.TABLE_URUN
                              where x.DURUM == true
                              select x.URUN_MODEL);

            if (kritikUrun != null) //Eğer kritik durumda bir ürün varsa
            {
                labelKritikUrun.Text = kritikUrun.Count().ToString(); //Etikete atama yapılıyor
            }
            else //Eğer kritik durumda bir ürün yoksa
            {
                labelKritikUrun.Text = "Kritik Ürün Yok"; //Etikete atama yapılıyor
            }
        }

        // Ürün sayısı en fazla olan kategori
        private void UrunSayisiEnFazlaKategori()
        {
            var enFazlaUrunluKategori = (from u in db.TABLE_URUN
                                         join k in db.TABLE_KATEGORI on u.ID equals k.ID
                                         group u by k.KATEGORI_AD into g
                                         orderby g.Count() descending
                                         select g.Key).FirstOrDefault();

            if (enFazlaUrunluKategori != null) // Eğer en fazla ürün içeren bir kategori varsa
            {
                labelUrunKategoriFazla.Text = enFazlaUrunluKategori; // Etikete atama yapılıyor
            }
            else // Eğer en fazla ürün içeren bir kategori yoksa
            {
                labelUrunKategoriFazla.Text = "Herhangi bir kategori bulunamadı."; // Etikete atama yapılıyor
            }

        }

        // En çok satan ürün ve adeti
        private void EnCokSatan()
        {
            var mostSoldProductModel = (from urunHareket in db.TABLE_URUNHAREKET
                                        join urun in db.TABLE_URUN on urunHareket.URUN equals urun.ID
                                        group urunHareket by urun.URUN_MODEL into urunGroup
                                        orderby urunGroup.Count() descending
                                        select new { UrunModel = urunGroup.Key, ToplamSatis = urunGroup.Count() })
                            .FirstOrDefault();

            labelEnCokSatan.Text = mostSoldProductModel.UrunModel + "\nAdet: " + mostSoldProductModel.ToplamSatis;
        }

        // En az satan ürün ve adeti
        private void EnAzSatan()
        {
            var leastSoldProductModel = (from urunHareket in db.TABLE_URUNHAREKET
                                        join urun in db.TABLE_URUN on urunHareket.URUN equals urun.ID
                                        group urunHareket by urun.URUN_MODEL into urunGroup
                                        orderby urunGroup.Count() ascending
                                        select new { UrunModel = urunGroup.Key, ToplamSatis = urunGroup.Count() })
                            .FirstOrDefault();

            labelEnAzSatan.Text = leastSoldProductModel.UrunModel + "\nAdet: " + leastSoldProductModel.ToplamSatis;
        }

        // En popüler kategori
        private void EnPopulerKategori()
        {
            var PopularCategory = (from urunHareket in db.TABLE_URUNHAREKET
                                    join urun in db.TABLE_URUN on urunHareket.URUN equals urun.ID
                                    join kategori in db.TABLE_KATEGORI on urun.KATEGORI equals kategori.ID
                                    group urunHareket by kategori.KATEGORI_AD into kategoriGroup
                                    orderby kategoriGroup.Count() descending
                                    select new { Kategori = kategoriGroup.Key, ToplamSatis = kategoriGroup.Count() })
                        .FirstOrDefault();

            labelEnPopulerKategori.Text = PopularCategory.Kategori + "\nSatış Adeti: " + PopularCategory.ToplamSatis;
        }
    }
}
