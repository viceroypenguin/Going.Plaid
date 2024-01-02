using System.Diagnostics.CodeAnalysis;

namespace Going.Plaid.Entity;

/// <summary>
/// The exception that is thrown when a response from the Plaid API contains an error.
/// </summary>
[Serializable]
public record PlaidError
{
	/// <summary>
	/// A broad categorization of the error.
	/// </summary>
	/// <remarks>
	/// See also: <seealso href="https://plaid.com/docs/errors/"/> for more information regarding individual values.
	/// </remarks>
	[JsonPropertyName("error_type")]
	public string ErrorType { get; init; } = null!;

	/// <summary>
	/// The particular error code. Safe for programmatic use.
	/// </summary>
	/// <remarks>
	/// See also: <seealso href="https://plaid.com/docs/errors/"/> for more information regarding individual values.
	/// </remarks>
	[JsonPropertyName("error_code")]
	public string ErrorCode { get; init; } = null!;

	/// <summary>
	/// A developer-friendly representation of the error code.
	/// </summary>
	/// <remarks>This may change over time and is not safe for programmatic use.</remarks>
	[JsonPropertyName("error_message")]
	public string ErrorMessage { get; init; } = null!;

	/// <summary>
	/// A user-friendly representation of the error code. <see langword="null"/> if the error is not related to user action.
	/// </summary>
	/// <remarks>
	/// This may change over time and is not safe for programmatic use.
	/// </remarks>
	[JsonPropertyName("display_message")]
	public string? DisplayMessage { get; init; }

	/// <summary>
	/// A unique string identifying the request, to be used for troubleshooting purposes. 
	/// </summary>
	/// <remarks>This field will be omitted in errors provided by webhooks.</remarks>
	[JsonPropertyName("request_id")]
	public string? RequestId { get; init; }

	/// <summary>
	/// In the Assets product, a request can pertain to more than one Item. If an error is returned for such a request, causes will return an array of errors containing a breakdown of these errors on the individual Item level, if any can be identified.
	/// </summary>
	/// <remarks><see cref="Causes"/> will only be provided for the <see cref="ErrorType"/> <c>ASSET_REPORT_ERROR</c>. <see cref="Causes"/> will also not be populated inside an error nested within a <see cref="Warning"/> object.</remarks>
	[JsonPropertyName("causes")]
	[SuppressMessage("Security", "CA5362:Potential reference cycle in deserialized object graph", Justification = "Actual data will not cause a reference cycle.")]
	public IReadOnlyList<Cause>? Causes { get; init; }

	/// <summary>
	/// The HTTP status code associated with the error. 
	/// </summary>
	/// <remarks>This will only be returned in the response body when the error information is provided via a webhook.</remarks>
	[JsonPropertyName("status")]
	public int? StatusCode { get; init; }

	/// <summary>
	/// The URL of a Plaid documentation page with more information about the error
	/// </summary>
	[JsonPropertyName("documentation_url")]
	public string? DocumentationUrl { get; init; }

	/// <summary>
	/// Suggested steps for resolving the error
	/// </summary>
	[JsonPropertyName("suggested_action")]
	public string? SuggestedAction { get; init; }
}
