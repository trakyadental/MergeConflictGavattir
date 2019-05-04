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
    public partial class StokHareket : UserControl
    {
        public string ID
        {
            set { tbMiktar.Text = value; }
        }
        public StokHareket()
        {
            InitializeComponent();
        }

        private void closeIcon_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
