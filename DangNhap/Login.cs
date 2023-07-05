
using Controler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangNhap
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            SystemControl a = new SystemControl();
            if (a.CheckAccount(txtEmail.Text, txtPass.Text, checkBox1.Checked))
            {
                this.Hide();
                if (checkBox1.Checked == true)
                {

                    frmAdmin A = new frmAdmin();
                    A.Show();
                }
                else
                {
                    MainFrom m = new MainFrom();
                    m.Show();
                }

                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("False");
            }
        }
    }
}
