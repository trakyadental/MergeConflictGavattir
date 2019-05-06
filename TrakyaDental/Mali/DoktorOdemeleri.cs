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
        public string conString = "";

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DoktorOdemeleri_Load(object sender, EventArgs e)
        {

            int counter = 0;
            string connStr = "Data Source=.;Initial Catalog=TrakyaDental;User ID=sa; Password=2362123";
            int[] doktorlar = new int[5];
            SqlConnection connect = new SqlConnection(connStr);
            connect.Open();
            SqlCommand commandPersonel = new SqlCommand("Select PersonelID from Personel where Unvan=@Unvan", connect); // Öncelikle Doktor olan personelin ID'si çekiliyor
            SqlCommand cmdIslemCek = new SqlCommand("Select * from Islem", connect); // Sonrasında yapılan işlemler arasından doktor olanların işlemleri çekiliyor
            commandPersonel.Parameters.AddWithValue("@Unvan", "DOKTOR");

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
                        int pers = Convert.ToInt32(doktorIslemOkuyucu[doktorIslemOkuyucu.GetOrdinal("PersonelID")]);
                        string islemID = doktorIslemOkuyucu["IslemID"].ToString();
                        string personelID = doktorIslemOkuyucu["PersonelID"].ToString();
                        string islemTipiID = doktorIslemOkuyucu["IslemTipiID"].ToString();
                        string Bakiye = doktorIslemOkuyucu["Bakiye"].ToString();
                        dataGridView1.Rows.Add(islemID, personelID, islemTipiID, Bakiye);
                    }
                }
            }
        }
    }
}
