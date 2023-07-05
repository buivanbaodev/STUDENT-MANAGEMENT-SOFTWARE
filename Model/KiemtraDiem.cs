using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace Model
{
    public class KiemtraDiem : DatabaseService
    {
        DiemDTO a = new DiemDTO();
        public bool Kiemtradiem(string Msv,string tm)
        {
            bool kq = false;
            try
            {
                string sql = "select * from Diem where MSSV=@MSSV and TenMon=@TenMon ";
                SqlParameter parMSSV = new SqlParameter("@MSSV", System.Data.SqlDbType.NVarChar);
                parMSSV.Value = Msv;
                SqlParameter parTenMon = new SqlParameter("@TenMon", System.Data.SqlDbType.NVarChar);
                parTenMon.Value = tm;
                SqlDataReader reader = ReadDataPars(sql, new[] {parMSSV,parTenMon });
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
