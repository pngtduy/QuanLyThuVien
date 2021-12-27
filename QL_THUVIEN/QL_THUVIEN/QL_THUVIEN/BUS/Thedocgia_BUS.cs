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
    class Thedocgia_BUS
    {
       Thedocgia_DAO tdgDao = new Thedocgia_DAO();

        public DataTable GetList()
        {
            return tdgDao.loadTheDocGia();
        }
        public void Xoa(string mTDG)
        {
            tdgDao.Delete(mTDG);
        }
        public bool Sua(Thedocgia_DTO tdg)
        {
            if (string.IsNullOrEmpty(tdg.MaThe))
                return false;
            tdgDao.Update(tdg);
            return true;
        }
        public int Them(Thedocgia_DTO tdg)
        {
            if (string.IsNullOrEmpty(tdg.MaThe))
                return 0;
            if (!tdgDao.Insert(tdg))
                return -1;
            return 1;
        }
        public DataTable TimKiem(string _timkiem)
        {
            return tdgDao.Search(_timkiem);
        }
    }
}
