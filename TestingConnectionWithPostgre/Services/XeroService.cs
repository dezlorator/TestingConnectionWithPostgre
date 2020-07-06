using Microsoft.Extensions.Logging;
using Xero.NetStandard.OAuth2.Client;
using Xero.NetStandard.OAuth2.Config;
using Xero.NetStandard.OAuth2.Token;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using Tenant = Xero.NetStandard.OAuth2.Models.Tenant;
using Microsoft.Extensions.Options;

namespace TestingConnectionWithPostgre.Services
{
    public class XeroService: IXeroService
    {
        private readonly ILogger<XeroService> _logger;
        private readonly XeroConfiguration _xeroConfig;
        private readonly IHttpClientFactory _httpClientFactory;
        private static IXeroToken _xeroToken;

        // Keep client secret and id of different application
        //private string clientId = "8443CF59A93F4F3EABACB7C9662A3036";
        //private string clientSecret = "1euUDCNAuxjbYU5PNyaHT-Nqt4zHzyonc03qkZzkPReqiCa0";
        public XeroService(IOptions<XeroConfiguration> config, IHttpClientFactory httpClientFactory, ILogger<XeroService> logger)
        {
            _logger = logger;
            _xeroConfig = config.Value;
            this._httpClientFactory = httpClientFactory;
        }

        public string GetLoginUrl()
        {
            var client = new XeroClient(_xeroConfig, _httpClientFactory);

            return client.BuildLoginUri();
        }

        public async Task<IXeroToken> GetTokensAsync(string code, string state)
        {      
            var client = new XeroClient(_xeroConfig, _httpClientFactory);

            //before getting the access token please check that the state matches
            _xeroToken = await client.RequestXeroTokenAsync(code);

            //from here you will need to access your Xero Tenants
            List<Tenant> tenants = await client.GetConnectionsAsync(_xeroToken);

            _xeroToken.Tenants = tenants;
            return _xeroToken;
        }
    }
}
