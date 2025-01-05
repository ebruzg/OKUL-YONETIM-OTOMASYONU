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
    public partial class FinalGiris : Form
    {
        public FinalGiris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-3CR91H0S;Initial Catalog=OKUL;Integrated Security=True");


        private string connectionString = ConfigurationManager.ConnectionStrings["baglanti2"].ConnectionString;
        private void FinalGiris_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'oKULDataSet.FinalSinav' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.finalSinavTableAdapter.Fill(this.oKULDataSet.FinalSinav);

            SqlCommand bolumbul1 = new SqlCommand("Select * FROM Bolum", baglanti);
            SqlDataAdapter db25 = new SqlDataAdapter(bolumbul1);
            DataTable bt25 = new DataTable();
            db25.Fill(bt25);
            bolumComboBox1.DisplayMember = "BolumAd";
            bolumComboBox1.ValueMember = "Id";
            bolumComboBox1.DataSource = bt25;

            SqlCommand gunbull = new SqlCommand("Select * FROM Gunler ", baglanti);
            SqlDataAdapter db20 = new SqlDataAdapter(gunbull);
            DataTable bt20 = new DataTable();
            db20.Fill(bt20);
            gunBox7.DisplayMember = "GunlerAd";
            gunBox7.ValueMember = "Id";
            gunBox7.DataSource = bt20;

            gunBox7.SelectedIndex = -1;



            SqlCommand oda1 = new SqlCommand("Select KatSinif.Id from KatSinif", baglanti);
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            SqlDataReader yaz90 = oda1.ExecuteReader();
            while (yaz90.Read())
            {

                salonBox8.Items.Add(yaz90[0].ToString());
            }
            baglanti.Close();

            if (yaz90 != null && !yaz90.IsClosed)
            {
                yaz90.Close();
            }



            SqlCommand sinif1 = new SqlCommand("Select DISTINCT Sinif from Siniflar", baglanti);
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            SqlDataReader yaz109 = sinif1.ExecuteReader();
            while (yaz109.Read())
            {

                sinifBox1.Items.Add(yaz109[0].ToString());
            }
            if (yaz109 != null && !yaz109.IsClosed)
            {
                yaz109.Close();
            }


            baglanti.Close();


            SqlCommand idal1 = new SqlCommand("Select Id from FinalSinav", baglanti);
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            SqlDataReader yaz150 = idal1.ExecuteReader();
            while (yaz150.Read())
            {

                idBox3.Items.Add(yaz150[0].ToString());
            }

            if (yaz150 != null && !yaz150.IsClosed)
            {
                yaz150.Close();
            }


            baglanti.Close();



            SqlCommand grup3 = new SqlCommand("Select DISTINCT Grubu from Siniflar", baglanti);
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            SqlDataReader yaz110 = grup3.ExecuteReader();
            while (yaz110.Read())
            {
                grupbox1.Items.Add(yaz110[0].ToString());

            }
            if (yaz110 != null && !yaz110.IsClosed)
            {
                yaz110.Close();
            }



            baglanti.Close();


            SqlCommand finalSinavSaati = new SqlCommand("Select SaatBasla,SaatBitis from Saatler", baglanti);

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            SqlDataReader yaz70 = finalSinavSaati.ExecuteReader();
            while (yaz70.Read())
            {

                string saatBasla = yaz70["SaatBasla"].ToString();
                string saatBitis = yaz70["SaatBitis"].ToString();
                string saatArasi = $"{saatBasla} - {saatBitis}";
                saatBox8.Items.Add(saatArasi);


            }

            if (yaz70 != null && !yaz70.IsClosed)
            {
                yaz70.Close();
            }



            baglanti.Close();
        }


        private void bolumComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (bolumComboBox1.SelectedIndex != -1)
            {
                using (SqlConnection baglanti = new SqlConnection(connectionString))
                {
                    DataTable dt101 = new DataTable();
                    SqlDataAdapter getir433 = new SqlDataAdapter(" Select * from Ders" +
                        " LEFT JOIN BolumDers ON BolumDers.DersId = Ders.Id " +
                        " LEFT JOIN Bolum ON Bolum.Id = BolumDers.BolumId " +
                     "where BolumId = " + bolumComboBox1.SelectedValue, baglanti);


                    getir433.Fill(dt101);
                    dersComboBox1.ValueMember = "Id";
                    dersComboBox1.DisplayMember = "DersAd";
                    dersComboBox1.DataSource = dt101;
                }
            }
        }

        private void InsertIntoFinalSinav(int saatId, int bolumDersId, int sinifId)
        {
            try
            {

                string query = @"INSERT INTO FinalSinav (SaatNo,BolumDersId,SinifId,GunNo,SalonNo) VALUES (@SaatId,@BolumDersId,@SinifId,@GunNo,@SalonNo)";
                using (SqlCommand sonekle1 = new SqlCommand(query, baglanti))
                {
                    sonekle1.Parameters.AddWithValue("@BolumDersId", bolumDersId);
                    sonekle1.Parameters.AddWithValue("@SaatId", saatId);
                    sonekle1.Parameters.AddWithValue("@SinifId", sinifId);
                    sonekle1.Parameters.AddWithValue("@GunNo", gunBox7.SelectedValue);
                    sonekle1.Parameters.AddWithValue("@SalonNo", salonBox8.SelectedItem);
                    //sonekle.Parameters.AddWithValue("SalonNo", Convert.ToInt32(salonBox5.SelectedItem));
                    baglanti.Open();

                    sonekle1.ExecuteNonQuery();
                    MessageBox.Show("Başarıyla eklendi");


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);

            }
            baglanti.Close();
        }

        private void FinalSinaviGuncelle(int saatId, int bolumDersId, int sinifId)
        {

            baglanti.Open();
            string query = "UPDATE FinalSinav SET BolumDersId=@BolumDersId,SaatNo=@SaatId, " +
                " SinifId = @SinifId,GunNo=@GunNo,SalonNo=@SalonNo WHERE Id=@Id";
            SqlCommand guncelle = new SqlCommand(query, baglanti);
            guncelle.Parameters.AddWithValue("@BolumDersId", bolumDersId);
            guncelle.Parameters.AddWithValue("@SaatId", saatId);
            guncelle.Parameters.AddWithValue("@SinifId", sinifId);
            guncelle.Parameters.AddWithValue("@GunNo", gunBox7.SelectedValue);
            guncelle.Parameters.AddWithValue("@SalonNo", salonBox8.SelectedItem);
            guncelle.Parameters.AddWithValue("@Id", idBox3.SelectedItem);
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


        

        private int[] GetIdsFromTimeRange(string timeRange)
        {
            string[] hours = timeRange.Split('-');
            string startTime = hours[0].Trim();
            string endTime = hours[1].Trim();

            int[] ids = new int[2];

            string query = "SELECT Saatler.Id FROM Saatler WHERE SaatBasla = @StartTime OR SaatBitis = @EndTime";

            using (SqlCommand command1 = new SqlCommand(query, baglanti))
            {

                command1.Parameters.AddWithValue("@StartTime", startTime);
                command1.Parameters.AddWithValue("@EndTime", endTime);

                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                using (SqlDataReader reader4 = command1.ExecuteReader())
                {
                    int i = 0;
                    while (reader4.Read() && i < 2)
                    {
                        ids[i] = reader4.GetInt32(0);
                        i++;

                    }


                    if (reader4 != null && !reader4.IsClosed)
                    {
                        reader4.Close();
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
                   INNER JOIN FinalSinav ON FinalSinav.SinifId = Siniflar.Id
         WHERE BolumAd = @BolumAd and Sinif = @Sinif and Grubu = @Grup";

            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                using (SqlCommand ekle40 = new SqlCommand(query, baglanti))
                {
                    ekle40.Parameters.AddWithValue("@BolumAd", bolumAd);
                    ekle40.Parameters.AddWithValue("@Sinif", sinif);
                    ekle40.Parameters.AddWithValue("@Grup", grup);


                    baglanti.Open();
                    try
                    {
                        object result = ekle40.ExecuteScalar();

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
            DataGridViewRow selectedRow = dataGridView5.CurrentRow;
            return Convert.ToInt32(selectedRow.Cells[5].Value);
        }


        private string GetGunAdByID(int gunID)
        {
            string gunAd = "";


            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            SqlCommand gunSorguu = new SqlCommand("SELECT GunlerAd FROM Gunler WHERE Gunler.Id = @GunID", baglanti);
            gunSorguu.Parameters.AddWithValue("@GunID", gunID);

            using (SqlDataReader gunokuu = gunSorguu.ExecuteReader())
            {
                if (gunokuu.Read())
                {
                    gunAd = gunokuu["GunlerAd"].ToString();
                }
                if (gunokuu != null && !gunokuu.IsClosed)
                {
                    gunokuu.Close();
                }


            }

            baglanti.Close();

            return gunAd;
        }

        private void dataGridView5_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {

            idBox3.Text = dataGridView5.CurrentRow.Cells[0].Value.ToString();
            salonBox8.Text = dataGridView5.CurrentRow.Cells[3].Value.ToString();





            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }


            int selectedGunID = Convert.ToInt32(dataGridView5.CurrentRow.Cells[5].Value);


            string selectedGunAd = GetGunAdByID(selectedGunID);

            gunBox7.Text = selectedGunAd;



            int selectedID = Convert.ToInt32(GetSelectedSaatID());


            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }


            SqlCommand saatsorguu = new SqlCommand("SELECT SaatBasla, SaatBitis FROM Saatler WHERE Saatler.Id = @SaatlerId", baglanti);
            saatsorguu.Parameters.AddWithValue("@SaatlerId", selectedID);


            using (SqlDataReader okuyucuu = saatsorguu.ExecuteReader())
            {
                if (okuyucuu.Read())
                {
                    string saatBasla = okuyucuu["SaatBasla"].ToString();
                    string saatBitis = okuyucuu["SaatBitis"].ToString();
                    string saatArasi = $"{saatBasla} - {saatBitis}";
                    saatBox8.SelectedItem = saatArasi;
                }

                if (okuyucuu != null && !okuyucuu.IsClosed)
                {
                    okuyucuu.Close();
                }
            }


            baglanti.Close();

        
            string bolumdersId = dataGridView5.CurrentRow.Cells[1].Value.ToString();

            SqlCommand dersSorguu = new SqlCommand("SELECT * FROM BolumDers " +
                "INNER JOIN Ders ON Ders.Id= BolumDers.DersId " +
                "INNER JOIN Bolum ON Bolum.Id = BolumDers.BolumId " +
                  "WHERE BolumDers.Id = @BolumDersId", baglanti);

            dersSorguu.Parameters.AddWithValue("@BolumDersId", bolumdersId);

            baglanti.Open();
            SqlDataReader dersOkuyucuu = dersSorguu.ExecuteReader();

            if (dersOkuyucuu.Read())
            {

                bolumComboBox1.Text = dersOkuyucuu["BolumAd"].ToString();
                dersComboBox1.Text = dersOkuyucuu["DersAd"].ToString();
            }

            dersOkuyucuu.Close();
            baglanti.Close();


            string sinifId = dataGridView5.CurrentRow.Cells[2].Value.ToString();

            SqlCommand sinifSorguu = new SqlCommand("SELECT * FROM Siniflar WHERE Siniflar.Id = @SinifId", baglanti);
            sinifSorguu.Parameters.AddWithValue("@SinifId", sinifId);

            baglanti.Open();
            SqlDataReader sinifOkuyucus = sinifSorguu.ExecuteReader();

            if (sinifOkuyucus.Read())
            {

                sinifBox1.Text = sinifOkuyucus["Sinif"].ToString();
                grupbox1.Text = sinifOkuyucus["Grubu"].ToString();
            }

            sinifOkuyucus.Close();
            baglanti.Close();

        }





        private void button1_Click_1(object sender, EventArgs e)
        {


            int bolumId = (int)bolumComboBox1.SelectedValue;
            int dersId = (int)dersComboBox1.SelectedValue;
            string selectedTimeRange = saatBox8.SelectedItem.ToString();
            string sinif = sinifBox1.Text;
            string grup = grupbox1.Text;
            string bolumAd = bolumComboBox1.Text;
            int sinifId = GetSinifId(bolumAd, sinif, grup);


            int[] saatIds = GetIdsFromTimeRange(selectedTimeRange);


            int bolumDersId = GetBolumDersIdFromDatabase(bolumId, dersId);

            InsertIntoFinalSinav(saatIds[0], bolumDersId, sinifId);




        }

        private void sil1_Click(object sender, EventArgs e)
        {

            string query = "DELETE FROM FinalSinav WHERE FinalSinav.Id = @Id";
            SqlCommand sil = new SqlCommand(query, baglanti);
            sil.Parameters.AddWithValue("@Id", Convert.ToInt32(idBox3.Text));
            baglanti.Open();
            sil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Başarıyla silindi.");
        }

        private void guncelle1_Click(object sender, EventArgs e)
        {
            int bolumId = (int)bolumComboBox1.SelectedValue;
            int dersId = (int)dersComboBox1.SelectedValue;
            string selectedTimeRange = saatBox8.SelectedItem.ToString();
            string sinif = sinifBox1.Text;
            string grup = grupbox1.Text;
            string bolumAd = bolumComboBox1.Text;
            int sinifId = GetSinifId(bolumAd, sinif, grup);
            int bolumDersId = GetBolumDersIdFromDatabase(bolumId, dersId);


            int[] saatIds = GetIdsFromTimeRange(selectedTimeRange);
            FinalSinaviGuncelle(saatIds[0], bolumDersId, sinifId);
        }



        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.finalSinavTableAdapter.FillBy(this.oKULDataSet.FinalSinav);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }



        

        

        private void fillBy3ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.finalSinavTableAdapter.FillBy3(this.oKULDataSet.FinalSinav);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        
    }
}
   



       

