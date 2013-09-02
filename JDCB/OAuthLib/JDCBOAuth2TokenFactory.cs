using RestAPICore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAuthLib
{
    public class JDCBOAuth2TokenFactory : IAuthTokenFactory
    {
        public OAuthSettings OAuthSettings { get; set; }
        public string Passport { get; set; }
        public string Password { get; set; }

        public AuthToken CreateToken()
        {
            return CreateTokenAsync(System.Threading.CancellationToken.None).Result;
        }

        public async Task<AuthToken> CreateTokenAsync(System.Threading.CancellationToken cancelToken)
        {
            var helper = new OAuth2Helper(OAuthSettings);

            Action<IDictionary<string, object>, string, RequestBase> authorizeByQuery = (context, baseUrl, requestBase) =>
            {
                requestBase.RequestData.QueryStringValues.Add("access_token", new List<string> { context["AccessToken"] as string });
            };

            var token = new DelegateAuthToken(null, authorizeByQuery);

            var accessToken = await helper.LoginAsync(Passport, Password, cancelToken);
            token.ContextData["UserID"] = accessToken.UserID;
            token.ContextData["AccessToken"] = accessToken.Token;

            return token;
        }
    }
}
