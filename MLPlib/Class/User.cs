using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLPlib.Class
{
    public class User
    {
        public int IDUser { get; set; }
        public string Username { get; set; }
        public int Pin { get; set; }
        public DateTime RegDate { get; set; }
        public bool Active { get; set; }


        public User()
        {

        }


    }
}
