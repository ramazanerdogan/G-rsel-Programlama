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
    public partial class yazarlar : Form
    {
        Baglanti bagla = new Baglanti();
        public yazarlar()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            yazarlarGuncelle yazarGuncelle = new yazarlarGuncelle();
            yazarGuncelle.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            yazarlarSil yazarSil = new yazarlarSil();
            yazarSil.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            bagla.baglan.Open();
            SqlCommand sorgu = new SqlCommand("insert into Yazarlar (YazarAdi,YazarSoyadi,Aciklama) values (@p1,@p2,@p3)", bagla.baglan);
            sorgu.Parameters.AddWithValue("@p1", txtyazarAdi.Text);
            sorgu.Parameters.AddWithValue("@p2", txtyazarsoyadi.Text);
            sorgu.Parameters.AddWithValue("@p3", txtaciklama.Text);
            sorgu.ExecuteNonQuery();
            bagla.baglan.Close();
            MessageBox.Show("Kayıt Başarıyla Eklendi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
