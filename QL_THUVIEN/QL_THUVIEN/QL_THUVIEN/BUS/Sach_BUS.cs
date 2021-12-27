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
    class Sach_BUS
    {
        Sach_DAO sDao = new Sach_DAO();

        public DataTable GetList()
        {
            return sDao.loadSach();
        }
        public void Xoa(string mS)
        {
            sDao.Delete(mS);
        }
        public bool Sua(Sach_DTO s)
        {
            if (string.IsNullOrEmpty(s.MaSach))
                return false;
            sDao.Update(s);
            return true;
        }
        public int Them(Sach_DTO s)
        {
            if (string.IsNullOrEmpty(s.MaSach))
                return 0;
            if (!sDao.Insert(s))
                return -1;
            return 1;
        }
        public DataTable TimKiem(string _timkiem)
        {
            return sDao.Search(_timkiem);
        }
    }
}
