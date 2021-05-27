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
    public partial class satislarGuncelle : Form
    {
        public satislarGuncelle()
        {
            InitializeComponent();
        }
        Baglanti bagla = new Baglanti();
        private void SatislarGuncelle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kitapciDataSet.Satislar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.satislarTableAdapter.Fill(this.kitapciDataSet.Satislar);
            // TODO: Bu kod satırı 'kitapciDataSet.Turler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.turlerTableAdapter.Fill(this.kitapciDataSet.Turler);

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            bagla.baglan.Open();
            int SatisNo = Convert.ToInt32(txtSilinecekTurAdi.Text);
            SqlCommand sorguAra = new SqlCommand("select count(*) from Satislar where SatisNo=" + SatisNo + "", bagla.baglan);
            string ara = sorguAra.ExecuteScalar().ToString();
            if (ara == "1")//eğer sonuç 1 se kayıt vardır.
            {
                SqlCommand sorgufiyat = new SqlCommand("select Fiyat from Satislar where SatisNo=" + SatisNo + "", bagla.baglan);
                SqlCommand sorgubasimtarihi = new SqlCommand("select SatisTarihi from Satislar where SatisNo=" + SatisNo + "", bagla.baglan);
                txtSatisTarihi.Text = sorgubasimtarihi.ExecuteScalar().ToString();
                txtFiyat.Text = sorgufiyat.ExecuteScalar().ToString();
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
            int SatisNo = Convert.ToInt32(txtSilinecekTurAdi.Text);
            SqlCommand sorguGuncelle = new SqlCommand("update Satislar set Fiyat='" + txtFiyat.Text + "',SatisTarihi='" + txtSatisTarihi.Text.ToString() + "' where SatisNo=" + SatisNo + "", bagla.baglan);
            sorguGuncelle.ExecuteNonQuery();
            bagla.baglan.Close();
            MessageBox.Show("Kayıt Başarıyla Güncellendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
