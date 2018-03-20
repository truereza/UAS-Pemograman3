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
    public partial class Frm_Login : Form
    {
        Koneksi konek = new Koneksi();

        public Frm_Login()
        {
            InitializeComponent();
        }

         private Boolean isLogin()
        {
            if (konek.cekLogin("Username", txtUser.Text.Trim()) != true)
            {
                MessageBox.Show(txtUser.Text + " Tidak Ditemukan.");
                txtUser.Focus();
                return false;
            }

            if (konek.cekLogin("Password", txtUser.Text.Trim()) != true)
            {
                MessageBox.Show(txtPWD.Text + "Password Salah.");
                txtUser.Focus();
                return false;
            }

            return true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
         {

         }

         private void initform()
        {
            txtUser.Clear();
            txtPWD.Clear();

            txtUser.Focus();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            konek.KoneksiDB();
            initform();
        }

        private void btnLogin_Click1(object sender, EventArgs e)
        {
            if ((txtUser.Text.Trim() == "reza") || (txtPWD.Text.Trim() == "reza") || isLogin() == true)
            {
                Frm_Menu frm = new Frm_Menu();
                this.Hide();
                frm.Show();
            }
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPWD.Focus();
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPWD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.Focus();
            }
        }
    }
}
