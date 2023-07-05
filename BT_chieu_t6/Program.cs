using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_chieu_t6
{ 
    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string pw = "123";
                string user="admin";
            Login f = new Login();
            f.user = user;
            f.pass = pw;
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

            Application.Run(new Login());
        }
    }
}
