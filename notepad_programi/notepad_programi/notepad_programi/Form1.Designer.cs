namespace notepad_programi
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbYeni = new System.Windows.Forms.ToolStripButton();
            this.tsbDosyayiAc = new System.Windows.Forms.ToolStripButton();
            this.tsbKaydet = new System.Windows.Forms.ToolStripDropDownButton();
            this.KaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FarklıKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbKes = new System.Windows.Forms.ToolStripButton();
            this.tsbKopyala = new System.Windows.Forms.ToolStripButton();
            this.tsbYapistir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSolaHizala = new System.Windows.Forms.ToolStripButton();
            this.tsbOrtala = new System.Windows.Forms.ToolStripButton();
            this.tsbSagaHizala = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbFont = new System.Windows.Forms.ToolStripButton();
            this.tsbBuyukHarf = new System.Windows.Forms.ToolStripButton();
            this.tsbRenkKutusu = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbGeriAl = new System.Windows.Forms.ToolStripButton();
            this.tsbİleriAl = new System.Windows.Forms.ToolStripButton();
            this.SagTikMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yapıştırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.YaziAlani = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblNum = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCaps = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1.SuspendLayout();
            this.SagTikMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbYeni,
            this.tsbDosyayiAc,
            this.tsbKaydet,
            this.toolStripSeparator1,
            this.tsbKes,
            this.tsbKopyala,
            this.tsbYapistir,
            this.toolStripSeparator2,
            this.tsbSolaHizala,
            this.tsbOrtala,
            this.tsbSagaHizala,
            this.toolStripSeparator3,
            this.tsbFont,
            this.tsbBuyukHarf,
            this.tsbRenkKutusu,
            this.toolStripSeparator4,
            this.tsbGeriAl,
            this.tsbİleriAl});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(30, 370);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ToolStrip1_ItemClicked);
            // 
            // tsbYeni
            // 
            this.tsbYeni.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbYeni.Image = ((System.Drawing.Image)(resources.GetObject("tsbYeni.Image")));
            this.tsbYeni.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbYeni.Name = "tsbYeni";
            this.tsbYeni.Size = new System.Drawing.Size(27, 20);
            this.tsbYeni.Text = "Yeni";
            this.tsbYeni.ToolTipText = "Yeni";
            this.tsbYeni.Click += new System.EventHandler(this.tsbYeni_Click);
            // 
            // tsbDosyayiAc
            // 
            this.tsbDosyayiAc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDosyayiAc.Image = ((System.Drawing.Image)(resources.GetObject("tsbDosyayiAc.Image")));
            this.tsbDosyayiAc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDosyayiAc.Name = "tsbDosyayiAc";
            this.tsbDosyayiAc.Size = new System.Drawing.Size(27, 20);
            this.tsbDosyayiAc.Text = "Dosya AÇ";
            this.tsbDosyayiAc.ToolTipText = "Dosyayı Aç";
            this.tsbDosyayiAc.Click += new System.EventHandler(this.tsbDosyayiAc_Click);
            // 
            // tsbKaydet
            // 
            this.tsbKaydet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbKaydet.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.KaydetToolStripMenuItem,
            this.FarklıKaydetToolStripMenuItem});
            this.tsbKaydet.Image = ((System.Drawing.Image)(resources.GetObject("tsbKaydet.Image")));
            this.tsbKaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbKaydet.Name = "tsbKaydet";
            this.tsbKaydet.Size = new System.Drawing.Size(27, 20);
            this.tsbKaydet.Text = "toolStripButton3";
            this.tsbKaydet.ToolTipText = "Kaydet";
            this.tsbKaydet.Click += new System.EventHandler(this.tsbKaydet_Click);
            // 
            // KaydetToolStripMenuItem
            // 
            this.KaydetToolStripMenuItem.Name = "KaydetToolStripMenuItem";
            this.KaydetToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.KaydetToolStripMenuItem.Text = "Kaydet";
            this.KaydetToolStripMenuItem.Click += new System.EventHandler(this.KaydetToolStripMenuItem_Click);
            // 
            // FarklıKaydetToolStripMenuItem
            // 
            this.FarklıKaydetToolStripMenuItem.Name = "FarklıKaydetToolStripMenuItem";
            this.FarklıKaydetToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.FarklıKaydetToolStripMenuItem.Text = "Farklı Kaydet";
            this.FarklıKaydetToolStripMenuItem.Click += new System.EventHandler(this.FarklıKaydetToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(27, 6);
            this.toolStripSeparator1.Click += new System.EventHandler(this.ToolStripSeparator1_Click);
            // 
            // tsbKes
            // 
            this.tsbKes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbKes.Image = ((System.Drawing.Image)(resources.GetObject("tsbKes.Image")));
            this.tsbKes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbKes.Name = "tsbKes";
            this.tsbKes.Size = new System.Drawing.Size(27, 20);
            this.tsbKes.Text = "Kes";
            this.tsbKes.Click += new System.EventHandler(this.tsbKes_Click);
            // 
            // tsbKopyala
            // 
            this.tsbKopyala.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbKopyala.Image = ((System.Drawing.Image)(resources.GetObject("tsbKopyala.Image")));
            this.tsbKopyala.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbKopyala.Name = "tsbKopyala";
            this.tsbKopyala.Size = new System.Drawing.Size(27, 20);
            this.tsbKopyala.Text = "toolStripButton2";
            this.tsbKopyala.ToolTipText = "Kopyala";
            this.tsbKopyala.Click += new System.EventHandler(this.tsbKopyala_Click);
            // 
            // tsbYapistir
            // 
            this.tsbYapistir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbYapistir.Image = ((System.Drawing.Image)(resources.GetObject("tsbYapistir.Image")));
            this.tsbYapistir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbYapistir.Name = "tsbYapistir";
            this.tsbYapistir.Size = new System.Drawing.Size(27, 20);
            this.tsbYapistir.Text = "toolStripButton3";
            this.tsbYapistir.ToolTipText = "Yapıştır";
            this.tsbYapistir.Click += new System.EventHandler(this.tsbYapistir_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(27, 6);
            this.toolStripSeparator2.Click += new System.EventHandler(this.ToolStripSeparator2_Click);
            // 
            // tsbSolaHizala
            // 
            this.tsbSolaHizala.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSolaHizala.Image = ((System.Drawing.Image)(resources.GetObject("tsbSolaHizala.Image")));
            this.tsbSolaHizala.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSolaHizala.Name = "tsbSolaHizala";
            this.tsbSolaHizala.Size = new System.Drawing.Size(27, 20);
            this.tsbSolaHizala.Text = "toolStripButton1";
            this.tsbSolaHizala.ToolTipText = "Sola Hizala";
            this.tsbSolaHizala.Click += new System.EventHandler(this.tsbSolaHizala_Click);
            // 
            // tsbOrtala
            // 
            this.tsbOrtala.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbOrtala.Image = ((System.Drawing.Image)(resources.GetObject("tsbOrtala.Image")));
            this.tsbOrtala.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOrtala.Name = "tsbOrtala";
            this.tsbOrtala.Size = new System.Drawing.Size(27, 20);
            this.tsbOrtala.Text = "toolStripButton2";
            this.tsbOrtala.ToolTipText = "Ortala";
            this.tsbOrtala.Click += new System.EventHandler(this.tsbOrtala_Click);
            // 
            // tsbSagaHizala
            // 
            this.tsbSagaHizala.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSagaHizala.Image = ((System.Drawing.Image)(resources.GetObject("tsbSagaHizala.Image")));
            this.tsbSagaHizala.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSagaHizala.Name = "tsbSagaHizala";
            this.tsbSagaHizala.Size = new System.Drawing.Size(27, 20);
            this.tsbSagaHizala.Text = "toolStripButton3";
            this.tsbSagaHizala.ToolTipText = "Sağa Hizala";
            this.tsbSagaHizala.Click += new System.EventHandler(this.tsbSagaHizala_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(27, 6);
            this.toolStripSeparator3.Click += new System.EventHandler(this.ToolStripSeparator3_Click);
            // 
            // tsbFont
            // 
            this.tsbFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFont.Image = ((System.Drawing.Image)(resources.GetObject("tsbFont.Image")));
            this.tsbFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFont.Name = "tsbFont";
            this.tsbFont.Size = new System.Drawing.Size(27, 20);
            this.tsbFont.Text = "Yazı Fontları";
            this.tsbFont.ToolTipText = "Yazı Fontları";
            this.tsbFont.Click += new System.EventHandler(this.tsbFont_Click);
            // 
            // tsbBuyukHarf
            // 
            this.tsbBuyukHarf.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBuyukHarf.Image = ((System.Drawing.Image)(resources.GetObject("tsbBuyukHarf.Image")));
            this.tsbBuyukHarf.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuyukHarf.Name = "tsbBuyukHarf";
            this.tsbBuyukHarf.Size = new System.Drawing.Size(27, 20);
            this.tsbBuyukHarf.Text = "Büyük Harf";
            this.tsbBuyukHarf.Click += new System.EventHandler(this.tsbBuyukHarf_Click);
            // 
            // tsbRenkKutusu
            // 
            this.tsbRenkKutusu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRenkKutusu.Image = ((System.Drawing.Image)(resources.GetObject("tsbRenkKutusu.Image")));
            this.tsbRenkKutusu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRenkKutusu.Name = "tsbRenkKutusu";
            this.tsbRenkKutusu.Size = new System.Drawing.Size(27, 20);
            this.tsbRenkKutusu.Text = "Renk Kutusu";
            this.tsbRenkKutusu.Click += new System.EventHandler(this.tsbRenkKutusu_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(27, 6);
            this.toolStripSeparator4.Click += new System.EventHandler(this.ToolStripSeparator4_Click);
            // 
            // tsbGeriAl
            // 
            this.tsbGeriAl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGeriAl.Image = ((System.Drawing.Image)(resources.GetObject("tsbGeriAl.Image")));
            this.tsbGeriAl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGeriAl.Name = "tsbGeriAl";
            this.tsbGeriAl.Size = new System.Drawing.Size(27, 20);
            this.tsbGeriAl.Text = "Geri Al";
            this.tsbGeriAl.Click += new System.EventHandler(this.tsbGeriAl_Click);
            // 
            // tsbİleriAl
            // 
            this.tsbİleriAl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbİleriAl.Image = ((System.Drawing.Image)(resources.GetObject("tsbİleriAl.Image")));
            this.tsbİleriAl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbİleriAl.Name = "tsbİleriAl";
            this.tsbİleriAl.Size = new System.Drawing.Size(27, 20);
            this.tsbİleriAl.Text = "İleri Al";
            this.tsbİleriAl.Click += new System.EventHandler(this.tsbİleriAl_Click);
            // 
            // SagTikMenu
            // 
            this.SagTikMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kesToolStripMenuItem,
            this.kopyalaToolStripMenuItem,
            this.yapıştırToolStripMenuItem});
            this.SagTikMenu.Name = "SagTikMenu";
            this.SagTikMenu.Size = new System.Drawing.Size(117, 70);
            this.SagTikMenu.Opening += new System.ComponentModel.CancelEventHandler(this.SagTikMenu_Opening);
            // 
            // kesToolStripMenuItem
            // 
            this.kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            this.kesToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.kesToolStripMenuItem.Text = "Kes";
            this.kesToolStripMenuItem.Click += new System.EventHandler(this.kesToolStripMenuItem_Click);
            // 
            // kopyalaToolStripMenuItem
            // 
            this.kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            this.kopyalaToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.kopyalaToolStripMenuItem.Text = "Kopyala";
            this.kopyalaToolStripMenuItem.Click += new System.EventHandler(this.kopyalaToolStripMenuItem_Click);
            // 
            // yapıştırToolStripMenuItem
            // 
            this.yapıştırToolStripMenuItem.Name = "yapıştırToolStripMenuItem";
            this.yapıştırToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.yapıştırToolStripMenuItem.Text = "Yapıştır";
            this.yapıştırToolStripMenuItem.Click += new System.EventHandler(this.yapıştırToolStripMenuItem_Click);
            // 
            // YaziAlani
            // 
            this.YaziAlani.Location = new System.Drawing.Point(33, 0);
            this.YaziAlani.Multiline = true;
            this.YaziAlani.Name = "YaziAlani";
            this.YaziAlani.Size = new System.Drawing.Size(341, 352);
            this.YaziAlani.TabIndex = 1;
            this.YaziAlani.TextChanged += new System.EventHandler(this.YaziAlani_TextChanged);
            this.YaziAlani.KeyDown += new System.Windows.Forms.KeyEventHandler(this.YaziAlani_KeyDown);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblNum,
            this.lblCaps,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(30, 348);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(338, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.StatusStrip1_ItemClicked);
            // 
            // lblNum
            // 
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(56, 17);
            this.lblNum.Text = "Numlock";
            this.lblNum.Click += new System.EventHandler(this.LblNum_Click);
            // 
            // lblCaps
            // 
            this.lblCaps.Name = "lblCaps";
            this.lblCaps.Size = new System.Drawing.Size(55, 17);
            this.lblCaps.Text = "Capslock";
            this.lblCaps.Click += new System.EventHandler(this.LblCaps_Click);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar1.Click += new System.EventHandler(this.ToolStripProgressBar1_Click);
            // 
            // fontDialog1
            // 
            this.fontDialog1.Apply += new System.EventHandler(this.FontDialog1_Apply);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(368, 370);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.YaziAlani);
            this.Name = "Form1";
            this.Text = "NotePad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.SagTikMenu.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbYeni;
        private System.Windows.Forms.ToolStripButton tsbDosyayiAc;
        private System.Windows.Forms.ContextMenuStrip SagTikMenu;
        private System.Windows.Forms.ToolStripMenuItem kesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yapıştırToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbKes;
        private System.Windows.Forms.ToolStripButton tsbKopyala;
        private System.Windows.Forms.ToolStripButton tsbYapistir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbSolaHizala;
        private System.Windows.Forms.ToolStripButton tsbOrtala;
        private System.Windows.Forms.ToolStripButton tsbSagaHizala;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbFont;
        private System.Windows.Forms.ToolStripButton tsbBuyukHarf;
        private System.Windows.Forms.ToolStripButton tsbRenkKutusu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbGeriAl;
        private System.Windows.Forms.ToolStripButton tsbİleriAl;
        private System.Windows.Forms.TextBox YaziAlani;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblNum;
        private System.Windows.Forms.ToolStripStatusLabel lblCaps;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripDropDownButton tsbKaydet;
        private System.Windows.Forms.ToolStripMenuItem KaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FarklıKaydetToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

