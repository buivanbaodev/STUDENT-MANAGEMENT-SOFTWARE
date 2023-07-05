using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class KTraTenmon : DatabaseService
    {
        MonDTO a = new MonDTO();
        public bool Kiemtratenmon(string tm)
        {
            bool kq = false;
            try
            {
                string sql = "select * from MonHoc where TenMon=@TenMon";
                SqlParameter parTenmon = new SqlParameter("@TenMon", System.Data.SqlDbType.NVarChar);
                parTenmon.Value =tm;
                SqlDataReader reader = ReadDataPars(sql, new[] { parTenmon });
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
