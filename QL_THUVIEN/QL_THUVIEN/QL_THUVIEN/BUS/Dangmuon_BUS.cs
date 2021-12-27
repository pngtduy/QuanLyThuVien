using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_THUVIEN.DAO;

namespace QL_THUVIEN.BUS
{
    class Dangmuon_BUS
    {
        Dangmuon_DAO dmDao = new Dangmuon_DAO();
        public DataTable GetList()
        {
            return dmDao.loadSach();
        }
        public DataTable TimKiem(string _timkiem, string _loaitk)
        {
            return dmDao.Search(_timkiem, _loaitk);
        }
    }
}
