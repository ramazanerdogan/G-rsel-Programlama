namespace KitapSatis
{
    partial class satislar
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Bilgiler = new System.Windows.Forms.GroupBox();
            this.txtFiyat = new System.Windows.Forms.MaskedTextBox();
            this.txtSatisTarihi = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Bilgiler.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(62, 388);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(307, 49);
            this.button3.TabIndex = 20;
            this.button3.Text = "Kayıt Silmek İçin Tıklayınız";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(62, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(307, 49);
            this.button2.TabIndex = 19;
            this.button2.Text = "Kayıt Güncellemek İçin Tıklayınız";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Bilgiler
            // 
            this.Bilgiler.Controls.Add(this.txtFiyat);
            this.Bilgiler.Controls.Add(this.txtSatisTarihi);
            this.Bilgiler.Controls.Add(this.button1);
            this.Bilgiler.Controls.Add(this.label8);
            this.Bilgiler.Controls.Add(this.label1);
            this.Bilgiler.Location = new System.Drawing.Point(30, 21);
            this.Bilgiler.Name = "Bilgiler";
            this.Bilgiler.Size = new System.Drawing.Size(355, 286);
            this.Bilgiler.TabIndex = 18;
            this.Bilgiler.TabStop = false;
            this.Bilgiler.Text = "Kayıt Ekleme :";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(111, 71);
            this.txtFiyat.Mask = "000";
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(157, 20);
            this.txtFiyat.TabIndex = 18;
            // 
            // txtSatisTarihi
            // 
            this.txtSatisTarihi.Location = new System.Drawing.Point(111, 109);
            this.txtSatisTarihi.Mask = "00/00/0000";
            this.txtSatisTarihi.Name = "txtSatisTarihi";
            this.txtSatisTarihi.Size = new System.Drawing.Size(157, 20);
            this.txtSatisTarihi.TabIndex = 17;
            this.txtSatisTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 60);
            this.button1.TabIndex = 8;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Satış Tarihi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fiyat :";
            // 
            // satislar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(433, 477);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Bilgiler);
            this.Name = "satislar";
            this.Text = "Satiş Yap";
            this.Bilgiler.ResumeLayout(false);
            this.Bilgiler.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox Bilgiler;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtSatisTarihi;
        private System.Windows.Forms.MaskedTextBox txtFiyat;
    }
}