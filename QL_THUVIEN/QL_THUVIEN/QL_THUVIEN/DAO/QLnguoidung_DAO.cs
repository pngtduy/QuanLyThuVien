using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_THUVIEN.DTO;

namespace QL_THUVIEN.DAO
{
    class QLnguoidung_DAO:DataProvider
    {
        public bool Insert(QLnguoidung_DTO nd)
        {
            if (GetData("select* from Account where TenDN = '" + nd.TenDN + "'").Rows.Count > 0)
                return false;
            string sql = string.Format("Insert Into Account values('{0}','{1}','{2}')",
                nd.TenDN, nd.MatKhau,1);

            Excute(sql);
            return true;
        }
    }
}
