using QLQuanAn.DAO;
using QLQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQuanAn.BUS
{
    class RestaurentBUS
    {
        RestaurentDAO restDAO = new RestaurentDAO();

        public DataTable readAll()
        {
            return restDAO.readAll();
        }

        public int insert(RestaurentDTO rest)
        {
            return restDAO.insert(rest);
        }

        public int delete(int id)
        {
            return restDAO.delete(id);
        }

        public int update(RestaurentDTO rest)
        {
            return restDAO.edit(rest);
        }
    }
}
