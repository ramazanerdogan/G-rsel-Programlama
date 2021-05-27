namespace KitapSatis
{
    partial class satislarGuncelle
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtSilinecekTurAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFiyat = new System.Windows.Forms.MaskedTextBox();
            this.txtSatisTarihi = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.satisNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satislarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kitapciDataSet = new KitapSatis.KitapciDataSet();
            this.turlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.turlerTableAdapter = new KitapSatis.KitapciDataSetTableAdapters.TurlerTableAdapter();
            this.satislarTableAdapter = new KitapSatis.KitapciDataSetTableAdapters.SatislarTableAdapter();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satislarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapciDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turlerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.txtSilinecekTurAdi);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(41, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 143);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Arama İşlemleri";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(48, 99);
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
            this.label4.Location = new System.Drawing.Point(26, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Güncellecek Satis Numarasını  Girin";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFiyat);
            this.groupBox1.Controls.Add(this.txtSatisTarihi);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(277, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 232);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Güncelleme İşlemleri";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(83, 70);
            this.txtFiyat.Mask = "000";
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(157, 20);
            this.txtFiyat.TabIndex = 21;
            // 
            // txtSatisTarihi
            // 
            this.txtSatisTarihi.Location = new System.Drawing.Point(83, 108);
            this.txtSatisTarihi.Mask = "00/00/0000";
            this.txtSatisTarihi.Name = "txtSatisTarihi";
            this.txtSatisTarihi.Size = new System.Drawing.Size(157, 20);
            this.txtSatisTarihi.TabIndex = 20;
            this.txtSatisTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Satış Tarihi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Fiyat :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.satisNoDataGridViewTextBoxColumn,
            this.fiyatDataGridViewTextBoxColumn,
            this.satisTarihiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.satislarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(90, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(346, 153);
            this.dataGridView1.TabIndex = 10;
            // 
            // satisNoDataGridViewTextBoxColumn
            // 
            this.satisNoDataGridViewTextBoxColumn.DataPropertyName = "SatisNo";
            this.satisNoDataGridViewTextBoxColumn.HeaderText = "Satiş Numarası";
            this.satisNoDataGridViewTextBoxColumn.Name = "satisNoDataGridViewTextBoxColumn";
            this.satisNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fiyatDataGridViewTextBoxColumn
            // 
            this.fiyatDataGridViewTextBoxColumn.DataPropertyName = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.HeaderText = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.Name = "fiyatDataGridViewTextBoxColumn";
            // 
            // satisTarihiDataGridViewTextBoxColumn
            // 
            this.satisTarihiDataGridViewTextBoxColumn.DataPropertyName = "SatisTarihi";
            this.satisTarihiDataGridViewTextBoxColumn.HeaderText = "Satiş Tarihi";
            this.satisTarihiDataGridViewTextBoxColumn.Name = "satisTarihiDataGridViewTextBoxColumn";
            // 
            // satislarBindingSource
            // 
            this.satislarBindingSource.DataMember = "Satislar";
            this.satislarBindingSource.DataSource = this.kitapciDataSet;
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
            // satislarTableAdapter
            // 
            this.satislarTableAdapter.ClearBeforeFill = true;
            // 
            // satislarGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(596, 441);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "satislarGuncelle";
            this.Text = "Satış Güncelle";
            this.Load += new System.EventHandler(this.SatislarGuncelle_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satislarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapciDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turlerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtSilinecekTurAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private KitapciDataSet kitapciDataSet;
        private System.Windows.Forms.BindingSource turlerBindingSource;
        private KitapciDataSetTableAdapters.TurlerTableAdapter turlerTableAdapter;
        private System.Windows.Forms.BindingSource satislarBindingSource;
        private KitapciDataSetTableAdapters.SatislarTableAdapter satislarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtFiyat;
        private System.Windows.Forms.MaskedTextBox txtSatisTarihi;
    }
}