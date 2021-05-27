namespace KitapSatis
{
    partial class SatislarSil
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.satisNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satislarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kitapciDataSet = new KitapSatis.KitapciDataSet();
            this.satislarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.satislarTableAdapter = new KitapSatis.KitapciDataSetTableAdapters.SatislarTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtSilinecekTurAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satislarBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapciDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satislarBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.satisNoDataGridViewTextBoxColumn,
            this.fiyatDataGridViewTextBoxColumn,
            this.satisTarihiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.satislarBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(104, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 143);
            this.dataGridView1.TabIndex = 0;
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
            this.satisTarihiDataGridViewTextBoxColumn.HeaderText = "Satis Tarihi";
            this.satisTarihiDataGridViewTextBoxColumn.Name = "satisTarihiDataGridViewTextBoxColumn";
            // 
            // satislarBindingSource1
            // 
            this.satislarBindingSource1.DataMember = "Satislar";
            this.satislarBindingSource1.DataSource = this.kitapciDataSet;
            // 
            // kitapciDataSet
            // 
            this.kitapciDataSet.DataSetName = "KitapciDataSet";
            this.kitapciDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // satislarBindingSource
            // 
            this.satislarBindingSource.DataMember = "Satislar";
            this.satislarBindingSource.DataSource = this.kitapciDataSet;
            // 
            // satislarTableAdapter
            // 
            this.satislarTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.txtSilinecekTurAdi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(156, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 143);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Silme İşlemleri";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(65, 94);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "Kaydı Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // txtSilinecekTurAdi
            // 
            this.txtSilinecekTurAdi.Location = new System.Drawing.Point(53, 59);
            this.txtSilinecekTurAdi.Name = "txtSilinecekTurAdi";
            this.txtSilinecekTurAdi.Size = new System.Drawing.Size(100, 20);
            this.txtSilinecekTurAdi.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Silinicek Verinin Satis Numarasını bilgisini Girin";
            // 
            // SatislarSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(530, 412);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SatislarSil";
            this.Text = "Satiş Silme Ekranı";
            this.Load += new System.EventHandler(this.SatislarSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satislarBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapciDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satislarBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private KitapciDataSet kitapciDataSet;
        private System.Windows.Forms.BindingSource satislarBindingSource;
        private KitapciDataSetTableAdapters.SatislarTableAdapter satislarTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtSilinecekTurAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource satislarBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisTarihiDataGridViewTextBoxColumn;
    }
}