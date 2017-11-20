using Acklann.Plaid.Management;
using Microsoft.AspNetCore.Mvc;

namespace Acklann.Plaid.Demo.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(Middleware.PlaidCredentials credentials)
        {
            _credentials = credentials;
        }

        public IActionResult Index()
        {
            return View(_credentials);
        }

        [HttpPost]
        public IActionResult GetAccessToken(Environment environment, [FromBody]PlaidLinkResponse metadata)
        {
            var client = new PlaidClient(environment);
            ExchangeTokenResponse result = client.ExchangeTokenAsync(new ExchangeTokenRequest()
            {
                Secret = _credentials.Secret,
                ClientId = _credentials.ClientId,
                PublicToken = metadata.PublicToken
            }).Result;
            _credentials.AccessToken = result.AccessToken;
            System.Diagnostics.Debug.WriteLine($"access_token: '{result.AccessToken}'");

            return Ok(result);
        }

        #region Private Members

        private Middleware.PlaidCredentials _credentials;

        #endregion Private Members
    }
}