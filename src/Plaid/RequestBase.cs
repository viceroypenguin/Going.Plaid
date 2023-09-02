namespace Going.Plaid;

/// <summary>
/// Provides methods and properties for making a standard request.
/// </summary>
public abstract class RequestBase
{
	/// <summary>
	/// The Plaid API secret. Provided in the developer area of the Plaid website.
	/// </summary>
	[JsonPropertyName("secret")]
	public string? Secret { get; set; }

	/// <summary>
	/// The Plaid API client_id. Provided in the developer area of the Plaid website.
	/// </summary>
	[JsonPropertyName("client_id")]
	public string? ClientId { get; set; }

	/// <summary>
	/// The Plaid API access_token. Provided by LINK process to identify an <see cref="Entity.Item"/> from the developer side.
	/// </summary>
	[JsonPropertyName("access_token")]
	public string? AccessToken { get; set; }

	/// <summary>
	/// Enable to receive the raw JSON provided by the Plaid server.
	/// Values:
	/// <list type="table">
	/// <item><term><c>false</c></term><description>Do not return the raw JSON.</description></item>
	/// <item><term><c>true</c></term><description>Return the raw JSON.</description></item>
	/// <item><term><c>null</c>/<c>default</c></term><description>Use the value in <see cref="PlaidClient.ShowRawJson"/>.</description></item>
	/// </list>
	/// </summary>
	[JsonIgnore]
	public bool? ShowRawJson { get; set; }

	/// <summary>
	/// Pass additional request headers.
	/// </summary>
	[JsonIgnore]
	public Dictionary<string, string>? AdditionalHeaders { get; set; }

	/// <summary>
	/// Indicates whether to include the AccessToken on an API call.
	/// </summary>
	protected internal virtual bool IncludeAccessToken => true;

	/// <summary>
	/// Indicates whether to include the Secret/ClientId on an API call.
	/// </summary>
	protected internal virtual bool IncludeSecrets => true;

	/// <summary>
	/// Updates the credential values if they have
	/// not already been provided.
	/// </summary>
	/// <param name="secret"></param>
	/// <param name="clientId"></param>
	/// <param name="accessToken"></param>
	internal void SetCredentials(
		string? secret,
		string? clientId,
		string? accessToken)
	{
		if (IncludeSecrets && string.IsNullOrWhiteSpace(Secret)) Secret = secret;
		if (IncludeSecrets && string.IsNullOrWhiteSpace(ClientId)) ClientId = clientId;
		if (IncludeAccessToken && string.IsNullOrWhiteSpace(AccessToken)) AccessToken = accessToken;
	}
}
