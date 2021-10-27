namespace Going.Plaid;

/// <summary>
/// Provides methods for sending request to and receiving data from Plaid banking API.
/// </summary>
public sealed partial class PlaidClient
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
		_baseUrl = new Uri($"https://{subDomain}.plaid.com/");

		_apiVersion = apiVersion switch
		{
			ApiVersion.v20200914 => "2020-09-14",
			_ => throw new ArgumentOutOfRangeException(nameof(ApiVersion), "Invalid API version provided."),
		};
		_environment = environment;
		_secret = secret;
		_clientId = clientId;
		AccessToken = string.IsNullOrWhiteSpace(accessToken) ? null : accessToken;

		if (httpClientFactory == null)
		{
			var collection = new ServiceCollection();
			collection.AddPlaidHttpClient();
			_serviceProvider = collection.BuildServiceProvider();
			_clientFactory = _serviceProvider.GetService<IHttpClientFactory>()!;
		}
		else
			_clientFactory = httpClientFactory;

		_logger = logger ?? new NullLogger<PlaidClient>();
	}

	private readonly Uri _baseUrl;
	private readonly string _apiVersion;
	private readonly string? _clientId, _secret;
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
		}
		.AddPlaidConverters();

	/// <summary>
	/// The access token used for all API calls.
	/// </summary>
	public string? AccessToken { get; set; }

	/// <summary>
	/// Debug option to include the raw json in the returned DTO
	/// </summary>
	public bool ShowRawJson { get; set; } = false;
	#endregion

	#region Private Members

	private ResponseParser PostAsync<TRequest>(string path, TRequest request) where TRequest : RequestBase
	{
		request.SetCredentials(_secret, _clientId, AccessToken);

		var client = _clientFactory.CreateClient("PlaidClient");
		var url = new Uri(_baseUrl, path);
		_logger.LogTrace("Initiating request. Method: {method}; Url: {url}; Content: {@content}", "POST", url, request);

		var requestMessage = new HttpRequestMessage
		{
			Method = HttpMethod.Post,
			RequestUri = url,
			Headers =
				{
					{ "Plaid-Version", _apiVersion },
				},
			Content = JsonContent.Create(request, options: JsonSerializerOptions),
		};
		return new ResponseParser
		{
			Message = client.SendAsync(requestMessage),
			Url = url.ToString(),
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
