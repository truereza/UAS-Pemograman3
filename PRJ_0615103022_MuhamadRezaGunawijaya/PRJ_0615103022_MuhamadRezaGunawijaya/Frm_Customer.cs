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
    public partial class Frm_Customer : Form
    {
        MySqlCommand cmd = null;
        MySqlDataReader reader = null;
        string sql;
        int baris = 0;

        Koneksi ConnDB = new Koneksi();

        public Frm_Customer()
        {
            InitializeComponent();
            DataCustomer();
        }

        private string KodeCust
        {
            get
            {
                string nomer = "Cust0001";
                MySqlCommand cmd = new MySqlCommand("select max(right(ID_Customer,4)) from tbl_0615103022_customer",
                    ConnDB.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader[0].ToString() != "")
                    nomer = "Cust" + (int.Parse(reader[0].ToString()) + 1).ToString("0000");

                reader.Close();
                return nomer;
            }
        }

        private Boolean isValid()
        {
            if (txtID.Text.Trim() == "")
            {
                MessageBox.Show("ID Customer harus diisi.");
                txtID.Focus();
                return false;
            }

            if (txtNama.Text == "")
            {
                MessageBox.Show("Nama harus diisi.");
                txtNama.Focus();
                return false;
            }


            if (txtAlamat.Text == "")
            {
                MessageBox.Show("Alamat harus isi.");
                txtAlamat.Focus();
                return false;
            }

            if (txtTelepon.Text == "")
            {
                MessageBox.Show("No Telepon harus isi.");
                txtTelepon.Focus();
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
        void DataCustomer()
        {
            ConnDB.KoneksiDB();
            DGCustomer.Rows.Clear();

            try
            {
                sql = "SELECT ID_Customer, Nama, Alamat, Telepon, Email FROM tbl_0615103022_customer;";
                cmd = new MySqlCommand(sql, ConnDB.conn);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int rows = DGCustomer.Rows.Add();

                    DGCustomer.Rows[rows].Cells[0].Value = rows + 1;

                    for (int j = 0; j < reader.FieldCount; j++)
                    {
                        DGCustomer.Rows[rows].Cells[j + 1].Value = reader.GetString(j);
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

        private void DGCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            baris = DGCustomer.CurrentCell.RowIndex;

            txtID.Text = DGCustomer.Rows[baris].Cells[1].Value.ToString();
            txtNama.Text = DGCustomer.Rows[baris].Cells[2].Value.ToString();
            txtAlamat.Text = DGCustomer.Rows[baris].Cells[3].Value.ToString();
            txtTelepon.Text = DGCustomer.Rows[baris].Cells[4].Value.ToString();
            txtEmail.Text = DGCustomer.Rows[baris].Cells[5].Value.ToString();
        }

        private void txtTelepon_TextChanged(object sender, EventArgs e)
        {
            string text = txtTelepon.Text;
            string str = txtTelepon.Text;
            bool hasDigit = false;

            if (txtTelepon.Text != "")
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
                    txtTelepon.Clear();
                    txtTelepon.Focus();
                    return;
                }
                if (str.Length > 12)
                {
                    MessageBox.Show("No Handphone Todak Boleh Lebih Dari 12 Digit!");
                    txtTelepon.Text = "";
                    txtTelepon.Focus();
                }
            }
        }

        private void clear()
        {
            txtID.Clear();
            txtNama.Clear();
            txtAlamat.Clear();
            txtTelepon.Clear();
            txtEmail.Clear();
            txtID.Focus();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clear();
            enabled();
            btnTambah.Visible = true;
            btnHapus.Visible = true;
            btnUbah.Visible = true;
            btnEdit.Visible = true;
            txtID.Enabled = false;
            txtNama.Enabled = false;
            txtAlamat.Enabled = false;
            txtTelepon.Enabled = false;
            txtEmail.Enabled = false;
            txtID.Text = KodeCust;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnDB.KoneksiDB();
            if (isValid() == true)
            {
                sql = "INSERT INTO tbl_0615103022_customer"
                    + " (ID_Customer, Nama, Alamat,"
                    + " Telepon, Email) VALUES('" + txtID.Text + "',"
                    + "'" + txtNama.Text + "', '" + txtAlamat.Text + "',"
                    + "'" + txtTelepon.Text + "', '" + txtEmail.Text + "')";
                cmd = new MySqlCommand(sql, ConnDB.conn);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Tersimpan");
                    DataCustomer();
                    clear();
                    txtID.Enabled = false;
                    txtNama.Enabled = false;
                    txtAlamat.Enabled = false;
                    txtTelepon.Enabled = false;
                    txtEmail.Enabled = false;
                    btnHapus.Visible = true;
                    btnUbah.Visible = true;
                    btnEdit.Visible = true;
                    btnTambah.Visible = true;
                    txtID.Text = KodeCust;
                    btnTambah.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Data gagal disimpan" + ex);
                }
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                if (MessageBox.Show("Anda Yakin Menghapus Data Ini?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    sql = "DELETE FROM tbl_0615103022_customer WHERE ID_Customer = '" + txtID.Text + "'";
                    cmd = new MySqlCommand(sql, ConnDB.conn);
                    ConnDB.KoneksiDB();
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Terhapus");
                        DataCustomer();
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Data gagal dihapus" + ex);
                    }
                    clear();
                    txtID.Text = KodeCust;
                }
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            ConnDB.KoneksiDB();

            sql = "UPDATE tbl_0615103022_customer SET Alamat ='" + txtAlamat.Text + "', Telepon = '" + txtTelepon.Text + "', Email = '" + txtEmail.Text + "'"
                + " Where ID_Customer='" + txtID.Text + "'";
            cmd = new MySqlCommand(sql, ConnDB.conn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Telah Diubah");
                DataCustomer();
                clear();
                txtID.Enabled = false;
                txtNama.Enabled = false;
                txtAlamat.Enabled = false;
                txtTelepon.Enabled = false;
                txtEmail.Enabled = false;
                btnTambah.Enabled = true;
                btnHapus.Enabled = true;
                txtID.Text = KodeCust;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data gagal diubah" + ex);
            }
        }

        private void disable()
        {
            txtID.Enabled = false;
            txtNama.Enabled = false;
            btnSimpan.Enabled = false;
            btnHapus.Enabled = false;
            btnEdit.Visible = false;
            btnTambah.Enabled = false;
        }

        private void enabled()
        {
            txtID.Enabled = true;
            txtNama.Enabled = true;
            btnSimpan.Enabled = true;
            btnHapus.Enabled = true;
            btnEdit.Visible = true;
            btnTambah.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            disable();
            txtAlamat.Enabled = true;
            txtTelepon.Enabled = true;
            txtEmail.Enabled = true;
            txtAlamat.Focus();
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
                txtAlamat.Focus();
            }
        }

        private void txtAlamat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTelepon.Focus();
            }
        }

        private void txtTelepon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEmail.Focus();
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSimpan.Focus();
            }
        }

        private void Cari()
        {
            string kond;

            kond = "WHERE Nama LIKE '%" + txtxcari.Text.Trim() + "%'";
            ConnDB.tampilData_Customer(DGCustomer, kond);
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            Cari();
        }

        private void Frm_Customer_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            txtNama.Enabled = false;
            txtAlamat.Enabled = false;
            txtTelepon.Enabled = false;
            txtEmail.Enabled = false;
            txtID.Text = KodeCust;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            btnTambah.Visible = false;
            txtNama.Enabled = true;
            txtAlamat.Enabled = true;
            txtTelepon.Enabled = true;
            txtEmail.Enabled = true;
            btnHapus.Visible = false;
            btnUbah.Visible = false;
            btnEdit.Visible = false;
            
            txtNama.Focus();
        }
    }
}
