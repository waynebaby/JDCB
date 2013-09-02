using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace OAuthLib.Test
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class OAuthLibTest
    {
        public OAuthLibTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        //#region OAuthHelperTest
        //[TestMethod]
        //public void TestOAuthHelperGet1_Fail()
        //{
        //    var settings = new OAuthSettings
        //    {
        //        AcessTokenUrl = "http://api.t.sina.com.cn/oauth/access_token",
        //        AuthorizeUrl = "http://api.t.sina.com.cn/oauth/authorize",
        //        RequestTokenUrl = "http://api.t.sina.com.cn/oauth/request_token",
        //        AppKey = "967389259",
        //        AppSecret = "001379b11292669a5399131cfc5b806d"
        //    };
        //    var oauthHelper = new OAuthHelper(settings);
        //    oauthHelper.Login("jdcbtest@sina.com", "jdcbtest");
        //    var url = string.Format("http://api.t.sina.com.cn/statuses/friends.json?count=1&user_id={0}", oauthHelper.AccessToken.UserID);
        //    using (var client = new WebClient())
        //    {
        //        var parameters = oauthHelper.GetOAuthBasicParams();
        //        parameters.Add("oauth_token", oauthHelper.AccessToken.Token);
        //        parameters.Add("count", "1");
        //        parameters.Add("user_id", oauthHelper.AccessToken.UserID);
        //        //var baseUrl = string.Format("http://api.t.sina.com.cn/statuses/friends/{0}.json", oauthHelper.AccessToken.UserID);
        //        var baseUrl = "http://api.t.sina.com.cn/statuses/friends.json";
        //        //baseUrl = url;
        //        var oauth = oauthHelper.ConstructOAuthHeader(parameters, "GET", baseUrl, oauthHelper.AccessToken.Secret, new[] { "count", "user_id" });
        //        client.Headers.Add(HttpRequestHeader.Authorization, oauth);
        //        //var oauthQuery = oauthHelper.ConstructOAuthQueryString(parameters, "GET", url, oauthHelper.AccessToken.Secret);
        //        //url = url + "?" + oauthQuery;
        //        client.Encoding = System.Text.Encoding.UTF8;
        //        var result = client.DownloadString(url);
        //    }
        //}

        //[TestMethod]
        //public void TestOAuthHelperGet_Success()
        //{
        //    var settings = new OAuthSettings
        //    {
        //        AcessTokenUrl = "http://api.t.sina.com.cn/oauth/access_token",
        //        AuthorizeUrl = "http://api.t.sina.com.cn/oauth/authorize",
        //        RequestTokenUrl = "http://api.t.sina.com.cn/oauth/request_token",
        //        AppKey = "967389259",
        //        AppSecret = "001379b11292669a5399131cfc5b806d"
        //    };
        //    var oauthHelper = new OAuthHelper(settings);
        //    oauthHelper.Login("jdcbtest@sina.com", "jdcbtest");
        //    var url = "http://api.t.sina.com.cn/statuses/friends.json";
        //    using (var client = new WebClient())
        //    {
        //        var parameters = oauthHelper.GetOAuthBasicParams();
        //        parameters.Add("oauth_token", oauthHelper.AccessToken.Token);
        //        parameters.Add("count", "1");
        //        parameters.Add("user_id", oauthHelper.AccessToken.UserID);

        //        var oauthQuery = oauthHelper.ConstructOAuthQueryString(parameters, "GET", url, oauthHelper.AccessToken.Secret);
        //        url = url + "?" + oauthQuery;
        //        client.Encoding = System.Text.Encoding.UTF8;
        //        var result = client.DownloadString(url);
        //    }
        //}


        //[TestMethod]
        //public void TestOAuthHelperPost()
        //{
        //    var settings = new OAuthSettings
        //    {
        //        AcessTokenUrl = "http://api.t.sina.com.cn/oauth/access_token",
        //        AuthorizeUrl = "http://api.t.sina.com.cn/oauth/authorize",
        //        RequestTokenUrl = "http://api.t.sina.com.cn/oauth/request_token",
        //        AppKey = "967389259",
        //        AppSecret = "001379b11292669a5399131cfc5b806d"
        //    };
        //    var oauthHelper = new OAuthHelper(settings);
        //    oauthHelper.Login("jdcbtest@sina.com", "jdcbtest");
        //    var url = "http://api.t.sina.com.cn/statuses/update.json";
        //    using (var client = new WebClient())
        //    {
        //        var parameters = oauthHelper.GetOAuthBasicParams();
        //        parameters.Add("oauth_token", oauthHelper.AccessToken.Token);
        //        parameters.Add("status", "test");

        //        var oauth = oauthHelper.ConstructOAuthHeader(parameters, "POST", url, oauthHelper.AccessToken.Secret, new[] { "status" });
        //        client.Headers.Add(HttpRequestHeader.Authorization, oauth);
        //        client.Encoding = System.Text.Encoding.UTF8;

        //        var body = new System.Collections.Specialized.NameValueCollection();
        //        body.Add("status", "test");
        //        var result = client.UploadValues(url, body);
        //    }
        //}
        //#endregion
    }
}
