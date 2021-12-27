using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_THUVIEN.DTO;

namespace QL_THUVIEN.DAO
{
    class Phieutra_DAO:DataProvider
    {
        public DataTable loadPhieuTra()
        {
            string sqlString = @"select * from Phieutra";
            return GetData(sqlString);
        }
        public bool Insert(Phieutra_DTO pt)
        {
            if (GetData("select* from Phieutra where MaPhieuTra = '" + pt.MaPhieuTra + "'").Rows.Count > 0)
                return false;
            string sql = string.Format("Insert Into Phieutra values('{0}','{1}','{2}','{3}')",
                pt.MaPhieuTra, pt.MaThe, pt.MaSach, pt.NgayTra);

            Excute(sql);
            return true;
        }
        public void Delete(string mPT)
        {
            Excute("delete from Phieutra where MaPhieuTra = '" + mPT + "'");
        }

        public void Update(Phieutra_DTO pt)
        {
            string sql = string.Format("Update Phieutra set MaPhieuTra='{0}', MaThe = '{1}', MaSach= '{2}', NgayTra = '{3}' where MaPhieuTra = '{0}'",
                pt.MaPhieuTra, pt.MaThe, pt.MaSach, pt.NgayTra);
            Excute(sql);
        }
        public DataTable Search(string _timkiem)
        {
            string sqlString = string.Format("select * from Phieutra where MaPhieuTra like N'%{0}%' or NgayTra like N'%{0}%' or MaThe like N'%{0}%' or MaSach like N'%{0}%'", _timkiem);
            return GetData(sqlString);
        }
    }
}
