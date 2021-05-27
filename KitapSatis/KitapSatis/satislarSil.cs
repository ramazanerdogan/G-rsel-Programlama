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
    public partial class SatislarSil : Form
    {
        public SatislarSil()
        {
            InitializeComponent();
        }
        Baglanti bagla = new Baglanti();
        private void SatislarSil_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kitapciDataSet.Satislar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.satislarTableAdapter.Fill(this.kitapciDataSet.Satislar);

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            bagla.baglan.Open();
            int SatisNo = Convert.ToInt32(txtSilinecekTurAdi.Text);
            SqlCommand sorgu = new SqlCommand("delete from Satislar where SatisNo=" + SatisNo + "", bagla.baglan);
            SqlCommand sorguAra = new SqlCommand("select count(*) from Satislar where SatisNo=" + SatisNo + "", bagla.baglan);
            SqlCommand sorguad = new SqlCommand("select SatisNo from Satislar where SatisNo=" + SatisNo + "", bagla.baglan);
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
