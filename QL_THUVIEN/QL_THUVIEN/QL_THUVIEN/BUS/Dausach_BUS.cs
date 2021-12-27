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
    class Dausach_BUS
    {
        Dausach_DAO dsDao = new Dausach_DAO();

        public DataTable GetList()
        {
            return dsDao.loadDausach();
        }
        public void Xoa(string mDS)
        {
            dsDao.Delete(mDS);
        }
        public bool Sua(Dausach_DTO ds)
        {
            if (string.IsNullOrEmpty(ds.MaDauSach))
                return false;
            dsDao.Update(ds);
            return true;
        }
        public int Them(Dausach_DTO ds)
        {
            if (string.IsNullOrEmpty(ds.MaDauSach))
                return 0;
            if (!dsDao.Insert(ds))
                return -1;
            return 1;
        }
        public DataTable TimKiem(string _timkiem)
        {
            return dsDao.Search(_timkiem);
        }
    }
}
