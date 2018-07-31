using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OwinAuthorization.Controllers
{
    public class TokenController : Controller
    {
        // GET: Token
        public ActionResult Index()
        {
            return new EmptyResult();
        }
    }
}