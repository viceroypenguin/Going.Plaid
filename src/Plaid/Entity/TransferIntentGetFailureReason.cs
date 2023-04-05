namespace Going.Plaid.Entity;

/// <summary>
/// <para>The reason for a failed transfer intent. Returned only if the transfer intent status is <c>failed</c>. Null otherwise.</para>
/// </summary>
public record TransferIntentGetFailureReason
{
	/// <summary>
	/// <para>A broad categorization of the error.</para>
	/// </summary>
	[JsonPropertyName("error_type")]
	public string? ErrorType { get; init; } = default!;

	/// <summary>
	/// <para>A code representing the reason for a failed transfer intent (i.e., an API error or the authorization being declined).</para>
	/// </summary>
	[JsonPropertyName("error_code")]
	public string? ErrorCode { get; init; } = default!;

	/// <summary>
	/// <para>A human-readable description of the code associated with a failed transfer intent.</para>
	/// </summary>
	[JsonPropertyName("error_message")]
	public string? ErrorMessage { get; init; } = default!;
}