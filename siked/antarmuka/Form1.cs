using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using siked.model;

namespace siked
{
    public partial class Form1 : Form
    {
        LoginCls login = new LoginCls();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (login.apakahAda(username_txt.Text, pwd_txt.Text))
            {
                MessageBox.Show("Berhasil Login.", "" + "BERHASIL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                /*username_txt.SelectAll();
                username_txt.Focus();*/
                /* //DashboardFrm dashboard = new DashboardFrm();
                 dashboard.Show();
                 this.Hide();*/
            }
            else
            {
                MessageBox.Show("Maaf, Username / Password salah.", "" + "KESALAHAN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                username_txt.SelectAll();
                username_txt.Focus();
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
