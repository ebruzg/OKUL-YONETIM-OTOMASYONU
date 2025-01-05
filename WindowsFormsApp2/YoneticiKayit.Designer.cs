
namespace WindowsFormsApp2
{
    partial class YoneticiKayit
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
            this.yoneticiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oKULDataSet = new WindowsFormsApp2.OKULDataSet();
            this.yoneticiTableAdapter = new WindowsFormsApp2.OKULDataSetTableAdapters.YoneticiTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yoneticiAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yoneticiSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullanıcıKodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adBox2 = new System.Windows.Forms.TextBox();
            this.soyadBox3 = new System.Windows.Forms.TextBox();
            this.kodBox4 = new System.Windows.Forms.TextBox();
            this.idBox7 = new System.Windows.Forms.ComboBox();
            this.Yönetici = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.fillBy7ToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillBy7ToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.yoneticiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oKULDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.fillBy7ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // yoneticiBindingSource
            // 
            this.yoneticiBindingSource.DataMember = "Yonetici";
            this.yoneticiBindingSource.DataSource = this.oKULDataSet;
            // 
            // oKULDataSet
            // 
            this.oKULDataSet.DataSetName = "OKULDataSet";
            this.oKULDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yoneticiTableAdapter
            // 
            this.yoneticiTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.yoneticiAdDataGridViewTextBoxColumn,
            this.yoneticiSoyadDataGridViewTextBoxColumn,
            this.kullanıcıKodDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.yoneticiBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(209, 249);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(427, 189);
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
            // yoneticiAdDataGridViewTextBoxColumn
            // 
            this.yoneticiAdDataGridViewTextBoxColumn.DataPropertyName = "YoneticiAd";
            this.yoneticiAdDataGridViewTextBoxColumn.HeaderText = "YoneticiAd";
            this.yoneticiAdDataGridViewTextBoxColumn.Name = "yoneticiAdDataGridViewTextBoxColumn";
            // 
            // yoneticiSoyadDataGridViewTextBoxColumn
            // 
            this.yoneticiSoyadDataGridViewTextBoxColumn.DataPropertyName = "YoneticiSoyad";
            this.yoneticiSoyadDataGridViewTextBoxColumn.HeaderText = "YoneticiSoyad";
            this.yoneticiSoyadDataGridViewTextBoxColumn.Name = "yoneticiSoyadDataGridViewTextBoxColumn";
            // 
            // kullanıcıKodDataGridViewTextBoxColumn
            // 
            this.kullanıcıKodDataGridViewTextBoxColumn.DataPropertyName = "KullanıcıKod";
            this.kullanıcıKodDataGridViewTextBoxColumn.HeaderText = "KullanıcıKod";
            this.kullanıcıKodDataGridViewTextBoxColumn.Name = "kullanıcıKodDataGridViewTextBoxColumn";
            // 
            // adBox2
            // 
            this.adBox2.Location = new System.Drawing.Point(413, 28);
            this.adBox2.Multiline = true;
            this.adBox2.Name = "adBox2";
            this.adBox2.Size = new System.Drawing.Size(223, 42);
            this.adBox2.TabIndex = 2;
            // 
            // soyadBox3
            // 
            this.soyadBox3.Location = new System.Drawing.Point(413, 85);
            this.soyadBox3.Multiline = true;
            this.soyadBox3.Name = "soyadBox3";
            this.soyadBox3.Size = new System.Drawing.Size(223, 42);
            this.soyadBox3.TabIndex = 3;
            // 
            // kodBox4
            // 
            this.kodBox4.Location = new System.Drawing.Point(413, 152);
            this.kodBox4.Multiline = true;
            this.kodBox4.Name = "kodBox4";
            this.kodBox4.Size = new System.Drawing.Size(223, 42);
            this.kodBox4.TabIndex = 4;
            // 
            // idBox7
            // 
            this.idBox7.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.yoneticiBindingSource, "Id", true));
            this.idBox7.DataSource = this.yoneticiBindingSource;
            this.idBox7.DisplayMember = "Id";
            this.idBox7.FormattingEnabled = true;
            this.idBox7.Location = new System.Drawing.Point(209, 222);
            this.idBox7.Name = "idBox7";
            this.idBox7.Size = new System.Drawing.Size(33, 21);
            this.idBox7.TabIndex = 5;
            this.idBox7.ValueMember = "Id";
            // 
            // Yönetici
            // 
            this.Yönetici.AutoSize = true;
            this.Yönetici.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Yönetici.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Yönetici.Location = new System.Drawing.Point(203, 35);
            this.Yönetici.Name = "Yönetici";
            this.Yönetici.Size = new System.Drawing.Size(151, 31);
            this.Yönetici.TabIndex = 6;
            this.Yönetici.Text = "Yönetici Ad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(203, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Yönetici Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(203, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kullanıcı Kodu";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(262, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button2.Location = new System.Drawing.Point(384, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 32);
            this.button2.TabIndex = 10;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Honeydew;
            this.button3.Location = new System.Drawing.Point(512, 215);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 32);
            this.button3.TabIndex = 11;
            this.button3.Text = "Ekle";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(132, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Id\'ya göre";
            // 
            // fillBy7ToolStrip
            // 
            this.fillBy7ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillBy7ToolStripButton});
            this.fillBy7ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy7ToolStrip.Name = "fillBy7ToolStrip";
            this.fillBy7ToolStrip.Size = new System.Drawing.Size(800, 25);
            this.fillBy7ToolStrip.TabIndex = 13;
            this.fillBy7ToolStrip.Text = "fillBy7ToolStrip";
            // 
            // fillBy7ToolStripButton
            // 
            this.fillBy7ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy7ToolStripButton.Name = "fillBy7ToolStripButton";
            this.fillBy7ToolStripButton.Size = new System.Drawing.Size(45, 22);
            this.fillBy7ToolStripButton.Text = "FillBy7";
            this.fillBy7ToolStripButton.Click += new System.EventHandler(this.fillBy7ToolStripButton_Click);
            // 
            // YoneticiKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(this.fillBy7ToolStrip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Yönetici);
            this.Controls.Add(this.idBox7);
            this.Controls.Add(this.kodBox4);
            this.Controls.Add(this.soyadBox3);
            this.Controls.Add(this.adBox2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "YoneticiKayit";
            this.Text = "YoneticiKayit";
            this.Load += new System.EventHandler(this.YoneticiKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yoneticiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oKULDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.fillBy7ToolStrip.ResumeLayout(false);
            this.fillBy7ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private OKULDataSet oKULDataSet;
        private System.Windows.Forms.BindingSource yoneticiBindingSource;
        private OKULDataSetTableAdapters.YoneticiTableAdapter yoneticiTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yoneticiAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yoneticiSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullanıcıKodDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox adBox2;
        private System.Windows.Forms.TextBox soyadBox3;
        private System.Windows.Forms.TextBox kodBox4;
        private System.Windows.Forms.ComboBox idBox7;
        private System.Windows.Forms.Label Yönetici;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip fillBy7ToolStrip;
        private System.Windows.Forms.ToolStripButton fillBy7ToolStripButton;
    }
}