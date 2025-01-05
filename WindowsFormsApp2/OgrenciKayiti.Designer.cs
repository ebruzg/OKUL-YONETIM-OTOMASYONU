
using System;

namespace WindowsFormsApp2
{
    partial class OgrenciKayiti
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ogrenci = new System.Windows.Forms.TextBox();
            this.ogrencisoyad = new System.Windows.Forms.TextBox();
            this.fakultecomboBox1 = new System.Windows.Forms.ComboBox();
            this.Cmbbolum = new System.Windows.Forms.ComboBox();
            this.sinifcomboBox3 = new System.Windows.Forms.ComboBox();
            this.grubucomboBox4 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cinsiyet1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.kullanicik = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(45, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Ad";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(46, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Grubu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(45, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sınıf";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(45, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bölüm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(45, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fakülte";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(45, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Öğrenci Soyad";
            // 
            // ogrenci
            // 
            this.ogrenci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrenci.Location = new System.Drawing.Point(205, 23);
            this.ogrenci.Name = "ogrenci";
            this.ogrenci.Size = new System.Drawing.Size(209, 26);
            this.ogrenci.TabIndex = 6;
            // 
            // ogrencisoyad
            // 
            this.ogrencisoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrencisoyad.Location = new System.Drawing.Point(205, 69);
            this.ogrencisoyad.Name = "ogrencisoyad";
            this.ogrencisoyad.Size = new System.Drawing.Size(209, 26);
            this.ogrencisoyad.TabIndex = 7;
            // 
            // fakultecomboBox1
            // 
            this.fakultecomboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fakultecomboBox1.FormattingEnabled = true;
            this.fakultecomboBox1.Location = new System.Drawing.Point(205, 155);
            this.fakultecomboBox1.Name = "fakultecomboBox1";
            this.fakultecomboBox1.Size = new System.Drawing.Size(209, 28);
            this.fakultecomboBox1.TabIndex = 8;
            // 
            // Cmbbolum
            // 
            this.Cmbbolum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Cmbbolum.FormattingEnabled = true;
            this.Cmbbolum.Location = new System.Drawing.Point(205, 199);
            this.Cmbbolum.Name = "Cmbbolum";
            this.Cmbbolum.Size = new System.Drawing.Size(209, 28);
            this.Cmbbolum.TabIndex = 9;
            this.Cmbbolum.SelectedIndexChanged += new System.EventHandler(this.Cmbbolum_SelectedIndexChanged);
            // 
            // sinifcomboBox3
            // 
            this.sinifcomboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sinifcomboBox3.FormattingEnabled = true;
            this.sinifcomboBox3.Location = new System.Drawing.Point(205, 242);
            this.sinifcomboBox3.Name = "sinifcomboBox3";
            this.sinifcomboBox3.Size = new System.Drawing.Size(209, 28);
            this.sinifcomboBox3.TabIndex = 10;
            // 
            // grubucomboBox4
            // 
            this.grubucomboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grubucomboBox4.FormattingEnabled = true;
            this.grubucomboBox4.Location = new System.Drawing.Point(205, 286);
            this.grubucomboBox4.Name = "grubucomboBox4";
            this.grubucomboBox4.Size = new System.Drawing.Size(209, 28);
            this.grubucomboBox4.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 39);
            this.button1.TabIndex = 12;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(205, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 39);
            this.button2.TabIndex = 13;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(323, 377);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 39);
            this.button3.TabIndex = 14;
            this.button3.Text = "Güncelle";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(46, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Cinsiyet";
            // 
            // cinsiyet1
            // 
            this.cinsiyet1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cinsiyet1.FormattingEnabled = true;
            this.cinsiyet1.Location = new System.Drawing.Point(205, 113);
            this.cinsiyet1.Name = "cinsiyet1";
            this.cinsiyet1.Size = new System.Drawing.Size(209, 28);
            this.cinsiyet1.TabIndex = 16;
            this.cinsiyet1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(45, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Kullanıcı Kodu";
            // 
            // kullanicik
            // 
            this.kullanicik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanicik.Location = new System.Drawing.Point(205, 329);
            this.kullanicik.Name = "kullanicik";
            this.kullanicik.Size = new System.Drawing.Size(209, 26);
            this.kullanicik.TabIndex = 18;
            // 
            // OgrenciKayiti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 450);
            this.Controls.Add(this.kullanicik);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cinsiyet1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grubucomboBox4);
            this.Controls.Add(this.sinifcomboBox3);
            this.Controls.Add(this.Cmbbolum);
            this.Controls.Add(this.fakultecomboBox1);
            this.Controls.Add(this.ogrencisoyad);
            this.Controls.Add(this.ogrenci);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OgrenciKayiti";
            this.Text = "OgrenciKayiti";
            this.Load += new System.EventHandler(this.OgrenciKayiti_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ogrenci;
        private System.Windows.Forms.TextBox ogrencisoyad;
        private System.Windows.Forms.ComboBox fakultecomboBox1;
        private System.Windows.Forms.ComboBox Cmbbolum;
        private System.Windows.Forms.ComboBox sinifcomboBox3;
        private System.Windows.Forms.ComboBox grubucomboBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cinsiyet1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox kullanicik;

        public EventHandler button1_Click { get; private set; }
    }
}