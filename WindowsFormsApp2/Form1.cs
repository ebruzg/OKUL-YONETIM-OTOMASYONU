using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sınıflarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void devamsızlıkGirişleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrenciKayiti form = new OgrenciKayiti();
            form.Show();
        }

        private void devamsızlıkGirişleriToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void vizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void sınavProgramlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vizeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VizeGiris form = new VizeGiris();
            form.Show();
        }

        private void öğrenciToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void yöneticiİdareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YoneticiKayit form1 = new YoneticiKayit();
            form1.Show();

        }

        private void finalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FinalGiris form3 = new FinalGiris();
                form3.Show();
        }

        private void dersKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DersEkle form4 = new DersEkle();
            form4.Show();
        }

        private void dersProgramlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form5 = new Form4();
            form5.Show();
        }
    }
}
