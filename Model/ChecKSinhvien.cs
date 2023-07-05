using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace Model
{
    public class ChecKSinhvien : DatabaseService
    {
        SinhvienDTO a = new SinhvienDTO();
        
        public bool KiemtraSV(string Msv)
        {
            bool kq = false;
            try
            {
                string sql = "select * from Sinhvien where MSSV=@MSSV ";
                SqlParameter parMSSV = new SqlParameter("@MSSV", System.Data.SqlDbType.NVarChar);
                parMSSV.Value = Msv;                
                SqlDataReader reader = ReadDataPars(sql, new[] { parMSSV});
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
