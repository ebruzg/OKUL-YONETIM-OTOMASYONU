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
using System.Configuration;

namespace WindowsFormsApp2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-3CR91H0S;Initial Catalog=OKUL;Integrated Security=True");
        private string connectionString = ConfigurationManager.ConnectionStrings["baglanti2"].ConnectionString;

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'oKULDataSet.Bolum' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bolumTableAdapter.Fill(this.oKULDataSet.Bolum);
            // TODO: Bu kod satırı 'oKULDataSet.DersProgrami' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.dersProgramiTableAdapter.Fill(this.oKULDataSet.DersProgrami);

            SqlCommand grup2 = new SqlCommand("Select DISTINCT Grubu from Siniflar", baglanti);
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            SqlDataReader yaz11 = grup2.ExecuteReader();
            while (yaz11.Read())
            {
                gruppBox2.Items.Add(yaz11[0].ToString());

            }
            if (yaz11 != null && !yaz11.IsClosed)
            {
                yaz11.Close();
            }


            SqlCommand sinif2 = new SqlCommand("Select DISTINCT Sinif from Siniflar", baglanti);
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            SqlDataReader yaz12 = sinif2.ExecuteReader();
            while (yaz12.Read())
            {
                siniffcomboBox.Items.Add(yaz12[0].ToString());

            }
            if (yaz12 != null && !yaz12.IsClosed)
            {
                yaz12.Close();
            }

            SqlCommand bolumbul = new SqlCommand("Select * FROM Bolum", baglanti);
            SqlDataAdapter db = new SqlDataAdapter(bolumbul);
            DataTable bt = new DataTable();
            db.Fill(bt);
            bolumbox6.DisplayMember = "BolumAd";
            bolumbox6.ValueMember = "Id";
            bolumbox6.DataSource = bt;



        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private int GetSinifId(string bolumAd, string sinif, string grup)
        {

            int sinifId = 0;

            string query = $@"SELECT Siniflar.Id FROM Siniflar  
                   INNER JOIN Bolum ON Siniflar.BolumId = Bolum.Id 
                   INNER JOIN DersProgrami ON DersProgrami.SinifId = Siniflar.Id
         WHERE BolumAd=@BolumAd and Sinif=@Sinif and Grubu=@Grup";

            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                using (SqlCommand ekle45 = new SqlCommand(query, baglanti))
                {
                    ekle45.Parameters.AddWithValue("@BolumAd", bolumAd);
                    ekle45.Parameters.AddWithValue("@Sinif", sinif);
                    ekle45.Parameters.AddWithValue("@Grup", grup);


                    baglanti.Open();
                    try
                    {
                        object result = ekle45.ExecuteScalar();

                        if (result != null)
                        {
                            sinifId = Convert.ToInt32(result);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }

                    {

                    }
                }
                baglanti.Close();
            }

            return sinifId;
        }

        private DataTable SinifveBolumSorgula(int sinifId)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {

                baglanti.Open();
                SqlCommand sorgula = new SqlCommand("Select * from DersProgrami " +
                "INNER JOIN Siniflar ON Siniflar.Id = DersProgrami.SinifId " +
                "INNER JOIN Bolum ON Siniflar.BolumId = Bolum.Id " +
                "where SinifId=@SinifId", baglanti);

                sorgula.Parameters.AddWithValue("@SinifId", sinifId);


                using (SqlDataReader reader = sorgula.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
                baglanti.Close();
            }
            return dataTable;

        }
        private void button4_Click(object sender, EventArgs e)
        {

            string bolumAd = bolumbox6.Text;
            string grup = gruppBox2.SelectedItem.ToString();
            string sinif = siniffcomboBox.SelectedItem.ToString();
            int sinifId = GetSinifId(bolumAd, sinif, grup);
            if (sinifId != 0)
            {
                DataTable dataTable = SinifveBolumSorgula(sinifId);
                dataGridView1.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("Belirtilen sınıfa ders programı hazırlanmamış.");





            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}




