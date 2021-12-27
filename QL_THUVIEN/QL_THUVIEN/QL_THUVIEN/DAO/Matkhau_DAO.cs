using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_THUVIEN.DTO;

namespace QL_THUVIEN.DAO
{
    class Matkhau_DAO:DataProvider
    {
        public void ChangePassWord(QLnguoidung_DTO _tv)
        {
            string sql = string.Format("update Account set MatKhau = '{0}' where TenDN = '{1}'", _tv.MatKhau, _tv.TenDN);
            Excute(sql);
        }
        public bool CheckExist(string _tdn, string _mkc)
        {
            string sql = string.Format("select* from Account where MatKhau = '{0}' and TenDN = '{1}'", _mkc, _tdn);
            if (GetData(sql).Rows.Count > 0)
                return true;
            return false;
        }
    }
}
