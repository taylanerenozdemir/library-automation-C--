using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kütüphane_Otomasyonu_Uygulaması.Model
{
    public class Kitap
    {
        public int kitapid;
        public string kitapisim;
        public string kitapyazari;
        public string kitapdili;
        public string yayinevi;
        public string tur;
        public int kitapadet;
        public int sayfasayisi;
        public int basimyili;

        public Kitap()
        {
            
        }
        public Kitap(int kitapid,string kitapisim,string kitapyazar,string kitapdili,string yayinevi,string tur,int adet,int sayfasayisi,int basimyili)
        {
            this.kitapid = kitapid;
            this.kitapisim = kitapisim;
            this.kitapyazari = kitapyazar;
            this.kitapdili = kitapdili;
            this.yayinevi = yayinevi;
            this.tur = tur;
            this.kitapadet = adet;
            this.sayfasayisi = sayfasayisi;
            this.basimyili = basimyili;
        }

        public int GetKitapID()
        {
            return this.kitapid;
        }
        public string GetKitapIsim()
        {
            return this.kitapisim;
        }
        public string GetKitapYazar()
        {
            return this.kitapyazari;
        }
        public string GetKitapDili()
        {
            return this.kitapdili;
        }
        public string GetYayinevi()
        {
            return this.yayinevi;
        }
        public string GetKitapTur()
        {
            return this.kitapyazari;
        }
        public int GetKitapAdet()
        {
            return this.kitapadet;
        }
        public int GetSayfaSayisi()
        {
            return this.sayfasayisi;
        }
        public int GetBasimYili()
        {
            return this.basimyili;
        }

    }
}
