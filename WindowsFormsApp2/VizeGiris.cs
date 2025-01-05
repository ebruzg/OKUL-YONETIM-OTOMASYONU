using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace WindowsFormsApp2
{
    public partial class VizeGiris : Form
    {
        public VizeGiris()

        {
            InitializeComponent();


        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-3CR91H0S;Initial Catalog=OKUL;Integrated Security=True");



        private string connectionString = ConfigurationManager.ConnectionStrings["baglanti2"].ConnectionString;


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        
    

            private void bolumComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bolumComboBox.SelectedIndex != -1)
            {
                using (SqlConnection baglanti = new SqlConnection(connectionString))
                {
                    DataTable dt101 = new DataTable();
                    SqlDataAdapter getir433 = new SqlDataAdapter(" Select * from Ders" +
                        " LEFT JOIN BolumDers ON BolumDers.DersId = Ders.Id " +
                        " LEFT JOIN Bolum ON Bolum.Id = BolumDers.BolumId " +
                     "where BolumId = " + bolumComboBox.SelectedValue, baglanti);


                    getir433.Fill(dt101);
                    dersComboBox.ValueMember = "Id";
                    dersComboBox.DisplayMember = "DersAd";
                    dersComboBox.DataSource = dt101;
                }
            }
        }


                private void VizeGiris_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'oKULDataSet.Ders' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.dersTableAdapter.Fill(this.oKULDataSet.Ders);
            // TODO: Bu kod satırı 'oKULDataSet.BolumDers' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bolumDersTableAdapter.Fill(this.oKULDataSet.BolumDers);


           SqlCommand bolumbul = new SqlCommand("Select * FROM Bolum", baglanti);
            SqlDataAdapter db = new SqlDataAdapter(bolumbul);
            DataTable bt = new DataTable();
            db.Fill(bt);
            bolumComboBox.DisplayMember = "BolumAd";
            bolumComboBox.ValueMember = "Id";
            bolumComboBox.DataSource = bt;
           
           

        

           /* bolumComboBox.SelectedIndex = -1;
            dersComboBox.SelectedIndex = -1; */
           
            SqlCommand gunbul = new SqlCommand("Select * FROM Gunler ", baglanti);
            SqlDataAdapter db2 = new SqlDataAdapter(gunbul);
            DataTable bt2 = new DataTable();
            db2.Fill(bt2);
            gunBox6.DisplayMember = "GunlerAd";
            gunBox6.ValueMember = "Id";
            gunBox6.DataSource = bt2;

            gunBox6.SelectedIndex = -1;
           




            SqlCommand oda = new SqlCommand("Select KatSinif.Id from KatSinif", baglanti);
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            SqlDataReader yaz9 = oda.ExecuteReader();
            while (yaz9.Read())
            {

                salonBox5.Items.Add(yaz9[0].ToString());
            }
            baglanti.Close();

            if (yaz9 != null && !yaz9.IsClosed)
            {
                yaz9.Close();
            }

           

            SqlCommand sinif = new SqlCommand("Select DISTINCT Sinif from Siniflar", baglanti);
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            SqlDataReader yaz10 = sinif.ExecuteReader();
            while (yaz10.Read())
            {

                sinifbox.Items.Add(yaz10[0].ToString());
            }
            if (yaz10 != null && !yaz10.IsClosed)
            {
                yaz10.Close();
            }

            
            baglanti.Close();


            SqlCommand idal = new SqlCommand("Select Id from VizeSinav", baglanti);
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            SqlDataReader yaz15 = idal.ExecuteReader();
            while (yaz15.Read())
            {

                idBox2.Items.Add(yaz15[0].ToString());
            }

            if (yaz15 != null && !yaz15.IsClosed)
            {
                yaz15.Close();
            }

          
            baglanti.Close();



            SqlCommand grup2 = new SqlCommand("Select DISTINCT Grubu from Siniflar", baglanti);
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            SqlDataReader yaz11 = grup2.ExecuteReader();
            while (yaz11.Read())
            {
                grupbox.Items.Add(yaz11[0].ToString());

            }
            if (yaz11 != null && !yaz11.IsClosed)
            {
               yaz11.Close();
            }

          

            baglanti.Close();


            SqlCommand vizeSinavSaati = new SqlCommand("Select SaatBasla,SaatBitis from Saatler", baglanti);

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            SqlDataReader yaz7 = vizeSinavSaati.ExecuteReader();
            while (yaz7.Read())
            {

                string saatBasla = yaz7["SaatBasla"].ToString();
                string saatBitis = yaz7["SaatBitis"].ToString();
                string saatArasi = $"{saatBasla} - {saatBitis}";
                saatBox7.Items.Add(saatArasi);


            }

            if (yaz7 != null && !yaz7.IsClosed)
            {
                yaz7.Close();
            }

          
            
            baglanti.Close();
        }


        private void InsertIntoVizeSinav(int saatId, int bolumDersId, int sinifId)
        {
            try
            {

                string query = @"INSERT INTO VizeSinav (SaatNo,BolumDersId,SinifId,GunNo,SalonNo) VALUES (@SaatId,@BolumDersId,@SinifId,@GunNo,@SalonNo)";
                using (SqlCommand sonekle = new SqlCommand(query, baglanti))
                {
                    sonekle.Parameters.AddWithValue("@BolumDersId", bolumDersId);
                    sonekle.Parameters.AddWithValue("@SaatId", saatId);
                    sonekle.Parameters.AddWithValue("@SinifId", sinifId);
                    sonekle.Parameters.AddWithValue("@GunNo", gunBox6.SelectedValue);
                    sonekle.Parameters.AddWithValue("@SalonNo", salonBox5.SelectedItem);
                    //sonekle.Parameters.AddWithValue("SalonNo", Convert.ToInt32(salonBox5.SelectedItem));
                    baglanti.Open();

                    sonekle.ExecuteNonQuery();
                    MessageBox.Show("Başarıyla eklendi");


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);

            }
            baglanti.Close();
        }

        private void VizeSinaviGuncelle(int saatId, int bolumDersId, int sinifId)
        { 

       baglanti.Open();
            string query = "UPDATE VizeSinav SET BolumDersId = @BolumDersId, SaatNo= @SaatId, " +
                " SinifId = @SinifId , GunNo=@GunNo , SalonNo=@SalonNo WHERE Id=@Id";
        SqlCommand guncelle = new SqlCommand(query, baglanti);
        guncelle.Parameters.AddWithValue("@BolumDersId", bolumDersId);
            guncelle.Parameters.AddWithValue("@SaatId", saatId);
            guncelle.Parameters.AddWithValue("@SinifId", sinifId);
            guncelle.Parameters.AddWithValue("@GunNo", gunBox6.SelectedValue);
            guncelle.Parameters.AddWithValue("@SalonNo", salonBox5.SelectedItem);
            guncelle.Parameters.AddWithValue("@Id", idBox2.SelectedItem);
            guncelle.ExecuteNonQuery();
            MessageBox.Show("Başarıyla güncellendi");
            baglanti.Close();
            }

        private int GetBolumDersIdFromDatabase(int bolumId, int dersId)
        {
            int bolumDersId = 0;

            try
            {

                string query = "SELECT BolumDers.Id FROM BolumDers WHERE BolumId = @BolumId AND DersId = @DersId";
                using (SqlCommand command = new SqlCommand(query, baglanti))
                {
                    command.Parameters.AddWithValue("@BolumId", bolumId);
                    command.Parameters.AddWithValue("@DersId", dersId);
                    baglanti.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        bolumDersId = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }

            return bolumDersId;
        }


        private int GetId(string vizeSinavSaati)
        {


            int vizeSinavSaatId = 0;

            string query = "SELECT Saatler.Id FROM Saatler " +
                           "INNER JOIN VizeSinav ON VizeSinav.SaatNo = Saatler.Id " +
                           "WHERE SaatBasla = @VizeSaat OR SaatBitis = @VizeSaat";

            using (SqlCommand command = new SqlCommand(query, baglanti))
            {

                string[] saatler = vizeSinavSaati.Split('-');
                string baslangicSaat = saatler[0].Trim();
                string bitisSaat = saatler[1].Trim();


                command.Parameters.AddWithValue("@VizeSaat", baslangicSaat);


                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                using (SqlDataReader reader1 = command.ExecuteReader())
                {
                    if (reader1.Read())
                    {
                        vizeSinavSaatId = reader1.GetInt32(0);

                    }

                    if (reader1 != null && !reader1.IsClosed)
                    {
                        reader1.Close();
                    }

                    baglanti.Close();

                }
            }
            return vizeSinavSaatId;
        }

        private int[] GetIdsFromTimeRange(string timeRange)
        {
            string[] hours = timeRange.Split('-');
            string startTime = hours[0].Trim();
            string endTime = hours[1].Trim();

            int[] ids = new int[2];

            string query = "SELECT Saatler.Id FROM Saatler WHERE SaatBasla = @StartTime OR SaatBitis = @EndTime";

            using (SqlCommand command = new SqlCommand(query, baglanti))
            {

                command.Parameters.AddWithValue("@StartTime", startTime);
                command.Parameters.AddWithValue("@EndTime", endTime);

                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    int i = 0;
                    while (reader.Read() && i < 2)
                    {
                        ids[i] = reader.GetInt32(0);
                        i++;

                    }


                    if (reader != null && !reader.IsClosed)
                    {
                        reader.Close();
                    }


                    baglanti.Close();

                }

                return ids;
            }
        }


        private int GetSinifId(string bolumAd, string sinif, string grup)
        {

            int sinifId = 0;

            string query = $@"SELECT Siniflar.Id FROM Siniflar  
                   INNER JOIN Bolum ON Siniflar.BolumId = Bolum.Id 
                   INNER JOIN VizeSinav ON VizeSinav.SinifId = Siniflar.Id
         WHERE BolumAd = @BolumAd and Sinif = @Sinif and Grubu = @Grup";

            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                using (SqlCommand ekle3 = new SqlCommand(query, baglanti))
                {
                    ekle3.Parameters.AddWithValue("@BolumAd", bolumAd);
                    ekle3.Parameters.AddWithValue("@Sinif", sinif);
                    ekle3.Parameters.AddWithValue("@Grup", grup);


                    baglanti.Open();
                    try
                    {
                        object result = ekle3.ExecuteScalar();

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

        private int GetSelectedSaatID()
        {
            DataGridViewRow selectedRow = dataGridView1.CurrentRow;
            return Convert.ToInt32(selectedRow.Cells[5].Value);
        }


        private string GetGunAdByID(int gunID)
        {
            string gunAd = "";

           
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            SqlCommand gunSorgu = new SqlCommand("SELECT GunlerAd FROM Gunler WHERE Gunler.Id = @GunID", baglanti);
            gunSorgu.Parameters.AddWithValue("@GunID", gunID);

            using (SqlDataReader gunoku = gunSorgu.ExecuteReader())
            {
                if (gunoku.Read())
                {
                    gunAd = gunoku["GunlerAd"].ToString();
                }
                if (gunoku != null && !gunoku.IsClosed)
                {
                    gunoku.Close();
                }

                
            }

            baglanti.Close();

            return gunAd;
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {

            idBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            salonBox5.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();





            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }


            int selectedGunID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[5].Value);


            string selectedGunAd = GetGunAdByID(selectedGunID);

            gunBox6.Text = selectedGunAd;



            int selectedID = Convert.ToInt32(GetSelectedSaatID());


            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }


            SqlCommand saatsorgu = new SqlCommand("SELECT SaatBasla, SaatBitis FROM Saatler WHERE Saatler.Id = @SaatlerId", baglanti);
            saatsorgu.Parameters.AddWithValue("@SaatlerId", selectedID);


            using (SqlDataReader okuyucu = saatsorgu.ExecuteReader())
            {
                if (okuyucu.Read())
                {
                    string saatBasla = okuyucu["SaatBasla"].ToString();
                    string saatBitis = okuyucu["SaatBitis"].ToString();
                    string saatArasi = $"{saatBasla} - {saatBitis}";
                    saatBox7.SelectedItem = saatArasi;
                }

                if (okuyucu != null && !okuyucu.IsClosed)
                {
                    okuyucu.Close();
                }
            }


            baglanti.Close();

        
            string bolumdersId = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            SqlCommand dersSorgu = new SqlCommand("SELECT * FROM BolumDers " +
                "INNER JOIN Ders ON Ders.Id= BolumDers.DersId " +
                "INNER JOIN Bolum ON Bolum.Id = BolumDers.BolumId " +
                  "WHERE BolumDers.Id = @BolumDersId" , baglanti);

            dersSorgu.Parameters.AddWithValue("@BolumDersId", bolumdersId);

            baglanti.Open();
            SqlDataReader dersOkuyucu = dersSorgu.ExecuteReader();

            if (dersOkuyucu.Read())
            {

                bolumComboBox.Text = dersOkuyucu["BolumAd"].ToString();
                dersComboBox.Text = dersOkuyucu["DersAd"].ToString();
            }

            dersOkuyucu.Close();
            baglanti.Close();
        

        string sinifId = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            SqlCommand sinifSorgu = new SqlCommand("SELECT * FROM Siniflar WHERE Siniflar.Id = @SinifId", baglanti);
            sinifSorgu.Parameters.AddWithValue("@SinifId", sinifId);

            baglanti.Open();
            SqlDataReader sinifOkuyucu = sinifSorgu.ExecuteReader();

            if (sinifOkuyucu.Read())
            {
             
                sinifbox.Text = sinifOkuyucu["Sinif"].ToString();
                grupbox.Text = sinifOkuyucu["Grubu"].ToString();
            }

            sinifOkuyucu.Close();
            baglanti.Close();
           
        }
        
        

       

        private void button1_Click(object sender, EventArgs e)
        {

            // Seçilen bölüm ID ve ders ID'lerini al
            int bolumId = (int)bolumComboBox.SelectedValue;
            int dersId = (int)dersComboBox.SelectedValue;
            string selectedTimeRange = saatBox7.SelectedItem.ToString();
            string sinif = sinifbox.Text;
            string grup = grupbox.Text;
            string bolumAd = bolumComboBox.Text;
            int sinifId = GetSinifId(bolumAd, sinif, grup);


            int[] saatIds = GetIdsFromTimeRange(selectedTimeRange);

            // Bölüm ID ve ders ID'leri ile bölüm ders ID'sini bul
            int bolumDersId = GetBolumDersIdFromDatabase(bolumId, dersId);

            InsertIntoVizeSinav(saatIds[0], bolumDersId, sinifId);
          



        }

        private void button3_Click(object sender, EventArgs e)
        {

            string query = "DELETE FROM VizeSinav WHERE VizeSinav.Id = @Id";
           SqlCommand sil = new SqlCommand(query, baglanti);
            sil.Parameters.AddWithValue("@Id",Convert.ToInt32(idBox2.Text));
            baglanti.Open();
            sil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Başarıyla silindi.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int bolumId = (int)bolumComboBox.SelectedValue;
            int dersId = (int)dersComboBox.SelectedValue;
            string selectedTimeRange = saatBox7.SelectedItem.ToString();
            string sinif = sinifbox.Text;
            string grup = grupbox.Text;
            string bolumAd = bolumComboBox.Text;
            int sinifId = GetSinifId(bolumAd, sinif, grup);
            int bolumDersId = GetBolumDersIdFromDatabase(bolumId, dersId);


            int[] saatIds = GetIdsFromTimeRange(selectedTimeRange);
            VizeSinaviGuncelle(saatIds[0], bolumDersId, sinifId);
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.vizeSinavTableAdapter.FillBy(this.oKULDataSet.VizeSinav);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.vizeSinavTableAdapter.FillBy1(this.oKULDataSet.VizeSinav);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }



    }
    
    

