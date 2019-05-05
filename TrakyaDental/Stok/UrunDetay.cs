using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrakyaDental.Stok
{
    public partial class UrunDetay : UserControl
    {
        public int urunID
        {
            set { this.textBox1.Text = value.ToString(); }
        }
        public string urunAd {
            set { textBox2.Text = value; }
        }
        public string urunGrubu
        {
            set { textBox3.Text = value; }
        }
        public int stokMikter
        {
            set { textBox4.Text = value.ToString(); }
        }
        public int birimFiyat
        {
            set { textBox5.Text = value.ToString(); }
        }
        public string aciklama
        {
            set { textBox6.Text = value; }
        }
        public DateTime skt
        {
            set { dateTimePicker1.Value = value; }
        }
        public string marka
        {
            set { textBox8.Text = value; }
        }
        public string barkod
        {
            set { textBox9.Text = value; }
        }

        public UrunDetay()
        {
            InitializeComponent();
        }

        private void closeIcon_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
