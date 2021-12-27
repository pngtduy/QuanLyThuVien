using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_THUVIEN.DAO;

namespace QL_THUVIEN.BUS
{
    class Timkiemsach_BUS
    {
        Timkiemsach_DAO sachDao = new Timkiemsach_DAO();
        public DataTable GetList()
        {
            return sachDao.loadSach();
        }
        public DataTable TimKiem(string _timkiem, string _loaitk)
        {
            return sachDao.Search(_timkiem, _loaitk);
        }
    }
}
