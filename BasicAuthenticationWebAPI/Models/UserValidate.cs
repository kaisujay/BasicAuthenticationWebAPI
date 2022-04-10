using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicAuthenticationWebAPI.Models
{
    public class UserValidate
    {
        public static bool Login(string userName, string password)
        {
            UserBL user = new UserBL();
            List<User> users = user.GetUsers();

            return users.Exists(x => x.UserName == userName && x.Password == password);
        }
    }
}