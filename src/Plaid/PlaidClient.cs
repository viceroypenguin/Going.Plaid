using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Going.Plaid.Converters;
using Going.Plaid.Entity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Extensions.Options;

namespace Going.Plaid
{
	/// <summary>
	/// Provides methods for sending request to and receiving data from Plaid banking API.
	/// </summary>
	public sealed class PlaidClient
	{
		#region Initialization

		/// <summary>
		/// Initializes a new instance of the <see cref="PlaidClient"/> class using parameters that can all come from Dependency Injextion.
		/// </summary>
		/// <param name="options"><see cref="PlaidOptions"/> initialized from an IConfiguration section</param>
		/// <param name="httpClientFactory">A factory instance used to create <see cref="HttpClient" /> instances. If one is not provided, a service collection will be created and used instead. For more information, see <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests"/> for more information.</param>
		/// <param name="logger">A logging instance. Log entries will be provided at Information level at completion of each api call; and at Trace level with request and content details at the start and end of each api call. If not provided, a <see cref="NullLogger" /> instance will be used.</param>
		public PlaidClient(
			IOptions<PlaidOptions> options,
			IHttpClientFactory? httpClientFactory = null,
			ILogger<PlaidClient>? logger = null)
			: this(
				  options.Value.Environment,
				  options.Value.ClientId,
				  options.Value.Secret,
				  options.Value.DefaultAccessToken,
				  apiVersion: options.Value.ApiVersion,
				  httpClientFactory: httpClientFactory,
				  logger: logger)
		{ }

		/// <summary>
		/// Initializes a new instance of the <see cref="PlaidClient"/> class.
		/// </summary>
		/// <param name="environment">The environment.</param>
		/// <param name="clientId">The client identifier.</param>
		/// <param name="secret">The secret.</param>
		/// <param name="accessToken">The access token.</param>
		/// <param name="httpClientFactory">A factory instance used to create <see cref="HttpClient" /> instances. If one is not provided, a service collection will be created and used instead. For more information, see <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests"/> for more information.</param>
		/// <param name="logger">A logging instance. Log entries will be provided at Information level at completion of each api call; and at Trace level with request and content details at the start and end of each api call. If not provided, a <see cref="NullLogger" /> instance will be used.</param>
		/// <param name="apiVersion">The Plaid API version.</param>
		/// <remarks>
		/// Usage patterns: 
		/// A single <see cref="PlaidClient"/> may be used for all API calls, or a separate one may be used for each <see cref="Item"/>. 
		/// If the <paramref name="accessToken"/> is provided, it will be used on every call unless overridden.
		/// However, if not provided here, it may be provided directly for each API call.
		/// </remarks>
		public PlaidClient(
			Environment environment,
			string? clientId = null,
			string? secret = null,
			string? accessToken = null,
			IHttpClientFactory? httpClientFactory = null,
			ILogger<PlaidClient>? logger = null,
			ApiVersion apiVersion = ApiVersion.v20200914)
		{
			var subDomain = environment switch
			{
				Environment.Sandbox => "sandbox",
				Environment.Development => "development",
				Environment.Production => "production",
				_ => throw new ArgumentOutOfRangeException(nameof(environment), "Invalid environment provided."),
			};
			_baseUrl = $"https://{subDomain}.plaid.com/";

			_secret = string.IsNullOrWhiteSpace(secret) ? null : secret;
			_clientId = string.IsNullOrWhiteSpace(clientId) ? null : clientId;
			_accessToken = string.IsNullOrWhiteSpace(accessToken) ? null : accessToken;
			_environment = environment;
			_apiVersion = apiVersion switch
			{
				ApiVersion.v20200914 => "2020-09-14",
				_ => throw new ArgumentOutOfRangeException(nameof(ApiVersion), "Invalid API version provided."),
			};

			if (httpClientFactory == null)
			{
				var collection = new ServiceCollection();
				collection.AddHttpClient();
				_serviceProvider = collection.BuildServiceProvider();
				_clientFactory = _serviceProvider.GetService<IHttpClientFactory>()!;
			}
			else
				_clientFactory = httpClientFactory;

			_logger = logger ?? new NullLogger<PlaidClient>();
		}

