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
    public partial class FrmBarang : Form
    {
        MySqlCommand cmd = null;
        MySqlDataReader reader = null;
        string sql;
        int baris = 0;

        Koneksi connDB = new Koneksi();

        public FrmBarang()
        {
            InitializeComponent();
            DataBarang();
        }

        private string KdBRG
        {
            get
            {
                string nomer = "BRG0001";
                MySqlCommand cmd = new MySqlCommand("select max(right(Kode_Barang,4)) from tbl_0615103022_barang",
                    connDB.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader[0].ToString() != "")
                    nomer = "BRG" + (int.Parse(reader[0].ToString()) + 1).ToString("0000");

                reader.Close();
                return nomer;
            }
        }

        private void clear()
        {
            txtNama.Clear();
            cmbSatuan.ResetText();
            txtStock.Clear();
            txtxHarga.Clear();
            txtKode.Focus();
        }

        private Boolean isValid()
        {
            if (txtKode.Text.Trim() == "")
            {
                MessageBox.Show("Kode barang harus diisi.");
                txtKode.Focus();
                return false;
            }

            if (txtNama.Text == "")
            {
                MessageBox.Show("Nama Barang harus diisi.");
                txtNama.Focus();
                return false;
            }

            if (cmbSatuan.Text == "")
            {
                MessageBox.Show("Satuan barang harus isi.");
                cmbSatuan.Focus();
                return false;
            }

            if (txtStock.Text == "")
            {
                MessageBox.Show("Stock barang harus isi.");
                txtStock.Focus();
                return false;
            }

            if (txtxHarga.Text == "")
            {
                MessageBox.Show("Harga Satuan barang harus isi.");
                txtxHarga.Focus();
                return false;
            }


            return true;
        }
        void DataBarang()
        {
            connDB.KoneksiDB();
            DGViewBRG.Rows.Clear();

            try
            {
                sql = "SELECT Kode_Barang, Nama_Barang, Satuan, Stock, Harga_Satuan FROM tbl_0615103022_barang;";
                cmd = new MySqlCommand(sql, connDB.conn);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int rows = DGViewBRG.Rows.Add();

                    DGViewBRG.Rows[rows].Cells[0].Value = rows + 1;

                    for (int j = 0; j < reader.FieldCount; j++)
                    {
                        DGViewBRG.Rows[rows].Cells[j + 1].Value = reader.GetString(j);
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
        private void FrmBarang_Load(object sender, EventArgs e)
        {
            txtKode.Text = KdBRG;
            txtKode.Enabled = false;
            txtNama.Enabled = false;
            cmbSatuan.Enabled = false;
            txtStock.Enabled = false;
            txtxHarga.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            baris = DGViewBRG.CurrentCell.RowIndex;

            txtKode.Text = DGViewBRG.Rows[baris].Cells[1].Value.ToString();
            txtNama.Text = DGViewBRG.Rows[baris].Cells[2].Value.ToString();
            cmbSatuan.Text = DGViewBRG.Rows[baris].Cells[3].Value.ToString();
            txtStock.Text = DGViewBRG.Rows[baris].Cells[4].Value.ToString();
            txtxHarga.Text = DGViewBRG.Rows[baris].Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connDB.KoneksiDB();
            if (isValid() == true)
            {
                sql = "INSERT INTO tbl_0615103022_barang"
                    + " (Kode_Barang, Nama_Barang, Satuan,"
                    + " Stock, Harga_Satuan) VALUES('" + txtKode.Text + "',"
                    + "'" + txtNama.Text + "', '" + cmbSatuan.Text + "',"
                    + "'" + txtStock.Text + "', '" + txtxHarga.Text + "')";
                cmd = new MySqlCommand(sql, connDB.conn);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Tersimpan");
                    DataBarang();
                    btnTambah.Visible = true;
                    btnHapus.Visible = true;
                    btnEdit.Visible = true;
                    btnUpdate.Visible = true;
                    txtKode.Enabled = false;
                    txtNama.Enabled = false;
                    cmbSatuan.Enabled = false;
                    txtStock.Enabled = false;
                    txtxHarga.Enabled = false;
                    clear();
                    txtKode.Text = KdBRG;
                    btnTambah.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Data gagal disimpan" + ex);
                }
            }
        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtKode.Text != "")
            {
                if (MessageBox.Show("Anda Yakin Menghapus Data Ini ?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                    sql = "DELETE FROM tbl_0615103022_barang WHERE Kode_Barang = '" + txtKode.Text + "'";
                    cmd = new MySqlCommand(sql, connDB.conn);
                    connDB.KoneksiDB();
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Terhapus");
                        DataBarang();
                        txtKode.Text = KdBRG;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Data gagal dihapus" + ex);
                    }
                    clear();
                    txtKode.Text = KdBRG;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtKode.Text = KdBRG;
            clear();
            enabled();
            btnTambah.Visible = true;
            btnHapus.Visible = true;
            btnEdit.Visible = true;
            btnUpdate.Visible = true;
            txtKode.Enabled = false;
            txtNama.Enabled = false;
            cmbSatuan.Enabled = false;
            txtStock.Enabled = false;
            txtxHarga.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connDB.KoneksiDB();

            sql = "UPDATE tbl_0615103022_barang SET Stock ='"+txtStock.Text+"', Harga_Satuan = '"+txtxHarga.Text+"'"
                + " Where Kode_Barang='"+txtKode.Text+"'";
                cmd = new MySqlCommand(sql, connDB.conn);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Telah Diubah");
                    DataBarang();
                    clear();
                    enabled();
                    txtKode.Enabled = false;
                    txtNama.Enabled = false;
                    cmbSatuan.Enabled = false;
                    txtStock.Enabled = false;
                    txtxHarga.Enabled = false;
                    txtKode.Text = KdBRG;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Data gagal diubah" + ex);
                }
            }

        private void txtEdit_Click(object sender, EventArgs e)
        {
            disabled();
            txtStock.Enabled = true;
            txtxHarga.Enabled = true;
            txtStock.Focus();
        }

        private void disabled()
        {
            txtKode.Enabled = false;
            txtNama.Enabled = false;
            cmbSatuan.Enabled = false;
            btnSImpan.Enabled = false;
            btnHapus.Enabled = false;
            btnTambah.Enabled = false;
            btnEdit.Visible = false;
        }
        private void enabled()
        {
            txtKode.Enabled = true;
            txtNama.Enabled = true;
            cmbSatuan.Enabled = true;
            btnSImpan.Enabled = true;
            btnHapus.Enabled = true;
            btnEdit.Visible = true;
            btnTambah.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {
            string text = txtStock.Text;
            bool hasDigit = false;

            if (txtStock.Text != "")
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
                    MessageBox.Show("Stock Harus Numeric");
                    txtStock.Clear();
                    txtStock.Focus();
                    return;
                }
            }
        }

        private void txtxHarga_TextChanged(object sender, EventArgs e)
        {
            string text = txtxHarga.Text;
            bool hasDigit = false;

            if (txtxHarga.Text != "")
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
                    MessageBox.Show("Harga Harus Numeric");
                    txtxHarga.Clear();
                    txtxHarga.Focus();
                    return;
                }
            }
        }

        private void txtKode_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtKode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNama.Focus();
            }
        }

        private void txtNama_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtNama_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbSatuan.Focus();
            }
        }

        private void cmbSatuan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtStock.Focus();
            }
        }

        private void txtStock_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtxHarga.Focus();
            }
        }

        private void txtxHarga_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtxHarga_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSImpan.Focus();
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            btnTambah.Visible = false;
            btnHapus.Visible = false;
            btnEdit.Visible = false;
            btnUpdate.Visible = false;

            txtNama.Enabled = true;
            cmbSatuan.Enabled = true;
            txtStock.Enabled = true;
            txtxHarga.Enabled = true;

            txtNama.Focus();
        }
        }
   }
