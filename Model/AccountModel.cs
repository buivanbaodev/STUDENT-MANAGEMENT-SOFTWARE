using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class AccountModel:DatabaseService
    {
        AccountDTO account = new AccountDTO();
        public bool CheckAccount(string email, string pass,bool quyen)
        {
            bool kq = false;
            try
            {
                string sql = "select * from Account where Email=@Email and Password=@Password and Quyen=@Quyen";
                SqlParameter parEmail = new SqlParameter("@Email", System.Data.SqlDbType.NVarChar);
                parEmail.Value = email;
                SqlParameter parPass = new SqlParameter("@Password", System.Data.SqlDbType.NVarChar);
                parPass.Value = pass;
                SqlParameter parQuyen = new SqlParameter("@Quyen", System.Data.SqlDbType.Bit);
                parQuyen.Value = quyen;
                SqlDataReader reader = ReadDataPars(sql, new[] { parEmail, parPass, parQuyen});
                if (reader.Read())
                {
                    kq = true;
                }
                
            }
            catch(Exception e) 
            {
                e.ToString();
            }
            finally
            {
                CloseConnect();
            }
            return kq;
        }
        public bool Logout()
        {
            bool kq = false;

            return kq;
        }
    }
}
