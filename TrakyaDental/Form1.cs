﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrakyaDental
{
    public partial class Form1 : Form
    {

        int mouseX = 0, mouseY = 0;
        bool mouseDown;
        Point lastLocation;
        public Form1()
        {
            InitializeComponent();
        }


        private void btnMinimize_Click(object sender, EventArgs e)
        {
            ActiveForm.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ActiveForm.Dispose();
        }
        
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X -lastLocation.X;
                mouseY = MousePosition.Y - lastLocation.Y;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void pbHastaIslemleri_Click(object sender, EventArgs e)
        {
            this.Hide();
            var hastaIslemForm = new HastaIslemleri();
            hastaIslemForm.ShowDialog();
            this.Dispose();
        }

        private void pbMaliIslemler_Click(object sender, EventArgs e)
        {
            this.Hide();
            var maliIslemForm = new MaliIslemleri();
            maliIslemForm.ShowDialog();
            this.Dispose();
        }

        private void pbKlinikIslemleri_Click(object sender, EventArgs e)
        {
            this.Hide();
            var klinikForm = new KlinikIslemleri();
            klinikForm.ShowDialog();
            this.Dispose();
        }

        private void pbStokIslemleri_Click(object sender, EventArgs e)
        {
            this.Hide();
            var stok = new StokIslemleri();
            stok.ShowDialog();
            this.Dispose();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
    }
}
