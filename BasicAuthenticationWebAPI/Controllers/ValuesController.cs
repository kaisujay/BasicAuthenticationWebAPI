using BasicAuthenticationWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BasicAuthenticationWebAPI.Controllers
{
    public class ValuesController : ApiController
    {
        [HttpGet]
        public List<User> GetUser()
        {
            UserBL user = new UserBL();
            return user.GetUsers();
        }
    }
}
