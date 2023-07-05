using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Controler;
namespace DangNhap
{
    public partial class fmDiem : Form
    {
        DatabaseService a = new DatabaseService();
        SystemControl b = new SystemControl();
        public fmDiem()
        {
            InitializeComponent();
        }

        private void btXemdiem_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text!=""&&comboBox1.Text!="")
            {
                if (b.KiemtraDiem(txtMaSV.Text, comboBox1.Text))
                {
                    a.OpenConnect();
                    dataGridView1.DataSource = a.LayBang("select * from Diem where MSSV like '%" + txtMaSV.Text.Trim() + "%' and TenMon like N'%" + comboBox1.Text.Trim() + "%'");
                }
                else
                    MessageBox.Show("Không tìm thấy Sinh viên này!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Chưa nhập đầy đủ thông tin!!!","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void fmDiem_Load(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "TenMon";
            comboBox1.ValueMember = "MaMon";
            comboBox1.DataSource = b.LoadComboBox("MonHoc").Tables[0];
        }

        private void btTrangchu_Click(object sender, EventArgs e)
        {
            this.Hide();
            fmMember a = new fmMember();
            a.Show();
        }
    }
}
