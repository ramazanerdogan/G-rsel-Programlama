namespace KitapSatis
{
    partial class kitaplar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Bilgiler = new System.Windows.Forms.GroupBox();
            this.txtBasimTarihi = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtISBNNO = new System.Windows.Forms.MaskedTextBox();
            this.txtFiyat = new System.Windows.Forms.MaskedTextBox();
            this.txtSayfasayisi = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOzet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Bilgiler.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bilgiler
            // 
            this.Bilgiler.Controls.Add(this.txtBasimTarihi);
            this.Bilgiler.Controls.Add(this.button1);
            this.Bilgiler.Controls.Add(this.txtISBNNO);
            this.Bilgiler.Controls.Add(this.txtFiyat);
            this.Bilgiler.Controls.Add(this.txtSayfasayisi);
            this.Bilgiler.Controls.Add(this.label8);
            this.Bilgiler.Controls.Add(this.label9);
            this.Bilgiler.Controls.Add(this.txtOzet);
            this.Bilgiler.Controls.Add(this.label6);
            this.Bilgiler.Controls.Add(this.label5);
            this.Bilgiler.Controls.Add(this.label4);
            this.Bilgiler.Controls.Add(this.label1);
            this.Bilgiler.Controls.Add(this.txtKitapAdi);
            this.Bilgiler.Location = new System.Drawing.Point(32, 21);
            this.Bilgiler.Name = "Bilgiler";
            this.Bilgiler.Size = new System.Drawing.Size(363, 391);
            this.Bilgiler.TabIndex = 15;
            this.Bilgiler.TabStop = false;
            this.Bilgiler.Text = "Kayit Ekleme:";
            // 
            // txtBasimTarihi
            // 
            this.txtBasimTarihi.Location = new System.Drawing.Point(135, 108);
            this.txtBasimTarihi.Mask = "00/00/0000";
            this.txtBasimTarihi.Name = "txtBasimTarihi";
            this.txtBasimTarihi.Size = new System.Drawing.Size(157, 20);
            this.txtBasimTarihi.TabIndex = 16;
            this.txtBasimTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 49);
            this.button1.TabIndex = 8;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtISBNNO
            // 
            this.txtISBNNO.Location = new System.Drawing.Point(135, 81);
            this.txtISBNNO.Mask = "00000000000";
            this.txtISBNNO.Name = "txtISBNNO";
            this.txtISBNNO.Size = new System.Drawing.Size(157, 20);
            this.txtISBNNO.TabIndex = 4;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(135, 134);
            this.txtFiyat.Mask = "000";
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(157, 20);
            this.txtFiyat.TabIndex = 6;
            // 
            // txtSayfasayisi
            // 
            this.txtSayfasayisi.Location = new System.Drawing.Point(135, 56);
            this.txtSayfasayisi.Mask = "0000";
            this.txtSayfasayisi.Name = "txtSayfasayisi";
            this.txtSayfasayisi.Size = new System.Drawing.Size(157, 20);
            this.txtSayfasayisi.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Özet :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(61, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Fiyat :";
            // 
            // txtOzet
            // 
            this.txtOzet.Location = new System.Drawing.Point(135, 160);
            this.txtOzet.Multiline = true;
            this.txtOzet.Name = "txtOzet";
            this.txtOzet.Size = new System.Drawing.Size(157, 128);
            this.txtOzet.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Basım Tarihi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "ISBNNO :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sayfa Sayisi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kitap Adı :";
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(135, 30);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(157, 20);
            this.txtKitapAdi.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(63, 431);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(307, 49);
            this.button2.TabIndex = 16;
            this.button2.Text = "Kayıt Güncellemek İçin Tıklayınız";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(63, 486);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(307, 49);
            this.button3.TabIndex = 17;
            this.button3.Text = "Kayıt Silmek İçin Tıklayınız";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // kitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(445, 558);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Bilgiler);
            this.Name = "kitaplar";
            this.Text = "Kitap Kayıt";
            this.Bilgiler.ResumeLayout(false);
            this.Bilgiler.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Bilgiler;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox txtISBNNO;
        private System.Windows.Forms.MaskedTextBox txtFiyat;
        private System.Windows.Forms.MaskedTextBox txtSayfasayisi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtOzet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MaskedTextBox txtBasimTarihi;
    }
}