		private readonly string _baseUrl, _apiVersion;
		private readonly string? _clientId, _secret, _accessToken;
		private readonly Environment _environment;
		private readonly IHttpClientFactory _clientFactory;
		private readonly IServiceProvider? _serviceProvider;
		private readonly ILogger _logger;

		internal static readonly JsonSerializerOptions JsonSerializerOptions =
			new JsonSerializerOptions()
			{
#if DEBUG
				WriteIndented = true,
#else
				WriteIndented = false,
#endif
				DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
				PropertyNameCaseInsensitive = true,
				Converters = { new EnumConverterFactory(), new DateTimeConverter(), },
			};

		/// <summary>
		/// Debug option to include the raw json in the returned DTO
		/// </summary>
		public bool ShowRawJson { get; set; } = false;
		#endregion

		#region API calls

		/* Item Management */

		/// <summary>
		/// Retrieves information about the status of an <see cref="Entity.Item"/>. Endpoint '<c>/item/get</c>'.
		/// </summary>
		public Task<Management.GetItemResponse> FetchItemAsync(Management.GetItemRequest request) =>
			PostAsync("item/get", request)
				.ParseResponseAsync<Management.GetItemResponse>();

		/// <summary>
		/// Creates a token that can be used with the Link tool in the web client. 
		/// </summary>
		public Task<Management.CreateLinkTokenResponse> CreateLinkTokenAsync(Management.CreateLinkTokenRequest request) =>
			PostAsync("link/token/create", request)
				.ParseResponseAsync<Management.CreateLinkTokenResponse>();

		/// <summary>
		/// Remove an <see cref="Entity.Item"/>. Once deleted, the access_token associated with the <see cref="Entity.Item"/> is no longer valid and cannot be used to access any data that was associated with the <see cref="Entity.Item"/>.
		/// </summary>
		public Task<Management.RemoveItemResponse> RemoveItemAsync(Management.RemoveItemRequest request) =>
			PostAsync("item/remove", request)
				.ParseResponseAsync<Management.RemoveItemResponse>();

		/// <summary>
		/// Updates the webhook associated with an <see cref="Entity.Item"/>. This request triggers a WEBHOOK_UPDATE_ACKNOWLEDGED webhook.
		/// </summary>
		public Task<Management.UpdateWebhookResponse> UpdateWebhookAsync(Management.UpdateWebhookRequest request) =>
			PostAsync("item/webhook/update", request)
				.ParseResponseAsync<Management.UpdateWebhookResponse>();

		/// <summary>
		/// Exchanges a Link public_token for an API access_token.
		/// </summary>
		public Task<Management.ExchangeTokenResponse> ExchangeTokenAsync(Management.ExchangeTokenRequest request) =>
			PostAsync("item/public_token/exchange", request)
				.ParseResponseAsync<Management.ExchangeTokenResponse>();

		/// <summary>
		/// Rotates the access_token associated with an <see cref="Entity.Item"/>. The endpoint returns a new access_token and immediately invalidates the previous access_token.
		/// </summary>
		public Task<Management.RotateAccessTokenResponse> RotateAccessTokenAsync(Management.RotateAccessTokenRequest request) =>
			PostAsync("item/access_token/invalidate", request)
				.ParseResponseAsync<Management.RotateAccessTokenResponse>();

		/* Institutions */

		/// <summary>
		/// Retrieves all institutions (the results will be paginated).
		/// </summary>
		public Task<Institution.GetAllInstitutionsResponse> FetchAllInstitutionsAsync(Institution.GetAllInstitutionsRequest request) =>
			PostAsync("institutions/get", request)
				.ParseResponseAsync<Institution.GetAllInstitutionsResponse>();

