using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_THUVIEN.DTO;

namespace QL_THUVIEN.DAO
{
    class Dausach_DAO:DataProvider
    {
        public DataTable loadDausach()
        {
            string sqlString = @"select * from Dausach";
            return GetData(sqlString);
        }
        public bool Insert(Dausach_DTO ds)
        {
            if (GetData("select* from Dausach where MaDauSach = '" + ds.MaDauSach + "'").Rows.Count > 0)
                return false;
            string sql = string.Format("Insert Into Dausach values('{0}',N'{1}',N'{2}',N'{3}','{4}','{5}','{6}','{7}','{8}')",
                ds.MaDauSach, ds.TenSach, ds.TacGia, ds.NhaXB, ds.NamXB,ds.SoLuong,ds.DonGia,ds.NgayNhap,ds.MaLoai);

            Excute(sql);
            return true;
        }
        public void Delete(string mDS)
        {
            Excute("delete from Dausach where MaDauSach = '" + mDS + "'");
        }

        public void Update(Dausach_DTO ds)
        {
            string sql = string.Format("Update Dausach set MaDauSach='{0}', TenSach = N'{1}', TacGia= N'{2}', NhaXB = N'{3}', NamXB = '{4}', SoLuong='{5}', DonGia='{6}', NgayNhap='{7}', MaLoai='{8}' where MaDauSach = '{0}'",
               ds.MaDauSach, ds.TenSach, ds.TacGia, ds.NhaXB, ds.NamXB, ds.SoLuong, ds.DonGia, ds.NgayNhap, ds.MaLoai);
            Excute(sql);
        }
        public DataTable Search(string _timkiem)
        {
            string sqlString = string.Format("select * from Dausach where NamXB like N'%{0}%'  or MaLoai like N'%{0}%'  or NhaXB like N'%{0}%' or TacGia like N'%{0}%' or MaDauSach like N'%{0}%' or TenSach like N'%{0}%'", _timkiem);
            return GetData(sqlString);
        }
    }
}
