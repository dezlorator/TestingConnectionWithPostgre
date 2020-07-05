using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IdentityModel.Client;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using TestingConnectionWithPostgre.Models;
using Xero.NetStandard.OAuth2.Model.Accounting;

namespace TestingConnectionWithPostgre.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class XeroController : ControllerBase
    {
        private string clientId = "8443CF59A93F4F3EABACB7C9662A3036";
        private string clientSecret = "1euUDCNAuxjbYU5PNyaHT-Nqt4zHzyonc03qkZzkPReqiCa0";
        private const string xeroAuthorizationUri = "https://login.xero.com/identity/connect/authorize";
        private const string scopeParameters = "openid profile email files accounting.transactions accounting.transactions.read accounting.reports.read accounting.journals.read accounting.settings accounting.settings.read accounting.contacts accounting.contacts.read accounting.attachments accounting.attachments.read offline_access";
        private const string redirectUri = "https://localhost:44362/oauth";
        private const string getTokenUri = "https://identity.xero.com/connect/token";
        private const string getConnectionsUri = "https://api.xero.com/connections";
        private const string getInvoicesUri = "https://api.xero.com/api.xro/2.0/Invoices";
        private string accessToken;
        private string refreshToken;
        private string identityToken;
        // GET api/values
        [HttpGet]
        public ContentResult Get()
        {
            var xeroAuthorizeUri = new RequestUrl(xeroAuthorizationUri);
            var url = xeroAuthorizeUri.CreateAuthorizeUrl(
             clientId: clientId,
             responseType: "code", //hardcoded authorisation code for now.
             redirectUri: redirectUri,
             state: "your state",
             scope: scopeParameters
         );
            return new ContentResult
            {
                ContentType = "text/html",
                StatusCode = (int)HttpStatusCode.OK,
                Content = String.Format("<html><head></head><body><a href ='{0}'>Connect to Xero</a></body></html>", url)
            };
        }

        [HttpGet("/oauth")]
        public async Task<ContentResult> Get(string code, string state)
        {
            var result = new ContentResult();
            var tenantList = new List<Tenant>();
            using (var client = new HttpClient())
            {
                var response = await client.RequestAuthorizationCodeTokenAsync(new AuthorizationCodeTokenRequest
                {
                    Address = getTokenUri,
                    GrantType = "code",
                    Code = code,
                    ClientId = clientId,
                    ClientSecret = clientSecret,
                    RedirectUri = redirectUri,
                    Parameters =
                    {
                        { "scope", scopeParameters}
                    }
                });

                if (response.IsError) { throw new Exception(response.Error); }
                accessToken = response.AccessToken;
                refreshToken = response.RefreshToken;
                identityToken = response.IdentityToken;

            }

            return await GetTenant();
        }

        [HttpGet("getTenant")]
        public async Task<ContentResult> GetTenant()
        {
            var result = new ContentResult();
            string tenant;
            string invoices;
            var tenantList = new List<Tenant>();
            var invoicesList = new Invoices();
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
                using (var requestMessage = new HttpRequestMessage(System.Net.Http.HttpMethod.Get, getConnectionsUri))
                {
                    HttpResponseMessage httpResult = client.SendAsync(requestMessage).Result;
                    System.Console.WriteLine(httpResult.RequestMessage);
                    tenant = httpResult.Content.ReadAsStringAsync().Result;
                    tenantList = JsonConvert.DeserializeObject<List<Tenant>>(tenant);
                }
                foreach (Tenant t in tenantList)
                {
                    using (var requestMessage = new HttpRequestMessage(System.Net.Http.HttpMethod.Get, getInvoicesUri))
                    {
                        requestMessage.Headers.Add("xero-tenant-id", t.TenantId.ToString());
                        HttpResponseMessage httpResult = client.SendAsync(requestMessage).Result;
                        System.Console.WriteLine(httpResult.RequestMessage);
                        invoices = httpResult.Content.ReadAsStringAsync().Result;
                        invoicesList = JsonConvert.DeserializeObject<Invoices>(invoices);
                    }
                    var content = String.Format(@"<html><head></head><body>
            <h3>AccessToken</h3><p>{0}</p>
            <h3>RefreshToken</h3><p>{1}</p>
            <h3>IdentityToken</h3><p>{2}</p>
            <h3>Tenant</h3><p>{3}</p>
            <h3>Invoice Data</h3><p>{4}</p>
            </body></html>", accessToken, refreshToken, identityToken, tenant, invoices);
                    result.Content = content;
                    result.ContentType = "text/html";

                }
            }

            return result;
        }
    }
}
