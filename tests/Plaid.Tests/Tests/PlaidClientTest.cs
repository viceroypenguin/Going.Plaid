using System;
using System.Linq;
using System.Threading.Tasks;
using Going.Plaid.Entity;
using Microsoft.Extensions.Configuration;
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

			if (string.IsNullOrWhiteSpace(configuration["Environment"]))
				throw new InvalidOperationException("Please provide Environment configuration via PLAID_CONFIG_ENVIRONMENT or secrets.json.");
			if (string.IsNullOrWhiteSpace(configuration["Client_Id"]))
				throw new InvalidOperationException("Please provide Client_Id configuration via PLAID_CONFIG_CLIENT_ID or secrets.json.");
			if (string.IsNullOrWhiteSpace(configuration["Secret"]))
				throw new InvalidOperationException("Please provide Secret configuration via PLAID_CONFIG_SECRET or secrets.json.");
			if (string.IsNullOrWhiteSpace(configuration["Access_Token"]))
				throw new InvalidOperationException("Please provide Access_Token configuration via PLAID_CONFIG_ACCESS_TOKEN or secrets.json.");

			PlaidClient = new PlaidClient(
				Enum.Parse<Environment>(configuration["Environment"]),
				configuration["Client_Id"],
				configuration["Secret"],
				configuration["Access_Token"]);
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
				new Investments.GetInvestmentTransactionsRequest());
			await Verify(result);
		}
	}
}
