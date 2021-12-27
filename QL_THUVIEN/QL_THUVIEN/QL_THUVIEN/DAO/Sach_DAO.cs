using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_THUVIEN.DTO;

namespace QL_THUVIEN.DAO
{
    class Sach_DAO:DataProvider
    {
        public DataTable loadSach()
        {
            string sqlString = @"select * from Sach";
            return GetData(sqlString);
        }
        public bool Insert(Sach_DTO s)
        {
            if (GetData("select* from Sach where MaSach = '" + s.MaSach + "'").Rows.Count > 0)
                return false;
            string sql = string.Format("Insert Into Sach  values('{0}',N'{1}','{2}')",
                s.MaSach, s.TinhTrangSach,s.MaDauSach);

            Excute(sql);
            return true;
        }
        public void Delete(string mS)
        {
            Excute("delete from Sach where MaSach = '" + mS + "'");
        }

        public void Update(Sach_DTO s)
        {
            string sql = string.Format("Update Sach set MaSach='{0}', TinhTrangSach=N'{1}', MaDauSach=N'{2}' where MaSach = '{0}'",
                s.MaSach, s.TinhTrangSach,s.MaDauSach);
            Excute(sql);
        }
        public DataTable Search(string _timkiem)
        {
            string sqlString = string.Format("select * from Sach where MaDauSach like N'%{0}%'or MaSach like N'%{0}%' or TinhTrangSach like N'%{0}%'", _timkiem);
            return GetData(sqlString);
        }
    }
}
