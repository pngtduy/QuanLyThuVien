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
    class Phieutra_BUS
    {
        Phieutra_DAO ptDao = new Phieutra_DAO();

        public DataTable GetList()
        {
            return ptDao.loadPhieuTra();
        }
        public void Xoa(string mPT)
        {
            ptDao.Delete(mPT);
        }
        public bool Sua(Phieutra_DTO pt)
        {
            if (string.IsNullOrEmpty(pt.MaPhieuTra))
                return false;
            ptDao.Update(pt);
            return true;
        }
        public int Them(Phieutra_DTO pt)
        {
            if (string.IsNullOrEmpty(pt.MaPhieuTra))
                return 0;
            if (!ptDao.Insert(pt))
                return -1;
            return 1;
        }
        public DataTable TimKiem(string _timkiem)
        {
            return ptDao.Search(_timkiem);

        }
    }
}
