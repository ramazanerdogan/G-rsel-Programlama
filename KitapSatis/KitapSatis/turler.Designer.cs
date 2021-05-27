namespace KitapSatis
{
    partial class turler
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
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtaciklama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtturAdi = new System.Windows.Forms.TextBox();
            this.Bilgiler.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(60, 379);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(307, 49);
            this.button3.TabIndex = 23;
            this.button3.Text = "Kayıt Silmek İçin Tıklayınız";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(60, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(307, 49);
            this.button2.TabIndex = 22;
            this.button2.Text = "Kayıt Güncellemek İçin Tıklayınız";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Bilgiler
            // 
            this.Bilgiler.Controls.Add(this.button1);
            this.Bilgiler.Controls.Add(this.label8);
            this.Bilgiler.Controls.Add(this.txtaciklama);
            this.Bilgiler.Controls.Add(this.label1);
            this.Bilgiler.Controls.Add(this.txtturAdi);
            this.Bilgiler.Location = new System.Drawing.Point(28, 12);
            this.Bilgiler.Name = "Bilgiler";
            this.Bilgiler.Size = new System.Drawing.Size(355, 293);
            this.Bilgiler.TabIndex = 21;
            this.Bilgiler.TabStop = false;
            this.Bilgiler.Text = "Kayıt Ekleme :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 49);
            this.button1.TabIndex = 8;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(61, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Açıklama";
            // 
            // txtaciklama
            // 
            this.txtaciklama.Location = new System.Drawing.Point(135, 70);
            this.txtaciklama.Multiline = true;
            this.txtaciklama.Name = "txtaciklama";
            this.txtaciklama.Size = new System.Drawing.Size(157, 128);
            this.txtaciklama.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tür Adı :";
            // 
            // txtturAdi
            // 
            this.txtturAdi.Location = new System.Drawing.Point(135, 30);
            this.txtturAdi.Name = "txtturAdi";
            this.txtturAdi.Size = new System.Drawing.Size(157, 20);
            this.txtturAdi.TabIndex = 0;
            // 
            // turler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(430, 449);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Bilgiler);
            this.Name = "turler";
            this.Text = "Kitap Tür Ekle";
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
        private System.Windows.Forms.TextBox txtaciklama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtturAdi;
    }
}