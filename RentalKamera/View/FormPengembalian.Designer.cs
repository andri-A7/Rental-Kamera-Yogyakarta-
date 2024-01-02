namespace RentalKamera.View
{
    partial class FormPengembalian
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
            this.dateTimePicker_pj = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvwPeminjaman = new System.Windows.Forms.ListView();
            this.label7 = new System.Windows.Forms.Label();
            this.button_cari = new System.Windows.Forms.Button();
            this.textBox_cari = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label_peminjaman = new System.Windows.Forms.Label();
            this.label_alamat = new System.Windows.Forms.Label();
            this.label_nama = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label_kamera = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label_alat = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label_hari = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_harga_kamera = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker_pj
            // 
            this.dateTimePicker_pj.Location = new System.Drawing.Point(326, 513);
            this.dateTimePicker_pj.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker_pj.Name = "dateTimePicker_pj";
            this.dateTimePicker_pj.Size = new System.Drawing.Size(216, 22);
            this.dateTimePicker_pj.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 390);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Rincian";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvwPeminjaman);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.button_cari);
            this.groupBox1.Controls.Add(this.textBox_cari);
            this.groupBox1.Location = new System.Drawing.Point(28, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1180, 342);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[ Daftar Peminjaman ]";
            // 
            // lvwPeminjaman
            // 
            this.lvwPeminjaman.HideSelection = false;
            this.lvwPeminjaman.Location = new System.Drawing.Point(8, 57);
            this.lvwPeminjaman.Margin = new System.Windows.Forms.Padding(4);
            this.lvwPeminjaman.Name = "lvwPeminjaman";
            this.lvwPeminjaman.Size = new System.Drawing.Size(1172, 277);
            this.lvwPeminjaman.TabIndex = 0;
            this.lvwPeminjaman.UseCompatibleStateImageBehavior = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.label7.Location = new System.Drawing.Point(286, 28);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 12);
            this.label7.TabIndex = 36;
            this.label7.Text = "*Berdasarkan ID Customer";
            // 
            // button_cari
            // 
            this.button_cari.Location = new System.Drawing.Point(210, 21);
            this.button_cari.Margin = new System.Windows.Forms.Padding(4);
            this.button_cari.Name = "button_cari";
            this.button_cari.Size = new System.Drawing.Size(68, 28);
            this.button_cari.TabIndex = 8;
            this.button_cari.Text = "Cari ";
            this.button_cari.UseVisualStyleBackColor = true;
            this.button_cari.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_cari
            // 
            this.textBox_cari.Location = new System.Drawing.Point(8, 23);
            this.textBox_cari.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_cari.Name = "textBox_cari";
            this.textBox_cari.Size = new System.Drawing.Size(199, 22);
            this.textBox_cari.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(469, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 31);
            this.label1.TabIndex = 23;
            this.label1.Text = "Pengembalian ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 591);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "TOTAL PEMBAYARAN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label2.Location = new System.Drawing.Point(112, 410);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 37;
            this.label2.Text = "- ID CUSTOMER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label4.Location = new System.Drawing.Point(112, 463);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 39;
            this.label4.Text = "- ALAMAT ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label8.Location = new System.Drawing.Point(112, 489);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 15);
            this.label8.TabIndex = 40;
            this.label8.Text = "- TANGGAL PEMINJAMAN";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label10.Location = new System.Drawing.Point(305, 410);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 15);
            this.label10.TabIndex = 41;
            this.label10.Text = ":";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label11.Location = new System.Drawing.Point(305, 463);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 15);
            this.label11.TabIndex = 42;
            this.label11.Text = ":";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label12.Location = new System.Drawing.Point(305, 489);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(10, 15);
            this.label12.TabIndex = 43;
            this.label12.Text = ":";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label13.Location = new System.Drawing.Point(112, 435);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 15);
            this.label13.TabIndex = 44;
            this.label13.Text = "- NAMA";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label14.Location = new System.Drawing.Point(305, 435);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(10, 15);
            this.label14.TabIndex = 45;
            this.label14.Text = ":";
            // 
            // label_peminjaman
            // 
            this.label_peminjaman.AutoSize = true;
            this.label_peminjaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label_peminjaman.Location = new System.Drawing.Point(323, 489);
            this.label_peminjaman.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_peminjaman.Name = "label_peminjaman";
            this.label_peminjaman.Size = new System.Drawing.Size(11, 15);
            this.label_peminjaman.TabIndex = 49;
            this.label_peminjaman.Text = "-";
            // 
            // label_alamat
            // 
            this.label_alamat.AutoSize = true;
            this.label_alamat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label_alamat.Location = new System.Drawing.Point(323, 463);
            this.label_alamat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_alamat.Name = "label_alamat";
            this.label_alamat.Size = new System.Drawing.Size(11, 15);
            this.label_alamat.TabIndex = 50;
            this.label_alamat.Text = "-";
            // 
            // label_nama
            // 
            this.label_nama.AutoSize = true;
            this.label_nama.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label_nama.Location = new System.Drawing.Point(323, 435);
            this.label_nama.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_nama.Name = "label_nama";
            this.label_nama.Size = new System.Drawing.Size(11, 15);
            this.label_nama.TabIndex = 51;
            this.label_nama.Text = "-";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label_id.Location = new System.Drawing.Point(323, 410);
            this.label_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(11, 15);
            this.label_id.TabIndex = 52;
            this.label_id.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(267, 591);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 53;
            this.label5.Text = "RP.";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total.Location = new System.Drawing.Point(302, 591);
            this.label_total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(34, 20);
            this.label_total.TabIndex = 54;
            this.label_total.Text = "0,0";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(909, 579);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 47);
            this.button1.TabIndex = 37;
            this.button1.Text = "BAYAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(1033, 579);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 47);
            this.button3.TabIndex = 55;
            this.button3.Text = "CANCEL";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label_kamera
            // 
            this.label_kamera.AutoSize = true;
            this.label_kamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label_kamera.Location = new System.Drawing.Point(808, 410);
            this.label_kamera.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_kamera.Name = "label_kamera";
            this.label_kamera.Size = new System.Drawing.Size(11, 15);
            this.label_kamera.TabIndex = 58;
            this.label_kamera.Text = "-";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label22.Location = new System.Drawing.Point(790, 410);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(10, 15);
            this.label22.TabIndex = 57;
            this.label22.Text = ":";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label23.Location = new System.Drawing.Point(627, 410);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(64, 15);
            this.label23.TabIndex = 56;
            this.label23.Text = "- KAMERA";
            // 
            // label_alat
            // 
            this.label_alat.AutoSize = true;
            this.label_alat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label_alat.Location = new System.Drawing.Point(808, 435);
            this.label_alat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_alat.Name = "label_alat";
            this.label_alat.Size = new System.Drawing.Size(11, 15);
            this.label_alat.TabIndex = 61;
            this.label_alat.Text = "-";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label25.Location = new System.Drawing.Point(790, 435);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(10, 15);
            this.label25.TabIndex = 60;
            this.label25.Text = ":";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label26.Location = new System.Drawing.Point(627, 435);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(42, 15);
            this.label26.TabIndex = 59;
            this.label26.Text = "- ALAT";
            // 
            // label_hari
            // 
            this.label_hari.AutoSize = true;
            this.label_hari.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label_hari.Location = new System.Drawing.Point(808, 463);
            this.label_hari.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_hari.Name = "label_hari";
            this.label_hari.Size = new System.Drawing.Size(11, 15);
            this.label_hari.TabIndex = 64;
            this.label_hari.Text = "-";
            this.label_hari.Click += new System.EventHandler(this.label27_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label28.Location = new System.Drawing.Point(790, 463);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(10, 15);
            this.label28.TabIndex = 63;
            this.label28.Text = ":";
            this.label28.Click += new System.EventHandler(this.label28_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label29.Location = new System.Drawing.Point(627, 463);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(42, 15);
            this.label29.TabIndex = 62;
            this.label29.Text = "- HARI";
            this.label29.Click += new System.EventHandler(this.label29_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label16.Location = new System.Drawing.Point(112, 513);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(166, 15);
            this.label16.TabIndex = 46;
            this.label16.Text = "- TANGGAL PENGEMBALIAN";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label15.Location = new System.Drawing.Point(305, 513);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(10, 15);
            this.label15.TabIndex = 65;
            this.label15.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label9.Location = new System.Drawing.Point(906, 410);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 15);
            this.label9.TabIndex = 66;
            this.label9.Text = "Rp.";
            // 
            // label_harga_kamera
            // 
            this.label_harga_kamera.AutoSize = true;
            this.label_harga_kamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label_harga_kamera.Location = new System.Drawing.Point(940, 410);
            this.label_harga_kamera.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_harga_kamera.Name = "label_harga_kamera";
            this.label_harga_kamera.Size = new System.Drawing.Size(11, 15);
            this.label_harga_kamera.TabIndex = 68;
            this.label_harga_kamera.Text = "-";
            // 
            // FormPengembalian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 639);
            this.Controls.Add(this.label_harga_kamera);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label_hari);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label_alat);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label_kamera);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.label_nama);
            this.Controls.Add(this.label_alamat);
            this.Controls.Add(this.label_peminjaman);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker_pj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormPengembalian";
            this.Text = "- TANGGAL PEMINJAMAN";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_pj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvwPeminjaman;
        private System.Windows.Forms.Button button_cari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_cari;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label_peminjaman;
        private System.Windows.Forms.Label label_alamat;
        private System.Windows.Forms.Label label_nama;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label_kamera;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label_alat;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label_hari;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_harga_kamera;
    }
}