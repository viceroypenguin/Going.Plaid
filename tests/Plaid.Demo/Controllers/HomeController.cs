using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Going.Plaid.Entity;
using Going.Plaid.Management;
using Microsoft.AspNetCore.Mvc;

namespace Going.Plaid.Demo.Controllers
{
	public class HomeController : Controller
	{
		public HomeController(Middleware.PlaidCredentials credentials, PlaidClient client)
		{
			_credentials = credentials;
			_client = client;
		}

		public IActionResult Index() =>
			View(_credentials);

		[HttpPost]
		public async Task<IActionResult> GetLinkToken([FromBody] string[] products)
		{
			var result = await _client.CreateLinkTokenAsync(
				new CreateLinkTokenRequest()
				{
					User = new User { ClientUserId = Guid.NewGuid().ToString(), },
					ClientName = "Going.Plaid.Net Walkthrough Demo ",
					Products = products.Select(p => Enum.Parse<Product>(p)).ToArray(),
					Language = Language.English,
					CountryCodes = new[] { "US" },
				});
			return Ok(result);
		}

		[HttpPost]
		public async Task<IActionResult> GetAccessToken([FromBody] string publicToken)
		{
			var result = await _client.ExchangeTokenAsync(
				new ExchangeTokenRequest()
				{
					PublicToken = publicToken,
				});
			_credentials.AccessToken = result.AccessToken;
			System.Diagnostics.Debug.WriteLine($"access_token: '{result.AccessToken}'");

			return Ok(result);
		}

		[HttpPost]
		public async Task<IActionResult> GetUpdateToken([FromBody] string accessToken)
		{
			var result = await _client.CreateLinkTokenAsync(
				new CreateLinkTokenRequest()
				{
					AccessToken = accessToken,
					User = new User { ClientUserId = Guid.NewGuid().ToString(), },
					ClientName = "Going.Plaid.Net Walkthrough Demo ",
					Language = Language.English,
					CountryCodes = new[] { "US" },
				});
			System.Diagnostics.Debug.WriteLine($"public_token: '{result.LinkToken}'");

			return Ok(result);
		}

		#region Private Members

		private readonly Middleware.PlaidCredentials _credentials;
		private readonly PlaidClient _client;

		#endregion Private Members
	}
}
