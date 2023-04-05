namespace Going.Plaid.Entity;

/// <summary>
/// <para>The details of a Link error.</para>
/// </summary>
public record CreditSessionError
{
	/// <summary>
	/// <para>A broad categorization of the error.</para>
	/// </summary>
	[JsonPropertyName("error_type")]
	public string? ErrorType { get; init; } = default!;

	/// <summary>
	/// <para>The particular error code.</para>
	/// </summary>
	[JsonPropertyName("error_code")]
	public string? ErrorCode { get; init; } = default!;

	/// <summary>
	/// <para>A developer-friendly representation of the error code.</para>
	/// </summary>
	[JsonPropertyName("error_message")]
	public string? ErrorMessage { get; init; } = default!;

	/// <summary>
	/// <para>A user-friendly representation of the error code. <c>null</c> if the error is not related to user action.</para>
	/// </summary>
	[JsonPropertyName("display_message")]
	public string? DisplayMessage { get; init; } = default!;
}