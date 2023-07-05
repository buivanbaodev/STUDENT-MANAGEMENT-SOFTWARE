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
    public partial class Wellcome : Form
    {
        public Wellcome()
        {
            InitializeComponent();
        }
        private string pas;
        public Wellcome(string pass)
        {
            InitializeComponent();
            this.pas = pass;
        }
        private void btBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login b = new Login();
            b.Show();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reset_Password f = new Reset_Password(label2.Text);
            f.ShowDialog();
        }

        private void Wellcome_Load(object sender, EventArgs e)
        {
            label2.Text = pas;
        }
    }
}
