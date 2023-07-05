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

namespace Account
{
    public partial class SignIn : Form
    {
        string connectionString = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=PHUONGNAM;Integrated Security=True";
        public SignIn()
        {
            InitializeComponent();
        }
        public bool FlSignUp = false;
        public bool FlchangelInfo = false;
        public bool Fladmin = false;
        // tao bien luu lai password
        public string OP = "";
        public string USN;


        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "" || txtpass.Text == "")
            {
                if (txtuser.Text == "" && txtpass.Text == "")
                {
                    MessageBox.Show("vui long  nhap user va password");
                }
                if (txtuser.Text == "")
                {
                    MessageBox.Show("username khong duoc de rong");
                }
                else
                {
                    MessageBox.Show("password khong duoc rong");
                }

            }
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                SqlCommand sqlCommand = new SqlCommand("Select * from account4 where users=@user and password=@pass", con);
                sqlCommand.Parameters.Add("@user", SqlDbType.NVarChar).Value = txtuser.Text;
                sqlCommand.Parameters.Add("@password", SqlDbType.NVarChar).Value = txtpass.Text;

                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.Read())
                {

                    USN = txtuser.Text;

                    OP = txtpass.Text;

                    this.Close();

                    Fladmin = true;
                }
                else
                {
                    MessageBox.Show("Mat Khau hoac tai khoan Sai!");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("khong ket noi duoc data base.");
            }
            finally
            {
                con.Close();
            }
        }
    }
    
}



  
      
