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
    public partial class kitaplar : Form
    {

        Baglanti bagla = new Baglanti();
        public kitaplar()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            kitaplarGuncelle kitapGuncelle = new kitaplarGuncelle();
            kitapGuncelle.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            kitaplarSil kitapSil = new kitaplarSil();
            kitapSil.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            bagla.baglan.Open();
            SqlCommand sorgu = new SqlCommand("insert into Kitaplar (KitapAdi,SayfaSayisi,ISBNNO,BasimTarihi,Fiyat,Ozet) values (@p1,@p2,@p3,@p4,@p5,@p6)", bagla.baglan);
            sorgu.Parameters.AddWithValue("@p1", txtKitapAdi.Text);
            sorgu.Parameters.AddWithValue("@p2", txtSayfasayisi.Text);
            sorgu.Parameters.AddWithValue("@p3", txtISBNNO.Text);
            sorgu.Parameters.AddWithValue("@p4", txtBasimTarihi.Text);
            sorgu.Parameters.AddWithValue("@p5", txtFiyat.Text);
            sorgu.Parameters.AddWithValue("@p6", txtOzet.Text);
            sorgu.ExecuteNonQuery();
            bagla.baglan.Close();
            MessageBox.Show("Kayıt Başarıyla Eklendi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
