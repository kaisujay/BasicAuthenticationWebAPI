using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace BasicAuthenticationWebAPI.Models
{
    public class BasicAuthenticationAttribute : AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            if (actionContext.Request.Headers.Authorization == null)    //If Authorization header is empty
            {
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
            }
            else
            {               
                string authenticationToken = actionContext.Request.Headers.Authorization.Parameter;     //Get the authentication token from the request header                
                string decodedAuthenticationToken = Encoding.UTF8.GetString(Convert.FromBase64String(authenticationToken));     //Decode the string              
                string[] usernamePasswordArray = decodedAuthenticationToken.Split(':');     //Convert the string into an string array                
                string username = usernamePasswordArray[0];     //First element of the array is the username            
                string password = usernamePasswordArray[1];     //Second element of the array is the password
                
                if (UserValidate.Login(username, password))     //call the login method to check the username and password
                {
                    Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity(username), null);                    
                }
                else
                {
                    actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
                }
            }
        }
    }
}