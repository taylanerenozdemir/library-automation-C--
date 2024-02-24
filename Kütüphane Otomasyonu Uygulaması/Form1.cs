using Kütüphane_Otomasyonu_Uygulaması.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_Otomasyonu_Uygulaması
{
    public partial class Form1 : Form
    {
        List<Kisi> kisilerim = new List<Kisi>();
        List<Kitap> _kitaplarim= new List<Kitap>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string KullaniciAdi, sifre = "";
            KullaniciAdi = txt_kullaniciadi.Text;
            sifre = txt_sifre.Text;
            bool kontrol = false;

            foreach (Kisi kisi in kisilerim)
            {
                if (KullaniciAdi.ToLower() == kisi.GetKullaniciAdi() && sifre.ToLower() == kisi.GetSifre() && kisi.GetYetki() == "Admin")
                {
                    //admin sayfasına yönlendir
                    AdminSayfasi adminSayfasi = new AdminSayfasi(kisilerim,_kitaplarim);
                    adminSayfasi.Show();
                    this.Hide();
                    kontrol=true;
                    break;
                }
                else if (KullaniciAdi.ToLower() == kisi.GetKullaniciAdi() && sifre.ToLower() == kisi.GetSifre() && kisi.GetYetki() == "Üye")
                {
                    UyeSayfasi uye1 = new UyeSayfasi(_kitaplarim);
                    uye1.Show();
                    this.Hide();
                    kontrol=true;
                    break;
                }
                
            }
            if (!kontrol)
            {
                MessageBox.Show("Hatalı Giriş Yaptınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kisilerim.Add(new Kisi(1, "Eren", "Özdemir", DateTime.Now, "eren", "1", "Admin"));
            kisilerim.Add(new Kisi(2, "Ahmet", "Çakar", DateTime.Now, "ahmet", "2", "Üye"));
            kisilerim.Add(new Kisi(3, "Bilal", "Çamur", DateTime.Now, "bilal", "3", "Üye"));
            kisilerim.Add(new Kisi(4, "Barış", "Gezer", DateTime.Now, "baris", "4", "Üye"));


            _kitaplarim.Add(new Kitap(1, "İçimizdeki Şeytan", "Sabahattin Ali", "Türkçe", "Yapı Kredi Yayınları", "Roman", 100, 250, 2016));
            _kitaplarim.Add(new Kitap(2, "Tutunamayanlar", "Oğuz Atay", "Türkçe", "İletişim Yayıncılık", "Roman", 350, 760, 2015));
            _kitaplarim.Add(new Kitap(3, "Uçurtma Avcısı", "Khaled Hosseini", "İngilizce", "Everest Yayıncılık", "Roman", 100, 350, 2010));
            _kitaplarim.Add(new Kitap(4, "Küçük Prens", "Antoine de Saint-Exupery", "İngilizce", "Can Çocuk Yayınları", "Roman", 50, 60, 2010));
            _kitaplarim.Add(new Kitap(5, "Kürk Mantolu Madonna", "Sabahattin Ali", "Türkçe", "Yapı Kredi Yayınları", "Roman", 80, 220, 2008));
        }
    }
}
