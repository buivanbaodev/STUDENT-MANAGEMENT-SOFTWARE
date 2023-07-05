using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//const string connectionString = "Data Source= ADMIN\\SQLEXPRESS"+""

namespace BT_chieu_t6
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public string pass="";
        public string user="";
        private void btLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Moi ban nhap tai khoan hoac mat khau!!!");
            }
            else if (txtUser.Text != user || txtPass.Text != pass)
            {
                MessageBox.Show("User hoac Password khong hop le!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtUser.Text == user && txtPass.Text == pass)
            {
                this.Hide();
                MessageBox.Show("Dang nhap thanh cong!!!", "Success", MessageBoxButtons.OK);
                this.Hide();
                Wellcome a = new Wellcome(txtPass.Text);
                a.Show();
                
            }              
        }
        

        private void btContactUs_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContactUs us = new ContactUs();
            us.Show();
        }
    }
}
