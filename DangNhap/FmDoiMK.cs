using Controler;

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
using System.Diagnostics;

namespace DangNhap
{
    public partial class FmDoiMK : Form
    {
        public FmDoiMK()
        {
            InitializeComponent();
        }
        SqlConnection conn =new SqlConnection( @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=PHUONGNAM;Integrated Security=True");
        
        private void btConfirm_Click(object sender, EventArgs e)
        {
              string select2 = "Select * From Account where Email=@Email and Password=@Password";
            SqlCommand cmd2 = new SqlCommand(select2,conn);
            SqlDataReader reader2;
            conn.Open();
            reader2 = cmd2.ExecuteReader();
           
            if (txtUsername.Text == "")
                MessageBox.Show(txtUsername, "Chưa nhập tên tài khoản !");
            else if (txtOldPass.Text == "")
            {
                MessageBox.Show(txtOldPass, "!");
                txtOldPass.Focus();
            }
            else if (txtNewPass.Text == "")
            {
                MessageBox.Show(txtNewPass, "!");
                txtNewPass.Focus();
            }
            else if (txtConfirm.Text == "")
            {
                MessageBox.Show(txtConfirm, "!");
                txtConfirm.Focus();
            }
            else if (txtConfirm.Text != txtNewPass.Text)
                MessageBox.Show("Bạn nhập lại password không trùng khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (reader2.Read())
            {
                cmd2.Dispose();
                reader2.Dispose();
                // Thực hiện truy vấn
                string update = "Update tblLOGIN Set MatKhau='" + txtNewPass.Text + "' where TenDN='" + txtUsername.Text + "'";
                SqlCommand cmd = new SqlCommand(update, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo!");

                // Trả tài nguyên
                cmd.Dispose();
            }

            else
            {
                MessageBox.Show("Tên tài khoản không tồn tại hoặc mật khẩu sai! ", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();

            }
            cmd2.Dispose();
            reader2.Dispose();
        }

        
    }
}
