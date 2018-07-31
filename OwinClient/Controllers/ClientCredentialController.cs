using Common;
using DotNetOpenAuth.OAuth2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace OwinClient.Controllers
{
    public class ClientCredentialController : Controller
    {
        // GET: ClientCredential
        public async Task<ActionResult> Index()
        {
            ViewBag.ApiResult = "";
            ViewBag.AccessToken = "";

            if (Request.HttpMethod == "POST")
            {
                var authServer = new AuthorizationServerDescription
                {
                    AuthorizationEndpoint = new Uri(Paths.AuthorizationServerBaseAddress + Paths.AuthorizePath),
                    TokenEndpoint = new Uri(Paths.AuthorizationServerBaseAddress + Paths.TokenPath)
                };
                var webServerClient = new WebServerClient(authServer, Clients.Client1.Id, Clients.Client1.Secret);

                var state = webServerClient.GetClientAccessToken(new[] { "test1", "test2", "test3" });
                var token = state.AccessToken;
                ViewBag.AccessToken = token;

                var client = new HttpClient(webServerClient.CreateAuthorizingHandler(token));
                var apiResult = await client.GetStringAsync(Paths.ResourceUserApiPath);

                ViewBag.ApiResult = apiResult;
            }

            return View();
        }
    }
}