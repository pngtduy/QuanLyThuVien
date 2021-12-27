using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_THUVIEN.DTO;

namespace QL_THUVIEN.DAO
{
    class Loaisach_DAO:DataProvider
    {
        public DataTable loadLoaiSach()
        {
            string sqlString = @"select * from Loaisach";
            return GetData(sqlString);
        }
        public bool Insert(Loaisach_DTO ls)
        {
            if (GetData("select* from Loaisach where MaLoai = '" + ls.MaLoai + "'").Rows.Count > 0)
                return false;
            string sql = string.Format("Insert Into Loaisach  values('{0}',N'{1}')",
                ls.MaLoai, ls.TenLoai);

            Excute(sql);
            return true;
        }
        public void Delete(string mLS)
        {
            Excute("delete from Loaisach where MaLoai = '" + mLS + "'");
        }

        public void Update(Loaisach_DTO ls)
        {
            string sql = string.Format("Update Loaisach set MaLoai='{0}', TenLoai=N'{1}' where MaLoai = '{0}'",
                ls.MaLoai, ls.TenLoai);
            Excute(sql);
        }
        public DataTable Search(string _timkiem)
        {
            string sqlString = string.Format("select * from Loaisach where MaLoai like N'%{0}%' or TenLoai like N'%{0}%'", _timkiem);
            return GetData(sqlString);
        }
    }
}
