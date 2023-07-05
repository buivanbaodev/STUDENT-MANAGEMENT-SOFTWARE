using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controler;
namespace DangNhap
{
    public partial class FmHoso : Form
    {
        SystemControl systemControl = new SystemControl();
        DatabaseService a = new DatabaseService();
        public FmHoso()
        {
            InitializeComponent();           
        }       
        private void FmHoso_Load_1(object sender, EventArgs e)
        {
            cbKhoa.DisplayMember = "TenKhoa";
            cbKhoa.ValueMember = "MaKhoa";
            cbKhoa.DataSource = systemControl.LoadCombo("DSKhoa").Tables[0];
            dataGridView1.DataSource = systemControl.LoadData("Sinhvien").Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtMaSV.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtHoten.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtDiachi.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            dateTimePicker1.Text= dataGridView1.Rows[i].Cells[3].Value.ToString();
            cbKhoa.Text= dataGridView1.Rows[i].Cells[4].Value.ToString();
        }
      
        private void btThem_Click(object sender, EventArgs e)
        { 
            try
            {
                if (txtMaSV.Text != "")
                {
                    if (systemControl.KiemtraSV(txtMaSV.Text) == true)
                    {
                        MessageBox.Show("Ma SV da ton tai!!!");
                    }
                    
                    else {
                        if (systemControl.KiemtraTenKhoa(cbKhoa.Text) == true)
                        {
                            a.OpenConnect();
                        ///Them vao sql
                        string sql = "insert into Sinhvien values('" + txtMaSV.Text + "',N'" + txtHoten.Text + "',N'" + txtDiachi.Text + "','" + dateTimePicker1.Value.ToString() + "',N'" + cbKhoa.Text + "')";
                        SqlCommand command = new SqlCommand(sql, a.connection);
                        int kq = (int)command.ExecuteNonQuery();
                        if (kq > 0)
                        {
                            MessageBox.Show("Thêm thành công!");
                            dataGridView1.DataSource = systemControl.LoadData("Sinhvien").Tables[0];
                        }
                        else MessageBox.Show("Thêm thất bại!!");
                        a.CloseConnect();
                        }
                        else { MessageBox.Show("Khoa không ton tai!!!"); }
                    }                    
                }
                else
                    MessageBox.Show("Chua nhap day du thong tin");
            }catch(Exception ex)
            {
                MessageBox.Show("Loi ket noi" + ex.Message);
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaSV.Text != "")
                {                    
                        a.OpenConnect();
                        ///Them vao sql
                        string sql = "update Sinhvien set HovaTen=N'" + txtHoten.Text + "',Diachi=N'" + txtDiachi.Text + "',Ngaysinh='" + dateTimePicker1.Value.ToString() + "',TenKhoa=N'" + cbKhoa.Text + "' where MSSV='"+txtMaSV.Text+"'";
                        SqlCommand command = new SqlCommand(sql, a.connection);
                        int kq = (int)command.ExecuteNonQuery();
                        if (kq > 0)
                        {
                            MessageBox.Show("Sửa thành công!");
                            dataGridView1.DataSource = systemControl.LoadData("Sinhvien").Tables[0];
                        }
                        else MessageBox.Show("Sửa thất bại!!");
                        a.CloseConnect();
                    
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
                string sql = "delete from Sinhvien where MSSV='" + txtMaSV.Text + "'";
                SqlCommand command = new SqlCommand(sql, a.connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công");
                dataGridView1.DataSource = systemControl.LoadData("Sinhvien").Tables[0];
                a.CloseConnect();
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main a = new Main();
            a.Show();
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            this.Hide();
            FmTraCuu a = new FmTraCuu();
            a.Show();
        }
    }
}
