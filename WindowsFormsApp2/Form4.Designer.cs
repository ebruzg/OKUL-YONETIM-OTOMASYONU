
namespace WindowsFormsApp2
{
    partial class Form4
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
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinifIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dersSaatiIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dersOdaKodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumDersleriIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dersProgramiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.oKULDataSet = new WindowsFormsApp2.OKULDataSet();
            this.dersProgramiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dersProgramiTableAdapter = new WindowsFormsApp2.OKULDataSetTableAdapters.DersProgramiTableAdapter();
            this.katSinifTableAdapter1 = new WindowsFormsApp2.OKULDataSetTableAdapters.KatSinifTableAdapter();
            this.siniffcomboBox = new System.Windows.Forms.ComboBox();
            this.gruppBox2 = new System.Windows.Forms.ComboBox();
            this.gunnbox3 = new System.Windows.Forms.ComboBox();
            this.saattbox4 = new System.Windows.Forms.ComboBox();
            this.salonnbox5 = new System.Windows.Forms.ComboBox();
            this.katSinifBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bolumbox6 = new System.Windows.Forms.ComboBox();
            this.dersBox7 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.katSinifBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bolumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.bolumTableAdapter = new WindowsFormsApp2.OKULDataSetTableAdapters.BolumTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersProgramiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oKULDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersProgramiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.katSinifBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.katSinifBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(477, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(574, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(676, 222);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 2;
            this.button3.Text = "Güncelle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.sinifIdDataGridViewTextBoxColumn,
            this.gunIdDataGridViewTextBoxColumn,
            this.dersSaatiIdDataGridViewTextBoxColumn,
            this.dersOdaKodDataGridViewTextBoxColumn,
            this.bolumDersleriIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dersProgramiBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(28, 272);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(642, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sinifIdDataGridViewTextBoxColumn
            // 
            this.sinifIdDataGridViewTextBoxColumn.DataPropertyName = "SinifId";
            this.sinifIdDataGridViewTextBoxColumn.HeaderText = "SinifId";
            this.sinifIdDataGridViewTextBoxColumn.Name = "sinifIdDataGridViewTextBoxColumn";
            // 
            // gunIdDataGridViewTextBoxColumn
            // 
            this.gunIdDataGridViewTextBoxColumn.DataPropertyName = "GunId";
            this.gunIdDataGridViewTextBoxColumn.HeaderText = "GunId";
            this.gunIdDataGridViewTextBoxColumn.Name = "gunIdDataGridViewTextBoxColumn";
            // 
            // dersSaatiIdDataGridViewTextBoxColumn
            // 
            this.dersSaatiIdDataGridViewTextBoxColumn.DataPropertyName = "DersSaatiId";
            this.dersSaatiIdDataGridViewTextBoxColumn.HeaderText = "DersSaatiId";
            this.dersSaatiIdDataGridViewTextBoxColumn.Name = "dersSaatiIdDataGridViewTextBoxColumn";
            // 
            // dersOdaKodDataGridViewTextBoxColumn
            // 
            this.dersOdaKodDataGridViewTextBoxColumn.DataPropertyName = "DersOdaKod";
            this.dersOdaKodDataGridViewTextBoxColumn.HeaderText = "DersOdaKod";
            this.dersOdaKodDataGridViewTextBoxColumn.Name = "dersOdaKodDataGridViewTextBoxColumn";
            // 
            // bolumDersleriIdDataGridViewTextBoxColumn
            // 
            this.bolumDersleriIdDataGridViewTextBoxColumn.DataPropertyName = "BolumDersleriId";
            this.bolumDersleriIdDataGridViewTextBoxColumn.HeaderText = "BolumDersleriId";
            this.bolumDersleriIdDataGridViewTextBoxColumn.Name = "bolumDersleriIdDataGridViewTextBoxColumn";
            // 
            // dersProgramiBindingSource1
            // 
            this.dersProgramiBindingSource1.DataMember = "DersProgrami";
            this.dersProgramiBindingSource1.DataSource = this.oKULDataSet;
            // 
            // oKULDataSet
            // 
            this.oKULDataSet.DataSetName = "OKULDataSet";
            this.oKULDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // katSinifTableAdapter1
            // 
            this.katSinifTableAdapter1.ClearBeforeFill = true;
            // 
            // siniffcomboBox
            // 
            this.siniffcomboBox.FormattingEnabled = true;
            this.siniffcomboBox.Location = new System.Drawing.Point(129, 65);
            this.siniffcomboBox.Name = "siniffcomboBox";
            this.siniffcomboBox.Size = new System.Drawing.Size(96, 21);
            this.siniffcomboBox.TabIndex = 4;
            // 
            // gruppBox2
            // 
            this.gruppBox2.FormattingEnabled = true;
            this.gruppBox2.Location = new System.Drawing.Point(129, 105);
            this.gruppBox2.Name = "gruppBox2";
            this.gruppBox2.Size = new System.Drawing.Size(96, 21);
            this.gruppBox2.TabIndex = 5;
            this.gruppBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // gunnbox3
            // 
            this.gunnbox3.FormattingEnabled = true;
            this.gunnbox3.Location = new System.Drawing.Point(676, 21);
            this.gunnbox3.Name = "gunnbox3";
            this.gunnbox3.Size = new System.Drawing.Size(96, 21);
            this.gunnbox3.TabIndex = 6;
            // 
            // saattbox4
            // 
            this.saattbox4.FormattingEnabled = true;
            this.saattbox4.Location = new System.Drawing.Point(676, 65);
            this.saattbox4.Name = "saattbox4";
            this.saattbox4.Size = new System.Drawing.Size(96, 21);
            this.saattbox4.TabIndex = 7;
            // 
            // salonnbox5
            // 
            this.salonnbox5.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dersProgramiBindingSource1, "DersOdaKod", true));
            this.salonnbox5.FormattingEnabled = true;
            this.salonnbox5.Location = new System.Drawing.Point(676, 105);
            this.salonnbox5.Name = "salonnbox5";
            this.salonnbox5.Size = new System.Drawing.Size(96, 21);
            this.salonnbox5.TabIndex = 8;
            // 
            // katSinifBindingSource
            // 
            this.katSinifBindingSource.DataMember = "KatSinif";
            this.katSinifBindingSource.DataSource = this.oKULDataSet;
            // 
            // bolumbox6
            // 
            this.bolumbox6.FormattingEnabled = true;
            this.bolumbox6.Location = new System.Drawing.Point(129, 23);
            this.bolumbox6.Name = "bolumbox6";
            this.bolumbox6.Size = new System.Drawing.Size(96, 21);
            this.bolumbox6.TabIndex = 9;
            // 
            // dersBox7
            // 
            this.dersBox7.FormattingEnabled = true;
            this.dersBox7.Location = new System.Drawing.Point(676, 154);
            this.dersBox7.Name = "dersBox7";
            this.dersBox7.Size = new System.Drawing.Size(96, 21);
            this.dersBox7.TabIndex = 10;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(63, 149);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(162, 29);
            this.button4.TabIndex = 11;
            this.button4.Text = " Ders Programı Sorgula";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(58, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Sınıf";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(58, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Grup";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(555, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ders Günü";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(555, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ders Saati";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(540, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ders Salonu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(51, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Bölüm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(587, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Ders";
            // 
            // katSinifBindingSource1
            // 
            this.katSinifBindingSource1.DataMember = "KatSinif";
            this.katSinifBindingSource1.DataSource = this.oKULDataSet;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bolumBindingSource, "Id", true));
            this.comboBox1.DataSource = this.oKULDataSet;
            this.comboBox1.DisplayMember = "Bolum.BolumAd";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(676, 195);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(96, 21);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.ValueMember = "Bolum.Id";
            // 
            // bolumBindingSource
            // 
            this.bolumBindingSource.DataMember = "Bolum";
            this.bolumBindingSource.DataSource = this.oKULDataSet;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(587, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "Bölüm";
            // 
            // bolumTableAdapter
            // 
            this.bolumTableAdapter.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dersBox7);
            this.Controls.Add(this.bolumbox6);
            this.Controls.Add(this.salonnbox5);
            this.Controls.Add(this.saattbox4);
            this.Controls.Add(this.gunnbox3);
            this.Controls.Add(this.gruppBox2);
            this.Controls.Add(this.siniffcomboBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersProgramiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oKULDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersProgramiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.katSinifBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.katSinifBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private OKULDataSet oKULDataSet;
        private System.Windows.Forms.BindingSource dersProgramiBindingSource;
        private OKULDataSetTableAdapters.DersProgramiTableAdapter dersProgramiTableAdapter;
        private OKULDataSetTableAdapters.KatSinifTableAdapter katSinifTableAdapter1;
        private System.Windows.Forms.ComboBox siniffcomboBox;
        private System.Windows.Forms.ComboBox gruppBox2;
        private System.Windows.Forms.ComboBox gunnbox3;
        private System.Windows.Forms.ComboBox saattbox4;
        private System.Windows.Forms.ComboBox salonnbox5;
        private System.Windows.Forms.ComboBox bolumbox6;
        private System.Windows.Forms.ComboBox dersBox7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource dersProgramiBindingSource1;
        private System.Windows.Forms.BindingSource katSinifBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource katSinifBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinifIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gunIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersSaatiIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersOdaKodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumDersleriIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource bolumBindingSource;
        private OKULDataSetTableAdapters.BolumTableAdapter bolumTableAdapter;
    }
}