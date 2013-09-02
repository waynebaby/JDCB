using System;
using System.Threading;
using System.Threading.Tasks;
namespace RestAPICore
{
    public interface IAuthTokenFactory
    {
        AuthToken CreateToken();
        Task<AuthToken> CreateTokenAsync(CancellationToken cancelToken);
    }


    public interface IUserNamePasswordAuthTokenFactory : IAuthTokenFactory
    {
         string UserName { get; set; }
         string Password { get; set; }
    }
}
