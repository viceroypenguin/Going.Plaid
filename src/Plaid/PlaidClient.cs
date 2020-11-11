using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
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
			ApiVersion apiVersion = ApiVersion.v20190529)
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
				ApiVersion.v20190529 => "2019-05-29",
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
				Converters = { new EnumConvertFactory(), new DateTimeConverter(), },
			};

#if DEBUG
		/// <summary>
		/// Debug option to include the raw json in the returned DTO
		/// </summary>
		public bool ShowRawJsonValues { get; init; } = false;
#endif
		#endregion

		#region API calls

		/* Item Management */

		/// <summary>
		/// Retrieves information about the status of an <see cref="Entity.Item"/>. Endpoint '<c>/item/get</c>'.
		/// </summary>
		/// <param name="request">The request.</param>
		public Task<Management.GetItemResponse> FetchItemAsync(Management.GetItemRequest request) =>
			ParseResponse<Management.GetItemResponse>(
				PostAsync("item/get", request));

		/// <summary>
		/// Delete an <see cref="Entity.Item"/>. Once deleted, the access_token associated with the <see cref="Entity.Item"/> is no longer valid and cannot be used to access any data that was associated with the <see cref="Entity.Item"/>.
		/// </summary>
		/// <param name="request">The request.</param>
		public Task<Management.DeleteItemResponse> DeleteItemAsync(Management.DeleteItemRequest request) =>
			ParseResponse<Management.DeleteItemResponse>(
				PostAsync("item/delete", request));

		/// <summary>
		/// Creates a token that can be used with the Link tool in the web client. 
		/// </summary>
		/// <param name="request"></param>
		public Task<Management.CreateLinkTokenResponse> CreateLinkTokenAsync(Management.CreateLinkTokenRequest request) =>
			ParseResponse<Management.CreateLinkTokenResponse>(
				PostAsync("link/token/create", request));

		/// <summary>
		/// Updates the webhook associated with an <see cref="Entity.Item"/>. This request triggers a WEBHOOK_UPDATE_ACKNOWLEDGED webhook.
		/// </summary>
		/// <param name="request">The request.</param>
		public Task<Management.UpdateWebhookResponse> UpdateWebhookAsync(Management.UpdateWebhookRequest request) =>
			ParseResponse<Management.UpdateWebhookResponse>(
				PostAsync("item/webhook/update", request));

		/// <summary>
		/// Exchanges a Link public_token for an API access_token.
		/// </summary>
		/// <param name="request">The request.</param>
		/// <returns>Task&lt;Management.ExchangeTokenResponse&gt;.</returns>
		public Task<Management.ExchangeTokenResponse> ExchangeTokenAsync(Management.ExchangeTokenRequest request) =>
			ParseResponse<Management.ExchangeTokenResponse>(
				PostAsync("item/public_token/exchange", request));

		/// <summary>
		/// Rotates the access_token associated with an <see cref="Entity.Item"/>. The endpoint returns a new access_token and immediately invalidates the previous access_token.
		/// </summary>
		/// <param name="request">The request.</param>
		public Task<Management.RotateAccessTokenResponse> RotateAccessTokenAsync(Management.RotateAccessTokenRequest request) =>
			ParseResponse<Management.RotateAccessTokenResponse>(
				PostAsync("item/access_token/invalidate", request));

		/* Institutions */

		/// <summary>
		/// Retrieves all institutions (the results will be paginated).
		/// </summary>
		/// <param name="request">The request.</param>
		public Task<Institution.GetAllInstitutionsResponse> FetchAllInstitutionsAsync(Institution.GetAllInstitutionsRequest request) =>
			ParseResponse<Institution.GetAllInstitutionsResponse>(
				PostAsync("institutions/get", request));

		/// <summary>
		/// Retrieves the institutions that match the query parameters.
		/// </summary>
		/// <param name="request">The request.</param>
		public Task<Institution.SearchResponse> FetchInstitutionsAsync(Institution.SearchRequest request) =>
			ParseResponse<Institution.SearchResponse>(
				PostAsync("institutions/search", request));

		/// <summary>
		/// Retrieves the institutions that match the id.
		/// </summary>
		/// <param name="request">The request.</param>
		public Task<Institution.SearchByIdResponse> FetchInstitutionByIdAsync(Institution.SearchByIdRequest request) =>
			ParseResponse<Institution.SearchByIdResponse>(
				PostAsync("institutions/get_by_id", request));

		/* Income */

		/// <summary>
		/// Retrieves information pertaining to a <see cref="Entity.Item"/>’s income. In addition to the annual income, detailed information will be provided for each contributing income stream (or job).
		/// </summary>
		/// <param name="request">The request.</param>
		public Task<Income.GetIncomeResponse> FetchUserIncomeAsync(Income.GetIncomeRequest request) =>
			ParseResponse<Income.GetIncomeResponse>(
				PostAsync("income/get", request));

		/* Investments */

		/// <summary>
		/// Retrieves information pertaining to a <see cref="Entity.Item"/>'s investment holdings.
		/// </summary>
		public Task<Investments.GetInvestmentHoldingsResponse> FetchInvestmentHoldingsAsync(Investments.GetInvestmentHoldingsRequest request) =>
			ParseResponse<Investments.GetInvestmentHoldingsResponse>(
				PostAsync("investments/holdings/get", request));

		/// <summary>
		/// Retrieves information pertaining to a <see cref="Entity.Item"/>'s investment transactions.
		/// </summary>
		public Task<Investments.GetInvestmentTransactionsResponse> FetchInvestmentTransactionsAsync(Investments.GetInvestmentTransactionsRequest request) =>
			ParseResponse<Investments.GetInvestmentTransactionsResponse>(
				PostAsync("investments/transactions/get", request));

		/* Auth */

		/// <summary>
		/// Retrieves the bank account and routing numbers associated with an <see cref="Entity.Item"/>’s checking and savings accounts, along with high-level account data and balances.
		/// </summary>
		/// <param name="request">The request.</param>
		/// <returns>Task&lt;Auth.GetAccountInfoResponse&gt;.</returns>
		public Task<Auth.GetAccountInfoResponse> FetchAccountInfoAsync(Auth.GetAccountInfoRequest request) =>
			ParseResponse<Auth.GetAccountInfoResponse>(
				PostAsync("auth/get", request));

		/* Balance */

		/// <summary>
		/// Retrieve high-level information about all accounts associated with an <see cref="Entity.Item"/>.
		/// </summary>
		/// <param name="request">The request.</param>
		/// <returns>Task&lt;Balance.GetAccountResponse&gt;.</returns>
		public Task<Balance.GetAccountResponse> FetchAccountAsync(Balance.GetAccountRequest request) =>
			ParseResponse<Balance.GetAccountResponse>(
				PostAsync("accounts/get", request));

		/// <summary>
		///  Retrieves the real-time balance for each of an <see cref="Entity.Item"/>’s accounts.
		/// </summary>
		/// <param name="request">The request.</param>
		/// <returns>Task&lt;Balance.GetBalanceResponse&gt;.</returns>
		public Task<Balance.GetBalanceResponse> FetchAccountBalanceAsync(Balance.GetBalanceRequest request) =>
			ParseResponse<Balance.GetBalanceResponse>(
				PostAsync("accounts/balance/get", request));

		/* Categories */

		/// <summary>
		///  Retrieves detailed information on categories returned by Plaid.
		/// </summary>
		/// <param name="request">The request.</param>
		/// <returns>Task&lt;Category.GetCategoriesResponse&gt;.</returns>
		public Task<Category.GetCategoriesResponse> FetchCategoriesAsync(Category.GetCategoriesRequest request) =>
			ParseResponse<Category.GetCategoriesResponse>(
				PostAsync("categories/get", request));

		/* Identity */

		/// <summary>
		/// Retrieves various account holder information on file with the financial institution, including names, emails, phone numbers, and addresses.
		/// </summary>
		/// <param name="request">The request.</param>
		/// <returns>Task&lt;Identity.GetUserIdentityResponse&gt;.</returns>
		public Task<Identity.GetUserIdentityResponse> FetchUserIdentityAsync(Identity.GetUserIdentityRequest request) =>
			ParseResponse<Identity.GetUserIdentityResponse>(
				PostAsync("identity/get", request));

		/* Transactions */

		/// <summary>
		///  Retrieves user-authorized transaction data for credit and depository-type <see cref="Entity.Account"/>.
		/// </summary>
		/// <param name="request">The request.</param>
		/// <returns>Task&lt;Transactions.GetTransactionsResponse&gt;.</returns>
		public Task<Transactions.GetTransactionsResponse> FetchTransactionsAsync(Transactions.GetTransactionsRequest request) =>
			ParseResponse<Transactions.GetTransactionsResponse>(
				PostAsync("transactions/get", request));

		/* Stripe */

		/// <summary>
		///  Exchanges a Link access_token for an Stripe API stripe_bank_account_token.
		/// </summary>
		/// <param name="request">The request.</param>
		/// <returns>Task&lt;Management.StripeTokenResponse&gt;.</returns>
		public Task<Management.StripeTokenResponse> FetchStripeTokenAsync(Management.StripeTokenRequest request) =>
			ParseResponse<Management.StripeTokenResponse>(
				PostAsync("processor/stripe/bank_account_token/create", request));

		#endregion

		#region Private Members

		private Task<HttpResponseMessage> PostAsync<TRequest>(string path, TRequest request) where TRequest : RequestBase
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
			return client.SendAsync(requestMessage);
		}

		private async Task<TResponse> ParseResponse<TResponse>(Task<HttpResponseMessage> message) where TResponse : ResponseBase, new()
			{
			using (var response = await message.ConfigureAwait(false))
			{
				var url = response.RequestMessage.RequestUri.ToString();
				_logger.LogInformation("Completed request. Url: {url}, Status Code: {statusCode}.", url, response.StatusCode);

				var result = await BuildResponse<TResponse>(url, response);
				_logger.LogTrace("Completed request details. Method: {method}; Url: {url}; Response: {@result}",
					response.RequestMessage.Method,
					url,
					result);
				return result;
			}
		}

		private async Task<TResponse> BuildResponse<TResponse>(string url, HttpResponseMessage response) where TResponse : ResponseBase, new()
		{
			if (response.IsSuccessStatusCode)
			{
#if DEBUG
				if (ShowRawJsonValues)
				{
					var json = await response.Content.ReadAsStringAsync();
					var result = JsonSerializer.Deserialize<TResponse>(json, options: JsonSerializerOptions);
					result!.RawJsonForDebugging = json;
					result.StatusCode = response.StatusCode;
					return result;
				}
				else
#endif
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

		#endregion Private Members
	}
}
