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
    class Loaisach_BUS
    {
        Loaisach_DAO lsDao = new Loaisach_DAO();

        public DataTable GetList()
        {
            return lsDao.loadLoaiSach();
        }
        public void Xoa(string mLS)
        {
            lsDao.Delete(mLS);
        }
        public bool Sua(Loaisach_DTO ls)
        {
            if (string.IsNullOrEmpty(ls.MaLoai))
                return false;
            lsDao.Update(ls);
            return true;
        }
        public int Them(Loaisach_DTO ls)
        {
            if (string.IsNullOrEmpty(ls.MaLoai))
                return 0;
            if (!lsDao.Insert(ls))
                return -1;
            return 1;
        }
        public DataTable TimKiem(string _timkiem)
        {
            return lsDao.Search(_timkiem);
        }
    }
}
