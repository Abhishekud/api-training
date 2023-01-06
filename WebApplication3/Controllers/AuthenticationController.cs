using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using WebApplication3.Filter;

namespace WebApplication3.Controllers
{
    [BasicAuthentication]
    public class AuthenticationController : ApiController
    {
        public string result()
        {
            return "Authentiation Method Called";
        }
    }
}
