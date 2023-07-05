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
    public partial class fmQLKhoa : Form
    {
        SystemControl systemControl = new SystemControl();
        DatabaseService a = new DatabaseService();
        public fmQLKhoa()
        {
            InitializeComponent();
        }
        
        private void fmQLKhoa_Load(object sender, EventArgs e)
        {            
            cbTenKhoa.DisplayMember = "TenKhoa";
            cbTenKhoa.ValueMember = "MaKhoa";
            cbTenKhoa.DataSource = systemControl.LoadCombo("DSKhoa").Tables[0];
            dataGridView1.DataSource = systemControl.LoadCombo("DSKhoa").Tables[0];
        }        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtMakhoa.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            cbTenKhoa.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMakhoa.Text != "")
                {
                    if (systemControl.KiemtraKhoa(txtMakhoa.Text) == true||systemControl.KiemtraTenKhoa(cbTenKhoa.Text)==true)   
                    {
                        MessageBox.Show("Khoa da ton tai!!!","Error",MessageBoxButtons.OKCancel);
                    }
                    else
                    {
                        a.OpenConnect();
                        ///Them vao sql
                        string sql = "insert into DSKhoa values('" + txtMakhoa.Text + "',N'" + cbTenKhoa.Text + "')";
                        SqlCommand command = new SqlCommand(sql, a.connection);
                        int kq = (int)command.ExecuteNonQuery();
                        if (kq > 0)
                        {
                            MessageBox.Show("Thêm thành công!");
                            dataGridView1.DataSource = systemControl.LoadCombo("DSKhoa").Tables[0];
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
                if (systemControl.KiemtraTenKhoaSV(cbTenKhoa.Text) == true)
                {
                    dialogResult = MessageBox.Show("Khoa này còn sinh viên?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.OK)
                    {
                        this.Hide();
                        fmQLKhoa a = new fmQLKhoa();
                        a.Show();
                    }
                    else
                    {
                        try
                        {

                            a.OpenConnect();
                            string sql1 = "delete from Sinhvien where TenKhoa=N'" + cbTenKhoa.Text + "'";
                            SqlCommand cmd = new SqlCommand(sql1, a.connection);
                            cmd.ExecuteNonQuery();
                            string sql = "delete from DSKhoa where MaKhoa='" + txtMakhoa.Text + "'";
                            SqlCommand command = new SqlCommand(sql, a.connection);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Xóa thành công");
                            dataGridView1.DataSource = systemControl.LoadCombo("DSKhoa").Tables[0];
                            a.CloseConnect();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Loi ket noi" + ex.Message);
                        }
                    }
                        

                }
                else
                {
                    a.OpenConnect();
                    string sql = "delete from DSKhoa where MaKhoa='" + txtMakhoa.Text + "'";
                    SqlCommand command = new SqlCommand(sql, a.connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công");
                    dataGridView1.DataSource = systemControl.LoadCombo("DSKhoa").Tables[0];
                    a.CloseConnect();
                }
                
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                    if (systemControl.KiemtraTenKhoa(cbTenKhoa.Text) == true)
                    {
                        MessageBox.Show("Khoa da ton tai!!!", "Error", MessageBoxButtons.OKCancel);
                    }
                    else
                    {
                        a.OpenConnect();
                        ///Them vao sql
                        string sql = "update DSKhoa set TenKhoa=N'" + cbTenKhoa.Text + "'where MaKhoa='" + txtMakhoa.Text + "'";
                        SqlCommand command = new SqlCommand(sql, a.connection);
                        int kq = (int)command.ExecuteNonQuery();
                        if (kq > 0)
                        {
                            MessageBox.Show("Sửa thành công!");
                            dataGridView1.DataSource = systemControl.LoadCombo("DSKhoa").Tables[0];
                        }
                        else MessageBox.Show("Sửa thất bại!!");
                        a.CloseConnect();
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi ket noi" + ex.Message);
            }
        }

        private void btTro_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main a = new Main();
            a.Show();
        }
    }
}
