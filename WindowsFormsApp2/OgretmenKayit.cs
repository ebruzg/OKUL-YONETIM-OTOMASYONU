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
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-3CR91H0S;Initial Catalog=OKUL;Integrated Security=True");

        private void Form2_Load(object sender, EventArgs e)
        {

            

            // TODO: Bu kod satırı 'oKULDataSet.Ders' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.dersTableAdapter.Fill(this.oKULDataSet.Ders);
            // TODO: Bu kod satırı 'oKULDataSet.Ogretmen' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogretmenTableAdapter.Fill(this.oKULDataSet.Ogretmen);


            SqlCommand brans = new SqlCommand(" Select * From Ders ", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(brans);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.ValueMember = "Id";
            comboBox1.DisplayMember = "DersAd";
            comboBox1.DataSource = dt;

        }



        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand brans = new SqlCommand("insert into Ogretmen (DersId,OgretmenAd,OgretmenSoyad,KullanıcıKod) values (@p1,@p2,@p3,@p4)", baglanti);


            brans.Parameters.AddWithValue("@p1", comboBox1.SelectedValue);
            brans.Parameters.AddWithValue("@p2", ogretmenadBox2.Text);
            brans.Parameters.AddWithValue("@p3", soyadbox3.Text);
            brans.Parameters.AddWithValue("@p4", kodBox1.Text);

            brans.ExecuteNonQuery();


            baglanti.Close();

            MessageBox.Show("Başarıyla eklendi.");

            
        }



       
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ogretmenTableAdapter.FillBy(this.oKULDataSet.Ogretmen);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Ogretmen WHERE Ogretmen.Id = @OgretmenId";
            SqlCommand silogrt = new SqlCommand(query, baglanti);
            silogrt.Parameters.AddWithValue("@OgretmenId", Convert.ToInt32(idBox1.Text));
            baglanti.Open();
            silogrt.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Başarıyla silindi.");
        }

        private void button3_Click(object sender, EventArgs e)
        {

          

            string query = "UPDATE Ogretmen SET DersId = @p1,  OgretmenAd = @p2, OgretmenSoyad = @p3,  KullanıcıKod = @p4 WHERE Ogretmen.Id = @OgretmenId";
            SqlCommand ogrgunc = new SqlCommand(query, baglanti);
            ogrgunc.Parameters.AddWithValue("@p1", comboBox1.SelectedValue);
            ogrgunc.Parameters.AddWithValue("@p2", ogretmenadBox2.Text);
            ogrgunc.Parameters.AddWithValue("@p3", soyadbox3.Text);
            ogrgunc.Parameters.AddWithValue("@p4", kodBox1.Text);
            ogrgunc.Parameters.AddWithValue("@OgretmenId", Convert.ToInt32(idBox1.Text));



            baglanti.Open();
            ogrgunc.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Başarıyla güncellendi.");







        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

          ogretmenadBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            kodBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            soyadbox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
           
        }

        private void fillBy4ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ogretmenTableAdapter.FillBy4(this.oKULDataSet.Ogretmen);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
