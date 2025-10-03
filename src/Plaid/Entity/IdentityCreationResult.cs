namespace Going.Plaid.Entity;

/// <summary>
/// <para>The result of creating an identity, indicating success or failure with optional error details.</para>
/// </summary>
public record IdentityCreationResult
{
	/// <summary>
	/// <para>The outcome of the identity creation operation.</para>
	/// </summary>
	[JsonPropertyName("result")]
	public Entity.IdentityCreationResultType Result { get; init; } = default!;

	/// <summary>
	/// <para>A broad categorization of the error. Safe for programmatic use.</para>
	/// </summary>
	[JsonPropertyName("error_type")]
	public Entity.PlaidErrorType? ErrorType { get; init; } = default!;

	/// <summary>
	/// <para>Specific error code indicating the nature of the failure. Safe for programmatic use.</para>
	/// </summary>
	[JsonPropertyName("error_code")]
	public string? ErrorCode { get; init; } = default!;

	/// <summary>
	/// <para>Human-readable error message providing details about the failure.</para>
	/// </summary>
	[JsonPropertyName("error_message")]
	public string? ErrorMessage { get; init; } = default!;

}
