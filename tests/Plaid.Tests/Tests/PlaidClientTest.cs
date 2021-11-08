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
	public class PlaidFixture : IAsyncLifetime
	{
		public PlaidClient PlaidClient { get; }

		public PlaidFixture()
		{
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

			PlaidClient = new PlaidClient(
				MOptions.Create(plaidOptions));
		}

		public async Task InitializeAsync()
		{
			var publicToken = await PlaidClient.SandboxPublicTokenCreateAsync(
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

			var accessToken = await PlaidClient.ItemPublicTokenExchangeAsync(
				new Item.ItemPublicTokenExchangeRequest
				{
					PublicToken = publicToken.PublicToken,
				});
			if (!accessToken.IsSuccessStatusCode)
				throw new InvalidOperationException("Unable to collect sandbox access token.");

			PlaidClient.AccessToken = accessToken.AccessToken;
		}

		public Task DisposeAsync() =>
			PlaidClient.ItemRemoveAsync(new());
	}

	[UsesVerify]
	public class PlaidClientTest : IClassFixture<PlaidFixture>
	{
		private static readonly VerifySettings settings = BuildVerifierSettings();
		private static VerifySettings BuildVerifierSettings()
		{
			VerifierSettings.UseStrictJson();
			VerifierSettings.DisableClipboard();

			var settings = new VerifySettings();
			settings.ModifySerialization(s =>
			{
				// random ids
				s.IgnoreMember("RequestId");
				s.IgnoreMember("AccountId");
				s.IgnoreMember("ItemId");
				s.IgnoreMember("TransactionId");
				s.IgnoreMember("SecurityId");
				s.IgnoreMember("InvestmentTransactionId");

				// dateonly vs datetime - ignore dates for now
				s.IgnoreMember("Date");
				s.IgnoreMember("InstitutionPriceAsOf");
				s.IgnoreMember("ClosePriceAsOf");
				s.IgnoreMember("AuthorizedDate");

				s.IgnoreMember<Item.ItemGetResponse>(s => s.Status);
			});
			return settings;
		}

		private readonly PlaidFixture _fixture;

		public PlaidClientTest(PlaidFixture fixture)
		{
			_fixture = fixture;
		}

		[Fact]
		public Task FetchItemAsync() =>
			Verify(_fixture.PlaidClient.ItemGetAsync(new()), settings);

		[Fact]
		public async Task FetchTransactionsAsync()
		{
			await _fixture.PlaidClient.TransactionsRefreshAsync(new());
			await Verify(_fixture.PlaidClient.TransactionsGetAsync(
				new() { StartDate = new DateOnly(2021, 01, 01), EndDate = new DateOnly(2021, 03, 31), }),
				settings);
		}

		[Fact]
		public Task FetchInvestmentTransactionsAsync() =>
			// only check no crash
			_fixture.PlaidClient.InvestmentsTransactionsGetAsync(
				new() { StartDate = new DateOnly(2021, 01, 01), EndDate = new DateOnly(2021, 03, 31), });

		[Fact]
		public Task FetchInvestmentHoldingsAsync() =>
			// only check no crash
			_fixture.PlaidClient.InvestmentsHoldingsGetAsync(new());
	}
}
