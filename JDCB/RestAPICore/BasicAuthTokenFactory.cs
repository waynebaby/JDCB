using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace RestAPICore
{
    public class BasicAuthTokenFactory : IAuthTokenFactory
    {
        public BasicAuthTokenFactory(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

        public string UserName { get; private set; }
        public string Password { get; private set; }

        /*   public AuthToken CreateToken(Can)
           {
               return new DelegateAuthToken(
                   (dic,request, postValues) =>
                   {

                       //string usernamePassword = UserName + ":" + Password;
                       //CredentialCache mycache = new CredentialCache();
                       //mycache.Add(request.RequestUri, "Basic", new NetworkCredential(UserName, Password));
                       //request.Credentials = mycache;
                       //request.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(new ASCIIEncoding().GetBytes(usernamePassword)));
                   }
               );
           }
           */
        public System.Threading.Tasks.Task<AuthToken> CreateTokenAsync()
        {
            throw new NotImplementedException();
        }

        public AuthToken CreateToken()
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task<AuthToken> CreateTokenAsync(System.Threading.CancellationToken cancelToken)
        {
            throw new NotImplementedException();
        }
    }
}
