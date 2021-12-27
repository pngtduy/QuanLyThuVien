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
    class Phieumuon_BUS
    {
        Phieumuon_DAO pmDao = new Phieumuon_DAO();

        public DataTable GetList()
        {
            return pmDao.loadPhieuMuon();
        }
        public void Xoa(string mPM)
        {
            pmDao.Delete(mPM);
        }
        public bool Sua(Phieumuon_DTO pm)
        {
            if (string.IsNullOrEmpty(pm.MaPhieuMuon))
                return false;
            pmDao.Update(pm);
            return true;
        }
        public int Them(Phieumuon_DTO pm)
        {
            if (string.IsNullOrEmpty(pm.MaPhieuMuon))
                return 0;
            if (!pmDao.Insert(pm))
                return -1;
            return 1;
        }
        public DataTable TimKiem(string _timkiem)
        {
            return pmDao.Search(_timkiem);

        }
    }
}
