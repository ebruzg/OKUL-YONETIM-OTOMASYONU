
using System;

namespace WindowsFormsApp2
{
    partial class VizeGiris
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bolumComboBox = new System.Windows.Forms.ComboBox();
            this.fKBolumDersBolumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bolumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oKULDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oKULDataSet = new WindowsFormsApp2.OKULDataSet();
            this.dersComboBox = new System.Windows.Forms.ComboBox();
            this.dersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oKULDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sinifbox = new System.Windows.Forms.ComboBox();
            this.grupbox = new System.Windows.Forms.ComboBox();
            this.salonBox5 = new System.Windows.Forms.ComboBox();
            this.vizeSinavBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vizeSinavBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.gunBox6 = new System.Windows.Forms.ComboBox();
            this.saatBox7 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumDersIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinifIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salonNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saatNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vizeSinavBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vizeSinavTableAdapter = new WindowsFormsApp2.OKULDataSetTableAdapters.VizeSinavTableAdapter();
            this.fKVizeNotlariVizeSinavBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vizeNotlariTableAdapter = new WindowsFormsApp2.OKULDataSetTableAdapters.VizeNotlariTableAdapter();
            this.bolumTableAdapter = new WindowsFormsApp2.OKULDataSetTableAdapters.BolumTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.idBox2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bolumDersTableAdapter = new WindowsFormsApp2.OKULDataSetTableAdapters.BolumDersTableAdapter();
            this.fillBy1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillBy1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dersTableAdapter = new WindowsFormsApp2.OKULDataSetTableAdapters.DersTableAdapter();
            this.fKVizeNotlariVizeSinavBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKVizeNotlariVizeSinavBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fKBolumDersBolumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oKULDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oKULDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oKULDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vizeSinavBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vizeSinavBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vizeSinavBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKVizeNotlariVizeSinavBindingSource)).BeginInit();
            this.fillBy1ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKVizeNotlariVizeSinavBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKVizeNotlariVizeSinavBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ders";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bölüm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(257, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sınıf";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(257, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Grup";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(446, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Sınav Salonu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(446, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Sınav Saati";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(447, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Sınav Günü";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // bolumComboBox
            // 
            this.bolumComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.fKBolumDersBolumBindingSource, "Id", true));
            this.bolumComboBox.DataSource = this.bolumBindingSource;
            this.bolumComboBox.DisplayMember = "BolumAd";
            this.bolumComboBox.FormattingEnabled = true;
            this.bolumComboBox.Location = new System.Drawing.Point(73, 71);
            this.bolumComboBox.Name = "bolumComboBox";
            this.bolumComboBox.Size = new System.Drawing.Size(117, 21);
            this.bolumComboBox.TabIndex = 9;
            this.bolumComboBox.ValueMember = "Id";
            this.bolumComboBox.SelectedIndexChanged += new System.EventHandler(this.bolumComboBox_SelectedIndexChanged);
            // 
            // fKBolumDersBolumBindingSource
            // 
            this.fKBolumDersBolumBindingSource.DataMember = "FK_BolumDers_Bolum";
            this.fKBolumDersBolumBindingSource.DataSource = this.bolumBindingSource;
            // 
            // bolumBindingSource
            // 
            this.bolumBindingSource.DataMember = "Bolum";
            this.bolumBindingSource.DataSource = this.oKULDataSetBindingSource;
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
            // dersComboBox
            // 
            this.dersComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.fKBolumDersBolumBindingSource, "Id", true));
            this.dersComboBox.DataSource = this.dersBindingSource;
            this.dersComboBox.DisplayMember = "DersAd";
            this.dersComboBox.FormattingEnabled = true;
            this.dersComboBox.Location = new System.Drawing.Point(73, 111);
            this.dersComboBox.Name = "dersComboBox";
            this.dersComboBox.Size = new System.Drawing.Size(117, 21);
            this.dersComboBox.TabIndex = 10;
            this.dersComboBox.ValueMember = "Id";
            // 
            // dersBindingSource
            // 
            this.dersBindingSource.DataMember = "Ders";
            this.dersBindingSource.DataSource = this.oKULDataSetBindingSource1;
            // 
            // oKULDataSetBindingSource1
            // 
            this.oKULDataSetBindingSource1.DataSource = this.oKULDataSet;
            this.oKULDataSetBindingSource1.Position = 0;
            // 
            // sinifbox
            // 
            this.sinifbox.FormattingEnabled = true;
            this.sinifbox.Location = new System.Drawing.Point(313, 39);
            this.sinifbox.Name = "sinifbox";
            this.sinifbox.Size = new System.Drawing.Size(43, 21);
            this.sinifbox.TabIndex = 11;
            // 
            // grupbox
            // 
            this.grupbox.FormattingEnabled = true;
            this.grupbox.Location = new System.Drawing.Point(313, 67);
            this.grupbox.Name = "grupbox";
            this.grupbox.Size = new System.Drawing.Size(43, 21);
            this.grupbox.TabIndex = 12;
            // 
            // salonBox5
            // 
            this.salonBox5.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vizeSinavBindingSource1, "SalonNo", true));
            this.salonBox5.FormattingEnabled = true;
            this.salonBox5.Location = new System.Drawing.Point(551, 100);
            this.salonBox5.Name = "salonBox5";
            this.salonBox5.Size = new System.Drawing.Size(149, 21);
            this.salonBox5.TabIndex = 13;
            // 
            // vizeSinavBindingSource1
            // 
            this.vizeSinavBindingSource1.DataMember = "VizeSinav";
            this.vizeSinavBindingSource1.DataSource = this.oKULDataSetBindingSource;
            // 
            // vizeSinavBindingSource2
            // 
            this.vizeSinavBindingSource2.DataMember = "VizeSinav";
            this.vizeSinavBindingSource2.DataSource = this.oKULDataSetBindingSource;
            // 
            // gunBox6
            // 
            this.gunBox6.FormattingEnabled = true;
            this.gunBox6.Location = new System.Drawing.Point(551, 67);
            this.gunBox6.Name = "gunBox6";
            this.gunBox6.Size = new System.Drawing.Size(149, 21);
            this.gunBox6.TabIndex = 14;
            // 
            // saatBox7
            // 
            this.saatBox7.FormattingEnabled = true;
            this.saatBox7.Location = new System.Drawing.Point(551, 32);
            this.saatBox7.Name = "saatBox7";
            this.saatBox7.Size = new System.Drawing.Size(149, 21);
            this.saatBox7.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(12, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 37);
            this.button1.TabIndex = 16;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Aqua;
            this.button2.Location = new System.Drawing.Point(596, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 37);
            this.button2.TabIndex = 17;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(595, 170);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 37);
            this.button3.TabIndex = 18;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.bolumDersIdDataGridViewTextBoxColumn,
            this.sinifIdDataGridViewTextBoxColumn,
            this.salonNoDataGridViewTextBoxColumn,
            this.gunNoDataGridViewTextBoxColumn,
            this.saatNoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vizeSinavBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 217);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(669, 253);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bolumDersIdDataGridViewTextBoxColumn
            // 
            this.bolumDersIdDataGridViewTextBoxColumn.DataPropertyName = "BolumDersId";
            this.bolumDersIdDataGridViewTextBoxColumn.HeaderText = "BolumDersId";
            this.bolumDersIdDataGridViewTextBoxColumn.Name = "bolumDersIdDataGridViewTextBoxColumn";
            // 
            // sinifIdDataGridViewTextBoxColumn
            // 
            this.sinifIdDataGridViewTextBoxColumn.DataPropertyName = "SinifId";
            this.sinifIdDataGridViewTextBoxColumn.HeaderText = "SinifId";
            this.sinifIdDataGridViewTextBoxColumn.Name = "sinifIdDataGridViewTextBoxColumn";
            // 
            // salonNoDataGridViewTextBoxColumn
            // 
            this.salonNoDataGridViewTextBoxColumn.DataPropertyName = "SalonNo";
            this.salonNoDataGridViewTextBoxColumn.HeaderText = "SalonNo";
            this.salonNoDataGridViewTextBoxColumn.Name = "salonNoDataGridViewTextBoxColumn";
            // 
            // gunNoDataGridViewTextBoxColumn
            // 
            this.gunNoDataGridViewTextBoxColumn.DataPropertyName = "GunNo";
            this.gunNoDataGridViewTextBoxColumn.HeaderText = "GunNo";
            this.gunNoDataGridViewTextBoxColumn.Name = "gunNoDataGridViewTextBoxColumn";
            // 
            // saatNoDataGridViewTextBoxColumn
            // 
            this.saatNoDataGridViewTextBoxColumn.DataPropertyName = "SaatNo";
            this.saatNoDataGridViewTextBoxColumn.HeaderText = "SaatNo";
            this.saatNoDataGridViewTextBoxColumn.Name = "saatNoDataGridViewTextBoxColumn";
            // 
            // vizeSinavBindingSource
            // 
            this.vizeSinavBindingSource.DataMember = "VizeSinav";
            this.vizeSinavBindingSource.DataSource = this.oKULDataSetBindingSource;
            // 
            // vizeSinavTableAdapter
            // 
            this.vizeSinavTableAdapter.ClearBeforeFill = true;
            // 
            // fKVizeNotlariVizeSinavBindingSource
            // 
            this.fKVizeNotlariVizeSinavBindingSource.DataMember = "FK_VizeNotlari_VizeSinav";
            this.fKVizeNotlariVizeSinavBindingSource.DataSource = this.vizeSinavBindingSource;
            // 
            // vizeNotlariTableAdapter
            // 
            this.vizeNotlariTableAdapter.ClearBeforeFill = true;
            // 
            // bolumTableAdapter
            // 
            this.bolumTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(8, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Fakülte";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bolumBindingSource, "BolumAd", true));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(73, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(117, 21);
            this.comboBox1.TabIndex = 21;
            // 
            // idBox2
            // 
            this.idBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vizeSinavBindingSource, "Id", true));
            this.idBox2.FormattingEnabled = true;
            this.idBox2.Location = new System.Drawing.Point(469, 170);
            this.idBox2.Name = "idBox2";
            this.idBox2.Size = new System.Drawing.Size(121, 21);
            this.idBox2.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(408, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "Seçilen Id Satırına Göre =";
            // 
            // bolumDersTableAdapter
            // 
            this.bolumDersTableAdapter.ClearBeforeFill = true;
            // 
            // fillBy1ToolStrip
            // 
            this.fillBy1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillBy1ToolStripButton});
            this.fillBy1ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy1ToolStrip.Name = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Size = new System.Drawing.Size(712, 25);
            this.fillBy1ToolStrip.TabIndex = 25;
            this.fillBy1ToolStrip.Text = "fillBy1ToolStrip";
            // 
            // fillBy1ToolStripButton
            // 
            this.fillBy1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy1ToolStripButton.Name = "fillBy1ToolStripButton";
            this.fillBy1ToolStripButton.Size = new System.Drawing.Size(45, 22);
            this.fillBy1ToolStripButton.Text = "FillBy1";
            this.fillBy1ToolStripButton.Click += new System.EventHandler(this.fillBy1ToolStripButton_Click);
            // 
            // dersTableAdapter
            // 
            this.dersTableAdapter.ClearBeforeFill = true;
            // 
            // fKVizeNotlariVizeSinavBindingSource1
            // 
            this.fKVizeNotlariVizeSinavBindingSource1.DataMember = "FK_VizeNotlari_VizeSinav";
            this.fKVizeNotlariVizeSinavBindingSource1.DataSource = this.vizeSinavBindingSource;
            // 
            // fKVizeNotlariVizeSinavBindingSource2
            // 
            this.fKVizeNotlariVizeSinavBindingSource2.DataMember = "FK_VizeNotlari_VizeSinav";
            this.fKVizeNotlariVizeSinavBindingSource2.DataSource = this.vizeSinavBindingSource;
            // 
            // VizeGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 490);
            this.Controls.Add(this.fillBy1ToolStrip);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.idBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.saatBox7);
            this.Controls.Add(this.gunBox6);
            this.Controls.Add(this.salonBox5);
            this.Controls.Add(this.grupbox);
            this.Controls.Add(this.sinifbox);
            this.Controls.Add(this.dersComboBox);
            this.Controls.Add(this.bolumComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "VizeGiris";
            this.Text = "VizeSinavProgrami";
            this.Load += new System.EventHandler(this.VizeGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fKBolumDersBolumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oKULDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oKULDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oKULDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vizeSinavBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vizeSinavBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vizeSinavBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKVizeNotlariVizeSinavBindingSource)).EndInit();
            this.fillBy1ToolStrip.ResumeLayout(false);
            this.fillBy1ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKVizeNotlariVizeSinavBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKVizeNotlariVizeSinavBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox bolumComboBox;
        private System.Windows.Forms.ComboBox dersComboBox;
        private System.Windows.Forms.ComboBox sinifbox;
        private System.Windows.Forms.ComboBox grupbox;
        private System.Windows.Forms.ComboBox salonBox5;
        private System.Windows.Forms.ComboBox gunBox6;
        private System.Windows.Forms.ComboBox saatBox7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource oKULDataSetBindingSource;
        private OKULDataSet oKULDataSet;
        private System.Windows.Forms.BindingSource vizeSinavBindingSource;
        private OKULDataSetTableAdapters.VizeSinavTableAdapter vizeSinavTableAdapter;
        private System.Windows.Forms.BindingSource fKVizeNotlariVizeSinavBindingSource;
        private OKULDataSetTableAdapters.VizeNotlariTableAdapter vizeNotlariTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumDersIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinifIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salonNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gunNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saatNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vizeSinavBindingSource2;
        private System.Windows.Forms.BindingSource vizeSinavBindingSource1;
        private System.Windows.Forms.BindingSource oKULDataSetBindingSource1;
        private System.Windows.Forms.BindingSource bolumBindingSource;
        private OKULDataSetTableAdapters.BolumTableAdapter bolumTableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox idBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource fKBolumDersBolumBindingSource;
        private OKULDataSetTableAdapters.BolumDersTableAdapter bolumDersTableAdapter;
        private System.Windows.Forms.ToolStrip fillBy1ToolStrip;
        private System.Windows.Forms.ToolStripButton fillBy1ToolStripButton;
        private System.Windows.Forms.BindingSource dersBindingSource;
        private OKULDataSetTableAdapters.DersTableAdapter dersTableAdapter;
        private System.Windows.Forms.BindingSource fKVizeNotlariVizeSinavBindingSource1;
        private System.Windows.Forms.BindingSource fKVizeNotlariVizeSinavBindingSource2;
    }
}