﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IdentityModel.Client;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using TestingConnectionWithPostgre.Models;

namespace TestingConnectionWithPostgre.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class XeroController : ControllerBase
    {
        private string clientId = "AB32FA202E1042D7A7A3910BB7DDBFB6";
        private string clientSecret = "mKMQsi9-3Xe_1WkdyZFUByu3yMbA5eILBXk39VkOPYlTtk14";
        // GET api/values
        [HttpGet]
        public ContentResult Get()
        {
            var xeroAuthorizeUri = new RequestUrl("https://login.xero.com/identity/connect/authorize");
            var url = xeroAuthorizeUri.CreateAuthorizeUrl(
             clientId: clientId,
             responseType: "code", //hardcoded authorisation code for now.
             redirectUri: "https://localhost:44362/oauth",
             state: "your state",
             scope: "openid profile email files accounting.transactions accounting.transactions.read accounting.reports.read accounting.journals.read accounting.settings accounting.settings.read accounting.contacts accounting.contacts.read accounting.attachments accounting.attachments.read offline_access"
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
                    Address = "https://identity.xero.com/connect/token",
                    GrantType = "code",
                    Code = code,
                    ClientId = clientId,
                    ClientSecret = clientSecret,
                    RedirectUri = "https://localhost:44362/oauth",
                    Parameters =
                    {
                        { "scope", "openid profile email files accounting.transactions accounting.transactions.read accounting.reports.read accounting.journals.read accounting.settings accounting.settings.read accounting.contacts accounting.contacts.read accounting.attachments accounting.attachments.read offline_access"}
                    }
                });

                if (response.IsError) { throw new Exception(response.Error); }
                var accessToken = response.AccessToken;
                var refreshToken = response.RefreshToken;
                var identityToken = response.IdentityToken;
                string tenant;
                string invoices;
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
                using (var requestMessage = new HttpRequestMessage(System.Net.Http.HttpMethod.Get, "https://api.xero.com/connections"))
                {
                    HttpResponseMessage httpResult = client.SendAsync(requestMessage).Result;
                    System.Console.WriteLine(httpResult.RequestMessage);
                    tenant = httpResult.Content.ReadAsStringAsync().Result;
                    tenantList = JsonConvert.DeserializeObject<List<Tenant>>(tenant);
                }
                string data = "";
                foreach (Tenant t in tenantList)
                {
                    using (var requestMessage = new HttpRequestMessage(System.Net.Http.HttpMethod.Get, "https://api.xero.com/api.xro/2.0/Invoices"))
                    {
                        requestMessage.Headers.Add("xero-tenant-id", t.TenantId.ToString());
                        HttpResponseMessage httpResult = client.SendAsync(requestMessage).Result;
                        System.Console.WriteLine(httpResult.RequestMessage);
                        invoices = httpResult.Content.ReadAsStringAsync().Result;
                        data = data + invoices;
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
