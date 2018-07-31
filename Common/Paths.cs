using System;

namespace Common
{

    public static class Paths {

        public const string ImplicitGrantCallBackPath = "http://localhost:8082/OwinClient/Implicit/Login";

        public const string AuthorizeCodeCallBackPath = "http://localhost:8082/OwinClient/AuthCode";

        public const string ResourceUserApiPath = "http://localhost:8082/OwinResource/api/user";

        public const string AuthorizationServerBaseAddress = "http://localhost:8082/OwinAuthorization";

        public const string LoginPath = "/Account/Login";
        public const string LogoutPath = "/Account/Logout";

        public const string AuthorizePath = "/Authorize";
        public const string TokenPath = "/Token";

    }
}