		/// <summary>
		/// Retrieves the institutions that match the query parameters.
		/// </summary>
		public Task<Institution.SearchResponse> FetchInstitutionsAsync(Institution.SearchRequest request) =>
			PostAsync("institutions/search", request)
				.ParseResponseAsync<Institution.SearchResponse>();

		/// <summary>
		/// Retrieves the institutions that match the id.
		/// </summary>
		public Task<Institution.SearchByIdResponse> FetchInstitutionByIdAsync(Institution.SearchByIdRequest request) =>
			PostAsync("institutions/get_by_id", request)
				.ParseResponseAsync<Institution.SearchByIdResponse>();

		/* Income */

		/// <summary>
		/// Retrieves information pertaining to a <see cref="Entity.Item"/>’s income. In addition to the annual income, detailed information will be provided for each contributing income stream (or job).
		/// </summary>
		public Task<Income.GetIncomeResponse> FetchUserIncomeAsync(Income.GetIncomeRequest request) =>
			PostAsync("income/get", request)
				.ParseResponseAsync<Income.GetIncomeResponse>();

		/* Investments */

		/// <summary>
		/// Retrieves information pertaining to a <see cref="Entity.Item"/>'s investment holdings.
		/// </summary>
		public Task<Investments.GetInvestmentHoldingsResponse> FetchInvestmentHoldingsAsync(Investments.GetInvestmentHoldingsRequest request) =>
			PostAsync("investments/holdings/get", request)
				.ParseResponseAsync<Investments.GetInvestmentHoldingsResponse>();

		/// <summary>
		/// Retrieves information pertaining to a <see cref="Entity.Item"/>'s investment transactions.
		/// </summary>
		public Task<Investments.GetInvestmentTransactionsResponse> FetchInvestmentTransactionsAsync(Investments.GetInvestmentTransactionsRequest request) =>
			PostAsync("investments/transactions/get", request)
				.ParseResponseAsync<Investments.GetInvestmentTransactionsResponse>();

		/* Auth */

		/// <summary>
		/// Retrieves the bank account and routing numbers associated with an <see cref="Entity.Item"/>’s checking and savings accounts, along with high-level account data and balances.
		/// </summary>
		public Task<Auth.GetAccountInfoResponse> FetchAccountInfoAsync(Auth.GetAccountInfoRequest request) =>
			PostAsync("auth/get", request)
				.ParseResponseAsync<Auth.GetAccountInfoResponse>();

		/* Balance */

		/// <summary>
		/// Retrieve high-level information about all accounts associated with an <see cref="Entity.Item"/>.
		/// </summary>
		public Task<Balance.GetAccountResponse> FetchAccountAsync(Balance.GetAccountRequest request) =>
			PostAsync("accounts/get", request)
				.ParseResponseAsync<Balance.GetAccountResponse>();

		/// <summary>
		///  Retrieves the real-time balance for each of an <see cref="Entity.Item"/>’s accounts.
		/// </summary>
		public Task<Balance.GetBalanceResponse> FetchAccountBalanceAsync(Balance.GetBalanceRequest request) =>
			PostAsync("accounts/balance/get", request)
				.ParseResponseAsync<Balance.GetBalanceResponse>();

		/* Categories */

		/// <summary>
		///  Retrieves detailed information on categories returned by Plaid.
		/// </summary>
		public Task<Category.GetCategoriesResponse> FetchCategoriesAsync(Category.GetCategoriesRequest request) =>
			PostAsync("categories/get", request)
				.ParseResponseAsync<Category.GetCategoriesResponse>();

		/* Identity */

		/// <summary>
		/// Retrieves various account holder information on file with the financial institution, including names, emails, phone numbers, and addresses.
		/// </summary>
		public Task<Identity.GetUserIdentityResponse> FetchUserIdentityAsync(Identity.GetUserIdentityRequest request) =>
			PostAsync("identity/get", request)
				.ParseResponseAsync<Identity.GetUserIdentityResponse>();

		/* Transactions */

