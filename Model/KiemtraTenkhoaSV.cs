using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace Model
{
    public class KiemtraTenkhoaSV : DatabaseService
    {
        public bool KiemtraTenKhoaSV(string Msv)
        {
            bool kq = false;
            try
            {
                string sql = "select * from Sinhvien where TenKhoa=@TenKhoa ";
                SqlParameter parMSSV = new SqlParameter("@TenKhoa", System.Data.SqlDbType.NVarChar);
                parMSSV.Value = Msv;
                SqlDataReader reader = ReadDataPars(sql, new[] { parMSSV });
                if (reader.Read())
                {
                    kq = true;
                }

            }
            catch (Exception e)
            {
                e.ToString();
            }
            finally
            {
                CloseConnect();
            }
            return kq;
        }
    }
}
