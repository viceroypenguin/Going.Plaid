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
			VerifierSettings.ScrubLinesContaining(StringComparison.OrdinalIgnoreCase, "request_id");

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
			result.Status = null!;

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
				new Institution.GetAllInstitutionsRequest());
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

			FixSecurity(result.Securities);
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

			FixSecurity(result.Securities);
			await Verify(result);
		}

		private void FixSecurity(Security[] securities)
		{
			// fixes a bug in the returned security data set
			// Plaid returns a different Institution ID for 
			// the same security in Sandbox.
			// working correctly in dev/prod.
			var s = securities.FirstOrDefault(s => s.SecurityId == "nnmo8doZ4lfKNEDe3mPJipLGkaGw3jfPrpxoN");
			if (s == default)
				return;

			// forces institution id to ins_3 for consistency
			s.InstitutionId = "ins_3";
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
	}
}
