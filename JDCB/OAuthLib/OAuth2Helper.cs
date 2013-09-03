using OAuthLib;
using System;
using System.Collections.Generic;
using System.Linq;
#if  WINDOWS_PHONE_8

#else
using System.Net.Http;
using System.Net.Http.Headers;
#endif
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;



namespace OAuthLib
{
    public class OAuth2Helper : OAuthHelper
    {
        public OAuth2Helper(OAuthSettings settings)
            : base(settings)
        {
            OAuthSettings.OAuthVersion = "2.0";
        }

        public override async Task<OAuthAccessToken> LoginAsync(string passport, string password, CancellationToken cancelToken)
        {
            using (var client = new HttpClient())
            {
                // https://api.weibo.com/oauth2/authorize
                using (var request = new HttpRequestMessage(HttpMethod.Post, Settings.AuthorizeUrl))
                {
                    //var callback = "CallbackUrl";

                    var dict1 = new Dictionary<string, string>();
                    dict1.Add("client_id", Settings.AppKey);
                    dict1.Add("redirect_uri", Settings.CallbackUrl);
                    dict1.Add("response_type", "code");
                    dict1.Add("display", "default");
                    var referrer = Settings.AuthorizeUrl + "?" + dict1.BuildToUrlString();
                    request.Headers.Referrer = new Uri(referrer);

                    var dict2 = new Dictionary<string, string>();
                    dict2.Add("action", "submit");
                    dict2.Add("withOfficalFlag", "0");
                    dict2.Add("ticket", null);
                    dict2.Add("isLoginSina", null);
                    dict2.Add("response_type", "token");
                    dict2.Add("regCallback", null);
                    dict2.Add("redirect_uri", Settings.CallbackUrl);
                    dict2.Add("client_id", Settings.AppKey);
                    dict2.Add("state", null);
                    dict2.Add("from", null);
                    dict2.Add("userId", passport);
                    dict2.Add("passwd", password);
                    dict2.Add("display", "js");
                    var postBody = dict2.BuildToUrlString();

                    request.Content = new StringContent(postBody);
#if WINDOWS_PHONE_8

#else
                    request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");

#endif

                    var response = await client.SendAsync(request);
                    var result = await response.Content.ReadAsStringAsync();

                    var pattern1 = @"\{""access_token"":""(?<token>.{0,32})"",""remind_in"":""(?<remind>\d+)"",""expires_in"":(?<expires>\d+),""uid"":""(?<uid>\d+)""\}";
                    var pattern2 = @"\{""access_token"":""(?<token>.{0,32})"",""remind_in"":""(?<remind>\d+)"",""expires_in"":(?<expires>\d+),""refresh_token"":""(?<refreshtoken>.{0,32})"",""uid"":""(?<uid>\d+)""\}";

                    if (!string.IsNullOrEmpty(result) && (Regex.IsMatch(result, pattern1) || Regex.IsMatch(result, pattern2)))
                    {
                        var group = Regex.IsMatch(result, "refresh_token") ? Regex.Match(result, pattern2) : Regex.Match(result, pattern1);

                        var accessToken = group.Groups["token"].Value;
                        if (accessToken != null)
                        {
                            var oauthAccessToken = new OAuthAccessToken();
                            oauthAccessToken.ExpiresIn = Convert.ToInt32(group.Groups["expires"].Value);
                            oauthAccessToken.Token = group.Groups["token"].Value;
                            oauthAccessToken.UserID = group.Groups["uid"].Value;

                            return oauthAccessToken;
                        }
                    }
                    return null;
                }
            }
        }

    }

    public static class DictionaryExtension
    {
        public static string BuildToUrlString(this IDictionary<string, string> obj)
        {
            var sb = new StringBuilder();
            if (obj != null && obj.Count > 0)
            {
                foreach (var kv in obj)
                {
                    sb.AppendFormat("{0}={1}",
                        Uri.EscapeDataString(kv.Key),
                        string.IsNullOrEmpty(kv.Value) ? "" : Uri.EscapeDataString(kv.Value.ToString()));
                    sb.Append("&");
                }
            }
            var urlStr = sb.ToString().TrimEnd('&');
            return urlStr;
        }
    }
}
