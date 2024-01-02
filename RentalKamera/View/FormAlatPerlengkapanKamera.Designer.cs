namespace RentalKamera.View
{
    partial class FormAlatPerlengkapanKamera
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
            this.btn_tmbh_alat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvwAlat = new System.Windows.Forms.ListView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox_seri_alat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_jenis_alat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_reset_alat = new System.Windows.Forms.Button();
            this.textBox_jumlah_alat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_tmbh_alat
            // 
            this.btn_tmbh_alat.Location = new System.Drawing.Point(56, 258);
            this.btn_tmbh_alat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_tmbh_alat.Name = "btn_tmbh_alat";
            this.btn_tmbh_alat.Size = new System.Drawing.Size(151, 28);
            this.btn_tmbh_alat.TabIndex = 15;
            this.btn_tmbh_alat.Text = "Tambahkan";
            this.btn_tmbh_alat.UseVisualStyleBackColor = true;
            this.btn_tmbh_alat.Click += new System.EventHandler(this.btn_tmbh_alat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvwAlat);
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
            this.groupBox1.Text = "[ Daftar Alat Perlengkapan Kamera ]";
            // 
            // lvwAlat
            // 
            this.lvwAlat.HideSelection = false;
            this.lvwAlat.Location = new System.Drawing.Point(8, 60);
            this.lvwAlat.Margin = new System.Windows.Forms.Padding(4);
            this.lvwAlat.Name = "lvwAlat";
            this.lvwAlat.Size = new System.Drawing.Size(715, 410);
            this.lvwAlat.TabIndex = 0;
            this.lvwAlat.UseCompatibleStateImageBehavior = false;
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
            // textBox_seri_alat
            // 
            this.textBox_seri_alat.Location = new System.Drawing.Point(168, 139);
            this.textBox_seri_alat.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_seri_alat.Name = "textBox_seri_alat";
            this.textBox_seri_alat.Size = new System.Drawing.Size(216, 22);
            this.textBox_seri_alat.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Alat Perlengkapan Kamera";
            // 
            // textBox_jenis_alat
            // 
            this.textBox_jenis_alat.Location = new System.Drawing.Point(168, 98);
            this.textBox_jenis_alat.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_jenis_alat.Name = "textBox_jenis_alat";
            this.textBox_jenis_alat.Size = new System.Drawing.Size(216, 22);
            this.textBox_jenis_alat.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Seri Barang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Jenis Barang";
            // 
            // btn_reset_alat
            // 
            this.btn_reset_alat.Location = new System.Drawing.Point(235, 258);
            this.btn_reset_alat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_reset_alat.Name = "btn_reset_alat";
            this.btn_reset_alat.Size = new System.Drawing.Size(151, 28);
            this.btn_reset_alat.TabIndex = 19;
            this.btn_reset_alat.Text = "Reset";
            this.btn_reset_alat.UseVisualStyleBackColor = true;
            // 
            // textBox_jumlah_alat
            // 
            this.textBox_jumlah_alat.Location = new System.Drawing.Point(168, 183);
            this.textBox_jumlah_alat.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_jumlah_alat.Name = "textBox_jumlah_alat";
            this.textBox_jumlah_alat.Size = new System.Drawing.Size(216, 22);
            this.textBox_jumlah_alat.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Jumlah";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 548);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = ".";
            // 
            // FormAlatPerlengkapanKamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 592);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_jumlah_alat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_tmbh_alat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_seri_alat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_jenis_alat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_reset_alat);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAlatPerlengkapanKamera";
            this.Text = "FormAlatPerlengkapanKamera";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_tmbh_alat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvwAlat;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox_seri_alat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_jenis_alat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_reset_alat;
        private System.Windows.Forms.TextBox textBox_jumlah_alat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}