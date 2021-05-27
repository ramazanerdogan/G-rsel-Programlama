using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace KitapSatis
{
    public partial class yazarlarGuncelle : Form
    {
        public yazarlarGuncelle()
        {
            InitializeComponent();
        }
        Baglanti bagla = new Baglanti();
        private void YazarlarGuncelle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kitapciDataSet.Yazarlar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.yazarlarTableAdapter.Fill(this.kitapciDataSet.Yazarlar);

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            bagla.baglan.Open();
            int YazarID = Convert.ToInt32(txtSilinecekTurAdi.Text);
            SqlCommand sorguGuncelle = new SqlCommand("update Yazarlar set YazarAdi='" + txtyazarAdi.Text + "',YazarSoyadi='" + txtyazarsoyadi.Text + "',Aciklama='" + txtaciklama.Text + "' where YazarID=" + YazarID + "", bagla.baglan);
            sorguGuncelle.ExecuteNonQuery();
            bagla.baglan.Close();
            MessageBox.Show("Kayıt Başarıyla Güncellendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            bagla.baglan.Open();
            int YazarID = Convert.ToInt32(txtSilinecekTurAdi.Text);
            SqlCommand sorguAra = new SqlCommand("select count(*) from Yazarlar where YazarID=" + YazarID + "", bagla.baglan);
            string ara = sorguAra.ExecuteScalar().ToString();
            if (ara == "1")//eğer sonuç 1 se kayıt vardır.
            {
                SqlCommand sorguyazaradi = new SqlCommand("select YazarAdi from Yazarlar where YazarID=" + YazarID + "", bagla.baglan);
                SqlCommand sorguyazarsoyadi = new SqlCommand("select YazarSoyadi from Yazarlar where YazarID=" + YazarID + "", bagla.baglan);
                SqlCommand sorguaciklama = new SqlCommand("select Aciklama from Yazarlar where YazarID=" + YazarID + "", bagla.baglan);
                txtyazarAdi.Text = sorguyazaradi.ExecuteScalar().ToString();
                txtyazarsoyadi.Text = sorguyazarsoyadi.ExecuteScalar().ToString();
                txtaciklama.Text = sorguaciklama.ExecuteScalar().ToString();
                bagla.baglan.Close();
            }
            else
            {
                bagla.baglan.Close();
                MessageBox.Show("Kayıt Bulunamadı");
            }
        }

       
    }
}
