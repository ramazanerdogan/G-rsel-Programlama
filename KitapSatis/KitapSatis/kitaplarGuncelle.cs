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
    public partial class kitaplarGuncelle : Form
    {
        Baglanti bagla = new Baglanti();
        public kitaplarGuncelle()
        {
            InitializeComponent();
        }

        private void KitaplarGuncelle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kitapciDataSet.Kitaplar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kitaplarTableAdapter.Fill(this.kitapciDataSet.Kitaplar);

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            bagla.baglan.Open();
            int kitapNo = Convert.ToInt32(txtSilinecekTurAdi.Text);
            SqlCommand sorguAra = new SqlCommand("select count(*) from Kitaplar where KitapNo=" + kitapNo + "", bagla.baglan);
            string ara = sorguAra.ExecuteScalar().ToString();
            if (ara == "1")//eğer sonuç 1 se kayıt vardır.
            {
                SqlCommand sorgukitapadi = new SqlCommand("select KitapAdi from Kitaplar where KitapNo=" + kitapNo + "", bagla.baglan);
                SqlCommand sorgusayfasayisi = new SqlCommand("select SayfaSayisi from Kitaplar where KitapNo=" + kitapNo + "", bagla.baglan);
                SqlCommand soguISBNNO = new SqlCommand("select ISBNNO from Kitaplar where KitapNo=" + kitapNo + "", bagla.baglan);
                SqlCommand sorgubasimtarihi = new SqlCommand("select BasimTarihi from Kitaplar where KitapNo=" + kitapNo + "", bagla.baglan);
                SqlCommand sorgufiyat = new SqlCommand("select Fiyat from Kitaplar where KitapNo=" + kitapNo + "", bagla.baglan);
                SqlCommand sorguozet = new SqlCommand("select Ozet from Kitaplar where KitapNo=" + kitapNo + "", bagla.baglan);

                txtKitapAdi.Text = sorgukitapadi.ExecuteScalar().ToString();
                txtSayfasayisi.Text = sorgusayfasayisi.ExecuteScalar().ToString();
                txtISBNNO.Text = soguISBNNO.ExecuteScalar().ToString();
                txtBasimTarihi.Text = sorgubasimtarihi.ExecuteScalar().ToString();
                txtFiyat.Text = sorgufiyat.ExecuteScalar().ToString();
                txtOzet.Text= sorguozet.ExecuteScalar().ToString();

                bagla.baglan.Close();
            }
            else
            {
                bagla.baglan.Close();
                MessageBox.Show("Kayıt Bulunamadı");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            bagla.baglan.Open();
            int kitapNo = Convert.ToInt32(txtSilinecekTurAdi.Text);
            SqlCommand sorguGuncelle = new SqlCommand("update Kitaplar set KitapAdi='" + txtKitapAdi.Text + "',SayfaSayisi='" + txtSayfasayisi.Text + "',ISBNNO='" + txtISBNNO.Text + "',BasimTarihi='" + txtBasimTarihi.Text + "',Fiyat='" + txtFiyat.Text + "',Ozet='" + txtOzet.Text + "' where KitapNo=" + kitapNo + "", bagla.baglan);
            sorguGuncelle.ExecuteNonQuery();
            bagla.baglan.Close();
            MessageBox.Show("Kayıt Başarıyla Güncellendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
