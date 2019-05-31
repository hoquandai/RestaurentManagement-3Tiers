using QLQuanAn.DAO;
using QLQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace RestaurentWS
{
    /// <summary>
    /// Summary description for RestaurentService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class RestaurentService : System.Web.Services.WebService
    {

        RestaurentDAO restDAO = new RestaurentDAO();

        [WebMethod]
        public DataSet readAll()
        {
            DataSet dataSet = new DataSet();
            var table = restDAO.readAll();
            dataSet.Tables.Add(table);
            return dataSet;
        }

        [WebMethod]
        public int insert(RestaurentDTO rest)
        {
            return restDAO.insert(rest);
        }

        [WebMethod]
        public int delete(int id)
        {
            return restDAO.delete(id);
        }

        [WebMethod]
        public int update(RestaurentDTO rest)
        {
            return restDAO.edit(rest);
        }
    }
}
