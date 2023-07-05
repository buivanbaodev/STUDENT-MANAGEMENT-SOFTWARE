using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Model
{
    public class DataBaseModel : DatabaseService
    {
        KhoaDTO KhoaDTO = new KhoaDTO();
        SinhvienDTO Sinhvien = new SinhvienDTO();
        public DataSet LoadData(string tenbang)
        {
            string sql = "select * from " + tenbang;
            return LoadData(sql, tenbang);
        }       
    }
}
