using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_THUVIEN.DTO;
using QL_THUVIEN.DAO;

namespace QL_THUVIEN.BUS
{
    class Nguoidung_BUS
    {
        Nguoidung_DAO tvDao = new Nguoidung_DAO();
        public bool DangNhap(string _tk, string _mk)
        {
            if (tvDao.login(_tk, _mk) == true)
                return true;
            return false;
        }
    }
}
