using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using TestingConnectionWithPostgre.Services;

namespace TestingConnectionWithPostgre.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class XeroController : ControllerBase
    {
        private readonly IXeroService _xeroService;

        public XeroController(IXeroService xeroService)
        {
            _xeroService = xeroService;
        }

        [HttpGet]
        public ContentResult Get()
        {
            var url = _xeroService.GetLoginUrl();
        
            return new ContentResult
            {
                ContentType = "text/html",
                StatusCode = (int)HttpStatusCode.OK,
                Content = String.Format("<html><head></head><body><a href ='{0}'>Connect to Xero</a></body></html>", url)
            };
        }

        [HttpGet("/oauth")]
        public async Task<IActionResult> Get(string code, string state)
        {
            var token = await _xeroService.GetTokensAsync(code, state);

            return Ok(token);
        }
    }
}
