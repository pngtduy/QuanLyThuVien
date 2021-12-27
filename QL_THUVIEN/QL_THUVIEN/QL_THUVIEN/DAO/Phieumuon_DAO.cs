using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_THUVIEN.DTO;

namespace QL_THUVIEN.DAO
{
    class Phieumuon_DAO:DataProvider
    {
        public DataTable loadPhieuMuon()
        {
            string sqlString = @"select * from Phieumuon";
            return GetData(sqlString);
        }
        public bool Insert(Phieumuon_DTO pm)
        {
            if (GetData("select* from Phieumuon where MaPhieuMuon = '" + pm.MaPhieuMuon + "'").Rows.Count > 0)
                return false;
            string sql = string.Format("Insert Into Phieumuon values('{0}','{1}','{2}','{3}','{4}')",
                pm.MaPhieuMuon, pm.NgayMuon, pm.NgayTraDuKien, pm.MaThe,pm.MaSach);

            Excute(sql);
            return true;
        }
        public void Delete(string mPM)
        {
            Excute("delete from Phieumuon where MaPhieuMuon = '" + mPM + "'");
        }

        public void Update(Phieumuon_DTO pm)
        {
            string sql = string.Format("Update Phieumuon set MaPhieuMuon='{0}', NgayMuon = '{1}', NgayTraDuKien= '{2}', MaThe = '{3}',MaSach='{4}' where MaPhieuMuon = '{0}'",
                pm.MaPhieuMuon, pm.NgayMuon, pm.NgayTraDuKien, pm.MaThe, pm.MaSach);
            Excute(sql);
        }
        public DataTable Search(string _timkiem)
        {
            string sqlString = string.Format("select * from Phieumuon where MaPhieuMuon like N'%{0}%' or NgayMuon like N'%{0}%' or MaThe like N'%{0}%' or MaSach like N'%{0}%'", _timkiem);
            return GetData(sqlString);
        }
    }
}
