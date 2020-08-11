using System;
using System.Linq;
using System.Threading.Tasks;
using Going.Plaid.Entity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using VerifyTests;
using VerifyXunit;
using Xunit;
using static VerifyXunit.Verifier;

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
				.AddEnvironmentVariables("PLAID_CONFIG_")
				.AddJsonFile("secrets.json", optional: true)
				.Build();
			PlaidOptions plaidOptions = configuration.GetSection(PlaidOptions.SectionKey).Get<PlaidOptions>()
				?? new PlaidOptions()
				{
					ClientId = configuration["Client_Id"],
					Secret = configuration["Secret"],
					DefaultAccessToken = configuration["Access_Token"]
				};

			// Since the default value of the PlaidOptions.Environment property is Sandbox, only allow the PLAID_CONFIG_ENVIRONMENT 
			// to override a Sandbox value. Otherwise, the non-default value was read from secrets.json so we do not need to override 
			// (as non of the other environment vars are used either)
			if (!string.IsNullOrWhiteSpace(configuration["Environment"]) && plaidOptions.Environment == Environment.Sandbox)
			{
				if (!Enum.TryParse<Environment>(configuration["Environment"], true, out Environment env))
				{
					throw new InvalidOperationException($"Environment configuration via PLAID_CONFIG_ENVIRONMENT is not valid. " +
						$"Actual: {configuration["ENVIRONMENT"]} ... " +
						$"Valid: {Enum.GetNames(typeof(Environment)).Aggregate((x,y) => $"{x}, {y}")}");
				}
				else
				{
					plaidOptions.Environment = env;
				}
			}
			if (string.IsNullOrWhiteSpace(plaidOptions.ClientId))
				throw new InvalidOperationException("Please provide Client_Id configuration via PLAID_CONFIG_CLIENT_ID or secrets.json.");
			if (string.IsNullOrWhiteSpace(plaidOptions.ClientId))
				throw new InvalidOperationException("Please provide Secret configuration via PLAID_CONFIG_SECRET or secrets.json.");
			if (string.IsNullOrWhiteSpace(plaidOptions.DefaultAccessToken))
				throw new InvalidOperationException("Please provide Access_Token configuration via PLAID_CONFIG_ACCESS_TOKEN or secrets.json.");

			IOptions<PlaidOptions> iPlaidOptions = Microsoft.Extensions.Options.Options.Create<PlaidOptions>(plaidOptions);
			PlaidClient = new PlaidClient(iPlaidOptions);
		}

		[Fact]
		public async Task FetchItemAsync()
		{
			var result = await PlaidClient.FetchItemAsync(
				new Management.GetItemRequest());
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

		[Fact]
		public async Task FetchInvestmentHoldingsAsync()
		{
			var result = await PlaidClient.FetchInvestmentHoldingsAsync(
				new Investments.GetInvestmentHoldingsRequest());
			await Verify(result);
		}

		[Fact]
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
	}
}
