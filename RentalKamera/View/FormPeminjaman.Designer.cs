namespace RentalKamera.View
{
    partial class FormPeminjaman
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
            this.btn_tmbh_pmj = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvwPeminjaman = new System.Windows.Forms.ListView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox_alamat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Nama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker_pj = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_kamera = new System.Windows.Forms.ComboBox();
            this.comboBox_alat = new System.Windows.Forms.ComboBox();
            this.id = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_tmbh_pmj
            // 
            this.btn_tmbh_pmj.Location = new System.Drawing.Point(41, 540);
            this.btn_tmbh_pmj.Margin = new System.Windows.Forms.Padding(4);
            this.btn_tmbh_pmj.Name = "btn_tmbh_pmj";
            this.btn_tmbh_pmj.Size = new System.Drawing.Size(151, 28);
            this.btn_tmbh_pmj.TabIndex = 15;
            this.btn_tmbh_pmj.Text = "Tambahkan";
            this.btn_tmbh_pmj.UseVisualStyleBackColor = true;
            this.btn_tmbh_pmj.Click += new System.EventHandler(this.btn_tmbh_pmj_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvwPeminjaman);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Location = new System.Drawing.Point(463, 98);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(732, 479);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[ Daftar Peminjaman ]";
            // 
            // lvwPeminjaman
            // 
            this.lvwPeminjaman.HideSelection = false;
            this.lvwPeminjaman.Location = new System.Drawing.Point(8, 60);
            this.lvwPeminjaman.Margin = new System.Windows.Forms.Padding(4);
            this.lvwPeminjaman.Name = "lvwPeminjaman";
            this.lvwPeminjaman.Size = new System.Drawing.Size(715, 410);
            this.lvwPeminjaman.TabIndex = 0;
            this.lvwPeminjaman.UseCompatibleStateImageBehavior = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 23);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 28);
            this.button2.TabIndex = 8;
            this.button2.Text = "Tampilkan";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(149, 23);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 28);
            this.button3.TabIndex = 9;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(279, 23);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 28);
            this.button4.TabIndex = 10;
            this.button4.Text = "Hapus";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox_alamat
            // 
            this.textBox_alamat.Location = new System.Drawing.Point(188, 140);
            this.textBox_alamat.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_alamat.Name = "textBox_alamat";
            this.textBox_alamat.Size = new System.Drawing.Size(216, 22);
            this.textBox_alamat.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Peminjaman";
            // 
            // textBox_Nama
            // 
            this.textBox_Nama.Location = new System.Drawing.Point(188, 100);
            this.textBox_Nama.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Nama.Name = "textBox_Nama";
            this.textBox_Nama.Size = new System.Drawing.Size(216, 22);
            this.textBox_Nama.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Alamat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nama";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(240, 540);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(151, 28);
            this.button5.TabIndex = 19;
            this.button5.Text = "Reset";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 251);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Daftar Pinjam";
            // 
            // dateTimePicker_pj
            // 
            this.dateTimePicker_pj.Location = new System.Drawing.Point(179, 251);
            this.dateTimePicker_pj.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker_pj.Name = "dateTimePicker_pj";
            this.dateTimePicker_pj.Size = new System.Drawing.Size(216, 22);
            this.dateTimePicker_pj.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 208);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Alat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 174);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Kamera";
            // 
            // comboBox_kamera
            // 
            this.comboBox_kamera.FormattingEnabled = true;
            this.comboBox_kamera.Location = new System.Drawing.Point(188, 174);
            this.comboBox_kamera.Name = "comboBox_kamera";
            this.comboBox_kamera.Size = new System.Drawing.Size(121, 24);
            this.comboBox_kamera.TabIndex = 26;
            // 
            // comboBox_alat
            // 
            this.comboBox_alat.FormattingEnabled = true;
            this.comboBox_alat.Location = new System.Drawing.Point(188, 208);
            this.comboBox_alat.Name = "comboBox_alat";
            this.comboBox_alat.Size = new System.Drawing.Size(121, 24);
            this.comboBox_alat.TabIndex = 27;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(240, 52);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(0, 16);
            this.id.TabIndex = 28;
            this.id.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(263, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 29;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            // 
            // FormPeminjaman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 592);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.id);
            this.Controls.Add(this.comboBox_alat);
            this.Controls.Add(this.comboBox_kamera);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker_pj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_tmbh_pmj);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_alamat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Nama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPeminjaman";
            this.Text = "FormAlatPerlengkapanKamera";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_tmbh_pmj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvwPeminjaman;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox_alamat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Nama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_pj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_kamera;
        private System.Windows.Forms.ComboBox comboBox_alat;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label label7;
    }
}