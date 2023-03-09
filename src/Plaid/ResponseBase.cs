namespace Going.Plaid;

/// <summary>
/// Provides common members for all Plaid API responses.
/// </summary>
public abstract record ResponseBase
{
	/// <summary>
	/// Holds the raw json returned by the server
	/// </summary>
	[JsonIgnore]
	public string? RawJson { get; set; }

	/// <summary>
	/// An error response given by the server
	/// </summary>
	[JsonPropertyName("error")]
	public PlaidError? Error { get; init; }

	/// <summary>
	/// The request identifier.
	/// </summary>
	[JsonPropertyName("request_id")]
	public string? RequestId { get; init; }

	/// <summary>
	/// The http status code.
	/// </summary>
	public HttpStatusCode StatusCode { get; internal set; }

	/// <summary>
	/// A value indicating whether this instance is success status code.
	/// </summary>
	/// <value><c>true</c> if this instance is success status code.</value>
	public bool IsSuccessStatusCode => StatusCode == HttpStatusCode.OK;
}
