using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
   public static class data
    {
        public static Dictionary<String,User> users= new Dictionary<String, User>();
        public static Dictionary<String, Brand> brands = new Dictionary<String, Brand>();
         public static   Brand b = new Brand();
        public static List<int> cart=new List<int>();
        public static string user;
    }
}
