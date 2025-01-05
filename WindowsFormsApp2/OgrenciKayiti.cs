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
using MongoDB.Driver.Core.Configuration;

namespace WindowsFormsApp2
{
    public partial class OgrenciKayiti : Form
    {
        public OgrenciKayiti()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-3CR91H0S;Initial Catalog=OKUL;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Cmbbolum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OgrenciKayiti_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cinsiyet = new SqlCommand("Select CinsiyetAd from Cinsiyet ", baglanti);
            SqlDataReader yaz3 = cinsiyet.ExecuteReader();
            while (yaz3.Read())
            {
                cinsiyet1.Items.Add(yaz3[0].ToString());
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand kumanda = new SqlCommand("Select  BolumAd from Bolum", baglanti);
            SqlDataReader yaz = kumanda.ExecuteReader();
            while (yaz.Read())
            {

                Cmbbolum.Items.Add(yaz[0].ToString());
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand sinifkomutu = new SqlCommand("Select DISTINCT Sinif from Siniflar", baglanti);
            SqlDataReader yaz1 = sinifkomutu.ExecuteReader();
            while (yaz1.Read())
            {

                sinifcomboBox3.Items.Add(yaz1[0].ToString());



            }

            baglanti.Close();

            baglanti.Open();
            SqlCommand grupkomutu = new SqlCommand("Select DISTINCT Grubu from Siniflar", baglanti);
            SqlDataReader yaz2 = grupkomutu.ExecuteReader();
            while (yaz2.Read())

            {
                grubucomboBox4.Items.Add(yaz2[0].ToString());
            }

            baglanti.Close();


        }




        private int GetId(string cinsiyetAd)
        {
            int cinsiyetId = 0;

            string query = "SELECT Id FROM Cinsiyet WHERE CinsiyetAd = @CinsiyetAd";
            string connectionString = @"Data Source=LAPTOP-3CR91H0S;Initial Catalog=OKUL;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CinsiyetAd", cinsiyetAd);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            cinsiyetId = Convert.ToInt32(result);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }

            return cinsiyetId;
        }




        
        
        private int GetSinifId(string bolumAd, string sinif, string grup)
           
        {
            int sinifId = 0;


            string query = "SELECT Siniflar.Id FROM Siniflar " +
                           "INNER JOIN Bolum ON Siniflar.BolumId = Bolum.Id " +
                           "WHERE BolumAd = @BolumAd AND Sinif = @Sinif AND Grubu = @Grup";


            string connectionString = @"Data Source=LAPTOP-3CR91H0S;Initial Catalog=OKUL;Integrated Security=True";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    connection.Open();

                    command.Parameters.AddWithValue("@BolumAd", bolumAd);
                    command.Parameters.AddWithValue("@Sinif", sinif);
                    command.Parameters.AddWithValue("@Grup", grup);

                    try
                    {


                        object result = command.ExecuteScalar();


                        if (result != null)
                        {
                            sinifId = Convert.ToInt32(result);
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Hata: " + ex.Message);
                    }
               
               
                }

                connection.Close();
            }


            return sinifId;
        }
        /*
        private int GetSinifId2(string bolumAd, string sinif, string grup)
        {
            int sinifId = 0;


            string query = "SELECT Id FROM Siniflar " +
                           "INNER JOIN Bolum ON Siniflar.BolumId = Bolum.Id " +
                           "WHERE BolumAd = @BolumAd AND Sinif = @Sinif AND Grubu = @Grup";


            string connectionString = @"Data Source=LAPTOP-3CR91H0S;Initial Catalog=OKUL;Integrated Security=True";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    connection.Open();

                    command.Parameters.AddWithValue("@BolumAd", bolumAd);
                    command.Parameters.AddWithValue("@Sinif", sinif);
                    command.Parameters.AddWithValue("@Grup", grup);

                    try
                    {


                        object result = command.ExecuteScalar();


                        if (result != null)
                        {
                            sinifId = Convert.ToInt32(result);
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
                connection.Close();
            }

            
            return sinifId;
        }
        */
        private void Button1_Click(object sender, EventArgs e)
        {
            string ogrenciAd = ogrenci.Text;
            string ogrenciSoyad = ogrencisoyad.Text;
            string cinsiyetAd = cinsiyet1.Text;
            string bolumAd = Cmbbolum.Text;
            string sinif = sinifcomboBox3.Text;
            string grup = grubucomboBox4.Text;
            string kullaniciKod = kullanicik.Text;

            if (string.IsNullOrEmpty(ogrenciAd) || string.IsNullOrEmpty(ogrenciSoyad) || string.IsNullOrEmpty(cinsiyetAd) || string.IsNullOrEmpty(bolumAd) || string.IsNullOrEmpty(sinif) || string.IsNullOrEmpty(grup))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

           
            int cinsiyetId = GetId(cinsiyetAd);

            if (cinsiyetId == 0)
            {
                MessageBox.Show("Geçersiz cinsiyet adı.");
                return;
            }


            int sinifId = GetSinifId(bolumAd, sinif,
                                     grup);

            if (sinifId == 0)
            {
                MessageBox.Show("Geçersiz sınıf bilgileri.");
                return;
            }
           

            string connectionString = @"Data Source=LAPTOP-3CR91H0S;Initial Catalog=OKUL;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Ogrenci (Ad, Soyad, CinsiyetId, SinifId, KullaniciKod) VALUES (@Ad, @Soyad, @CinsiyetId, @SinifId, @KullaniciKodu)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Ad", ogrenciAd);
                    command.Parameters.AddWithValue("@Soyad", ogrenciSoyad);
                    command.Parameters.AddWithValue("@CinsiyetId", cinsiyetId);
                    command.Parameters.AddWithValue("@SinifId", sinifId);
                    command.Parameters.AddWithValue(" @KullaniciKodu" , kullaniciKod);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show($"{rowsAffected} satır eklendi.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
        }
    }
}
              
          