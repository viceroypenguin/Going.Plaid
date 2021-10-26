using System;
using System.Linq;
using System.Threading.Tasks;
using Going.Plaid.Entity;
using Microsoft.Extensions.Configuration;
using VerifyTests;
using VerifyXunit;
using Xunit;
using static VerifyXunit.Verifier;
using MOptions = Microsoft.Extensions.Options.Options;

#if !NET6_0_OR_GREATER
using DateOnly = System.DateTime;
#endif

namespace Going.Plaid.Tests
{
	[UsesVerify]
	public class PlaidClientTest : IAsyncLifetime
	{
		private readonly PlaidClient _plaidClient;

		public PlaidClientTest()
		{
			VerifierSettings.DisableClipboard();
			VerifierSettings.ModifySerialization(s =>
			{
				s.IgnoreMember("RequestId");
				s.IgnoreMember("AccountId");
				s.IgnoreMember("ItemId");
				s.IgnoreMember("InvestmentTransactionId");
				s.IgnoreMember<Item.ItemGetResponse>(s => s.Status);
			});
			VerifierSettings.UseStrictJson();

			var configuration = new ConfigurationBuilder()
				.AddEnvironmentVariables()
				.AddJsonFile("secrets.json", optional: true)
				.Build();
			var plaidOptions = configuration.GetSection(PlaidOptions.SectionKey).Get<PlaidOptions>()!;

			if (string.IsNullOrWhiteSpace(plaidOptions.ClientId))
				throw new InvalidOperationException("Please provide ClientId configuration via PLAID__CLIENTID environment variable or Plaid:ClientId in secrets.json.");
			if (string.IsNullOrWhiteSpace(plaidOptions.Secret))
				throw new InvalidOperationException("Please provide Secret configuration via PLAID__SECRET or Plaid:Secret in secrets.json.");
			if (!string.IsNullOrWhiteSpace(plaidOptions.DefaultAccessToken))
				throw new InvalidOperationException("Please do not provide DefaultAccessToken configuration. The Access Token will be generated using Sandbox APIs.");
			if (plaidOptions.Environment != Environment.Sandbox)
				throw new InvalidOperationException("Environment must be Sandbox.");

			_plaidClient = new PlaidClient(
				MOptions.Create(plaidOptions));
		}

		public async Task InitializeAsync()
		{
			var publicToken = await _plaidClient.SandboxPublicTokenCreateAsync(
				new Sandbox.SandboxPublicTokenCreateRequest
				{
					InstitutionId = "ins_3",
					InitialProducts = new[]
					{
						Products.Auth,
						Products.Balance,
						Products.Investments,
						Products.Transactions,
					},
				});
			if (!publicToken.IsSuccessStatusCode)
				throw new InvalidOperationException("Unable to collect sandbox public token.");

			var accessToken = await _plaidClient.ItemPublicTokenExchangeAsync(
				new Item.ItemPublicTokenExchangeRequest
				{
					PublicToken = publicToken.PublicToken,
				});
			if (!accessToken.IsSuccessStatusCode)
				throw new InvalidOperationException("Unable to collect sandbox access token.");

			_plaidClient.AccessToken = accessToken.AccessToken;
		}

		public Task DisposeAsync() =>
			_plaidClient.ItemRemoveAsync(new());

		[Fact]
		public Task FetchItemAsync() =>
			Verify(_plaidClient.ItemGetAsync(new()));

		[Fact]
		public async Task FetchTransactionsAsync()
		{
			await _plaidClient.TransactionsRefreshAsync(new());
			await Verify(_plaidClient.TransactionsGetAsync(new() { StartDate = new DateOnly(2021, 01, 01), EndDate = new DateOnly(2021, 03, 31), }));
		}

		[Fact]
		public Task FetchInvestmentTransactionsAsync() =>
			Verify(_plaidClient.InvestmentsTransactionsGetAsync(new() { StartDate = new DateOnly(2021, 01, 01), EndDate = new DateOnly(2021, 03, 31), }));

		[Fact]
		public Task FetchInvestmentHoldingsAsync() =>
			Verify(_plaidClient.InvestmentsHoldingsGetAsync(new()));

		///* Auth */

		//[Fact]
		//public async Task FetchAccountInfoAsync()
		//{
		//	var result = await PlaidClient.FetchAccountInfoAsync(
		//		new Auth.GetAccountInfoRequest());
		//	await Verify(result);
		//}

		///* Balance */

		//[Fact]
		//public async Task FetchAccountAsync()
		//{
		//	var result = await PlaidClient.FetchAccountAsync(
		//		new Balance.GetAccountRequest());
		//	await Verify(result);
		//}

		//[Fact]
		//public async Task FetchAccountBalanceAsync()
		//{
		//	var result = await PlaidClient.FetchAccountBalanceAsync(
		//		new Balance.GetBalanceRequest());
		//	await Verify(result);
		//}

		///* Categories */

		//[Fact]
		//public async Task FetchCategoriesAsync()
		//{
		//	var result = await PlaidClient.FetchCategoriesAsync(
		//		new Category.GetCategoriesRequest());
		//	await Verify(result);
		//}

		///* Identity */

		//[Fact]
		//public async Task FetchUserIdentityAsync()
		//{
		//	var result = await PlaidClient.FetchUserIdentityAsync(
		//		new Identity.GetUserIdentityRequest());
		//	await Verify(result);
		//}

		///* Transactions */

		//[Fact]
		//public async Task FetchTransactionsAsync()
		//{
		//	var result = await PlaidClient.FetchTransactionsAsync(
		//		new Transactions.GetTransactionsRequest()
		//		{
		//			StartDate = Convert.ToDateTime("2020-07-01"),
		//			EndDate = Convert.ToDateTime("2020-07-31"),
		//		});
		//	await Verify(result);
		//}

		///* Liabilities */

		//[Fact]
		//public async Task FetchLiabilitiesAsync()
		//{
		//	var result = await PlaidClient.FetchLiabilitiesAsync(
		//		new Liabilities.GetLiabilitiesRequest { });
		//	await Verify(result);
		//}
	}
}
