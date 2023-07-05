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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FmDoiMK a = new FmDoiMK();
            a.Show();
        }

      
        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login a = new Login();
            a.Show();
        }

        private void traCứuVàThêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FmTraCuu a = new FmTraCuu();
            a.Show();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FmHoso a = new FmHoso();
            a.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login a = new Login();
            a.Show();
        }

        private void quảnLýKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fmQLKhoa a = new fmQLKhoa();
            a.Show();
        }

        private void quảnLýĐiểmSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fmQLDiemSV a = new fmQLDiemSV();
            a.Show();
        }
    }
}
