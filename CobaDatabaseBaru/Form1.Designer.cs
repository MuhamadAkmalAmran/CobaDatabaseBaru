﻿
namespace CobaDatabaseBaru
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.prodiTIDataSet = new CobaDatabaseBaru.ProdiTIDataSet();
            this.nilaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nilaiTableAdapter = new CobaDatabaseBaru.ProdiTIDataSetTableAdapters.NilaiTableAdapter();
            this.iDNilaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodeMKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nilaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPeriodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodiTIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nilaiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDNilaiDataGridViewTextBoxColumn,
            this.nIMDataGridViewTextBoxColumn,
            this.kodeMKDataGridViewTextBoxColumn,
            this.nilaiDataGridViewTextBoxColumn,
            this.iDPeriodeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nilaiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(252, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(266, 167);
            this.dataGridView1.TabIndex = 0;
            // 
            // prodiTIDataSet
            // 
            this.prodiTIDataSet.DataSetName = "ProdiTIDataSet";
            this.prodiTIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nilaiBindingSource
            // 
            this.nilaiBindingSource.DataMember = "Nilai";
            this.nilaiBindingSource.DataSource = this.prodiTIDataSet;
            // 
            // nilaiTableAdapter
            // 
            this.nilaiTableAdapter.ClearBeforeFill = true;
            // 
            // iDNilaiDataGridViewTextBoxColumn
            // 
            this.iDNilaiDataGridViewTextBoxColumn.DataPropertyName = "IDNilai";
            this.iDNilaiDataGridViewTextBoxColumn.HeaderText = "IDNilai";
            this.iDNilaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDNilaiDataGridViewTextBoxColumn.Name = "iDNilaiDataGridViewTextBoxColumn";
            this.iDNilaiDataGridViewTextBoxColumn.Width = 125;
            // 
            // nIMDataGridViewTextBoxColumn
            // 
            this.nIMDataGridViewTextBoxColumn.DataPropertyName = "NIM";
            this.nIMDataGridViewTextBoxColumn.HeaderText = "NIM";
            this.nIMDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nIMDataGridViewTextBoxColumn.Name = "nIMDataGridViewTextBoxColumn";
            this.nIMDataGridViewTextBoxColumn.Width = 125;
            // 
            // kodeMKDataGridViewTextBoxColumn
            // 
            this.kodeMKDataGridViewTextBoxColumn.DataPropertyName = "KodeMK";
            this.kodeMKDataGridViewTextBoxColumn.HeaderText = "KodeMK";
            this.kodeMKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodeMKDataGridViewTextBoxColumn.Name = "kodeMKDataGridViewTextBoxColumn";
            this.kodeMKDataGridViewTextBoxColumn.Width = 125;
            // 
            // nilaiDataGridViewTextBoxColumn
            // 
            this.nilaiDataGridViewTextBoxColumn.DataPropertyName = "Nilai";
            this.nilaiDataGridViewTextBoxColumn.HeaderText = "Nilai";
            this.nilaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nilaiDataGridViewTextBoxColumn.Name = "nilaiDataGridViewTextBoxColumn";
            this.nilaiDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDPeriodeDataGridViewTextBoxColumn
            // 
            this.iDPeriodeDataGridViewTextBoxColumn.DataPropertyName = "IDPeriode";
            this.iDPeriodeDataGridViewTextBoxColumn.HeaderText = "IDPeriode";
            this.iDPeriodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDPeriodeDataGridViewTextBoxColumn.Name = "iDPeriodeDataGridViewTextBoxColumn";
            this.iDPeriodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodiTIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nilaiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ProdiTIDataSet prodiTIDataSet;
        private System.Windows.Forms.BindingSource nilaiBindingSource;
        private ProdiTIDataSetTableAdapters.NilaiTableAdapter nilaiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDNilaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeMKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nilaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPeriodeDataGridViewTextBoxColumn;
    }
}

