using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xero.NetStandard.OAuth2.Token;

namespace TestingConnectionWithPostgre.Services
{
    public interface IXeroService
    {
        string GetLoginUrl();
        Task<IXeroToken> GetTokensAsync(string code, string state);
    }
}
