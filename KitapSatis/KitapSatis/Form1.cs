using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitapSatis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            satislar satislar = new satislar();
            satislar.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            yazarlar yazarlar = new yazarlar();
            yazarlar.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            turler turler = new turler();
            turler.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            kitaplar kitaplar = new kitaplar();
            kitaplar.ShowDialog();
        }
    }
}
