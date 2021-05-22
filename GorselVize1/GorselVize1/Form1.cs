using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace GorselVize1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] menemen = Enumerable.Repeat(0, 6).ToArray();//menemen adında dizi tanımlıyoruz.
        private void button1_Click(object sender, EventArgs e)
        {          
            if (openFileDialog1.ShowDialog() == DialogResult.OK)//open file dialog ile dosyamızı alıyoruz
            {
                // dosya adı seçilen dosya olacak.               
                dosyayolu.Text = openFileDialog1.FileName;//openfiledialog ile alan dosyayı textboxa yazıyoruz
                FileInfo basaksehir = new FileInfo(openFileDialog1.FileName);
                String yol = basaksehir.Name;//dosyanın ismini textboxa yazıyoruz              
            }
            else
            {
                MessageBox.Show("hatalı giriş");
            }           
        }      
        private void button2_Click(object sender, EventArgs e)
        {
            if (dosyayolu.Text == "" )//Dosya yolu boş ise ekrana hata mesajı ersin.
            {
                MessageBox.Show("LÜTFEN DOSYA YOLUNU GİRİN");               
            }            
            else
            {
               if (aranacakkelime.Text == "")//textboxa veri girmediği için hata mesajı yazdırsın.
                {
                    MessageBox.Show("Aranacak Kelime Girmediğiniz için ATOM kelimesi Baz Alınacaktır. ");
                }

                string bulanik, dosyaadi = dosyayolu.Text;//değişken tanımlayıp atama yapıyoruz

                string[] kelimeler = aranacakkelime.Text.Split(',');//kelimeler adında dizi tanımlıyoruz ve textboxdan girilen verinin sadece string kısmını almak için split fonksiyonu kullanıyoruz
                kelimeler[0] = "ATOM";//eğer textboxdan gelmezse bu atamayı yapıyoruz
                ArrayList atomderesi = new ArrayList();
                using (StreamReader dosya = new StreamReader(dosyaadi, Encoding.GetEncoding("iso-8859-9"), false))//streamreader kullanarak dosyayı okuyoruz 
                {
                    while ((bulanik = dosya.ReadLine()) != null)//dosya içini boşalana kadar okuyoruz
                    {

                        for (int i = 0; i < kelimeler.Count(); i++)
                        {
                            string[] kaynak = bulanik.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',', '<', '>', '/', '$', '[', ']', '(', ')', '=' }, StringSplitOptions.RemoveEmptyEntries);// diziden split fonksiyonu ile silme islemleri yapıyoruz
                            var aramasorgusu = from kelime in kaynak where kelime.ToLowerInvariant() == kelimeler[i].ToLowerInvariant() select kelime;//sorgu ile kelimenin doğruluğunu ve sayısını bulamaya çalışıyoruz
                            menemen[i] = menemen[i] + aramasorgusu.Count();     //arama sorgusunun adeti bulunmaktadır.            
                        }

                        if (bulanik.StartsWith("HEADER"))//dosyanın 62 satırında ismi olduğu için substring fonksiyonu ile ismi alıyoruz
                        {
                            string isim = bulanik.Substring(62, 4);
                            textBox3.Text = isim;
                        }
                        if (bulanik.StartsWith("ATOM"))//atom isimli satırları arıyoruz
                        {
                            listBox2.Items.Add(bulanik);//atom isimli satırları yazıyoruz

                            ArrayList alist = new ArrayList();
                            atomderesi.Add(bulanik);//atom isimli satırları arrayliste atıyoruz
                            alist.Add(Convert.ToDouble(bulanik.Substring(31, 7)));//atomun x kordinatını aliste atıyoruz
                            string asayisi = bulanik.Substring(7, 5);
                            textBox4.Text =asayisi+ " Atom bulunur.";// ar
                            double enbuyuksayistanbul;

                            enbuyuksayistanbul = Convert.ToDouble(alist[0]);
                            foreach (double ramazan in alist)//arraylistteki en büyük sayıyı buluyoruz foreach ile 
                            {
                                if (enbuyuksayistanbul<ramazan)
                                {
                                    enbuyuksayistanbul = ramazan;
                                }
                            }
                            foreach (string erdogan in atomderesi)//atom isimli satırlarıdan en büyük x kordinatlı atomun  atom numarasını yazıyoruz
                            {
                                if (Convert.ToDouble(erdogan.Substring(31, 7)) == enbuyuksayistanbul)
                                {
                                    textBox1.Text = erdogan.Substring(7, 5).TrimStart();//atomun atom numarasını yazıyoruz
                                   
                                }
                            }
                            foreach  (string istanbul in atomderesi)
                            {
                                if (Convert.ToDouble(istanbul.Substring(31,7))==enbuyuksayistanbul)// atom isimli satırlarıdan en büyük x kordinatlı atomun ismini yazdırıyoruz.
                                {
                                    textBox2.Text = istanbul.Substring(13, 3).ToString().TrimStart();//atomun ismi 13.indexte bulunmaktadır
                                }
                                
                                
                            }
                            
                        }
                    }
                }
                string bilgi = "";
                for (int i = 0; i < kelimeler.Count(); i++)
                {

                    bilgi = "Aranan Kelime=" + kelimeler[i] + "\n  Kelime Sayisi " + menemen[i];//
                    listBox1.Items.Add(bilgi);//listboxa bilgi yazdırılır.
                  //  textBox4.Text = "  atom bulunur.";// aranan kelimenin kaç adet olduğunu yazdırır.
                }
            }
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void button3_Click(object sender, EventArgs e)
        {                          
        }


    }
}
