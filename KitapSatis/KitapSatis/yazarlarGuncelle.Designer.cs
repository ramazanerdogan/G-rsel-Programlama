﻿namespace KitapSatis
{
    partial class yazarlarGuncelle
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
            this.yazarIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazarAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazarSoyadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazarlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kitapciDataSet = new KitapSatis.KitapciDataSet();
            this.yazarlarTableAdapter = new KitapSatis.KitapciDataSetTableAdapters.YazarlarTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtyazarsoyadi = new System.Windows.Forms.TextBox();
            this.txtaciklama = new System.Windows.Forms.TextBox();
            this.txtyazarAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtSilinecekTurAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazarlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapciDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yazarIDDataGridViewTextBoxColumn,
            this.yazarAdiDataGridViewTextBoxColumn,
            this.yazarSoyadiDataGridViewTextBoxColumn,
            this.aciklamaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.yazarlarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(100, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 145);
            this.dataGridView1.TabIndex = 1;
            // 
            // yazarIDDataGridViewTextBoxColumn
            // 
            this.yazarIDDataGridViewTextBoxColumn.DataPropertyName = "YazarID";
            this.yazarIDDataGridViewTextBoxColumn.HeaderText = "Yazar Numarası";
            this.yazarIDDataGridViewTextBoxColumn.Name = "yazarIDDataGridViewTextBoxColumn";
            this.yazarIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yazarAdiDataGridViewTextBoxColumn
            // 
            this.yazarAdiDataGridViewTextBoxColumn.DataPropertyName = "YazarAdi";
            this.yazarAdiDataGridViewTextBoxColumn.HeaderText = "Yazar Adi";
            this.yazarAdiDataGridViewTextBoxColumn.Name = "yazarAdiDataGridViewTextBoxColumn";
            // 
            // yazarSoyadiDataGridViewTextBoxColumn
            // 
            this.yazarSoyadiDataGridViewTextBoxColumn.DataPropertyName = "YazarSoyadi";
            this.yazarSoyadiDataGridViewTextBoxColumn.HeaderText = "Yazar Soyadi";
            this.yazarSoyadiDataGridViewTextBoxColumn.Name = "yazarSoyadiDataGridViewTextBoxColumn";
            // 
            // aciklamaDataGridViewTextBoxColumn
            // 
            this.aciklamaDataGridViewTextBoxColumn.DataPropertyName = "Aciklama";
            this.aciklamaDataGridViewTextBoxColumn.HeaderText = "Aciklama";
            this.aciklamaDataGridViewTextBoxColumn.Name = "aciklamaDataGridViewTextBoxColumn";
            // 
            // yazarlarBindingSource
            // 
            this.yazarlarBindingSource.DataMember = "Yazarlar";
            this.yazarlarBindingSource.DataSource = this.kitapciDataSet;
            // 
            // kitapciDataSet
            // 
            this.kitapciDataSet.DataSetName = "KitapciDataSet";
            this.kitapciDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yazarlarTableAdapter
            // 
            this.yazarlarTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtyazarsoyadi);
            this.groupBox1.Controls.Add(this.txtaciklama);
            this.groupBox1.Controls.Add(this.txtyazarAdi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(304, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 241);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Güncelleme İşlemleri";
            // 
            // txtyazarsoyadi
            // 
            this.txtyazarsoyadi.Location = new System.Drawing.Point(88, 66);
            this.txtyazarsoyadi.Name = "txtyazarsoyadi";
            this.txtyazarsoyadi.Size = new System.Drawing.Size(136, 20);
            this.txtyazarsoyadi.TabIndex = 23;
            // 
            // txtaciklama
            // 
            this.txtaciklama.Location = new System.Drawing.Point(88, 99);
            this.txtaciklama.Multiline = true;
            this.txtaciklama.Name = "txtaciklama";
            this.txtaciklama.Size = new System.Drawing.Size(136, 83);
            this.txtaciklama.TabIndex = 22;
            // 
            // txtyazarAdi
            // 
            this.txtyazarAdi.Location = new System.Drawing.Point(88, 32);
            this.txtyazarAdi.Name = "txtyazarAdi";
            this.txtyazarAdi.Size = new System.Drawing.Size(136, 20);
            this.txtyazarAdi.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Yazar Soyadı :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Açıklama :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Yazar Adı :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.txtSilinecekTurAdi);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(68, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 143);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Arama İşlemleri";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(45, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "Ara";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // txtSilinecekTurAdi
            // 
            this.txtSilinecekTurAdi.Location = new System.Drawing.Point(53, 61);
            this.txtSilinecekTurAdi.Name = "txtSilinecekTurAdi";
            this.txtSilinecekTurAdi.Size = new System.Drawing.Size(100, 20);
            this.txtSilinecekTurAdi.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Silinicek Yazar Numarasını Adını Girin";
            // 
            // yazarlarGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(691, 447);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "yazarlarGuncelle";
            this.Text = "Yazar Guncelle";
            this.Load += new System.EventHandler(this.YazarlarGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazarlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapciDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private KitapciDataSet kitapciDataSet;
        private System.Windows.Forms.BindingSource yazarlarBindingSource;
        private KitapciDataSetTableAdapters.YazarlarTableAdapter yazarlarTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSilinecekTurAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazarIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazarAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazarSoyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aciklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtyazarsoyadi;
        private System.Windows.Forms.TextBox txtaciklama;
        private System.Windows.Forms.TextBox txtyazarAdi;
    }
}