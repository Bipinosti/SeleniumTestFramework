using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework.Generators
{
   public class UserGenerator
    {
        public static User Generate()
        {
            var user = new User()
            {
                Username = "admin",
                Password = "admin"
            };

            return user;
        }
    }

    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
