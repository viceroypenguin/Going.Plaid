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

namespace Going.Plaid.Tests
{
	[UsesVerify]
	public class PlaidClientTest
	{
		public PlaidClient PlaidClient { get; }

		public PlaidClientTest()
		{
			VerifierSettings.DisableClipboard();
			VerifierSettings.ScrubLinesContaining(StringComparison.OrdinalIgnoreCase, "RequestId");

			var configuration = new ConfigurationBuilder()
				.AddEnvironmentVariables()
				.AddJsonFile("secrets.json", optional: true)
				.Build();
			var plaidOptions = configuration.GetSection(PlaidOptions.SectionKey).Get<PlaidOptions>();

			if (string.IsNullOrWhiteSpace(plaidOptions?.ClientId))
				throw new InvalidOperationException("Please provide ClientId configuration via PLAID__CLIENTID environment variable or Plaid:ClientId in secrets.json.");
			if (string.IsNullOrWhiteSpace(plaidOptions?.Secret))
				throw new InvalidOperationException("Please provide Secret configuration via PLAID__SECRET or Plaid:Secret in secrets.json.");
			if (string.IsNullOrWhiteSpace(plaidOptions?.DefaultAccessToken))
				throw new InvalidOperationException("Please provide DefaultAccessToken configuration via PLAID__DEFAULTACCESSTOKEN or Plaid:DefaultAccessToken in secrets.json.");

			PlaidClient = new PlaidClient(
				MOptions.Create(plaidOptions));
		}

		[Fact]
		public async Task FetchItemAsync()
		{
			var result = await PlaidClient.FetchItemAsync(
				new Management.GetItemRequest());

			// because values will change regularly and we don't want
			// to have to update output json for that.
			result = result with { Status = null!, };

			await Verify(result);
		}

		[Fact]
		public async Task UpdateWebhookAsync()
		{
			var result = await PlaidClient.UpdateWebhookAsync(
				new Management.UpdateWebhookRequest()
				{
					Webhook = "https://example.com",
				});
			await Verify(result);
		}

		/* Institutions */

		[Fact]
		public async Task FetchAllInstitutionsAsync()
		{
			// institution list may change over time. don't validate.
			var result = await PlaidClient.FetchAllInstitutionsAsync(
				new Institution.GetAllInstitutionsRequest()
				{
					CountryCodes = new[] { "US", },
				});
			Assert.Equal(100, result.Institutions.Length);
		}

		[Fact]
		public async Task FetchInstitutionsAsync()
		{
			var result = await PlaidClient.FetchInstitutionsAsync(
				new Institution.SearchRequest
				{
					Query = "Chase",
					Products = new[] { Product.Transactions, },
					CountryCodes = new[] { "US", },
				});
			await Verify(result);
		}

		[Fact]
		public async Task FetchInstitutionByIdAsync()
		{
			var result = await PlaidClient.FetchInstitutionByIdAsync(
				new Institution.SearchByIdRequest
				{
					InstitutionId = "ins_3",
					CountryCodes = new[] { "US", },
				});
			await Verify(result);
		}

		/* Income */

		[Fact]
		public async Task FetchUserIncomeAsync()
		{
			var result = await PlaidClient.FetchUserIncomeAsync(
				new Income.GetIncomeRequest());
			await Verify(result);
		}

		/* Investments */

		[Fact(Skip = "Plaid has consistency problems with returned data from this API")]
		public async Task FetchInvestmentHoldingsAsync()
		{
			var result = await PlaidClient.FetchInvestmentHoldingsAsync(
				new Investments.GetInvestmentHoldingsRequest());

			await Verify(result);
		}

		[Fact(Skip = "Plaid has consistency problems with returned data from this API")]
		public async Task FetchInvestmentTransactionsAsync()
		{
			var result = await PlaidClient.FetchInvestmentTransactionsAsync(
				new Investments.GetInvestmentTransactionsRequest()
				{
					StartDate = Convert.ToDateTime("2020-07-01"),
					EndDate = Convert.ToDateTime("2020-07-31"),
				});

			await Verify(result);
		}

		/* Auth */

		[Fact]
		public async Task FetchAccountInfoAsync()
		{
			var result = await PlaidClient.FetchAccountInfoAsync(
				new Auth.GetAccountInfoRequest());
			await Verify(result);
		}

		/* Balance */

		[Fact]
		public async Task FetchAccountAsync()
		{
			var result = await PlaidClient.FetchAccountAsync(
				new Balance.GetAccountRequest());
			await Verify(result);
		}

		[Fact]
		public async Task FetchAccountBalanceAsync()
		{
			var result = await PlaidClient.FetchAccountBalanceAsync(
				new Balance.GetBalanceRequest());
			await Verify(result);
		}

		/* Categories */

		[Fact]
		public async Task FetchCategoriesAsync()
		{
			var result = await PlaidClient.FetchCategoriesAsync(
				new Category.GetCategoriesRequest());
			await Verify(result);
		}

		/* Identity */

		[Fact]
		public async Task FetchUserIdentityAsync()
		{
			var result = await PlaidClient.FetchUserIdentityAsync(
				new Identity.GetUserIdentityRequest());
			await Verify(result);
		}

		/* Transactions */

		[Fact]
		public async Task FetchTransactionsAsync()
		{
			var result = await PlaidClient.FetchTransactionsAsync(
				new Transactions.GetTransactionsRequest()
				{
					StartDate = Convert.ToDateTime("2020-07-01"),
					EndDate = Convert.ToDateTime("2020-07-31"),
				});
			await Verify(result);
		}

		/* Liabilities */

		[Fact]
		public async Task FetchLiabilitiesAsync()
		{
			var result = await PlaidClient.FetchLiabilitiesAsync(
				new Liabilities.GetLiabilitiesRequest { });
			await Verify(result);
		}
	}
}
