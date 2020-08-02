using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Going.Plaid.Entity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Going.Plaid
{
	/// <summary>
	/// Provides methods for sending request to and receiving data from Plaid banking API.
	/// </summary>
	public class PlaidClient
	{
		#region Initialization
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

			_secret = secret;
			_clientId = clientId;
			_accessToken = accessToken;
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
				_clientFactory = _serviceProvider.GetService<IHttpClientFactory>();
			}
			else
				_clientFactory = httpClientFactory;

			_logger = logger ?? new NullLogger<PlaidClient>();
		}

		private readonly string _baseUrl, _apiVersion;
		private readonly string? _clientId, _secret, _accessToken;
		private readonly IHttpClientFactory _clientFactory;
		private readonly IServiceProvider? _serviceProvider;
		private readonly ILogger _logger;

		private readonly JsonSerializer _jsonSerializer = new JsonSerializer() { Converters = { new EnumMemberEnumConverter(), }, };

#if DEBUG
		/// <summary>
		/// Debug option to include the raw json in the returned DTO
		/// </summary>
		public bool ShowRawJsonValues { get; set; } = false;
#endif
		#endregion

		#region API calls

		/* Item Management */

		/// <summary>
		/// Retrieves information about the status of an <see cref="Entity.Item"/>. Endpoint '<c>/item/get</c>'.
		/// </summary>
		/// <param name="request">The request.</param>
		public Task<Management.GetItemResponse> FetchItemAsync(Management.GetItemRequest request) =>
			PostAsync<Management.GetItemResponse>("item/get", request);

		/// <summary>
		/// Delete an <see cref="Entity.Item"/>. Once deleted, the access_token associated with the <see cref="Entity.Item"/> is no longer valid and cannot be used to access any data that was associated with the <see cref="Entity.Item"/>.
		/// </summary>
		/// <param name="request">The request.</param>
		public Task<Management.DeleteItemResponse> DeleteItemAsync(Management.DeleteItemRequest request) =>
			PostAsync<Management.DeleteItemResponse>("item/delete", request);

		/// <summary>
		/// Creates a token that can be used with the Link tool in the web client. 
		/// </summary>
		/// <param name="request"></param>
		public Task<Management.CreateLinkTokenResponse> CreateLinkTokenAsync(Management.CreateLinkTokenRequest request) =>
			PostAsync<Management.CreateLinkTokenResponse>("link/token/create", request);

		/// <summary>
		/// Updates the webhook associated with an <see cref="Entity.Item"/>. This request triggers a WEBHOOK_UPDATE_ACKNOWLEDGED webhook.
		/// </summary>
		/// <param name="request">The request.</param>
		public Task<Management.UpdateWebhookResponse> UpdateWebhookAsync(Management.UpdateWebhookRequest request) =>
			PostAsync<Management.UpdateWebhookResponse>("item/webhook/update", request);

		/// <summary>
		/// Exchanges a Link public_token for an API access_token.
		/// </summary>
		/// <param name="request">The request.</param>
		/// <returns>Task&lt;Management.ExchangeTokenResponse&gt;.</returns>
		public Task<Management.ExchangeTokenResponse> ExchangeTokenAsync(Management.ExchangeTokenRequest request) =>
			PostAsync<Management.ExchangeTokenResponse>("item/public_token/exchange", request);

		/// <summary>
		/// Rotates the access_token associated with an <see cref="Entity.Item"/>. The endpoint returns a new access_token and immediately invalidates the previous access_token.
		/// </summary>
		/// <param name="request">The request.</param>
		public Task<Management.RotateAccessTokenResponse> RotateAccessTokenAsync(Management.RotateAccessTokenRequest request) =>
			PostAsync<Management.RotateAccessTokenResponse>("item/access_token/invalidate", request);

		/* Institutions */

		/// <summary>
		/// Retrieves all institutions (the results will be paginated).
		/// </summary>
		/// <param name="request">The request.</param>
		public Task<Institution.GetAllInstitutionsResponse> FetchAllInstitutionsAsync(Institution.GetAllInstitutionsRequest request) =>
			PostAsync<Institution.GetAllInstitutionsResponse>("institutions/get", request);

		/// <summary>
		/// Retrieves the institutions that match the query parameters.
		/// </summary>
		/// <param name="request">The request.</param>
		public Task<Institution.SearchResponse> FetchInstitutionsAsync(Institution.SearchRequest request) =>
			PostAsync<Institution.SearchResponse>("institutions/search", request);

		/// <summary>
		/// Retrieves the institutions that match the id.
		/// </summary>
		/// <param name="request">The request.</param>
		public Task<Institution.SearchByIdResponse> FetchInstitutionByIdAsync(Institution.SearchByIdRequest request) =>
			PostAsync<Institution.SearchByIdResponse>("institutions/get_by_id", request);

		/* Income */

		/// <summary>
		/// Retrieves information pertaining to a <see cref="Entity.Item"/>’s income. In addition to the annual income, detailed information will be provided for each contributing income stream (or job).
		/// </summary>
		/// <param name="request">The request.</param>
		public Task<Income.GetIncomeResponse> FetchUserIncomeAsync(Income.GetIncomeRequest request) =>
			PostAsync<Income.GetIncomeResponse>("income/get", request);

		/* Investments */

		/// <summary>
		/// Retrieves information pertaining to a <see cref="Entity.Item"/>'s investment holdings.
		/// </summary>
		public Task<Investments.GetInvestmentHoldingsResponse> FetchInvestmentHoldingsAsync(Investments.GetInvestmentHoldingsRequest request) =>
			PostAsync<Investments.GetInvestmentHoldingsResponse>("investments/holdings/get", request);

		/// <summary>
		/// Retrieves information pertaining to a <see cref="Entity.Item"/>'s investment transactions.
		/// </summary>
		public Task<Investments.GetInvestmentTransactionsResponse> FetchInvestmentTransactionsAsync(Investments.GetInvestmentTransactionsRequest request) =>
			PostAsync<Investments.GetInvestmentTransactionsResponse>("investments/transactions/get", request);

		/* Auth */

		/// <summary>
		/// Retrieves the bank account and routing numbers associated with an <see cref="Entity.Item"/>’s checking and savings accounts, along with high-level account data and balances.
		/// </summary>
		/// <param name="request">The request.</param>
		/// <returns>Task&lt;Auth.GetAccountInfoResponse&gt;.</returns>
		public Task<Auth.GetAccountInfoResponse> FetchAccountInfoAsync(Auth.GetAccountInfoRequest request) =>
			PostAsync<Auth.GetAccountInfoResponse>("auth/get", request);

		/* Balance */

		/// <summary>
		/// Retrieve high-level information about all accounts associated with an <see cref="Entity.Item"/>.
		/// </summary>
		/// <param name="request">The request.</param>
		/// <returns>Task&lt;Balance.GetAccountResponse&gt;.</returns>
		public Task<Balance.GetAccountResponse> FetchAccountAsync(Balance.GetAccountRequest request) =>
			PostAsync<Balance.GetAccountResponse>("accounts/get", request);

		/// <summary>
		///  Retrieves the real-time balance for each of an <see cref="Entity.Item"/>’s accounts.
		/// </summary>
		/// <param name="request">The request.</param>
		/// <returns>Task&lt;Balance.GetBalanceResponse&gt;.</returns>
		public Task<Balance.GetBalanceResponse> FetchAccountBalanceAsync(Balance.GetBalanceRequest request) =>
			PostAsync<Balance.GetBalanceResponse>("accounts/balance/get", request);

		/* Categories */

		/// <summary>
		///  Retrieves detailed information on categories returned by Plaid.
		/// </summary>
		/// <param name="request">The request.</param>
		/// <returns>Task&lt;Category.GetCategoriesResponse&gt;.</returns>
		public Task<Category.GetCategoriesResponse> FetchCategoriesAsync(Category.GetCategoriesRequest request) =>
			PostAsync<Category.GetCategoriesResponse>("categories/get", request);

		/* Identity */

		/// <summary>
		/// Retrieves various account holder information on file with the financial institution, including names, emails, phone numbers, and addresses.
		/// </summary>
		/// <param name="request">The request.</param>
		/// <returns>Task&lt;Identity.GetUserIdentityResponse&gt;.</returns>
		public Task<Identity.GetUserIdentityResponse> FetchUserIdentityAsync(Identity.GetUserIdentityRequest request) =>
			PostAsync<Identity.GetUserIdentityResponse>("identity/get", request);

		/* Transactions */

		/// <summary>
		///  Retrieves user-authorized transaction data for credit and depository-type <see cref="Entity.Account"/>.
		/// </summary>
		/// <param name="request">The request.</param>
		/// <returns>Task&lt;Transactions.GetTransactionsResponse&gt;.</returns>
		public Task<Transactions.GetTransactionsResponse> FetchTransactionsAsync(Transactions.GetTransactionsRequest request) =>
			PostAsync<Transactions.GetTransactionsResponse>("transactions/get", request);

		/* Stripe */

		/// <summary>
		///  Exchanges a Link access_token for an Stripe API stripe_bank_account_token.
		/// </summary>
		/// <param name="request">The request.</param>
		/// <returns>Task&lt;Management.StripeTokenResponse&gt;.</returns>
		public Task<Management.StripeTokenResponse> FetchStripeTokenAsync(Management.StripeTokenRequest request) =>
			PostAsync<Management.StripeTokenResponse>("processor/stripe/bank_account_token/create", request);

		#endregion

		#region Private Members

		private async Task<TResponse> PostAsync<TResponse>(string path, RequestBase request) where TResponse : ResponseBase, new()
		{
			EnsureCredentials(request);

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
				Content = new StringContent(request.ToJson(), Encoding.UTF8, "application/json"),
			};
			using (var response = await client.SendAsync(requestMessage))
			{
				_logger.LogInformation("Completed request. Url: {url}, Status Code: {statusCode}.", url, response.StatusCode);

				var result = await BuildResponse<TResponse>(url, response);
				_logger.LogTrace("Completed request details. Method: {method}; Url: {url}; Content: {@content}; Response: {@result}");
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
					var result = JsonConvert.DeserializeObject<TResponse>(
						json,
						new JsonSerializerSettings()
						{
							DateFormatString = "yyyy-MM-dd",
							NullValueHandling = NullValueHandling.Ignore,
							Converters =
							{
								new EnumMemberEnumConverter(),
							},
						});
					result!.RawJsonForDebugging = json;
					result.StatusCode = response.StatusCode;
					return result;
				}
				else
