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
    public partial class turlerGuncelle : Form
    {
        public turlerGuncelle()
        {
            InitializeComponent();
        }
        Baglanti bagla = new Baglanti();
        private void TurlerGuncelle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kitapciDataSet.Turler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.turlerTableAdapter.Fill(this.kitapciDataSet.Turler);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            bagla.baglan.Open();
            int TurID = Convert.ToInt32(txtSilinecekTurAdi.Text);
            SqlCommand sorguGuncelle = new SqlCommand("update Turler set TurAdi='" + txtturAdi.Text + "',Aciklama='" + txtaciklama.Text + "' where TurID=" + TurID + "", bagla.baglan);
            sorguGuncelle.ExecuteNonQuery();
            bagla.baglan.Close();
            MessageBox.Show("Kayıt Başarıyla Güncellendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            bagla.baglan.Open();
            int TurID = Convert.ToInt32(txtSilinecekTurAdi.Text);
            SqlCommand sorguAra = new SqlCommand("select count(*) from Turler where TurID=" + TurID + "", bagla.baglan);
            string ara = sorguAra.ExecuteScalar().ToString();
            if (ara == "1")//eğer sonuç 1 se kayıt vardır.
            {
                SqlCommand sorguturadi = new SqlCommand("select TurAdi from Turler where TurID=" + TurID + "", bagla.baglan);
                SqlCommand sorguaciklama = new SqlCommand("select Aciklama from Turler where TurID=" + TurID + "", bagla.baglan);
                txtturAdi.Text = sorguturadi.ExecuteScalar().ToString();
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
