namespace KitapSatis
{
    partial class turlerGuncelle
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
            this.kitapciDataSet = new KitapSatis.KitapciDataSet();
            this.turlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.turlerTableAdapter = new KitapSatis.KitapciDataSetTableAdapters.TurlerTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtSilinecekTurAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtaciklama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtturAdi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.turIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kitapciDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turlerBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // kitapciDataSet
            // 
            this.kitapciDataSet.DataSetName = "KitapciDataSet";
            this.kitapciDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // turlerBindingSource
            // 
            this.turlerBindingSource.DataMember = "Turler";
            this.turlerBindingSource.DataSource = this.kitapciDataSet;
            // 
            // turlerTableAdapter
            // 
            this.turlerTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.txtSilinecekTurAdi);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(58, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 143);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Arama İşlemleri";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(48, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "Ara";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // txtSilinecekTurAdi
            // 
            this.txtSilinecekTurAdi.Location = new System.Drawing.Point(57, 61);
            this.txtSilinecekTurAdi.Name = "txtSilinecekTurAdi";
            this.txtSilinecekTurAdi.Size = new System.Drawing.Size(100, 20);
            this.txtSilinecekTurAdi.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Silinicek Tür Numarasını girin ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtaciklama);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtturAdi);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(295, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 215);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Güncelleme İşlemleri:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(9, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Açıklama";
            // 
            // txtaciklama
            // 
            this.txtaciklama.Location = new System.Drawing.Point(86, 56);
            this.txtaciklama.Multiline = true;
            this.txtaciklama.Name = "txtaciklama";
            this.txtaciklama.Size = new System.Drawing.Size(135, 111);
            this.txtaciklama.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Tür Adı :";
            // 
            // txtturAdi
            // 
            this.txtturAdi.Location = new System.Drawing.Point(86, 23);
            this.txtturAdi.Name = "txtturAdi";
            this.txtturAdi.Size = new System.Drawing.Size(135, 20);
            this.txtturAdi.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.turIDDataGridViewTextBoxColumn,
            this.turAdiDataGridViewTextBoxColumn,
            this.aciklamaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.turlerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(108, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 145);
            this.dataGridView1.TabIndex = 7;
            // 
            // turIDDataGridViewTextBoxColumn
            // 
            this.turIDDataGridViewTextBoxColumn.DataPropertyName = "TurID";
            this.turIDDataGridViewTextBoxColumn.HeaderText = "Tür Numarası";
            this.turIDDataGridViewTextBoxColumn.Name = "turIDDataGridViewTextBoxColumn";
            this.turIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // turAdiDataGridViewTextBoxColumn
            // 
            this.turAdiDataGridViewTextBoxColumn.DataPropertyName = "TurAdi";
            this.turAdiDataGridViewTextBoxColumn.HeaderText = "Tür Adi";
            this.turAdiDataGridViewTextBoxColumn.Name = "turAdiDataGridViewTextBoxColumn";
            // 
            // aciklamaDataGridViewTextBoxColumn
            // 
            this.aciklamaDataGridViewTextBoxColumn.DataPropertyName = "Aciklama";
            this.aciklamaDataGridViewTextBoxColumn.HeaderText = "Açiklama";
            this.aciklamaDataGridViewTextBoxColumn.Name = "aciklamaDataGridViewTextBoxColumn";
            // 
            // turlerGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(604, 440);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "turlerGuncelle";
            this.Text = "Kitap Türü Güncelle";
            this.Load += new System.EventHandler(this.TurlerGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kitapciDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turlerBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private KitapciDataSet kitapciDataSet;
        private System.Windows.Forms.BindingSource turlerBindingSource;
        private KitapciDataSetTableAdapters.TurlerTableAdapter turlerTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtSilinecekTurAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn turIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aciklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtaciklama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtturAdi;
    }
}