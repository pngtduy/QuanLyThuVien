using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_THUVIEN.DAO
{
    class Sachdangmuon_DAO:DataProvider
    {
        public DataTable loadSach()
        {
            string sqlString = string.Format("select MaPhieuMuon,Phieumuon.MaThe,Docgia.MaDocGia, Docgia.HoTen,Sach.MaSach,Dausach.TenSach,Dausach.TacGia,NgayMuon,NgayTraDuKien from Phieumuon, Sach, Thedocgia,Dausach, Loaisach, Docgia where Phieumuon.MaThe = Thedocgia.MaThe and Sach.MaSach = Phieumuon.MaSach and Sach.MaDauSach=Dausach.MaDauSach and Dausach.MaLoai=Loaisach.MaLoai  and Docgia.MaDocGia=Thedocgia.MaDocGia");
            return GetData(sqlString);
        }
        public DataTable Search(string _ts)
        {
            string sqlString = string.Format("select MaPhieuMuon,Phieumuon.MaThe,Docgia.MaDocGia, Docgia.HoTen,Sach.MaSach,Dausach.TenSach,Dausach.TacGia,NgayMuon,NgayTraDuKien from Phieumuon, Sach, Thedocgia,Dausach, Loaisach, Docgia where Phieumuon.MaThe = Thedocgia.MaThe and Sach.MaSach = Phieumuon.MaSach and Sach.MaDauSach=Dausach.MaDauSach and Dausach.MaLoai=Loaisach.MaLoai  and Docgia.MaDocGia=Thedocgia.MaDocGia and Dausach.TenSach like N'%{0}%'", _ts);
            return GetData(sqlString);
        }
    }
}
