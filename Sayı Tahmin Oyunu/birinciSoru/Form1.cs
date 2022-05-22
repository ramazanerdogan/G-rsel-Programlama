using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace birinciSoru
{
    public partial class Form1 : Form
    {
        int[] bilgisayarSectigiSayi;//bir dizi değişkeni tanımladık
        public void RastgeleSayiTekirdag()// rastgele sayi için bir fonksiyon yazıyoruz.
        {
            bilgisayarSectigiSayi = new int[4]; //4 basamaklı olacak

            Random rastgele = new Random();
            int rastgeleSayi = rastgele.Next(1023, 9876); //random sayi üretiyoruz
            int sayiBir, sayiIki, sayiUc, sayiDort;
            sayiBir = rastgeleSayi % 10;
            sayiIki = (rastgeleSayi / 10) % 10;
            sayiUc = (rastgeleSayi / 100) % 10;
            sayiDort = (rastgeleSayi / 1000) % 10;
            if (sayiBir != sayiIki && sayiBir != sayiUc && sayiBir != sayiDort && sayiIki != sayiUc && sayiIki != sayiDort && sayiUc != sayiDort)
            {
                
                for (int i = 0; i < 4; i++)
                {
                    
                    bilgisayarSectigiSayi[i] = rastgeleSayi % 10;
                    rastgeleSayi = rastgeleSayi / 10;
                }

            }//buraya kadarki işlemlerde aldığımız sayıyı basamaklara ayırarak tüm sayıların birbirinden farklı gelmesini sağladık
            else
            {
                RastgeleSayiTekirdag();
            }
            


        }
        public Form1()
        {
            InitializeComponent();
        }
        int sayac;// ekrana kaç tahminde bulunduğunu yazmamız için bir sayac tanımladık.
        private void Form1_Load(object sender, EventArgs e)//form açıldığında yapılacak işlemler
        {
            RastgeleSayiTekirdag();//form açıldığında sayı üretilsin istiyoruz.
            textBox3.Text = sayac.ToString();
        }
        
        private void button1_Click(object sender, EventArgs e)//butona bastıkça olacccak işlemler
        {
            sayac++;//butona bastıkça sayacı arttırıcaz.
            textBox3.Text = sayac.ToString();//sayacı yazdırıcaz.


            int i;

            int artiSayiBilgisayarIsmail = 0;
            int eksiSayiBilgisayarEnis = 0;
            int[] tahminHafızaSuleymanpasa = new int[4];//değişkenler tanımladık

            int x = 0;

            while (x < 4)//döngü oluşturduk.Her basamak tahmini için 4.
            {
                x++;
                artiSayiBilgisayarIsmail = 0;
                eksiSayiBilgisayarEnis = 0;//ipucu değişkenleri
                


                int tahminiSayiTekirdagKirazi = Convert.ToInt32(textBox1.Text);//tahmindeki sayılar farklı girilmesi için 
                int kontrolSayisi = tahminiSayiTekirdagKirazi;                 //rastgelle sayıda yaptığımız işlemleri yaparak
                int sayiBir, sayiIki, sayiUc, sayiDort;                        //if else ile kontrol ettirdik.
                sayiBir = kontrolSayisi % 10;
                sayiIki = (kontrolSayisi / 10) % 10;
                sayiUc = (kontrolSayisi / 100) % 10;
                sayiDort = (kontrolSayisi / 1000) % 10;
                if (sayiBir != sayiIki && sayiBir != sayiUc && sayiBir != sayiDort && sayiIki != sayiUc && sayiIki != sayiDort && sayiUc != sayiDort)
                {





                    for (i = 0; i < 4; i++)//basamaklara göre karşılaştırma oyunu yaparak gerekli değişkenleri arttırdık ve azalttık.
                    {
                        tahminHafızaSuleymanpasa[i] = tahminiSayiTekirdagKirazi % 10;

                        tahminiSayiTekirdagKirazi /= 10;

                        bool mevcutRakam = false;//doğru ve yanlış olabilecek bir değişken atadik ve başlangıç yanlış dedik.

                        for (int j = 0; j < 4; j++)
                        {
                            if (tahminHafızaSuleymanpasa[i] == bilgisayarSectigiSayi[j])
                            {
                                mevcutRakam = true;//karşılaştırma sonucu doğru olduğunda döngüden çık
                                break;
                            }
                        }

                        if (mevcutRakam == true)// true olunca gerekli şartlarda ipucu değişkenlerine işlem yaptır.
                        {
                            if (tahminHafızaSuleymanpasa[i] == bilgisayarSectigiSayi[i])
                            {
                                artiSayiBilgisayarIsmail++;
                            }
                            else
                            {
                                eksiSayiBilgisayarEnis++;
                            }
                        }

                    }

                    textBox2.Text = Convert.ToString("+" + artiSayiBilgisayarIsmail + "," + "-" + eksiSayiBilgisayarEnis);//ipuçlarını yazdır.

                    if (artiSayiBilgisayarIsmail == 4)//yani tüm değerler doğru olduğunda kontrol et
                    {
                        textBox4.Text = Convert.ToString("TEBRİKLER...Oyun Bitti...");//oyun bitti bilgisi ver.
                        label6.Text = (sayac.ToString()) + ".Hakta Oyunu Kazandiniz.";// tahmin hakkını ekranda göster.
                        
                    }
                }
                else//tahmindeki sayılar aynı girildiğinde verilecek uyarı mesajı.
                {
                    MessageBox.Show("Lutfen Tahmindeki Tum Sayilari Farkli Giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }

            }

        }

        
    }
}
