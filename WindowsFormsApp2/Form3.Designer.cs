
namespace WindowsFormsApp2
{
    partial class DersEkle
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
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dersAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oKULDataSet = new WindowsFormsApp2.OKULDataSet();
            this.dersTableAdapter = new WindowsFormsApp2.OKULDataSetTableAdapters.DersTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dersIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumDersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKBolumDersDersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bolumDersTableAdapter = new WindowsFormsApp2.OKULDataSetTableAdapters.BolumDersTableAdapter();
            this.siniflarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siniflarTableAdapter = new WindowsFormsApp2.OKULDataSetTableAdapters.SiniflarTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.ekleBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.secdbox = new System.Windows.Forms.ComboBox();
            this.dersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bolumsecBox2 = new System.Windows.Forms.ComboBox();
            this.bolumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.dersProgramiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dersProgramiTableAdapter = new WindowsFormsApp2.OKULDataSetTableAdapters.DersProgramiTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.bolumTableAdapter = new WindowsFormsApp2.OKULDataSetTableAdapters.BolumTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.idbox8 = new System.Windows.Forms.ComboBox();
            this.idbox10 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oKULDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumDersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKBolumDersDersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siniflarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersProgramiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.dersAdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(80, 271);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(247, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dersAdDataGridViewTextBoxColumn
            // 
            this.dersAdDataGridViewTextBoxColumn.DataPropertyName = "DersAd";
            this.dersAdDataGridViewTextBoxColumn.HeaderText = "DersAd";
            this.dersAdDataGridViewTextBoxColumn.Name = "dersAdDataGridViewTextBoxColumn";
            // 
            // dersBindingSource
            // 
            this.dersBindingSource.DataMember = "Ders";
            this.dersBindingSource.DataSource = this.oKULDataSet;
            // 
            // oKULDataSet
            // 
            this.oKULDataSet.DataSetName = "OKULDataSet";
            this.oKULDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dersTableAdapter
            // 
            this.dersTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn1,
            this.dersIdDataGridViewTextBoxColumn,
            this.bolumIdDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.bolumDersBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(471, 271);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(344, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // ıdDataGridViewTextBoxColumn1
            // 
            this.ıdDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn1.Name = "ıdDataGridViewTextBoxColumn1";
            this.ıdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dersIdDataGridViewTextBoxColumn
            // 
            this.dersIdDataGridViewTextBoxColumn.DataPropertyName = "DersId";
            this.dersIdDataGridViewTextBoxColumn.HeaderText = "DersId";
            this.dersIdDataGridViewTextBoxColumn.Name = "dersIdDataGridViewTextBoxColumn";
            // 
            // bolumIdDataGridViewTextBoxColumn
            // 
            this.bolumIdDataGridViewTextBoxColumn.DataPropertyName = "BolumId";
            this.bolumIdDataGridViewTextBoxColumn.HeaderText = "BolumId";
            this.bolumIdDataGridViewTextBoxColumn.Name = "bolumIdDataGridViewTextBoxColumn";
            // 
            // bolumDersBindingSource
            // 
            this.bolumDersBindingSource.DataMember = "BolumDers";
            this.bolumDersBindingSource.DataSource = this.oKULDataSet;
            // 
            // fKBolumDersDersBindingSource
            // 
            this.fKBolumDersDersBindingSource.DataMember = "FK_BolumDers_Ders";
            this.fKBolumDersDersBindingSource.DataSource = this.dersBindingSource;
            // 
            // bolumDersTableAdapter
            // 
            this.bolumDersTableAdapter.ClearBeforeFill = true;
            // 
            // siniflarBindingSource
            // 
            this.siniflarBindingSource.DataMember = "Siniflar";
            this.siniflarBindingSource.DataSource = this.oKULDataSet;
            // 
            // siniflarTableAdapter
            // 
            this.siniflarTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(106, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = " Yeni Ders Ekle";
            // 
            // ekleBox1
            // 
            this.ekleBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekleBox1.Location = new System.Drawing.Point(111, 51);
            this.ekleBox1.Name = "ekleBox1";
            this.ekleBox1.Size = new System.Drawing.Size(156, 38);
            this.ekleBox1.TabIndex = 4;
            this.ekleBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 47);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(493, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dersi İlgili Bölüme Ekle";
            // 
            // secdbox
            // 
            this.secdbox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bolumDersBindingSource, "DersId", true));
            this.secdbox.DataSource = this.dersBindingSource1;
            this.secdbox.DisplayMember = "DersAd";
            this.secdbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.secdbox.FormattingEnabled = true;
            this.secdbox.Location = new System.Drawing.Point(523, 78);
            this.secdbox.Name = "secdbox";
            this.secdbox.Size = new System.Drawing.Size(154, 28);
            this.secdbox.TabIndex = 7;
            this.secdbox.ValueMember = "Id";
            // 
            // dersBindingSource1
            // 
            this.dersBindingSource1.DataMember = "Ders";
            this.dersBindingSource1.DataSource = this.oKULDataSet;
            // 
            // bolumsecBox2
            // 
            this.bolumsecBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bolumDersBindingSource, "BolumId", true));
            this.bolumsecBox2.DataSource = this.bolumBindingSource;
            this.bolumsecBox2.DisplayMember = "BolumAd";
            this.bolumsecBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bolumsecBox2.FormattingEnabled = true;
            this.bolumsecBox2.Location = new System.Drawing.Point(717, 77);
            this.bolumsecBox2.Name = "bolumsecBox2";
            this.bolumsecBox2.Size = new System.Drawing.Size(154, 28);
            this.bolumsecBox2.TabIndex = 8;
            this.bolumsecBox2.ValueMember = "Id";
            // 
            // bolumBindingSource
            // 
            this.bolumBindingSource.DataMember = "Bolum";
            this.bolumBindingSource.DataSource = this.oKULDataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(742, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Bölüm Seç";
            // 
            // dersProgramiBindingSource
            // 
            this.dersProgramiBindingSource.DataMember = "DersProgrami";
            this.dersProgramiBindingSource.DataSource = this.oKULDataSet;
            // 
            // dersProgramiTableAdapter
            // 
            this.dersProgramiTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(619, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 47);
            this.button2.TabIndex = 10;
            this.button2.Text = "Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(584, 218);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 47);
            this.button3.TabIndex = 11;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(704, 218);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 47);
            this.button4.TabIndex = 12;
            this.button4.Text = "Güncelle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // bolumTableAdapter
            // 
            this.bolumTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(146, 218);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 47);
            this.button5.TabIndex = 13;
            this.button5.Text = "Sil";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(256, 218);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(93, 47);
            this.button6.TabIndex = 14;
            this.button6.Text = "Güncelle";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // idbox8
            // 
            this.idbox8.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dersBindingSource, "Id", true));
            this.idbox8.DataSource = this.dersBindingSource;
            this.idbox8.DisplayMember = "Id";
            this.idbox8.FormattingEnabled = true;
            this.idbox8.Location = new System.Drawing.Point(72, 232);
            this.idbox8.Name = "idbox8";
            this.idbox8.Size = new System.Drawing.Size(33, 21);
            this.idbox8.TabIndex = 15;
            this.idbox8.ValueMember = "Id";
            // 
            // idbox10
            // 
            this.idbox10.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bolumDersBindingSource, "Id", true));
            this.idbox10.DataSource = this.bolumDersBindingSource;
            this.idbox10.DisplayMember = "Id";
            this.idbox10.FormattingEnabled = true;
            this.idbox10.Location = new System.Drawing.Point(523, 232);
            this.idbox10.Name = "idbox10";
            this.idbox10.Size = new System.Drawing.Size(30, 21);
            this.idbox10.TabIndex = 16;
            this.idbox10.ValueMember = "Id";
            // 
            // DersEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 450);
            this.Controls.Add(this.idbox10);
            this.Controls.Add(this.idbox8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bolumsecBox2);
            this.Controls.Add(this.secdbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ekleBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DersEkle";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oKULDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumDersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKBolumDersDersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siniflarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersProgramiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private OKULDataSet oKULDataSet;
        private System.Windows.Forms.BindingSource dersBindingSource;
        private OKULDataSetTableAdapters.DersTableAdapter dersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource fKBolumDersDersBindingSource;
        private OKULDataSetTableAdapters.BolumDersTableAdapter bolumDersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource siniflarBindingSource;
        private OKULDataSetTableAdapters.SiniflarTableAdapter siniflarTableAdapter;
        private System.Windows.Forms.BindingSource bolumDersBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ekleBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox secdbox;
        private System.Windows.Forms.ComboBox bolumsecBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource dersProgramiBindingSource;
        private OKULDataSetTableAdapters.DersProgramiTableAdapter dersProgramiTableAdapter;
        private System.Windows.Forms.BindingSource dersBindingSource1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource bolumBindingSource;
        private OKULDataSetTableAdapters.BolumTableAdapter bolumTableAdapter;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox idbox8;
        private System.Windows.Forms.ComboBox idbox10;
    }
}