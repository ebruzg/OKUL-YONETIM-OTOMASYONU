
namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.öğrenciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OgrenciKayit = new System.Windows.Forms.ToolStripMenuItem();
            this.notGirişleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devamsızlıkGirişleriToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sınıflarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dersProgramlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sınavProgramlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vizeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.finalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sınıfİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelKayıtİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.yöneticiİdareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fakütlteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bölümİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fakülteKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bölümKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dersKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(575, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciToolStripMenuItem,
            this.sınıflarToolStripMenuItem,
            this.personelToolStripMenuItem,
            this.fakütlteToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(575, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // öğrenciToolStripMenuItem
            // 
            this.öğrenciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OgrenciKayit,
            this.notGirişleriToolStripMenuItem,
            this.devamsızlıkGirişleriToolStripMenuItem1});
            this.öğrenciToolStripMenuItem.Name = "öğrenciToolStripMenuItem";
            this.öğrenciToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.öğrenciToolStripMenuItem.Text = "Öğrenci";
            // 
            // OgrenciKayit
            // 
            this.OgrenciKayit.Name = "OgrenciKayit";
            this.OgrenciKayit.Size = new System.Drawing.Size(178, 22);
            this.OgrenciKayit.Text = "Öğrenci Kayıt";
            this.OgrenciKayit.Click += new System.EventHandler(this.devamsızlıkGirişleriToolStripMenuItem_Click);
            // 
            // notGirişleriToolStripMenuItem
            // 
            this.notGirişleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vizeToolStripMenuItem,
            this.finalToolStripMenuItem});
            this.notGirişleriToolStripMenuItem.Name = "notGirişleriToolStripMenuItem";
            this.notGirişleriToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.notGirişleriToolStripMenuItem.Text = "Not Girişleri";
            // 
            // vizeToolStripMenuItem
            // 
            this.vizeToolStripMenuItem.Name = "vizeToolStripMenuItem";
            this.vizeToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.vizeToolStripMenuItem.Text = "Vize";
            this.vizeToolStripMenuItem.Click += new System.EventHandler(this.vizeToolStripMenuItem_Click);
            // 
            // finalToolStripMenuItem
            // 
            this.finalToolStripMenuItem.Name = "finalToolStripMenuItem";
            this.finalToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.finalToolStripMenuItem.Text = "Final";
            // 
            // devamsızlıkGirişleriToolStripMenuItem1
            // 
            this.devamsızlıkGirişleriToolStripMenuItem1.Name = "devamsızlıkGirişleriToolStripMenuItem1";
            this.devamsızlıkGirişleriToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.devamsızlıkGirişleriToolStripMenuItem1.Text = "Devamsızlık Girişleri";
            this.devamsızlıkGirişleriToolStripMenuItem1.Click += new System.EventHandler(this.devamsızlıkGirişleriToolStripMenuItem1_Click);
            // 
            // sınıflarToolStripMenuItem
            // 
            this.sınıflarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dersProgramlarıToolStripMenuItem,
            this.sınavProgramlarıToolStripMenuItem,
            this.sınıfİşlemleriToolStripMenuItem});
            this.sınıflarToolStripMenuItem.Name = "sınıflarToolStripMenuItem";
            this.sınıflarToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.sınıflarToolStripMenuItem.Text = "Sınıflar";
            this.sınıflarToolStripMenuItem.Click += new System.EventHandler(this.sınıflarToolStripMenuItem_Click);
            // 
            // dersProgramlarıToolStripMenuItem
            // 
            this.dersProgramlarıToolStripMenuItem.Name = "dersProgramlarıToolStripMenuItem";
            this.dersProgramlarıToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.dersProgramlarıToolStripMenuItem.Text = "Ders Programları";
            this.dersProgramlarıToolStripMenuItem.Click += new System.EventHandler(this.dersProgramlarıToolStripMenuItem_Click);
            // 
            // sınavProgramlarıToolStripMenuItem
            // 
            this.sınavProgramlarıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vizeToolStripMenuItem1,
            this.finalToolStripMenuItem1});
            this.sınavProgramlarıToolStripMenuItem.Name = "sınavProgramlarıToolStripMenuItem";
            this.sınavProgramlarıToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.sınavProgramlarıToolStripMenuItem.Text = "Sınav Programları";
            this.sınavProgramlarıToolStripMenuItem.Click += new System.EventHandler(this.sınavProgramlarıToolStripMenuItem_Click);
            // 
            // vizeToolStripMenuItem1
            // 
            this.vizeToolStripMenuItem1.Name = "vizeToolStripMenuItem1";
            this.vizeToolStripMenuItem1.Size = new System.Drawing.Size(99, 22);
            this.vizeToolStripMenuItem1.Text = "Vize";
            this.vizeToolStripMenuItem1.Click += new System.EventHandler(this.vizeToolStripMenuItem1_Click);
            // 
            // finalToolStripMenuItem1
            // 
            this.finalToolStripMenuItem1.Name = "finalToolStripMenuItem1";
            this.finalToolStripMenuItem1.Size = new System.Drawing.Size(99, 22);
            this.finalToolStripMenuItem1.Text = "Final";
            this.finalToolStripMenuItem1.Click += new System.EventHandler(this.finalToolStripMenuItem1_Click);
            // 
            // sınıfİşlemleriToolStripMenuItem
            // 
            this.sınıfİşlemleriToolStripMenuItem.Name = "sınıfİşlemleriToolStripMenuItem";
            this.sınıfİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.sınıfİşlemleriToolStripMenuItem.Text = "Sınıf İşlemleri";
            // 
            // personelToolStripMenuItem
            // 
            this.personelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelKayıtİşlemleriToolStripMenuItem});
            this.personelToolStripMenuItem.Name = "personelToolStripMenuItem";
            this.personelToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.personelToolStripMenuItem.Text = "Personel";
            // 
            // personelKayıtİşlemleriToolStripMenuItem
            // 
            this.personelKayıtİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciToolStripMenuItem1,
            this.yöneticiİdareToolStripMenuItem});
            this.personelKayıtİşlemleriToolStripMenuItem.Name = "personelKayıtİşlemleriToolStripMenuItem";
            this.personelKayıtİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.personelKayıtİşlemleriToolStripMenuItem.Text = "Personel Kayıt İşlemleri";
            // 
            // öğrenciToolStripMenuItem1
            // 
            this.öğrenciToolStripMenuItem1.Name = "öğrenciToolStripMenuItem1";
            this.öğrenciToolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
            this.öğrenciToolStripMenuItem1.Text = "Öğretmen";
            this.öğrenciToolStripMenuItem1.Click += new System.EventHandler(this.öğrenciToolStripMenuItem1_Click);
            // 
            // yöneticiİdareToolStripMenuItem
            // 
            this.yöneticiİdareToolStripMenuItem.Name = "yöneticiİdareToolStripMenuItem";
            this.yöneticiİdareToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.yöneticiİdareToolStripMenuItem.Text = "Yönetici (İdare) ";
            this.yöneticiİdareToolStripMenuItem.Click += new System.EventHandler(this.yöneticiİdareToolStripMenuItem_Click);
            // 
            // fakütlteToolStripMenuItem
            // 
            this.fakütlteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bölümİşlemleriToolStripMenuItem});
            this.fakütlteToolStripMenuItem.Name = "fakütlteToolStripMenuItem";
            this.fakütlteToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.fakütlteToolStripMenuItem.Text = "Fakülte";
            // 
            // bölümİşlemleriToolStripMenuItem
            // 
            this.bölümİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fakülteKayıtToolStripMenuItem,
            this.bölümKayıtToolStripMenuItem,
            this.dersKayıtToolStripMenuItem});
            this.bölümİşlemleriToolStripMenuItem.Name = "bölümİşlemleriToolStripMenuItem";
            this.bölümİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.bölümİşlemleriToolStripMenuItem.Text = "Bölüm İşlemleri";
            // 
            // fakülteKayıtToolStripMenuItem
            // 
            this.fakülteKayıtToolStripMenuItem.Name = "fakülteKayıtToolStripMenuItem";
            this.fakülteKayıtToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.fakülteKayıtToolStripMenuItem.Text = "Fakülte Kayıt";
            // 
            // bölümKayıtToolStripMenuItem
            // 
            this.bölümKayıtToolStripMenuItem.Name = "bölümKayıtToolStripMenuItem";
            this.bölümKayıtToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.bölümKayıtToolStripMenuItem.Text = "Bölüm Kayıt";
            // 
            // dersKayıtToolStripMenuItem
            // 
            this.dersKayıtToolStripMenuItem.Name = "dersKayıtToolStripMenuItem";
            this.dersKayıtToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.dersKayıtToolStripMenuItem.Text = "Ders Kayıt";
            this.dersKayıtToolStripMenuItem.Click += new System.EventHandler(this.dersKayıtToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem öğrenciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OgrenciKayit;
        private System.Windows.Forms.ToolStripMenuItem notGirişleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sınıflarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dersProgramlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sınavProgramlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devamsızlıkGirişleriToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sınıfİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelKayıtİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem yöneticiİdareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fakütlteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bölümİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fakülteKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bölümKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dersKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vizeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem finalToolStripMenuItem1;
    }
}

