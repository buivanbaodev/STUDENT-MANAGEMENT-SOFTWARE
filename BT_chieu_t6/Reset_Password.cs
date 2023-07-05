using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_chieu_t6
{
    public partial class Reset_Password : Form
    {
        public Reset_Password()
        {
            InitializeComponent();
        }
        private string pass;
        public Reset_Password(string pass)
        {
            InitializeComponent();
            this.pass = pass;
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            if(txtNewPass.Text==txtConfirm.Text)
            {
                pass=txtNewPass.Text;
            }
            
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login a = new Login();
            a.Show();
        }

        private void Reset_Password_Load(object sender, EventArgs e)
        {
            txtOldPass.Text=pass;
        }
    }
}
