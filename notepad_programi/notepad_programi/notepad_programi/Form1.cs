using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;//dosya okuma ve kaydetme için kullanılacaktır.

namespace notepad_programi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            YaziAlani.Cut();
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YaziAlani.Copy();
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YaziAlani.Paste();
        }

        private void tsbKes_Click(object sender, EventArgs e)
        {
            YaziAlani.Cut();
            tsbYapistir.Enabled = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //form yüklendiğinde yapıştır buyonum pasif olsun
            tsbYapistir.Enabled = false;
            lblNum.Text = Console.NumberLock ? "Numlock Açık" : "Numlock Kapalı ";
            lblCaps.Text = Console.CapsLock ? "Capslock Açık " : "Capslock Kapalı ";
        }

        private void tsbKopyala_Click(object sender, EventArgs e)
        {
            YaziAlani.Copy();
            tsbYapistir.Enabled = true;
        }

        private void tsbYapistir_Click(object sender, EventArgs e)
        {
            YaziAlani.Paste();
        }

        private void tsbGeriAl_Click(object sender, EventArgs e)
        {
            //geri alma işlemi yapar
            YaziAlani.Undo();
        }

        private void tsbİleriAl_Click(object sender, EventArgs e)
        {
            //yenileme işlemi yazı alanı içinde
            //YaziAlani.Redo();
        }

        private void tsbSolaHizala_Click(object sender, EventArgs e)
        {
            //yazıları sola hizalar
            YaziAlani.TextAlign = HorizontalAlignment.Left;
        }

        private void tsbOrtala_Click(object sender, EventArgs e)
        {
            //yazıları ortalar
            YaziAlani.TextAlign = HorizontalAlignment.Center;
        }

        private void tsbSagaHizala_Click(object sender, EventArgs e)
        {
            //yazıları sağa hizalar
            YaziAlani.TextAlign = HorizontalAlignment.Right;
        }

        int sayac = 0;//yazıları büyük küçük yapmak için kullamacagız.
        DialogResult secim = new DialogResult();//dialog butonlarından seçim atamak için kullanacağız.
        string dosya_adi = null;

        private void tsbBuyukHarf_Click(object sender, EventArgs e)
        {
            //yazıları büyük/küçük yap
            string yazi = YaziAlani.Text;
            if (sayac % 2 == 0)
            {
                YaziAlani.Text = yazi.ToLower();
                
            }
            else
            {
                YaziAlani.Text = yazi.ToUpper();
            }
            sayac++;
        }

        private void YaziAlani_KeyDown(object sender, KeyEventArgs e)
        {
            lblNum.Text = Console.NumberLock ? "Numlock Açık" : "Numlock Kapalı";
            lblCaps.Text = Console.CapsLock ? "Capslock Açık" : "Capslock Kapalı";
        }

        private void tsbFont_Click(object sender, EventArgs e)
        {
            secim = fontDialog1.ShowDialog();
            if (secim==DialogResult.OK)
            {
                YaziAlani.Font = fontDialog1.Font;//seçilen fontu yazıya aktardı
            }          
        }

        private void tsbRenkKutusu_Click(object sender, EventArgs e)
        {                                                              
            secim = colorDialog1.ShowDialog();
            if (secim==DialogResult.OK)
            {
                YaziAlani.ForeColor = colorDialog1.Color;
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            YaziAlani.Width = this.Width - 50;
            YaziAlani.Height = this.Height - 70;
        }

        private void tsbYeni_Click(object sender, EventArgs e)
        {
            //kendisinin bir kopyasını oluşturarak açacak

            System.Diagnostics.Process.Start(Application.ProductName);
        }

        private void tsbDosyayiAc_Click(object sender, EventArgs e)
        {
            //dosya açma işlemi yapar.
            secim = openFileDialog1.ShowDialog();
            if (secim==DialogResult.OK)
            {
                //dosya adi seçilen dosya olacak.
                dosya_adi = openFileDialog1.FileName;
                //seçilen dosya ile program arasında bir hat oluşturuyoruz.
                //1254 türkçe karakter kodu.
                StreamReader dosyaOku = new StreamReader(openFileDialog1.FileName, Encoding.GetEncoding(1254));

                //burada dosyayı sonuna kadar okuyoruz.
                YaziAlani.Text = dosyaOku.ReadToEnd();

                //hattı kapatıyoruz.
                dosyaOku.Close();

                //formun başlığına dosya adını ekliyoruz.
                this.Text = "Not Defteri [" + dosya_adi + "]";



            }

        }

        private void tsbKaydet_Click(object sender, EventArgs e)
        {

        }

        private void KaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dosya_adi==null)
            {
                FarklıKaydetToolStripMenuItem_Click(null, null);
            }
            else
            {
                //daha önceden kaydedildiyse o dosyaya ulaşmak gerekiyor.
                //yapılan değişiklikler o dosyanın üzerine yazılacak.
                StreamWriter dosyayolu = new StreamWriter(dosya_adi, false, Encoding.GetEncoding(1254));
                dosyayolu.Write(YaziAlani.Text);
                //kalan bilgi bellekten atıyoruz.
                dosyayolu.Flush();
                //dosya yolunu kapat
                dosyayolu.Close();
               //formun başlığına dosya adına ekleyeceğiz.
                this.Text = "Not Defteri[" + dosya_adi + "]";
                
            }
        }

        private void FarklıKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            secim = saveFileDialog1.ShowDialog();
            if (secim==DialogResult.OK)
            {
                //dosya adı seçilen dosya olacak
                dosya_adi = saveFileDialog1.FileName;

                //kaydetme işlemine git
                KaydetToolStripMenuItem_Click(null, null); 

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            secim = MessageBox.Show("Kaydetmeden Çıkmak İstiyormusunuz.", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (secim==DialogResult.OK)
            {
                Application.Exit();
            }
            else if (secim==DialogResult.No)
            {
                KaydetToolStripMenuItem_Click(null, null);
            }
            else if (secim==DialogResult.Cancel)
            {
                Application.Run();  
            }
            

            
        }

        private void YaziAlani_TextChanged(object sender, EventArgs e)
        {

        }

        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ToolStripSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripSeparator2_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripSeparator3_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripSeparator4_Click(object sender, EventArgs e)
        {

        }

        private void SagTikMenu_Opening(object sender, CancelEventArgs e)
        {

        }

        private void StatusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void LblNum_Click(object sender, EventArgs e)
        {

        }

        private void LblCaps_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void FontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void SaveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
