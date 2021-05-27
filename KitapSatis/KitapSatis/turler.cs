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
    public partial class turler : Form
    {
        public turler()
        {
            InitializeComponent();
        }
        Baglanti bagla = new Baglanti();
        private void Button2_Click(object sender, EventArgs e)
        {
            turlerGuncelle tur = new turlerGuncelle();
            tur.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            turlerSil turSil = new turlerSil();
            turSil.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            bagla.baglan.Open();
            SqlCommand sorgu = new SqlCommand("insert into Turler (TurAdi,Aciklama) values (@p1,@p2)", bagla.baglan);
            sorgu.Parameters.AddWithValue("@p1", txtturAdi.Text);
            sorgu.Parameters.AddWithValue("@p2", txtaciklama.Text);
            sorgu.ExecuteNonQuery();
            bagla.baglan.Close();
            MessageBox.Show("Kayıt Başarıyla Eklendi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
