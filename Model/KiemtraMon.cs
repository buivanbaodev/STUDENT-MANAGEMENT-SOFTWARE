using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace Model
{
    public class KiemtraMon : DatabaseService
    {
        MonDTO a = new MonDTO();
        public bool Kiemtramon(string Mk)
        {
            bool kq = false;
            try
            {
                string sql = "select * from MonHoc where MaMon=@MaMon";
                SqlParameter parMamon = new SqlParameter("@MaMon", System.Data.SqlDbType.Char);
                parMamon.Value = Mk;
                SqlDataReader reader = ReadDataPars(sql, new[] { parMamon });
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
