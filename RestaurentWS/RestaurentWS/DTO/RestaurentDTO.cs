using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQuanAn.DTO
{
    public class RestaurentDTO
    {
        private int id;
        private String name;
        private String address;
        private String opentime;
        private String closetime;

        public int ID { get => id; set => id = value; }
        public String Name { get => name; set => name = value; }
        public String Address { get => address; set => address = value; }
        public String OpenTime { get => opentime; set => opentime = value; }
        public String CloseTime { get => closetime; set => closetime = value; }
    }
}
