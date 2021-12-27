using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_THUVIEN.DAO
{
    class Dangmuon_DAO:DataProvider
    {
        public DataTable loadSach()
        {
            string sqlString = @"select Docgia.HoTen, Dausach.TenSach, Phieumuon.NgayMuon 
                                    from Dausach, Docgia, Phieumuon, Sach,Thedocgia 
                                    where Docgia.MaDocGia=Thedocgia.MaDocGia 
                                    and Sach.MaDauSach=Dausach.MaDauSach
                                    and Phieumuon.MaThe=Thedocgia.MaThe
                                    and Phieumuon.MaSach= Sach.MaSach";
            return GetData(sqlString);
        }
        public DataTable Search(string _timkiem, string _loaitk)
        {
            string table = "";
            if (_loaitk == "HoTen")
                table = "Docgia";
            else
                table = "Dausach";
            string sqlString = string.Format(@"select Docgia.HoTen, Dausach.TenSach, Phieumuon.NgayMuon 
                                    from Dausach, Docgia, Phieumuon, Sach, Thedocgia
                                    where Docgia.MaDocGia = Thedocgia.MaDocGia
                                    and Sach.MaDauSach = Dausach.MaDauSach
                                    and Phieumuon.MaThe = Thedocgia.MaThe
                                    and Phieumuon.MaSach = Sach.MaSach and {0}.{1} like N'%{2}%'", table, _loaitk, _timkiem);
            return GetData(sqlString);
        }
    }
}
