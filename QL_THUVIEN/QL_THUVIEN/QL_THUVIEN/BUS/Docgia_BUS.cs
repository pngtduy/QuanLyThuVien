using QL_THUVIEN.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_THUVIEN.DTO;

namespace QL_THUVIEN.BUS
{
    class Docgia_BUS
    {
        Docgia_DAO dgDao = new Docgia_DAO();

        public DataTable GetList()
        {
            return dgDao.loadDocGia();
        }
        public void Xoa(string mDG)
        {
            dgDao.Delete(mDG);
        }
        public bool Sua(Docgia_DTO dg)
        {
            if (string.IsNullOrEmpty(dg.MaDocGia))
                return false;
            dgDao.Update(dg);
            return true;
        }
        public int Them(Docgia_DTO dg)
        {
            if (string.IsNullOrEmpty(dg.MaDocGia))
                return 0;
            if (!dgDao.Insert(dg))
                return -1;
            return 1;
        }
        public DataTable TimKiem(string _timkiem)
        {
            return dgDao.Search(_timkiem);
        }
    }
}
