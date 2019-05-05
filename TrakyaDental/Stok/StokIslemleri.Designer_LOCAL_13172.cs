namespace TrakyaDental
{
    partial class StokIslemleri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StokIslemleri));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pbStokHareketi = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pbSil = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbDetay = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbAra = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.stokHareket1 = new TrakyaDental.Stok.StokHareket();
            this.urunDetay1 = new TrakyaDental.Stok.UrunDetay();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStokHareketi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAra)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1124, 46);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(1056, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(25, 23);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1087, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHeader.Location = new System.Drawing.Point(16, 11);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(373, 24);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "TRAKYA DENTAL - Dental Klinik Çözümleri";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pbStokHareketi);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pbSil);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pbDetay);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pbAra);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 599);
            this.panel2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(8, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 27);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "5500";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(67, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Stok Hareketi";
            // 
            // pbStokHareketi
            // 
            this.pbStokHareketi.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pbStokHareketi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbStokHareketi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbStokHareketi.InitialImage = null;
            this.pbStokHareketi.Location = new System.Drawing.Point(7, 158);
            this.pbStokHareketi.Name = "pbStokHareketi";
            this.pbStokHareketi.Size = new System.Drawing.Size(215, 46);
            this.pbStokHareketi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStokHareketi.TabIndex = 7;
            this.pbStokHareketi.TabStop = false;
            this.pbStokHareketi.Click += new System.EventHandler(this.pbStokHareketi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(104, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sil";
            // 
            // pbSil
            // 
            this.pbSil.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pbSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbSil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSil.InitialImage = null;
            this.pbSil.Location = new System.Drawing.Point(8, 105);
            this.pbSil.Name = "pbSil";
            this.pbSil.Size = new System.Drawing.Size(215, 46);
            this.pbSil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSil.TabIndex = 4;
            this.pbSil.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(93, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Detay";
            // 
            // pbDetay
            // 
            this.pbDetay.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pbDetay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbDetay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDetay.InitialImage = null;
            this.pbDetay.Location = new System.Drawing.Point(8, 52);
            this.pbDetay.Name = "pbDetay";
            this.pbDetay.Size = new System.Drawing.Size(215, 46);
            this.pbDetay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDetay.TabIndex = 2;
            this.pbDetay.TabStop = false;
            this.pbDetay.Click += new System.EventHandler(this.pbDetay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(177, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ARA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pbAra
            // 
            this.pbAra.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pbAra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbAra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAra.InitialImage = null;
            this.pbAra.Location = new System.Drawing.Point(166, 19);
            this.pbAra.Name = "pbAra";
            this.pbAra.Size = new System.Drawing.Size(57, 26);
            this.pbAra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAra.TabIndex = 0;
            this.pbAra.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.stokHareket1);
            this.panel3.Controls.Add(this.urunDetay1);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(235, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(889, 599);
            this.panel3.TabIndex = 2;
            // 
            // stokHareket1
            // 
            this.stokHareket1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stokHareket1.Location = new System.Drawing.Point(313, 218);
            this.stokHareket1.Name = "stokHareket1";
            this.stokHareket1.Size = new System.Drawing.Size(241, 173);
            this.stokHareket1.TabIndex = 14;
            // 
            // urunDetay1
            // 
            this.urunDetay1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.urunDetay1.Location = new System.Drawing.Point(130, 95);
            this.urunDetay1.Name = "urunDetay1";
            this.urunDetay1.Size = new System.Drawing.Size(640, 400);
            this.urunDetay1.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(876, 494);
            this.dataGridView1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(84, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Stok Bilgileri";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TrakyaDental.Properties.Resources.goBack_2x;
            this.pictureBox1.Location = new System.Drawing.Point(10, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(229, 46);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 599);
            this.panel4.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 

            // stokHareket1
            // 
            this.stokHareket1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stokHareket1.Location = new System.Drawing.Point(313, 218);
            this.stokHareket1.Name = "stokHareket1";
            this.stokHareket1.Size = new System.Drawing.Size(241, 202);
            this.stokHareket1.TabIndex = 14;
            // 
            // urunDetay1
            // 
            this.urunDetay1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.urunDetay1.Location = new System.Drawing.Point(130, 95);
            this.urunDetay1.Name = "urunDetay1";
            this.urunDetay1.Size = new System.Drawing.Size(640, 400);
            this.urunDetay1.TabIndex = 13;
            // 
            // StokIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1124, 645);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StokIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.StokIslemleri_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStokHareketi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAra)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbAra;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbStokHareketi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbSil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbDetay;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Stok.UrunDetay urunDetay1;
        private Stok.StokHareket stokHareket1;
    }
}

