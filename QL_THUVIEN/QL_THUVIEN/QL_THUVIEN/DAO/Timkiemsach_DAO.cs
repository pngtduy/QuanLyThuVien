using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_THUVIEN.DAO
{
    class Timkiemsach_DAO:DataProvider
    {
        public DataTable loadSach()
        {
            string sqlString = @"select Sach.MaSach, Dausach.TenSach,Loaisach.TenLoai,Dausach.TacGia, sach.TinhTrangSach, Dausach.NhaXB
                                    from (Sach join Dausach on sach.MaDauSach=Dausach.MaDauSach) join Loaisach on Loaisach.MaLoai=Dausach.MaLoai";
            return GetData(sqlString);
        }
        public DataTable Search(string _timkiem, string _loaitk)
        {
            string sqlString = string.Format(@"select Sach.MaSach, Dausach.TenSach,Loaisach.TenLoai,Dausach.TacGia, sach.TinhTrangSach, Dausach.NhaXB
                                                from(Sach join Dausach on sach.MaDauSach = Dausach.MaDauSach) join Loaisach on Loaisach.MaLoai = Dausach.MaLoai
                                                where {0} like N'%{1}%'", _loaitk, _timkiem);
            return GetData(sqlString);
        }
    }
}
