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
using System.Data.SqlClient;

namespace DangNhap
{
    public partial class fmQLDiemSV : Form
    {
        DatabaseService a = new DatabaseService();
        SystemControl systemControl = new SystemControl();
        public fmQLDiemSV()
        {
            InitializeComponent();
        }

        private void btTChu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main a = new Main();
            a.Show();
        }

        private void fmQLDiemSV_Load(object sender, EventArgs e)
        {
            cbMaSV.DisplayMember = "MSSV";
            cbMaSV.ValueMember = "MSSV";
            cbMaSV.DataSource = systemControl.LoadData("Sinhvien").Tables[0];
            cbMon.DisplayMember = "TenMon";
            cbMon.ValueMember = "MaMon";
            cbMon.DataSource = systemControl.LoadComboBox("MonHoc").Tables[0];
            dataGridView1.DataSource = systemControl.LoadDataDiem("Diem").Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
           cbMaSV.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            cbMon.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtDiem.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbMaSV.Text != "")
                {
                    if (systemControl.KiemtraDiem(cbMaSV.Text,cbMon.Text)==true)
                    {
                        MessageBox.Show("Sinh viên đã có điểm Môn này!!!", "Error", MessageBoxButtons.OK);
                    }
                    else
                    {                       
                            a.OpenConnect();
                            ///Them vao sql
                            string sql = "insert into Diem values('" + cbMaSV.Text + "',N'" + cbMon.Text + "','" + float.Parse(txtDiem.Text) + "')";
                            SqlCommand command = new SqlCommand(sql, a.connection);
                            int kq = (int)command.ExecuteNonQuery();
                            if (kq > 0)
                            {
                                MessageBox.Show("Thêm thành công!");
                                dataGridView1.DataSource = systemControl.LoadDataDiem("Diem").Tables[0];
                            }
                            else MessageBox.Show("Thêm thất bại!!");
                            a.CloseConnect();
                        }                                              
                    }            
                else
                    MessageBox.Show("Chua nhap day du thong tin");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi ket noi" + ex.Message);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                a.OpenConnect();
                string sql = "delete from Diem where MSSV='" + cbMaSV.Text + "'and TenMon=N'"+cbMon.Text+"'";
                SqlCommand command = new SqlCommand(sql, a.connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công");
                dataGridView1.DataSource = systemControl.LoadDataDiem("Diem").Tables[0];
                a.CloseConnect();
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (systemControl.KiemtraDiem(cbMaSV.Text,cbMon.Text)==true)
                {
                    a.OpenConnect();
                    ///Them vao sql
                    string sql = "update Diem set Diem='" + float.Parse(txtDiem.Text) + "'where MSSV='" + cbMaSV.Text + "' and TenMon=N'" + cbMon.Text + "'";
                    SqlCommand command = new SqlCommand(sql, a.connection);
                    int kq = (int)command.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Sửa thành công!");
                        dataGridView1.DataSource = systemControl.LoadDataDiem("Diem").Tables[0];
                    }
                    else MessageBox.Show("Sửa thất bại!!");
                    a.CloseConnect();
                   
                }
                else
                {
                    MessageBox.Show("SV chưa có điểm môn này!!!", "Error", MessageBoxButtons.OK);                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi ket noi" + ex.Message);
            }
        }
    }
}