#endif
				{
					var result = await OptimizedDeserializeResponse<TResponse>(response);
					result.StatusCode = response.StatusCode;
					return result;
				}
			}
			else
			{
				var json = await response.Content.ReadAsStringAsync();
				var error = JObject.Parse(json);
				var result = new TResponse
				{
					Exception = new Exceptions.PlaidException(error["error_message"]!.Value<string>())
					{
						HelpLink = "https://plaid.com/docs/api/#errors-overview",
						DisplayMessage = error["display_message"]!.Value<string>(),
						ErrorType = error["error_type"]!.Value<string>(),
						ErrorCode = error["error_code"]!.Value<string>(),
						Source = url,
					}
				};
				return result;
			}
		}

		private async Task<TResponse> OptimizedDeserializeResponse<TResponse>(HttpResponseMessage response) where TResponse : ResponseBase
		{
			using (var responseStream = await response.Content.ReadAsStreamAsync())
			using (var streamReader = new StreamReader(responseStream))
			using (var jsonTextReader = new JsonTextReader(streamReader))
			{
				return _jsonSerializer.Deserialize<TResponse>(jsonTextReader)!;
			}
		}

		private void EnsureCredentials(RequestBase req)
		{
			if (string.IsNullOrWhiteSpace(req.Secret)) req.Secret = _secret;
			if (string.IsNullOrWhiteSpace(req.ClientId)) req.ClientId = _clientId;

			if (req.UseAccessToken)
			{
				if (string.IsNullOrWhiteSpace(req.AccessToken))
					req.AccessToken = _accessToken;
			}
			else
				req.AccessToken = null;
		}

		#endregion Private Members
	}
}
