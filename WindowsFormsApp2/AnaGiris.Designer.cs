namespace WindowsFormsApp2
{
    partial class AnaGiris
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
            this.personelB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // personelB
            // 
            this.personelB.BackColor = System.Drawing.Color.Turquoise;
            this.personelB.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personelB.Location = new System.Drawing.Point(257, 90);
            this.personelB.Name = "personelB";
            this.personelB.Size = new System.Drawing.Size(231, 190);
            this.personelB.TabIndex = 1;
            this.personelB.Text = "Admin Girişi";
            this.personelB.UseVisualStyleBackColor = false;
            this.personelB.Click += new System.EventHandler(this.personelB_Click);
            // 
            // AnaGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.personelB);
            this.Name = "AnaGiris";
            this.Text = "anagiris";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button personelB;
    }
}