using System.Collections.Generic;
using System.Threading.Tasks;
using T.Core;
using T.Shared;

namespace T.Host.Token
{
    public interface IAuthentication
    {
        Task<ApiExcuteResult> Authenticate(string username, string password);

        IEnumerable<User> GetAll();
    }
}
