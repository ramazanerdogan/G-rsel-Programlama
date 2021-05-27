﻿namespace KitapSatis
{
    partial class turlerSil
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtSilinecekTurAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.turIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kitapciDataSet = new KitapSatis.KitapciDataSet();
            this.turlerTableAdapter = new KitapSatis.KitapciDataSetTableAdapters.TurlerTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapciDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.txtSilinecekTurAdi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(169, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 143);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Silme İşlemleri";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(67, 94);
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
            this.label1.Location = new System.Drawing.Point(46, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Silinicek TurID Adını Girin";
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
            this.dataGridView1.Location = new System.Drawing.Point(111, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 141);
            this.dataGridView1.TabIndex = 2;
            // 
            // turIDDataGridViewTextBoxColumn
            // 
            this.turIDDataGridViewTextBoxColumn.DataPropertyName = "TurID";
            this.turIDDataGridViewTextBoxColumn.HeaderText = "Tur ID";
            this.turIDDataGridViewTextBoxColumn.Name = "turIDDataGridViewTextBoxColumn";
            this.turIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // turAdiDataGridViewTextBoxColumn
            // 
            this.turAdiDataGridViewTextBoxColumn.DataPropertyName = "TurAdi";
            this.turAdiDataGridViewTextBoxColumn.HeaderText = "Tur Adi";
            this.turAdiDataGridViewTextBoxColumn.Name = "turAdiDataGridViewTextBoxColumn";
            // 
            // aciklamaDataGridViewTextBoxColumn
            // 
            this.aciklamaDataGridViewTextBoxColumn.DataPropertyName = "Aciklama";
            this.aciklamaDataGridViewTextBoxColumn.HeaderText = "Açiklama";
            this.aciklamaDataGridViewTextBoxColumn.Name = "aciklamaDataGridViewTextBoxColumn";
            // 
            // turlerBindingSource
            // 
            this.turlerBindingSource.DataMember = "Turler";
            this.turlerBindingSource.DataSource = this.kitapciDataSet;
            // 
            // kitapciDataSet
            // 
            this.kitapciDataSet.DataSetName = "KitapciDataSet";
            this.kitapciDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // turlerTableAdapter
            // 
            this.turlerTableAdapter.ClearBeforeFill = true;
            // 
            // turlerSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(530, 412);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "turlerSil";
            this.Text = "Kitap Türü Sil";
            this.Load += new System.EventHandler(this.TurlerSil_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapciDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtSilinecekTurAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private KitapciDataSet kitapciDataSet;
        private System.Windows.Forms.BindingSource turlerBindingSource;
        private KitapciDataSetTableAdapters.TurlerTableAdapter turlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn turIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aciklamaDataGridViewTextBoxColumn;
    }
}