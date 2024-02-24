using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kütüphane_Otomasyonu_Uygulaması.Model
{
    public class Kisi
    {
        public int id;
        public string isim;
        public string soyisim;
        public DateTime olusturmatarih;
        public string kullaniciadi;
        public string sifre;
        public string yetki;

        public Kisi()
        {
            
        }
        public Kisi(int id,string isim,string soyisim,DateTime olusturmatarih,string kullaniciadi,string kullanicisifre,string yetki)
        {
            this.id = id;
            this.isim = isim;
            this.soyisim = soyisim;
            this.olusturmatarih = olusturmatarih;
            this.kullaniciadi = kullaniciadi;
            this.kullaniciadi = kullaniciadi;
            this.sifre = kullanicisifre;
            this.yetki=yetki;

        }
        public void SetID(int id)
        {
            this.id = id;
        }
        public int GetID()
        {
           return this.id;
        }
        public void SetIsim(string isim)
        {
            this.isim=isim;
        }
        public string GetIsim()
        {
            return this.isim;
        }
        public void SetSoyisim(string soyisim)
        {
            this.soyisim=soyisim;
        }
        public string GetSoyisim()
        {
            return this.soyisim;
        }
        public void SetOlusturmaTarih(DateTime olusturmaTarih)
        {
            this.olusturmatarih=olusturmaTarih;
        }
        public DateTime GetOlusturmaTarih()
        {
            return this.olusturmatarih;
        }
        public void SetKullaniciAdi(string kullaniciadi)
        {
            this.kullaniciadi = kullaniciadi;
        }
        public string GetKullaniciAdi()
        {
            return this.kullaniciadi;
        }
        public void SetSifre(string sifre)
        {
            this.sifre = sifre;
        }
        public string GetSifre()
        {
            return this.sifre;
        }
        public void SetYetki(string yetki)
        {
            this.yetki = yetki;
        }
        public string GetYetki()
        {
            return this.yetki;
        }
        public override string ToString()
        {
            return "İsim - Soyisim: " + this.isim + " " + this.soyisim;
        }

    }
}
