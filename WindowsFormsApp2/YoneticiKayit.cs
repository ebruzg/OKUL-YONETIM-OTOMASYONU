using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class YoneticiKayit : Form
    {
        public YoneticiKayit()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-3CR91H0S;Initial Catalog=OKUL;Integrated Security=True");
        private void YoneticiKayit_Load(object sender, EventArgs e)
        {
            
           
            this.yoneticiTableAdapter.Fill(this.oKULDataSet.Yonetici);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.yoneticiTableAdapter.FillBy(this.oKULDataSet.Yonetici);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand yonetici = new SqlCommand("insert into Yonetici (YoneticiAd,YoneticiSoyad,KullanıcıKod) values (@p1,@p2,@p3)", baglanti);


            yonetici.Parameters.AddWithValue("@p1", adBox2.Text);
            yonetici.Parameters.AddWithValue("@p2", soyadBox3.Text);
            yonetici.Parameters.AddWithValue("@p3", kodBox4.Text);
           
            yonetici.ExecuteNonQuery();


            baglanti.Close();

            MessageBox.Show("Başarıyla eklendi.");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Yonetici WHERE Yonetici.Id = @YoneticiId";
            SqlCommand silyonetici = new SqlCommand(query, baglanti);
            silyonetici.Parameters.AddWithValue("@YoneticiId", Convert.ToInt32(idBox7.Text));
            baglanti.Open();
            silyonetici.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Başarıyla silindi.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Yonetici SET  YoneticiAd = @p1, YoneticiSoyad = @p2,  KullanıcıKod = @p3 WHERE Yonetici.Id = @YoneticiId";
            SqlCommand yogunc = new SqlCommand(query, baglanti);
            yogunc.Parameters.AddWithValue("@p1", adBox2.Text);
            yogunc.Parameters.AddWithValue("@p2", soyadBox3.Text);
            yogunc.Parameters.AddWithValue("@p3", kodBox4.Text);
            yogunc.Parameters.AddWithValue("@YoneticiId", Convert.ToInt32(idBox7.Text));



            baglanti.Open();
            yogunc.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Başarıyla güncellendi.");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            adBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            kodBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            soyadBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand yenile = new SqlCommand("Select * from Yonetici");
        }

        private void fillBy7ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.yoneticiTableAdapter.FillBy7(this.oKULDataSet.Yonetici);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
