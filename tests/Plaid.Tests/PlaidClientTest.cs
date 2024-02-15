using Going.Plaid.Entity;
using Microsoft.Extensions.Configuration;
using Xunit;

#if !NET6_0_OR_GREATER
using DateOnly = System.DateTime;
#endif

namespace Going.Plaid.Tests;

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
			Environment.Sandbox,
			clientId: plaidOptions.ClientId,
			secret: plaidOptions.Secret,
			accessToken: plaidOptions.DefaultAccessToken,
			apiVersion: plaidOptions.ApiVersion);
	}

	public async Task InitializeAsync()
	{
		var publicToken = await PlaidClient.SandboxPublicTokenCreateAsync(
			new Sandbox.SandboxPublicTokenCreateRequest
			{
				InstitutionId = "ins_3",
				InitialProducts =
				[
					Products.Auth,
					Products.Investments,
					Products.Transactions,
					Products.Assets,
				],
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

public class PlaidClientTest(PlaidFixture fixture) : IClassFixture<PlaidFixture>
{
	private readonly PlaidFixture _fixture = fixture;

	[Fact]
	public Task FetchCategoriesAsync() =>
		// only check no crash
		_fixture.PlaidClient.CategoriesGetAsync(new());

	[Fact]
	public Task FetchItemAsync() =>
		// only check no crash
		_fixture.PlaidClient.ItemGetAsync(new());

	[Fact]
	public async Task FetchTransactionsAsync()
	{
		_ = await _fixture.PlaidClient.TransactionsRefreshAsync(new());
		// only check no crash
		_ = await _fixture.PlaidClient.TransactionsGetAsync(
			new() { StartDate = new DateOnly(2021, 01, 01), EndDate = new DateOnly(2021, 03, 31), });
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
