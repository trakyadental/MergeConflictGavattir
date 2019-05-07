using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TrakyaDental
{
    public partial class DoktorOdemeleri : UserControl
    {
        public DoktorOdemeleri()
        {
            InitializeComponent();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void DoktorOdemeleri_Load(object sender, EventArgs e)
        {
            doktorOdemeleriYeni1.Hide();
            int counter = 0;
            string connStr = "Data Source=.;Initial Catalog=TrakyaDental;User ID=sa; Password=2362123";
            int[] doktorlar = new int[5];

            SqlConnection connect = new SqlConnection(connStr);
            connect.Open();

            SqlCommand commandPersonel = new SqlCommand("Select PersonelID from Personel where Unvan=@Unvan", connect); // Öncelikle Doktor olan personelin ID'si çekiliyor
            commandPersonel.Parameters.AddWithValue("@Unvan", "DOKTOR");
            SqlCommand cmdIslemCek = new SqlCommand("Select * from Islem", connect); // Sonrasında yapılan işlemler arasından doktor olanların işlemleri çekiliyor
            

            SqlDataReader reader = commandPersonel.ExecuteReader();
            while (reader.Read())
            {
                doktorlar[counter++] = Convert.ToInt32(reader[reader.GetOrdinal("PersonelID")]); // Doktor olan personellerin ID'leri Çekiliyor
            }
            reader.Close();
            counter = 0;
            SqlDataReader doktorIslemOkuyucu = cmdIslemCek.ExecuteReader();
            while (doktorIslemOkuyucu.Read())
            {
                foreach (int personel in doktorlar)
                {
                    if (Convert.ToInt32(doktorIslemOkuyucu[doktorIslemOkuyucu.GetOrdinal("PersonelID")]) == personel) // Bu kısımda doktor olan tüm personelin
                    {                                                                                                 // verileri DataGridView'a atılıyor.
                        string islemID = doktorIslemOkuyucu["IslemID"].ToString();
                        string personelID = doktorIslemOkuyucu["PersonelID"].ToString();
                        string islemTipiID = doktorIslemOkuyucu["IslemTipiID"].ToString();
                        string Bakiye;
                        if (doktorIslemOkuyucu["Bakiye"].ToString() != "")
                        {
                            Bakiye = doktorIslemOkuyucu["Bakiye"].ToString();
                        }
                        else
                        {
                            Bakiye = "0";
                        }
                        dataGridView1.Rows.Add(islemID, personelID, islemTipiID, Bakiye);
                    }
                }
            }
        }

        private void labelPlus_Click(object sender, EventArgs e)
        {
            doktorOdemeleriYeni1.Show();
        }

        private DataTable odemeGetir()
        {
            DataTable odemeBilgileri = new DataTable();


            string connStr = "Data Source=.;Initial Catalog=TrakyaDental;User ID=sa; Password=2362123";


            using (SqlConnection con = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from Islem", con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    odemeBilgileri.Load(reader);
                }
            }
            return odemeBilgileri;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            foreach(DataRow row in odemeGetir().Rows)
            {
                dataGridView1.Rows.Add(row[0],row[1],row[2],row[3]);
            }
        }
    }
}
