using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
   public class User
    {
        //List<string> cart;
        public string name="";
        public string password="";
        public string address="";
        public string email="";
       public User() {}
        public void signUp(string nam,string pass,string adr,string em)
        {
            name = nam;
            password = pass;
            address = adr;
            email = em;
        }
    }
}
