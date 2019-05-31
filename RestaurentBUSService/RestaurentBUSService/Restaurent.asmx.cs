using RestaurentBUSService.RestDAOWS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace RestaurentBUSService
{
    /// <summary>
    /// Summary description for Restaurent
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Restaurent : System.Web.Services.WebService
    {
        RestDAOWS.RestaurentServiceSoapClient restDAO = new RestDAOWS.RestaurentServiceSoapClient();

        [WebMethod]
        public DataSet readAll()
        {
            return restDAO.readAll();
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
            return restDAO.update(rest);
        }
    }
}