		/// <summary>
		///  Retrieves user-authorized transaction data for credit and depository-type <see cref="Entity.Account"/>.
		/// </summary>
		public Task<Transactions.GetTransactionsResponse> FetchTransactionsAsync(Transactions.GetTransactionsRequest request) =>
			PostAsync("transactions/get", request)
				.ParseResponseAsync<Transactions.GetTransactionsResponse>();

		/* Stripe */

		/// <summary>
		///  Exchanges a Link access_token for an Stripe API stripe_bank_account_token.
		/// </summary>
		public Task<Management.StripeTokenResponse> FetchStripeTokenAsync(Management.StripeTokenRequest request) =>
			PostAsync("processor/stripe/bank_account_token/create", request)
				.ParseResponseAsync<Management.StripeTokenResponse>();

		/* Liabilities */

		/// <summary>
		///  Returns various details about an <see cref="Item"/> with loan or credit accounts. 
		///  Liabilities is supported for US and Canada accounts only. Currently supported account types 
		///  are account type credit with account subtype credit card or paypal, and account type loan 
		///  with account subtype student or mortgage. 
		/// </summary>
		public Task<Liabilities.GetLiabilitiesResponse> FetchLiabilitiesAsync(Liabilities.GetLiabilitiesRequest request) =>
			PostAsync("liabilities/get", request)
				.ParseResponseAsync<Liabilities.GetLiabilitiesResponse>();

		#endregion

		#region Private Members

		private ResponseParser PostAsync<TRequest>(string path, TRequest request) where TRequest : RequestBase
		{
			request.SetCredentials(_secret, _clientId, _accessToken);

			var client = _clientFactory.CreateClient();
			var url = _baseUrl + path;
			_logger.LogTrace("Initiating request. Method: {method}; Url: {url}; Content: {@content}", "POST", url, request);

			var requestMessage = new HttpRequestMessage
			{
				Method = HttpMethod.Post,
				RequestUri = new Uri(url),
				Headers =
				{
					{ "Plaid-Version", _apiVersion },
				},
				Content = JsonContent.Create(request, options: JsonSerializerOptions),
			};
			return new ResponseParser
			{
				Message = client.SendAsync(requestMessage),
				Url = url,
				IncludeRawJson = request.ShowRawJson ?? ShowRawJson,
				Logger = _logger,
			};
		}

		private struct ResponseParser
		{
			public Task<HttpResponseMessage> Message { get; init; }
			public string Url { get; init; }
			public bool IncludeRawJson { get; init; }
			public ILogger Logger { get; init; }

			public async Task<TResponse> ParseResponseAsync<TResponse>() where TResponse : ResponseBase, new()
			{
				using (var response = await Message.ConfigureAwait(false))
				{
					Logger.LogInformation("Completed request. Url: {url}, Status Code: {statusCode}.", Url, response.StatusCode);

					var result = await BuildResponse<TResponse>(response);
					Logger.LogTrace("Completed request details. Url: {url}; Response: {@result}",
						Url,
						result);
					return result;
				}
			}

			private async Task<TResponse> BuildResponse<TResponse>(HttpResponseMessage response) where TResponse : ResponseBase, new()
			{
				if (response.IsSuccessStatusCode)
				{
					if (IncludeRawJson)
					{
						var json = await response.Content.ReadAsStringAsync();
						var result = JsonSerializer.Deserialize<TResponse>(json, options: JsonSerializerOptions);
						result!.RawJson = json;
						result.StatusCode = response.StatusCode;
						return result;
					}
					else
					{
						var result = await response.Content.ReadFromJsonAsync<TResponse>(options: JsonSerializerOptions);
						result!.StatusCode = response.StatusCode;
						return result;
					}
				}
				else
				{
					var exception = await response.Content.ReadFromJsonAsync<Exceptions.PlaidException>(options: JsonSerializerOptions);
					var result = new TResponse
					{
						Exception = exception,
						StatusCode = response.StatusCode,
					};
					return result;
				}
			}
		}

		#endregion Private Members
	}
}
