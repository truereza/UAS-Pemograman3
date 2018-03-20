using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PRJ_0615103022_MuhamadRezaGunawijaya
{
    public partial class Frm_Karyawan : Form
    {
        MySqlCommand cmd = null;
        MySqlDataReader reader = null;
        string sql;
        int baris = 0;

        Koneksi connDB = new Koneksi();

        public Frm_Karyawan()
        {
            InitializeComponent();
            DataKaryawan();
        }

        private string KodeKaryawan
        {
            get
            {
                string nomer = "KRW00001";
                MySqlCommand cmd = new MySqlCommand("select max(right(ID_Karyawan,5)) from tbl_0615103022_karyawan",
                    connDB.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader[0].ToString() != "")
                    nomer = "KRW" + (int.Parse(reader[0].ToString()) + 1).ToString("00000");

                reader.Close();
                return nomer;
            }
        }

        private void Frm_Karyawan_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            txtNama.Enabled = false;
            dtpTGLLhr.Enabled = false;
            txtTelp.Enabled = false;
            txtEmail.Enabled = false;
            txtID.Text = KodeKaryawan;
        }

        private void clear()
        {
            txtID.Clear();
            txtNama.Clear();
            txtTelp.Clear();
            txtEmail.Clear();
            dtpTGLLhr.ResetText();
            txtID.Focus();
        }

        private Boolean isValid()
        {
            if (txtID.Text.Trim() == "")
            {
                MessageBox.Show("ID Karyawan harus diisi.");
                txtID.Focus();
                return false;
            }

            if (txtNama.Text == "")
            {
                MessageBox.Show("Nama harus diisi.");
                txtNama.Focus();
                return false;
            }


            if (txtTelp.Text == "")
            {
                MessageBox.Show("No Telepon harus isi.");
                txtTelp.Focus();
                return false;
            }

            if (txtEmail.Text == "" || !txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Email harus isi atau Format Email Salah");
                txtEmail.Focus();
                return false;
            }
            return true;
        }

        void DataKaryawan()
        {
            connDB.KoneksiDB();
            DGKaryawan.Rows.Clear();

            try
            {
                sql = "SELECT ID_Karyawan, Nama, TanggalLahir, Telepon, Email FROM tbl_0615103022_karyawan;";
                cmd = new MySqlCommand(sql, connDB.conn);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int rows = DGKaryawan.Rows.Add();

                    DGKaryawan.Rows[rows].Cells[0].Value = rows + 1;

                    for (int j = 0; j < reader.FieldCount; j++)
                    {
                        DGKaryawan.Rows[rows].Cells[j + 1].Value = reader.GetString(j);
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

        private void DGKaryawan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            baris = DGKaryawan.CurrentCell.RowIndex;

            txtID.Text = DGKaryawan.Rows[baris].Cells[1].Value.ToString();
            txtNama.Text = DGKaryawan.Rows[baris].Cells[2].Value.ToString();
            //dtpTGLLhr.Text = DGKaryawan.Rows[baris].Cells[3].Value.ToString();
            txtTelp.Text = DGKaryawan.Rows[baris].Cells[4].Value.ToString();
            txtEmail.Text = DGKaryawan.Rows[baris].Cells[5].Value.ToString();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            connDB.KoneksiDB();
            if (isValid() == true)
            {
                sql = "INSERT INTO tbl_0615103022_karyawan"
                    + " (ID_Karyawan, Nama, TanggalLahir,"
                    + " Telepon, Email) VALUES('" + txtID.Text + "',"
                    + "'" + txtNama.Text + "', '" + dtpTGLLhr.Text + "',"
                    + "'" + txtTelp.Text + "', '" + txtEmail.Text + "')";
                cmd = new MySqlCommand(sql, connDB.conn);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Tersimpan");
                    DataKaryawan();
                    clear();
                    txtID.Enabled = false;
                    txtNama.Enabled = false;
                    dtpTGLLhr.Enabled = false;
                    txtTelp.Enabled = false;
                    txtEmail.Enabled = false;
                    btnHapus.Visible = true;
                    btnUbah.Visible = true;
                    btnEdit.Visible = true;
                    btnTambah.Visible = true;
                    btnTambah.Focus();
                    txtID.Text = KodeKaryawan;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Data gagal disimpan" + ex);
                }
            }
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNama.Focus();
            }
        }

        private void txtNama_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtpTGLLhr.Focus();
            }
        }

        private void dtpTGLLhr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTelp.Focus();
            }
        }

        private void txtTelp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEmail.Focus();
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSimpan.Focus();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                if (MessageBox.Show("Anda Yakin Menghapus Data Ini?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    sql = "DELETE FROM tbl_0615103022_karyawan WHERE ID_Karyawan = '" + txtID.Text + "'";
                    cmd = new MySqlCommand(sql, connDB.conn);
                    connDB.KoneksiDB();
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Terhapus");
                        DataKaryawan();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Data gagal dihapus" + ex);
                    }
                    clear();
                    txtID.Text = KodeKaryawan;
                }
            }
        }

        private void txtTelp_TextChanged(object sender, EventArgs e)
        {
            string text = txtTelp.Text;
            string str = txtTelp.Text;
            bool hasDigit = false;

            if (txtTelp.Text != "")
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
                    MessageBox.Show("Telepon harus Numeric");
                    txtTelp.Clear();
                    txtTelp.Focus();
                    return;
                }
                if (str.Length > 12)
                {
                    MessageBox.Show("No Handphone Todak Boleh Lebih Dari 12 Digit!");
                    txtTelp.Text = "";
                    txtTelp.Focus();
                }
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            connDB.KoneksiDB();

            sql = "UPDATE tbl_0615103022_karyawan SET Telepon ='"+txtTelp.Text+"', Email = '"+txtEmail.Text+"'"
                + " Where Id_Karyawan='"+txtID.Text+"'";
                cmd = new MySqlCommand(sql, connDB.conn);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Telah Diubah");
                    DataKaryawan();
                    clear();
                    enabled();
                    txtID.Enabled = false;
                    txtNama.Enabled = false;
                    dtpTGLLhr.Enabled = false;
                    txtTelp.Enabled = false;
                    txtEmail.Enabled = false;
                    btnTambah.Enabled = true;
                    btnHapus.Enabled = true;
                    txtID.Text = KodeKaryawan;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Data gagal diubah" + ex);
                }
            }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            disable();
            txtTelp.Enabled = true;
            txtEmail.Enabled = true;
            txtTelp.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
            enabled();
            btnTambah.Visible = true;
            btnHapus.Visible = true;
            btnEdit.Visible = true;
            btnUbah.Visible = true;
            txtID.Enabled = false;
            txtNama.Enabled = false;
            dtpTGLLhr.Enabled = false;
            txtTelp.Enabled = false;
            txtEmail.Enabled = false;
            txtID.Text = KodeKaryawan;
        }

        private void disable()
        {
            txtID.Enabled = false;
            txtNama.Enabled = false;
            dtpTGLLhr.Enabled = false;
            btnSimpan.Enabled = false;
            btnHapus.Enabled = false;
            btnTambah.Enabled = false;
            btnEdit.Visible = false;
        }

        private void enabled()
        {
            txtID.Enabled = true;
            txtNama.Enabled = true;
            dtpTGLLhr.Enabled = true;
            btnSimpan.Enabled = true;
            btnHapus.Enabled = true;
            btnEdit.Visible = true;
            btnTambah.Enabled = true;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            btnTambah.Visible = false;
            btnHapus.Visible = false;
            btnUbah.Visible = false;
            btnEdit.Visible = false;

            txtNama.Enabled = true;
            dtpTGLLhr.Enabled = true;
            txtTelp.Enabled = true;
            txtEmail.Enabled = true;
            txtNama.Focus();
        }
    }
}
