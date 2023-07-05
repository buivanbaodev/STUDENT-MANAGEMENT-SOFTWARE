using DTO;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controler
{
    public class SystemControl
    {
        AccountModel mo = new AccountModel();
        public bool CheckAccount(string email,string pass,bool quyen)
        {
            bool kq = false;
            if (mo.CheckAccount(email, pass,quyen))
            {
                kq = true;
            }
            
            return kq;
        }
    }
}
