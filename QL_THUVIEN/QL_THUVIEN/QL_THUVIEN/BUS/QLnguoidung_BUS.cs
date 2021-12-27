using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_THUVIEN.DAO;
using QL_THUVIEN.DTO;

namespace QL_THUVIEN.BUS
{
    class QLnguoidung_BUS
    {
        QLnguoidung_DAO ngDao = new QLnguoidung_DAO();

        public int Them(QLnguoidung_DTO nd)
        {
            if (string.IsNullOrEmpty(nd.TenDN))
                return 0;
            if (!ngDao.Insert(nd))
                return -1;
            return 1;
        }
    }
}
