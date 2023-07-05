using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace Model
{
    public class KiemtraTenKhoa : DatabaseService
    {
        KhoaDTO a = new KhoaDTO();
        public bool KiemtraTenkhoa(string Tk)
        {
            bool kq = false;
            try
            {
                string sql = "select * from DSKhoa where TenKhoa=@TenKhoa ";
                SqlParameter parTenkhoa = new SqlParameter("@TenKhoa", System.Data.SqlDbType.NVarChar);
                parTenkhoa.Value = Tk;
                SqlDataReader reader = ReadDataPars(sql, new[] {  parTenkhoa });
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
