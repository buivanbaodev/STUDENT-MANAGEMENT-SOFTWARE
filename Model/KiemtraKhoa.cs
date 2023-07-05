using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace Model
{
    public class KiemtraKhoa : DatabaseService
    {
        KhoaDTO a = new KhoaDTO();
        public bool Kiemtrakhoa(string Mk)
        {
            bool kq = false;
            try
            {
                string sql = "select * from DSKhoa where MaKhoa=@MaKhoa";
                SqlParameter parMakhoa = new SqlParameter("@MaKhoa", System.Data.SqlDbType.Char);
                parMakhoa.Value = Mk;
                SqlDataReader reader = ReadDataPars(sql, new[] { parMakhoa});
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
