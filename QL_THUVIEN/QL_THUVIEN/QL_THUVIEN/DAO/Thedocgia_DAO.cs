using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_THUVIEN.DTO;

namespace QL_THUVIEN.DAO
{
    class Thedocgia_DAO:DataProvider
    {
        public DataTable loadTheDocGia()
        {
            string sqlString = @"select * from Thedocgia";
            return GetData(sqlString);
        }
        public bool Insert(Thedocgia_DTO tdg)
        {
            if (GetData("select* from Thedocgia where MaThe = '" + tdg.MaThe + "'").Rows.Count > 0)
                return false;
            string sql = string.Format("Insert Into Thedocgia values('{0}','{1}','{2}','{3}')",
                tdg.MaThe, tdg.NgayLap, tdg.NgayHetHan, tdg.MaDocGia);

            Excute(sql);
            return true;
        }
        public void Delete(string mTDG)
        {
            Excute("delete from Thedocgia where MaThe = '" + mTDG + "'");
        }

        public void Update(Thedocgia_DTO tdg)
        {
            string sql = string.Format("Update Thedocgia set MaThe='{0}', NgayLap = '{1}', NgayHetHan= '{2}', MaDocGia = '{3}' where MaThe = '{0}'",
                tdg.MaThe, tdg.NgayLap, tdg.NgayHetHan, tdg.MaDocGia);
            Excute(sql);
        }
        public DataTable Search(string _timkiem)
        {
            string sqlString = string.Format("select * from Thedocgia where MaDocGia like N'%{0}%' or NgayLap like N'%{0}%' or MaThe like N'%{0}%'", _timkiem);
            return GetData(sqlString);
        }
    }
}
