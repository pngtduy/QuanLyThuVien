using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_THUVIEN.DTO;
using QL_THUVIEN.DAO;

namespace QL_THUVIEN.BUS
{
    class Matkhau_BUS
    {
        Matkhau_DAO mkDao = new Matkhau_DAO();
        public void DoiMatKhau(QLnguoidung_DTO _tv)
        {
            mkDao.ChangePassWord(_tv);
        }
        public bool CheckExist(string _tdn, string _mkc)
        {
            return mkDao.CheckExist(_tdn, _mkc);

        }
    }
}
