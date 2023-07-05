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

namespace DangNhap
{
    public partial class MainFrom : Form
    {
        SummaryForm smForm = new SummaryForm();
        Login dtForm = new Login();
        

        public MainFrom()
        {
            InitializeComponent();
            //CallTochildForm();
        }
     
        private void btnDetail_Click(object sender, EventArgs e)
        {
            btnDetail.BackColor = Color.Yellow;
            if (btnDetail.BackColor == Color.Yellow)
            {
                btnSummary.BackColor= Color.White;
            }
            Login f = new Login();
            CallTochildForm(f);
        }

   

        private void MainFrom_Resize(object sender, EventArgs e)
        {
            panel1.Height = Convert.ToInt32(0.16*this.Height);
            pnMain.Height = Convert.ToInt32(0.8 * this.Height);
            btnDetail.Width = Convert.ToInt32(this.Width * 0.22);

        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            btnSummary.BackColor = Color.Yellow;
            if (btnSummary.BackColor == Color.Yellow)
            {
                btnDetail.BackColor = Color.White;
            }
            SummaryForm g = new SummaryForm();
            //dtForm.ChangeInfoForm();
            CallTochildForm(g);
        }
        public void CallTochildForm(Form childForm)
        {
            if(this.pnMain.Controls.Count > 0)
            {
                this.pnMain.Controls.RemoveAt(0);
            }
            //caì đặt các thuộc tính cho form fr
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            //đưa fr vào làm control của pannel panel2
            this.pnMain.Controls.Add(childForm);
            this.pnMain.Tag = childForm;
            childForm.Show();
        }

       
        private SqlConnection con;
        private DataTable dt = new DataTable("User");
        // private DataTable dt = new DataTable();
        private SqlDataAdapter da = new SqlDataAdapter();

        private void Connect()
        { // Copy Data Source vào chuỗi
            String cn = @"Data Source=DESKTOP-MIE6OUS;Initial Catalog=MCV1;User ID=sa;Password=123456";
            try
            {
                con = new SqlConnection(cn);
                con.Open();
                MessageBox.Show("Kết nối thành công", "Ahihi", MessageBoxButtons.OK, MessageBoxIcon.Information);
           

 }
            catch (Exception )
            {
                MessageBox.Show("Không Kết nối tới CSDL", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        private void MainFrom_Load(object sender, EventArgs e)
        {

        }
        private SqlConnection conn;
        private DataTable dtt = new DataTable("tbNhanVien");
        // private DataTable dtt = new DataTable();
        private SqlDataAdapter daa = new SqlDataAdapter();

        private void connect()
        { // Copy Data Source vào chuỗi
            String cn = @"Data Source=DESKTOP-MIE6OUS;Initial Catalog=User;Integrated Security=True";
            try
            {
                conn = new SqlConnection(cn);
                conn.Open();
                MessageBox.Show("Kết nối thành công", "Ahihi", MessageBoxButtons.OK, MessageBoxIcon.Information);
           

 }
            catch (Exception )
            {
                MessageBox.Show("Không Kết nối tới CSDL", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void disconnect()   // gọi hàm này sau khi đã dùng xong csdl 
        {
            conn.Close();
            conn.Dispose();
            conn = null;
        }
    }
}
