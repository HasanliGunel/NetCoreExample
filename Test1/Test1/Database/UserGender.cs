using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test1.Database
{
    public class UserGender
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int UserID { get; set; }
        public User User { get; set; } 

    }
}
