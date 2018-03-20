using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace PRJ_0615103022_MuhamadRezaGunawijaya
{
    public partial class Frm_Transaksi : Form
    {
        MySqlCommand cmd1 = null;
        MySqlCommand cmd2 = null;
        MySqlCommand cmdview = null;
        MySqlDataReader reader = null;
        string sql1;
        string sql2;
        string sqlview;

        Koneksi connDB = new Koneksi();

        public Frm_Transaksi()
        {
            InitializeComponent();
            DataTransaksi();
            IsiCMBKodeBarang();
            IsiCMBIDCustomer();
            IsiCMBIDKRW();
        }

        private void Frm_Transaksi_Load(object sender, EventArgs e)
        {
            txtNOta.Enabled = false;
            txtNOta.Text = NoTRX;
            cmbCust.Focus();
            btnSimpan.Visible = false;
        }

        private string NoTRX
        {
            get
            {
                string nomer = "TRX-0001";
                MySqlCommand cmd = new MySqlCommand("select max(right(No_Nota,4)) from tbl_0615103022_headtransaksi",
                    connDB.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader[0].ToString() != "")
                    nomer = "TRX-" + (int.Parse(reader[0].ToString()) + 1).ToString("0000");

                reader.Close();
                return nomer;
            }
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        void clear()
        {
            cmbCust.ResetText();
            cmbKodeBRG.ResetText();
            txtNamaCust.Clear();
            txtNamaBRG.Clear();
            txtSatuan.Clear();
            txtHargasatuan.Clear();
            txtJumlahBRG.Clear();
            txtTotal.Clear();
            txtDiskon.Clear();
            txtTotBay.Clear();
            txtJumlahByr.Clear();
            txtKembali.Clear();
            cmbIDKRW.ResetText();
        }

        void disabled() 
        {
            txtNamaBRG.Enabled = false;
            txtSatuan.Enabled = false;
            txtHargasatuan.Enabled = false;
        }

        void enabled()
        {
            txtNamaBRG.Enabled = true;
            txtSatuan.Enabled = true;
            txtHargasatuan.Enabled = true;
        }

        private Boolean isValid()
        {
            if (txtNOta.Text.Trim() == "")
            {
                MessageBox.Show("No Nota harus diisi.");
                txtNOta.Focus();
                return false;
            }

            if (cmbCust.Text == "" && (txtNamaCust.Text== ""))
            {
                MessageBox.Show("ID Customer harus diisi.");
                cmbCust.Focus();
                return false;
            }

            if (cmbKodeBRG.Text == "")
            {
                MessageBox.Show("Kode barang harus isi.");
                cmbKodeBRG.Focus();
                return false;
            }

            if (txtJumlahBRG.Text == "")
            {
                MessageBox.Show("Jumlah barang harus isi.");
                txtJumlahBRG.Focus();
                return false;
            }

            if (txtJumlahByr.Text == "")
            {
                MessageBox.Show("Total Bayar barang harus isi.");
                txtJumlahByr.Focus();
                return false;
            }
            if (txtKembali.Text.Trim() == "")
            {
                MessageBox.Show("Jumlah kembalian belum terhitung.");
                txtJumlahByr.Focus();
                return false;
            }
            return true;
        }

        private Boolean isValid1()
        {
            if (txtNOta.Text.Trim() == "")
            {
                MessageBox.Show("No Nota harus diisi.");
                txtNOta.Focus();
                return false;
            }

            if (cmbCust.Text == "" && (txtNamaCust.Text == ""))
            {
                MessageBox.Show("ID Customer harus diisi.");
                cmbCust.Focus();
                return false;
            }

            if (cmbKodeBRG.Text == "")
            {
                MessageBox.Show("Kode barang harus isi.");
                cmbKodeBRG.Focus();
                return false;
            }

            if (txtJumlahBRG.Text == "")
            {
                MessageBox.Show("Jumlah barang harus isi.");
                txtJumlahBRG.Focus();
                return false;
            }
            return true;
        }
        
        void DataTransaksi()
        {
            connDB.KoneksiDB();
            DGTRX.Rows.Clear();

            try
            {
                sqlview = " SELECT h.No_Nota, h.ID_Customer, d.Kode_Barang, d.Nama_Barang, d.Jumlah, h.Total_Harga " +
                          " FROM tbl_0615103022_headtransaksi h, tbl_0615103022_detailtransaksi d WHERE h.No_Nota = d.No_Nota";
                cmdview = new MySqlCommand(sqlview, connDB.conn);
                reader = cmdview.ExecuteReader();

                while (reader.Read())
                {
                    int rows = DGTRX.Rows.Add();

                    DGTRX.Rows[rows].Cells[0].Value = rows + 1;

                    for (int j = 0; j < reader.FieldCount; j++)
                    {
                        DGTRX.Rows[rows].Cells[j + 1].Value = reader.GetString(j);
                    }
                }
            }

            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }

        void IsiCMBIDKRW()
        {
            connDB.KoneksiDB();

            try
            {
                sqlview = "SELECT ID_Karyawan FROM tbl_0615103022_karyawan;";
                cmdview = new MySqlCommand(sqlview, connDB.conn);
                reader = cmdview.ExecuteReader();

                while (reader.Read())
                {
                    cmbIDKRW.Items.Add(reader[0]);
                }
            }

            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }

        void IsiCMBIDCustomer()
        {
            connDB.KoneksiDB();

            try
            {
                sqlview = "SELECT ID_Customer FROM tbl_0615103022_customer;";
                cmdview = new MySqlCommand(sqlview, connDB.conn);
                reader = cmdview.ExecuteReader();

                while (reader.Read())
                {
                    cmbCust.Items.Add(reader[0]);
                }
            }

            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }

        void IsiCMBKodeBarang()
        {
            connDB.KoneksiDB();

            try
            {
                sqlview = "SELECT Kode_Barang FROM tbl_0615103022_barang;";
                cmdview = new MySqlCommand(sqlview, connDB.conn);
                reader = cmdview.ExecuteReader();

                while (reader.Read())
                {
                    cmbKodeBRG.Items.Add(reader[0]);
                }
            }

            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }

        private void cmbKodeBRG_SelectedIndexChanged(object sender, EventArgs e)
        {
            connDB.KoneksiDB();

            try
            {
                sqlview = "SELECT Nama_Barang, Satuan, Harga_Satuan FROM tbl_0615103022_barang WHERE Kode_Barang='" + cmbKodeBRG.Text + "'";
                cmdview = new MySqlCommand(sqlview, connDB.conn);
                reader = cmdview.ExecuteReader();

                if (reader.Read())
                {
                    txtNamaBRG.Text = reader[0].ToString();
                    txtSatuan.Text = reader[1].ToString();
                    txtHargasatuan.Text = reader[2].ToString();
                }
                //IsiCMBKodeBarang();
                disabled();
            }

            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }

        private void cmbCust_SelectedIndexChanged(object sender, EventArgs e)
        {
            connDB.KoneksiDB();

            try
            {
                sqlview = "SELECT Nama FROM tbl_0615103022_customer WHERE ID_Customer='" + cmbCust.Text + "'";
                cmdview = new MySqlCommand(sqlview, connDB.conn);
                reader = cmdview.ExecuteReader();

                if (reader.Read())
                {
                    txtNamaCust.Text = reader[0].ToString();
                }

                //IsiCMBIDCustomer();
                txtNamaCust.Enabled = false;
            }

            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }

        private void hitung()
        {
            double jmlhsblmdiskon = 0;
            double diskon = 0;
            
            jmlhsblmdiskon = jmlhsblmdiskon + (Convert.ToInt32(txtHargasatuan.Text) * Convert.ToInt32(txtJumlahBRG.Text));

            if (jmlhsblmdiskon > 10000000)
            {
                diskon = jmlhsblmdiskon * 0.10;
            }
            txtDiskon.Text = Convert.ToString(jmlhsblmdiskon);
            txtDiskon.Text = Convert.ToString(diskon);
            txtTotal.Text = Convert.ToString(jmlhsblmdiskon);
        }

        private double HitungTotalBayar()
        {
            return (Convert.ToDouble(txtTotal.Text) - Convert.ToDouble(txtDiskon.Text));
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            if (isValid1() == true)
            {
                hitung();
                txtTotBay.Text = Convert.ToString(HitungTotalBayar());
                txtJumlahByr.Focus();
                txtDiskon.Enabled = false;
                btnSimpan.Visible = true;
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            connDB.KoneksiDB();
            HtungKembali();
            if (isValid() == true)
            {
                
                sql1 = "INSERT INTO tbl_0615103022_headtransaksi"
                    + " (No_Nota, Tanggal, ID_Customer,"
                    + " Total_Harga, ID_Karyawan) VALUES('" + txtNOta.Text + "',"
                    + "'" + dTPTRX.Text + "', '" + cmbCust.Text + "',"
                    + "'" + txtTotal.Text + "', '" + cmbIDKRW.Text + "')";
                cmd1 = new MySqlCommand(sql1, connDB.conn);

                sql2 = "INSERT INTO tbl_0615103022_detailtransaksi"
                                 + " (No_Nota, Kode_Barang, Nama_Barang, Jumlah) VALUES('" + txtNOta.Text + "',"
                                 + "'" + cmbKodeBRG.Text + "', '" + txtNamaBRG.Text + "', '" + txtJumlahBRG.Text + "')";
                cmd2 = new MySqlCommand(sql2, connDB.conn);

                try
                {
                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
 
                    MessageBox.Show("Data Tersimpan");
                    DataTransaksi();
                    clear(); enabled();
                    txtNamaCust.Enabled = true;
                    txtNOta.Text = NoTRX;
                    cmbIDKRW.Focus();
                    btnSimpan.Visible = false;
                } 
                catch (Exception ex)
                {
                    MessageBox.Show("Data gagal disimpan" + ex);
                }
            }
        }

        private void txtNOta_TextChanged(object sender, EventArgs e)
        {
            
        }

        void HtungKembali()
        {
                txtKembali.Text = Convert.ToString(Convert.ToDouble(txtJumlahByr.Text) - Convert.ToDouble(txtTotBay.Text));
        }

        private void txtKembali_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HtungKembali();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cmbCust_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbKodeBRG.Focus();
            }
        }

        private void txtJumlahBRG_TextChanged(object sender, EventArgs e)
        {
            string text = txtJumlahBRG.Text;
            string str = txtJumlahBRG.Text;
            bool hasDigit = false;

            if (txtJumlahBRG.Text != "")
            {
                foreach (char letter in text)
                {
                    if (char.IsDigit(letter))
                    {
                        hasDigit = true;
                        break;
                    }
                }
                if (!hasDigit)
                {
                    MessageBox.Show("Jumlah Barang harus Numeric");
                    txtJumlahBRG.Clear();
                    txtJumlahBRG.Focus();
                    return;
                }
            }
        }

        private void cmbKodeBRG_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtJumlahBRG.Focus();
            }
        }

        private void txtJumlahBRG_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnHitung.Focus();
            }
        }

        private void txtJumlahByr_TextChanged(object sender, EventArgs e)
        {
            string text = txtJumlahByr.Text;
            string str = txtJumlahByr.Text;
            bool hasDigit = false;

            if (txtJumlahByr.Text != "")
            {
                foreach (char letter in text)
                {
                    if (char.IsDigit(letter))
                    {
                        hasDigit = true;
                        break;
                    }
                }
                if (!hasDigit)
                {
                    MessageBox.Show("Jumlah Barang harus Numeric");
                    txtJumlahByr.Clear();
                    txtJumlahByr.Focus();
                    return;
                }
            }
        }

        private void txtJumlahByr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSimpan.Focus();
            }
        }
    }
}
