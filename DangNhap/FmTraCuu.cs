using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Model;
using Controler;
namespace DangNhap
{
    public partial class FmTraCuu : Form
    {
        SystemControl systemControl = new SystemControl();
        DatabaseService a = new DatabaseService();
        public FmTraCuu()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main a = new Main();
            a.Show();
        }
        private void FmTraCuu_Load(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "TenKhoa";
            comboBox1.ValueMember = "MaKhoa";
            comboBox1.DataSource = systemControl.LoadCombo("DSKhoa").Tables[0];
            dataGridView1.DataSource = systemControl.LoadData("Sinhvien").Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtMaSV.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtHoten.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtDiachi.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
        }
        private void btTimkiem_Click(object sender, EventArgs e)
        {
            if (cbMaSV.Checked)
            {
                a.OpenConnect();
                dataGridView1.DataSource = a.LayBang("select * from Sinhvien where MSSV like '%" + txtMaSV.Text.Trim() + "%'");
            }
            if (cbHoten.Checked)
            {
                a.OpenConnect();
                dataGridView1.DataSource = a.LayBang("select * from Sinhvien where HovaTen like N'%" + txtHoten.Text.Trim() + "%'");
            }
            if (cbDiaChi.Checked)
            {
                a.OpenConnect();
                dataGridView1.DataSource = a.LayBang("select * from Sinhvien where Diachi like N'%" + txtDiachi.Text.Trim() + "%'");
            }
            if (cbMaKhoa.Checked)
            {
                a.OpenConnect();
                dataGridView1.DataSource = a.LayBang("select * from Sinhvien where TenKhoa like N'%" + comboBox1.Text.Trim() + "%'");
            }
            if (cbNgaysinh.Checked)
            {
                a.OpenConnect();
                dataGridView1.DataSource = a.LayBang("select * from Sinhvien where Ngaysinh like '%" + dateTimePicker1.Text.Trim() + "%'");
            }
        }
    }
}
