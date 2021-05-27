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
    public partial class satislar : Form
    {

        Baglanti bagla = new Baglanti();

        public satislar()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            satislarGuncelle satislarguncelle = new satislarGuncelle();
            satislarguncelle.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            SatislarSil satisSil = new SatislarSil();
            satisSil.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            bagla.baglan.Open();
            SqlCommand sorgu = new SqlCommand("insert into Satislar (Fiyat,SatisTarihi) values (@p1,@p2)", bagla.baglan);
            sorgu.Parameters.AddWithValue("@p1", txtFiyat.Text);
            sorgu.Parameters.AddWithValue("@p2", txtSatisTarihi.Text);   
            sorgu.ExecuteNonQuery();
            bagla.baglan.Close();
            MessageBox.Show("Kayıt Başarıyla Eklendi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
