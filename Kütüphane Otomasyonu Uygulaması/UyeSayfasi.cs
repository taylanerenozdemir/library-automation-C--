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
    public partial class UyeSayfasi : Form
    {
        List<Kitap> kitaplarim;
        public UyeSayfasi(List<Kitap> kitaplarim)
        {
            InitializeComponent();
            this.kitaplarim=kitaplarim;
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            txtkitapidara.Text = null;
            foreach(Kitap kitap in kitaplarim)
            {
                dataGridView1.Rows.Add(kitap.GetKitapID(), kitap.GetKitapIsim(), kitap.GetKitapYazar(), kitap.GetKitapDili(), kitap.GetYayinevi(), kitap.GetKitapTur(), kitap.GetKitapAdet(), kitap.GetSayfaSayisi(), kitap.GetBasimYili());
            }
        }

        private void UyeSayfasi_Load(object sender, EventArgs e)
        {
            foreach(Kitap kitap in kitaplarim)
            {
                dataGridView1.Rows.Add(kitap.GetKitapID(), kitap.GetKitapIsim(), kitap.GetKitapYazar(), kitap.GetKitapDili(), kitap.GetYayinevi(), kitap.GetKitapTur(), kitap.GetKitapAdet(), kitap.GetSayfaSayisi(), kitap.GetBasimYili());
            }
        }

        private void btncikisyap_Click(object sender, EventArgs e)
        {
            Form1 loginsayfasi = new Form1();
            loginsayfasi.Show();
            this.Hide();
            MessageBox.Show("Başarıyla Çıkış Yaptınız!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnkitapara_Click(object sender, EventArgs e)
        {
            int aranankitapid = Convert.ToInt32(txtkitapidara.Text);
            Kitap hedefKitap = null;
            foreach(Kitap kitap in kitaplarim)
            {
                if(kitap.GetKitapID()== aranankitapid)
                {
                    hedefKitap= kitap;
                    break;
                }
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(hedefKitap.GetKitapID(), hedefKitap.GetKitapIsim(), hedefKitap.GetKitapYazar(), hedefKitap.GetKitapDili(), hedefKitap.GetYayinevi(), hedefKitap.GetKitapTur(), hedefKitap.GetKitapAdet(), hedefKitap.GetSayfaSayisi(), hedefKitap.GetBasimYili());
        }
    }
}
