using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PRJ_0615103022_MuhamadRezaGunawijaya
{
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
        }

        private void transaksiToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Login frmLogin = new Frm_Login();
            this.Hide();
            frmLogin.Show();
        }

        private void Frm_Menu_Load(object sender, EventArgs e)
        {
            Frm_Login frmLogin = new Frm_Login();
            frmLogin.Close();
        }

        private void barangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBarang frmBRG = new FrmBarang();
            frmBRG.MdiParent = this;
            frmBRG.MaximizeBox = false;
            frmBRG.MinimizeBox = false;
            frmBRG.Show();
            frmBRG.Focus();
            frmBRG.WindowState = FormWindowState.Normal;
        }

        private void karyawanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Karyawan frmBRG = new Frm_Karyawan();
            frmBRG.MdiParent = this;
            frmBRG.MaximizeBox = false;
            frmBRG.MinimizeBox = false;
            frmBRG.Show();
            frmBRG.Focus();
            frmBRG.WindowState = FormWindowState.Normal;
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Customer frmBRG = new Frm_Customer();
            frmBRG.MdiParent = this;
            frmBRG.MaximizeBox = false;
            frmBRG.MinimizeBox = false;
            frmBRG.Show();
            frmBRG.Focus();
            frmBRG.WindowState = FormWindowState.Normal;
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_User frmBRG = new Frm_User();
            frmBRG.MdiParent = this;
            frmBRG.MaximizeBox = false;
            frmBRG.MinimizeBox = false;
            frmBRG.Show();
            frmBRG.Focus();
            frmBRG.WindowState = FormWindowState.Normal;
        }

        private void transaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Transaksi frmTRX = new Frm_Transaksi();
            frmTRX.MdiParent = this;
            frmTRX.MaximizeBox = false;
            frmTRX.MinimizeBox = false;
            frmTRX.Show();
            frmTRX.Focus();
            frmTRX.WindowState = FormWindowState.Normal;
            frmTRX.WindowState = FormWindowState.Maximized;
        }
    }
}
