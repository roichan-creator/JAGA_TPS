using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGA_TPS
{
    public static class UserStore
    {
        public static List<User> Users = new List<User>();
        public static User? CurrentUser { get; set; }
    }
}
