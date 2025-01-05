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
    public partial class DersEkle : Form
    {
        public DersEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-3CR91H0S;Initial Catalog=OKUL;Integrated Security=True");

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'oKULDataSet.Bolum' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bolumTableAdapter.Fill(this.oKULDataSet.Bolum);
            // TODO: Bu kod satırı 'oKULDataSet.DersProgrami' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.dersProgramiTableAdapter.Fill(this.oKULDataSet.DersProgrami);
            // TODO: Bu kod satırı 'oKULDataSet.Siniflar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.siniflarTableAdapter.Fill(this.oKULDataSet.Siniflar);
            // TODO: Bu kod satırı 'oKULDataSet.BolumDers' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bolumDersTableAdapter.Fill(this.oKULDataSet.BolumDers);
            // TODO: Bu kod satırı 'oKULDataSet.Ders' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.dersTableAdapter.Fill(this.oKULDataSet.Ders);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ekleBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand derss = new SqlCommand("insert into Ders (DersAd) values (@p1)", baglanti);

            derss.Parameters.AddWithValue("@p1", ekleBox1.Text);

            derss.ExecuteNonQuery();


            baglanti.Close();

            MessageBox.Show("Başarıyla eklendi.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand ders1 = new SqlCommand("insert into BolumDers(DersId, BolumId) values (@t1, @t2)", baglanti);

            ders1.Parameters.AddWithValue("@t1", secdbox.SelectedValue);
            ders1.Parameters.AddWithValue("@t2", bolumsecBox2.SelectedValue);

            ders1.ExecuteNonQuery();


            baglanti.Close();

            MessageBox.Show("Başarıyla eklendi.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();


            SqlCommand deleteCommand = new SqlCommand(
                "DELETE FROM DersProgrami WHERE BolumDersId IN (SELECT BolumDersId FROM BolumDers WHERE DersId = @t1 AND BolumId = @t2)",
                baglanti);

            deleteCommand.Parameters.AddWithValue("@t1", secdbox.SelectedValue);
            deleteCommand.Parameters.AddWithValue("@t2", bolumsecBox2.SelectedValue);

            deleteCommand.ExecuteNonQuery();


            SqlCommand deleteCommand2 = new SqlCommand(
                "DELETE FROM BolumDers WHERE DersId = @t1 AND BolumId = @t2",
                baglanti);

            deleteCommand2.Parameters.AddWithValue("@t1", secdbox.SelectedValue);
            deleteCommand2.Parameters.AddWithValue("@t2", bolumsecBox2.SelectedValue);

            deleteCommand2.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Başarıyla silindi.");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand updateCommand4 = new SqlCommand("UPDATE BolumDers " +
                "SET BolumId= @t9, DersId= @t10 WHERE BolumDers.Id = @t11",
               baglanti);
            updateCommand4.Parameters.AddWithValue("@t11", idbox10.SelectedValue);
            updateCommand4.Parameters.AddWithValue("@t9", bolumsecBox2.SelectedValue);
            updateCommand4.Parameters.AddWithValue("@t10", secdbox.SelectedValue);

            updateCommand4.ExecuteNonQuery();



            baglanti.Close();
            MessageBox.Show("Başarıyla guncellendi.");
        }

        private void button6_Click(object sender, EventArgs e)

        {
            baglanti.Open();
            SqlCommand updateCommand3 = new SqlCommand("UPDATE Ders SET DersAd= @t8 WHERE Ders.Id = @t1",
               baglanti);

            updateCommand3.Parameters.AddWithValue("@t8", ekleBox1.Text);
            updateCommand3.Parameters.AddWithValue("@t1", idbox8.SelectedValue);

            updateCommand3.ExecuteNonQuery();



            baglanti.Close();
            MessageBox.Show("Başarıyla guncellendi.");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglanti.Open();


            SqlCommand deleteCommand3 = new SqlCommand( "DELETE FROM Ders WHERE Ders.Id = @t1" ,
                baglanti);

            deleteCommand3.Parameters.AddWithValue("@t1", idbox8.SelectedValue);
     

            deleteCommand3.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Başarıyla silindi.");
        }
    }
    }

