using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace PRJ_0615103022_MuhamadRezaGunawijaya
{
    class Koneksi
    {
        public MySqlConnection conn = null;
        public string alamat;
        public MySqlCommand cmd = null;
        public MySqlDataReader reader = null;
        Boolean isLogin;

        public void KoneksiDB()
        {
            alamat = "Data Source=localhost;Database=db_0615103022_penjualanbrg;User ID=root;Password=;";

            try
            {
                conn = new MySqlConnection(alamat);
                conn.Open();
                //MessageBox.Show("Koneksi Terhubung");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi Tidak Terhubung Kepada Server" + ex.ToString());
            }
        }

        public Boolean cekLogin(string field, string cek)
        {
            string vsql = "SELECT " + field + " FROM tbl_0615103022_login WHERE " + field + " = '" + cek + "' ";

            try
            {
                cmd = new MySqlCommand(vsql, conn);
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                    isLogin = true;
                else
                    isLogin = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
            finally { }

            return isLogin;
        }

        public void tampilData_Customer(DataGridView DGCust, string kond = "")
        {
            DGCust.Rows.Clear();

            alamat = "SELECT ID_Customer, Nama, Alamat, Telepon, Email FROM tbl_0615103022_customer " + kond;

            try
            {
                cmd = new MySqlCommand(alamat, conn);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int rows = DGCust.Rows.Add();

                    DGCust.Rows[rows].Cells[0].Value = reader.GetString(0);
                    DGCust.Rows[rows].Cells[1].Value = reader.GetString(1);
                    DGCust.Rows[rows].Cells[2].Value = reader.GetString(2);
                    DGCust.Rows[rows].Cells[3].Value = reader.GetString(3);
                    DGCust.Rows[rows].Cells[4].Value = reader.GetString(4);

                }
                DGCust.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data TIdak Ditemukan : " + ex.ToString());
            }
            finally { }
        }

    }
}
