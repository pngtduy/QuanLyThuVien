using QL_THUVIEN.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_THUVIEN.DAO
{
    class Docgia_DAO:DataProvider
    {
        public DataTable loadDocGia()
        {
            string sqlString = @"select * from Docgia";
            return GetData(sqlString);
        }
        public bool Insert(Docgia_DTO dg)
        {
            if (GetData("select* from Docgia where MaDocGia = '" + dg.MaDocGia + "'").Rows.Count > 0)
                return false;
            string sql = string.Format("Insert Into Docgia values('{0}',N'{1}','{2}',N'{3}',N'{4}')",
                dg.MaDocGia, dg.HoTen, dg.NgaySinh, dg.GioiTinh, dg.DiaChi);

            Excute(sql);
            return true;
        }
        public void Delete(string mDG)
        {
            Excute("delete from Docgia where MaDocGia = '" + mDG + "'");
        }

        public void Update(Docgia_DTO dg)
        {
            string sql = string.Format("Update Docgia set MaDocGia='{0}', HoTen = N'{1}', NgaySinh= '{2}', GioiTinh = N'{3}', DiaChi = N'{4}' where MaDocGia = '{0}'",
                dg.MaDocGia, dg.HoTen, dg.NgaySinh, dg.GioiTinh, dg.DiaChi);
            Excute(sql);
        }
        public DataTable Search(string _timkiem)
        {
            string sqlString = string.Format("select * from Docgia where MaDocGia like N'%{0}%' or NgaySinh like N'%{0}%' or GioiTinh like N'%{0}%' or DiaChi like N'%{0}%' or HoTen like N'%{0}%'", _timkiem);
            return GetData(sqlString);
        }
    }
}
