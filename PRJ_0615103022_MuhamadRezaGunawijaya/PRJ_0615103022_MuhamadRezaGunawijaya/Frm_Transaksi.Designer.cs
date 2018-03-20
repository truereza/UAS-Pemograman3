namespace PRJ_0615103022_MuhamadRezaGunawijaya
{
    partial class Frm_Transaksi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Transaksi));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbKodeBRG = new System.Windows.Forms.ComboBox();
            this.cmbCust = new System.Windows.Forms.ComboBox();
            this.txtNamaCust = new System.Windows.Forms.TextBox();
            this.txtHargasatuan = new System.Windows.Forms.TextBox();
            this.txtSatuan = new System.Windows.Forms.TextBox();
            this.txtNamaBRG = new System.Windows.Forms.TextBox();
            this.btnHitung = new System.Windows.Forms.Button();
            this.txtJumlahBRG = new System.Windows.Forms.TextBox();
            this.dTPTRX = new System.Windows.Forms.DateTimePicker();
            this.txtNOta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DGTRX = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtKembali = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtJumlahByr = new System.Windows.Forms.TextBox();
            this.txtTotBay = new System.Windows.Forms.TextBox();
            this.txtDiskon = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.cmbIDKRW = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGTRX)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbIDKRW);
            this.groupBox1.Controls.Add(this.cmbKodeBRG);
            this.groupBox1.Controls.Add(this.cmbCust);
            this.groupBox1.Controls.Add(this.txtNamaCust);
            this.groupBox1.Controls.Add(this.txtHargasatuan);
            this.groupBox1.Controls.Add(this.txtSatuan);
            this.groupBox1.Controls.Add(this.txtNamaBRG);
            this.groupBox1.Controls.Add(this.btnHitung);
            this.groupBox1.Controls.Add(this.txtJumlahBRG);
            this.groupBox1.Controls.Add(this.dTPTRX);
            this.groupBox1.Controls.Add(this.txtNOta);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(848, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmbKodeBRG
            // 
            this.cmbKodeBRG.FormattingEnabled = true;
            this.cmbKodeBRG.Location = new System.Drawing.Point(101, 39);
            this.cmbKodeBRG.Name = "cmbKodeBRG";
            this.cmbKodeBRG.Size = new System.Drawing.Size(121, 23);
            this.cmbKodeBRG.TabIndex = 20;
            this.cmbKodeBRG.SelectedIndexChanged += new System.EventHandler(this.cmbKodeBRG_SelectedIndexChanged);
            this.cmbKodeBRG.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbKodeBRG_KeyDown);
            // 
            // cmbCust
            // 
            this.cmbCust.FormattingEnabled = true;
            this.cmbCust.Location = new System.Drawing.Point(721, 44);
            this.cmbCust.Name = "cmbCust";
            this.cmbCust.Size = new System.Drawing.Size(121, 23);
            this.cmbCust.TabIndex = 19;
            this.cmbCust.SelectedIndexChanged += new System.EventHandler(this.cmbCust_SelectedIndexChanged);
            this.cmbCust.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCust_KeyDown);
            // 
            // txtNamaCust
            // 
            this.txtNamaCust.Location = new System.Drawing.Point(721, 71);
            this.txtNamaCust.Name = "txtNamaCust";
            this.txtNamaCust.Size = new System.Drawing.Size(107, 21);
            this.txtNamaCust.TabIndex = 18;
            // 
            // txtHargasatuan
            // 
            this.txtHargasatuan.Location = new System.Drawing.Point(374, 62);
            this.txtHargasatuan.Name = "txtHargasatuan";
            this.txtHargasatuan.Size = new System.Drawing.Size(100, 21);
            this.txtHargasatuan.TabIndex = 17;
            // 
            // txtSatuan
            // 
            this.txtSatuan.Location = new System.Drawing.Point(272, 62);
            this.txtSatuan.Name = "txtSatuan";
            this.txtSatuan.Size = new System.Drawing.Size(100, 21);
            this.txtSatuan.TabIndex = 16;
            // 
            // txtNamaBRG
            // 
            this.txtNamaBRG.Location = new System.Drawing.Point(101, 62);
            this.txtNamaBRG.Name = "txtNamaBRG";
            this.txtNamaBRG.Size = new System.Drawing.Size(169, 21);
            this.txtNamaBRG.TabIndex = 15;
            // 
            // btnHitung
            // 
            this.btnHitung.Location = new System.Drawing.Point(760, 128);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(82, 29);
            this.btnHitung.TabIndex = 6;
            this.btnHitung.Text = "Hitung";
            this.btnHitung.UseVisualStyleBackColor = true;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // txtJumlahBRG
            // 
            this.txtJumlahBRG.Location = new System.Drawing.Point(101, 89);
            this.txtJumlahBRG.Name = "txtJumlahBRG";
            this.txtJumlahBRG.Size = new System.Drawing.Size(57, 21);
            this.txtJumlahBRG.TabIndex = 14;
            this.txtJumlahBRG.TextChanged += new System.EventHandler(this.txtJumlahBRG_TextChanged);
            this.txtJumlahBRG.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtJumlahBRG_KeyDown);
            // 
            // dTPTRX
            // 
            this.dTPTRX.Location = new System.Drawing.Point(272, 15);
            this.dTPTRX.Name = "dTPTRX";
            this.dTPTRX.Size = new System.Drawing.Size(151, 21);
            this.dTPTRX.TabIndex = 10;
            // 
            // txtNOta
            // 
            this.txtNOta.Location = new System.Drawing.Point(101, 14);
            this.txtNOta.Name = "txtNOta";
            this.txtNOta.Size = new System.Drawing.Size(107, 21);
            this.txtNOta.TabIndex = 7;
            this.txtNOta.TextChanged += new System.EventHandler(this.txtNOta_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Jumlah";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(642, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "ID Karyawan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kode Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tanggal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(642, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Customer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "No Nota";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DGTRX);
            this.groupBox2.Location = new System.Drawing.Point(12, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(848, 239);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data";
            // 
            // DGTRX
            // 
            this.DGTRX.AllowUserToAddRows = false;
            this.DGTRX.AllowUserToDeleteRows = false;
            this.DGTRX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGTRX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column1,
            this.Column5,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6});
            this.DGTRX.Location = new System.Drawing.Point(9, 20);
            this.DGTRX.Name = "DGTRX";
            this.DGTRX.Size = new System.Drawing.Size(833, 213);
            this.DGTRX.TabIndex = 0;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "No";
            this.Column7.Name = "Column7";
            this.Column7.Width = 40;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "No Nota";
            this.Column1.Name = "Column1";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ID Customer";
            this.Column5.Name = "Column5";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Kode Barang";
            this.Column2.Name = "Column2";
            this.Column2.Width = 130;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nama Barang";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Jumlah";
            this.Column4.Name = "Column4";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "SubTotal";
            this.Column6.Name = "Column6";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtKembali);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtJumlahByr);
            this.groupBox3.Controls.Add(this.txtTotBay);
            this.groupBox3.Controls.Add(this.txtDiskon);
            this.groupBox3.Controls.Add(this.txtTotal);
            this.groupBox3.Location = new System.Drawing.Point(630, 426);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(230, 166);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Jumlah";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 15);
            this.label11.TabIndex = 9;
            this.label11.Text = "Kembali";
            // 
            // txtKembali
            // 
            this.txtKembali.Location = new System.Drawing.Point(106, 128);
            this.txtKembali.Name = "txtKembali";
            this.txtKembali.Size = new System.Drawing.Size(111, 21);
            this.txtKembali.TabIndex = 8;
            this.txtKembali.TextChanged += new System.EventHandler(this.txtKembali_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 15);
            this.label10.TabIndex = 7;
            this.label10.Text = "Jumlah Bayar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "Total Bayar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Diskon (-)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Total";
            // 
            // txtJumlahByr
            // 
            this.txtJumlahByr.Location = new System.Drawing.Point(106, 101);
            this.txtJumlahByr.Name = "txtJumlahByr";
            this.txtJumlahByr.Size = new System.Drawing.Size(111, 21);
            this.txtJumlahByr.TabIndex = 3;
            this.txtJumlahByr.TextChanged += new System.EventHandler(this.txtJumlahByr_TextChanged);
            this.txtJumlahByr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtJumlahByr_KeyDown);
            // 
            // txtTotBay
            // 
            this.txtTotBay.Location = new System.Drawing.Point(106, 74);
            this.txtTotBay.Name = "txtTotBay";
            this.txtTotBay.Size = new System.Drawing.Size(111, 21);
            this.txtTotBay.TabIndex = 2;
            // 
            // txtDiskon
            // 
            this.txtDiskon.Location = new System.Drawing.Point(106, 47);
            this.txtDiskon.Name = "txtDiskon";
            this.txtDiskon.Size = new System.Drawing.Size(111, 21);
            this.txtDiskon.TabIndex = 1;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(106, 20);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(111, 21);
            this.txtTotal.TabIndex = 0;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(785, 598);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 29);
            this.btnSimpan.TabIndex = 0;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(626, 598);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(62, 23);
            this.btnKeluar.TabIndex = 1;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // cmbIDKRW
            // 
            this.cmbIDKRW.FormattingEnabled = true;
            this.cmbIDKRW.Location = new System.Drawing.Point(721, 12);
            this.cmbIDKRW.Name = "cmbIDKRW";
            this.cmbIDKRW.Size = new System.Drawing.Size(121, 23);
            this.cmbIDKRW.TabIndex = 21;
            // 
            // Frm_Transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 633);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Transaksi";
            this.Text = "Transaksi";
            this.Load += new System.EventHandler(this.Frm_Transaksi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGTRX)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHitung;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNOta;
        private System.Windows.Forms.DateTimePicker dTPTRX;
        private System.Windows.Forms.DataGridView DGTRX;
        private System.Windows.Forms.TextBox txtJumlahBRG;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.TextBox txtSatuan;
        private System.Windows.Forms.TextBox txtNamaBRG;
        private System.Windows.Forms.TextBox txtHargasatuan;
        private System.Windows.Forms.TextBox txtNamaCust;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtJumlahByr;
        private System.Windows.Forms.TextBox txtTotBay;
        private System.Windows.Forms.TextBox txtDiskon;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtKembali;
        private System.Windows.Forms.ComboBox cmbKodeBRG;
        private System.Windows.Forms.ComboBox cmbCust;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.ComboBox cmbIDKRW;
    }
}