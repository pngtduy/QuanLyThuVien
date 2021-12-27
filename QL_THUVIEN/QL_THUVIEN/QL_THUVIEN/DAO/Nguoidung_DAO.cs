using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QL_THUVIEN.DAO
{
    class Nguoidung_DAO:DataProvider
    {
        public bool login(string _tk, string _mk)
        {
            if (GetData("select* from Account where TenDN = '" + _tk + "' and MatKhau = '" + _mk + "'").Rows.Count > 0)
                return true;
            return false;
        }
    }
}
