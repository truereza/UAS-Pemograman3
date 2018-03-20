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
    public partial class Frm_User : Form
    {
        public MySqlCommand cmd;
        public MySqlDataReader reader;
        public string sql;

        Koneksi connDB = new Koneksi();

        public Frm_User()
        {
            InitializeComponent();
            IsiCMB();
        }

        private void Frm_User_Load(object sender, EventArgs e)
        {
            cmbID.Focus();
        }

        private void clear()
        {
            cmbID.ResetText();
            txtUser.Clear();
            txtPWD.Clear();
            cmbID.Focus();
        }
        void IsiCMB()
        {
            connDB.KoneksiDB();

            try
            {
                sql = "SELECT ID_Karyawan FROM tbl_0615103022_karyawan;";
                cmd = new MySqlCommand(sql, connDB.conn);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbID.Items.Add(reader[0]);
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

        private void cmbID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            connDB.KoneksiDB();

            sql = "INSERT INTO tbl_0615103022_login"
                + " (ID_Karyawan, Username, Password) "
                + " VALUES('" + cmbID.Text + "','" + txtUser.Text + "', '" + txtPWD.Text + "')";
            cmd = new MySqlCommand(sql, connDB.conn);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Tersimpan");
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data gagal disimpan" + ex);
            }
        }
    }
}
