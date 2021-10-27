namespace Going.Plaid.Income;

/// <summary>
/// <para>IncomeVerificationCreateResponse defines the response schema for <c>/income/verification/create</c>.</para>
/// </summary>
public record IncomeVerificationCreateResponse : ResponseBase
{
	/// <summary>
	/// <para>ID of the verification. This ID is persisted throughout the lifetime of the verification.</para>
	/// </summary>
	[JsonPropertyName("income_verification_id")]
	public string IncomeVerificationId { get; init; } = default!;
}