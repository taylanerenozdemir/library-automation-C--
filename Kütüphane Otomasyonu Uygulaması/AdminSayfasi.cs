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
    public partial class AdminSayfasi : Form
    {
        List<Kisi> _kisilerim;
        List<Kitap> kitaplarim;
        
        public AdminSayfasi(List<Kisi> data,List<Kitap>kitapdata)
        {
            InitializeComponent();
            this._kisilerim = data;
            this.kitaplarim=kitapdata;
        }
        private void AdminSayfasi_Load(object sender, EventArgs e)
        {
            foreach (Kisi kisi in _kisilerim)
            {
                dataGridView1.Rows.Add(kisi.GetID(), kisi.GetIsim(), kisi.GetSoyisim(), kisi.GetOlusturmaTarih(), kisi.GetKullaniciAdi(), kisi.GetSifre(), kisi.GetYetki());
            }
            foreach(Kitap kitap in kitaplarim)
            {
                dataGridView4.Rows.Add(kitap.GetKitapID(), kitap.GetKitapIsim(), kitap.GetKitapYazar(), kitap.GetKitapDili(), kitap.GetYayinevi(), kitap.GetKitapTur(), kitap.GetKitapAdet(), kitap.GetSayfaSayisi(), kitap.GetBasimYili());
            }
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(Convert.ToInt32(txtid.Text), txtisim.Text, txtsoyisim.Text, txttarih.Text, txtkullaniciadi.Text, txtsifre.Text, txtyetki.Text);
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }

        public void TextleriDoldur()
        {
            txtid.Text = (dataGridView1.CurrentRow.Cells[0].Value.ToString());
            txtisim.Text = (dataGridView1.CurrentRow.Cells[1].Value.ToString());
            txtsoyisim.Text = (dataGridView1.CurrentRow.Cells[2].Value.ToString());
            txttarih.Text = (dataGridView1.CurrentRow.Cells[3].Value.ToString());
            txtkullaniciadi.Text = (dataGridView1.CurrentRow.Cells[0].Value.ToString());
            txtsifre.Text = (dataGridView1.CurrentRow.Cells[0].Value.ToString());
            txtyetki.Text = (dataGridView1.CurrentRow.Cells[0].Value.ToString());
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TextleriDoldur();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            string id = txtid.Text;
            string isim = txtisim.Text;
            string soyisim= txtsoyisim.Text;
            string tarih = txttarih.Text;
            string kullaniciadi=txtkullaniciadi.Text;
            string sifre=txtsifre.Text;
            string yetki=txtyetki.Text;

            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            dataGridView1.Rows.Add(id, isim, soyisim, tarih, kullaniciadi, sifre, yetki);
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < groupboxuyeislemleri.Controls.Count; i++)
            {
                if (groupboxuyeislemleri.Controls[i] is TextBox || groupboxuyeislemleri.Controls[i] is MaskedTextBox)
                {
                    groupboxuyeislemleri.Controls[i].Text=string.Empty;
                }
            }
        }

        private void btnkitapekle_Click(object sender, EventArgs e)
        {
            dataGridView4.Rows.Add(txtkitapid.Text, txtkitapisim.Text, txtkitapyazar.Text, txtdil.Text, txtyayinevi.Text, txttur.Text, txtadet.Text, txtsayfasayisi.Text,txtbasimyili.Text);
        }

        private void btnkitapsil_Click(object sender, EventArgs e)
        {
            dataGridView4.Rows.Remove(dataGridView4.CurrentRow);
        }

        private void btnkitapguncelle_Click(object sender, EventArgs e)
        {
            int kitapid = Convert.ToInt32(txtkitapid.Text);
            string kitapisim= txtkitapisim.Text;
            string kitapyazar = txtkitapyazar.Text;
            string dil= txtdil.Text;
            string yayinevi= txtyayinevi.Text;
            string tur= txttur.Text;
            string adet= txtadet.Text;
            string sayfasayisi= txtsayfasayisi.Text;
            string basimyili= txtbasimyili.Text;

            dataGridView4.Rows.Remove(dataGridView4.CurrentRow);
            dataGridView4.Rows.Add(kitapid, kitapisim, kitapyazar, dil, yayinevi, tur, adet, sayfasayisi, basimyili);
        }

        private void btnkitaptemizle_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < kitapislemleri.Controls.Count; i++)
            {
                if (kitapislemleri.Controls[i] is TextBox)
                {
                    kitapislemleri.Controls[i].Text=string.Empty;
                }
            }
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtkitapid.Text = dataGridView4.CurrentRow.Cells[0].Value.ToString();
            txtkitapisim.Text = dataGridView4.CurrentRow.Cells[1].Value.ToString();
            txtkitapyazar.Text = dataGridView4.CurrentRow.Cells[2].Value.ToString();
            txtdil.Text = dataGridView4.CurrentRow.Cells[3].Value.ToString();
            txtyayinevi.Text = dataGridView4.CurrentRow.Cells[4].Value.ToString();
            txttur.Text = dataGridView4.CurrentRow.Cells[5].Value.ToString();
            txtadet.Text = dataGridView4.CurrentRow.Cells[6].Value.ToString();
            txtsayfasayisi.Text = dataGridView4.CurrentRow.Cells[7].Value.ToString();
            txtbasimyili.Text = dataGridView4.CurrentRow.Cells[8].Value.ToString();
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            Kisi hedefkisi = null;
            int secilenkisiID = Convert.ToInt32(txtaranankisiID.Text);

            foreach(Kisi kisi in _kisilerim)
            {
                if (kisi.GetID() == secilenkisiID)
                {
                    hedefkisi=kisi;
                    break;
                }
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(hedefkisi.GetID(), hedefkisi.GetIsim(), hedefkisi.GetSoyisim(), hedefkisi.GetOlusturmaTarih(), hedefkisi.GetKullaniciAdi(), hedefkisi.GetSifre(), hedefkisi.GetYetki());
        }

        private void btnaranantemizle_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (Kisi hedefkisi in _kisilerim)
            {         
                dataGridView1.Rows.Add(hedefkisi.GetID(), hedefkisi.GetIsim(), hedefkisi.GetSoyisim(), hedefkisi.GetOlusturmaTarih(), hedefkisi.GetKullaniciAdi(), hedefkisi.GetSifre(), hedefkisi.GetYetki());
            }
        }

        private void btnkitapara_Click(object sender, EventArgs e)
        {
            Kitap hedefkitap = null;
            int _kitapid_ = Convert.ToInt32(txtaranankitap.Text);
            foreach(Kitap kitap in kitaplarim)
            {
                if (kitap.GetKitapID() == _kitapid_)
                {
                    hedefkitap = kitap;
                }
            }
            dataGridView4.Rows.Clear();
            dataGridView4.Rows.Add(hedefkitap.GetKitapID(), hedefkitap.GetKitapIsim(), hedefkitap.GetKitapYazar(), hedefkitap.GetKitapDili(), hedefkitap.GetYayinevi(), hedefkitap.GetKitapTur(), hedefkitap.GetKitapAdet(), hedefkitap.GetSayfaSayisi(), hedefkitap.GetBasimYili());
        }

        private void btnaranankitaptemizle_Click(object sender, EventArgs e)
        {
            dataGridView4.Rows.Clear();
            foreach (Kitap hedefkitap in kitaplarim)
            {
                dataGridView4.Rows.Add(hedefkitap.GetKitapID(), hedefkitap.GetKitapIsim(), hedefkitap.GetKitapYazar(), hedefkitap.GetKitapDili(), hedefkitap.GetYayinevi(), hedefkitap.GetKitapTur(), hedefkitap.GetKitapAdet(), hedefkitap.GetSayfaSayisi(), hedefkitap.GetBasimYili());
            }
        }

        private void btn_admincikis_Click(object sender, EventArgs e)
        {
            Form1 loginsayfasi= new Form1();
            loginsayfasi.Show();
            this.Hide();
            MessageBox.Show("Başarıyla Çıkış Yapıldı!","Bilgilendirme",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
