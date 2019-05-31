using QLQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQuanAn.DAO
{
    class RestaurentDAO
    {
        public DataTable readAll()
        {
            string sql = "select * from quanan";
            return ProcessData.ExcuteQuery(sql);
        }

        public int insert(RestaurentDTO restaurant)
        {
            string sql = string.Format("insert into quanan(name, address, opentime, closetime) values" +
                "('{0}', '{1}', '{2}', '{3}')",
                restaurant.Name, restaurant.Address, restaurant.OpenTime, restaurant.CloseTime);

            return ProcessData.ExcuteNonQuery(sql);
        }

        public int delete(int id)
        {
            string sql = "delete from quanan where id = " + id;
            return ProcessData.ExcuteNonQuery(sql);
        }

        public int edit(RestaurentDTO rest)
        {
            
            string sql = string.Format("UPDATE quanan SET name = '{0}', address = '{1}', opentime = '{2}', closetime = '{3}' where id = '{4}'",
                rest.Name, rest.Address, rest.OpenTime, rest.CloseTime, rest.ID);

            return ProcessData.ExcuteNonQuery(sql);
        }
    }
}
