﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicAuthenticationWebAPI.Models
{
    public class UserBL
    {
        public List<User> GetUsers()
        {
            List<User> userList = new List<User>
            {
                new User{ID = 101 , UserName = "MaleUser" , Password = "123456"},
                new User{ID = 101 , UserName = "FemaleUser" , Password = "abcdef"}
            };

            return userList;
        }
    }
}