
using System;

namespace WindowsFormsApp2
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.kodBox1 = new System.Windows.Forms.TextBox();
            this.ogretmenadBox2 = new System.Windows.Forms.TextBox();
            this.soyadbox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ogretmenBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.oKULDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oKULDataSet = new WindowsFormsApp2.OKULDataSet();
            this.dersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dersIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogretmenAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogretmenSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullanıcıKodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogretmenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.ogretmenTableAdapter = new WindowsFormsApp2.OKULDataSetTableAdapters.OgretmenTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.idBox1 = new System.Windows.Forms.ComboBox();
            this.ogretmenBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ogretmenBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dersTableAdapter = new WindowsFormsApp2.OKULDataSetTableAdapters.DersTableAdapter();
            this.fillBy4ToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillBy4ToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.ogretmenBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oKULDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oKULDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogretmenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogretmenBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogretmenBindingSource3)).BeginInit();
            this.fillBy4ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(529, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(715, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // kodBox1
            // 
            this.kodBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kodBox1.Location = new System.Drawing.Point(229, 215);
            this.kodBox1.Name = "kodBox1";
            this.kodBox1.Size = new System.Drawing.Size(273, 35);
            this.kodBox1.TabIndex = 2;
            // 
            // ogretmenadBox2
            // 
            this.ogretmenadBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogretmenadBox2.Location = new System.Drawing.Point(229, 55);
            this.ogretmenadBox2.Name = "ogretmenadBox2";
            this.ogretmenadBox2.Size = new System.Drawing.Size(273, 35);
            this.ogretmenadBox2.TabIndex = 3;
            // 
            // soyadbox3
            // 
            this.soyadbox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soyadbox3.Location = new System.Drawing.Point(229, 110);
            this.soyadbox3.Name = "soyadbox3";
            this.soyadbox3.Size = new System.Drawing.Size(273, 35);
            this.soyadbox3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(37, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Öğretmen Ad";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(31, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Öğretmen Soyad";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 8;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(37, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kullanıcı Kodu";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ogretmenBindingSource1, "DersId", true));
            this.comboBox1.DataSource = this.dersBindingSource;
            this.comboBox1.DisplayMember = "DersAd";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(229, 163);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(273, 37);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.ValueMember = "DersId";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ogretmenBindingSource1
            // 
            this.ogretmenBindingSource1.DataMember = "Ogretmen";
            this.ogretmenBindingSource1.DataSource = this.oKULDataSetBindingSource;
            // 
            // oKULDataSetBindingSource
            // 
            this.oKULDataSetBindingSource.DataSource = this.oKULDataSet;
            this.oKULDataSetBindingSource.Position = 0;
            // 
            // oKULDataSet
            // 
            this.oKULDataSet.DataSetName = "OKULDataSet";
            this.oKULDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dersBindingSource
            // 
            this.dersBindingSource.DataMember = "Ders";
            this.dersBindingSource.DataSource = this.oKULDataSetBindingSource;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(37, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Verdiği Ders";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Pink;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.dersIdDataGridViewTextBoxColumn,
            this.ogretmenAdDataGridViewTextBoxColumn,
            this.ogretmenSoyadDataGridViewTextBoxColumn,
            this.kullanıcıKodDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ogretmenBindingSource1;
            this.dataGridView1.GridColor = System.Drawing.Color.HotPink;
            this.dataGridView1.Location = new System.Drawing.Point(42, 262);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(546, 192);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dersIdDataGridViewTextBoxColumn
            // 
            this.dersIdDataGridViewTextBoxColumn.DataPropertyName = "DersId";
            this.dersIdDataGridViewTextBoxColumn.HeaderText = "DersId";
            this.dersIdDataGridViewTextBoxColumn.Name = "dersIdDataGridViewTextBoxColumn";
            // 
            // ogretmenAdDataGridViewTextBoxColumn
            // 
            this.ogretmenAdDataGridViewTextBoxColumn.DataPropertyName = "OgretmenAd";
            this.ogretmenAdDataGridViewTextBoxColumn.HeaderText = "OgretmenAd";
            this.ogretmenAdDataGridViewTextBoxColumn.Name = "ogretmenAdDataGridViewTextBoxColumn";
            // 
            // ogretmenSoyadDataGridViewTextBoxColumn
            // 
            this.ogretmenSoyadDataGridViewTextBoxColumn.DataPropertyName = "OgretmenSoyad";
            this.ogretmenSoyadDataGridViewTextBoxColumn.HeaderText = "OgretmenSoyad";
            this.ogretmenSoyadDataGridViewTextBoxColumn.Name = "ogretmenSoyadDataGridViewTextBoxColumn";
            // 
            // kullanıcıKodDataGridViewTextBoxColumn
            // 
            this.kullanıcıKodDataGridViewTextBoxColumn.DataPropertyName = "KullanıcıKod";
            this.kullanıcıKodDataGridViewTextBoxColumn.HeaderText = "KullanıcıKod";
            this.kullanıcıKodDataGridViewTextBoxColumn.Name = "kullanıcıKodDataGridViewTextBoxColumn";
            // 
            // ogretmenBindingSource
            // 
            this.ogretmenBindingSource.DataMember = "Ogretmen";
            this.ogretmenBindingSource.DataSource = this.oKULDataSetBindingSource;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LemonChiffon;
            this.button3.ForeColor = System.Drawing.Color.Fuchsia;
            this.button3.Location = new System.Drawing.Point(715, 55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 37);
            this.button3.TabIndex = 13;
            this.button3.Text = "Güncelle";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ogretmenTableAdapter
            // 
            this.ogretmenTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(700, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Id sayısına göre";
            // 
            // idBox1
            // 
            this.idBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ogretmenBindingSource1, "Id", true));
            this.idBox1.DataSource = this.ogretmenBindingSource2;
            this.idBox1.DisplayMember = "Id";
            this.idBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.idBox1.FormattingEnabled = true;
            this.idBox1.Location = new System.Drawing.Point(715, 102);
            this.idBox1.Name = "idBox1";
            this.idBox1.Size = new System.Drawing.Size(104, 32);
            this.idBox1.TabIndex = 16;
            this.idBox1.ValueMember = "Id";
            // 
            // ogretmenBindingSource2
            // 
            this.ogretmenBindingSource2.DataMember = "Ogretmen";
            this.ogretmenBindingSource2.DataSource = this.oKULDataSetBindingSource;
            // 
            // ogretmenBindingSource3
            // 
            this.ogretmenBindingSource3.DataMember = "Ogretmen";
            this.ogretmenBindingSource3.DataSource = this.oKULDataSetBindingSource;
            // 
            // dersTableAdapter
            // 
            this.dersTableAdapter.ClearBeforeFill = true;
            // 
            // fillBy4ToolStrip
            // 
            this.fillBy4ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillBy4ToolStripButton});
            this.fillBy4ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy4ToolStrip.Name = "fillBy4ToolStrip";
            this.fillBy4ToolStrip.Size = new System.Drawing.Size(839, 25);
            this.fillBy4ToolStrip.TabIndex = 17;
            this.fillBy4ToolStrip.Text = "fillBy4ToolStrip";
            // 
            // fillBy4ToolStripButton
            // 
            this.fillBy4ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy4ToolStripButton.Name = "fillBy4ToolStripButton";
            this.fillBy4ToolStripButton.Size = new System.Drawing.Size(45, 22);
            this.fillBy4ToolStripButton.Text = "FillBy4";
            this.fillBy4ToolStripButton.Click += new System.EventHandler(this.fillBy4ToolStripButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(839, 474);
            this.Controls.Add(this.fillBy4ToolStrip);
            this.Controls.Add(this.idBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.soyadbox3);
            this.Controls.Add(this.ogretmenadBox2);
            this.Controls.Add(this.kodBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ogretmenBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oKULDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oKULDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogretmenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogretmenBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogretmenBindingSource3)).EndInit();
            this.fillBy4ToolStrip.ResumeLayout(false);
            this.fillBy4ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox kodBox1;
        private System.Windows.Forms.TextBox ogretmenadBox2;
        private System.Windows.Forms.TextBox soyadbox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource oKULDataSetBindingSource;
        private OKULDataSet oKULDataSet;
        private System.Windows.Forms.BindingSource ogretmenBindingSource;
        private OKULDataSetTableAdapters.OgretmenTableAdapter ogretmenTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogretmenAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogretmenSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullanıcıKodDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ogretmenBindingSource1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox idBox1;
        private System.Windows.Forms.BindingSource ogretmenBindingSource2;
        private System.Windows.Forms.BindingSource ogretmenBindingSource3;
        private System.Windows.Forms.BindingSource dersBindingSource;
        private OKULDataSetTableAdapters.DersTableAdapter dersTableAdapter;
        private System.Windows.Forms.ToolStrip fillBy4ToolStrip;
        private System.Windows.Forms.ToolStripButton fillBy4ToolStripButton;
    }
}
