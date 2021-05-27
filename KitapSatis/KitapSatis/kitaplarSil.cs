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
    public partial class kitaplarSil : Form
    {
        public kitaplarSil()
        {
            InitializeComponent();
        }
        Baglanti bagla = new Baglanti();
        private void KitaplarSil_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kitapciDataSet.Kitaplar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kitaplarTableAdapter.Fill(this.kitapciDataSet.Kitaplar);

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            bagla.baglan.Open();
            int kitapNo = Convert.ToInt32(txtSilinecekTurAdi.Text);
            SqlCommand sorgu = new SqlCommand("delete from Kitaplar where KitapNo=" + kitapNo + "", bagla.baglan);
            SqlCommand sorguAra = new SqlCommand("select count(*) from Kitaplar where KitapNo=" + kitapNo + "", bagla.baglan);
            SqlCommand sorguad = new SqlCommand("select KitapAdi from Kitaplar where KitapNo=" + kitapNo + "", bagla.baglan);
            if (sorguAra.ExecuteScalar().ToString() == "1")//sonuç 1 değeri dönerse kayıt var demektir
            {
                string ad = sorguad.ExecuteScalar().ToString();


                DialogResult secim = new DialogResult();
                secim = MessageBox.Show(ad + " " + " İsimli Kaydı Silmek İstiyormusunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (secim == DialogResult.Yes)
                {
                    sorgu.ExecuteNonQuery();
                    bagla.baglan.Close();
                    MessageBox.Show("Kayıt Başarıyla Silindi");
                }
                else
                {
                    bagla.baglan.Close();
                    MessageBox.Show("Kayıt Silme İptal Edildi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Aradığınız Kayıt Bulunamadı...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bagla.baglan.Close();
            }


        }
    }
}
