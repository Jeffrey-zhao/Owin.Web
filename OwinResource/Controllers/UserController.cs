﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Http;


namespace OwinResource.Controllers
{
    [Authorize]
    public class UserController : ApiController
    {
        public object Get()
        {
            var identity = User.Identity as ClaimsIdentity;

            var infos = identity.Claims.Where(claim => claim.Type.Equals("urn:oauth:scope"))
                .Select(claim => claim.Value)
                .ToDictionary(s => s, s => s + " value is xxx");

            return new { name = identity.Name, infos };
        }
    }
}