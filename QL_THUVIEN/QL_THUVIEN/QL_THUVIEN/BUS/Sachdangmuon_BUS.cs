using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_THUVIEN.DAO;

namespace QL_THUVIEN.BUS
{
    class Sachdangmuon_BUS
    {
        Sachdangmuon_DAO sachdangmuonDao = new Sachdangmuon_DAO();
        public DataTable GetList()
        {
            return sachdangmuonDao.loadSach();
        }
        public DataTable TimKiem(string _ts)
        {
            return sachdangmuonDao.Search(_ts);
        }
    }
}
