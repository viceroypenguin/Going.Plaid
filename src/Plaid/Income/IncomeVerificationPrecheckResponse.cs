namespace Going.Plaid.Income;

/// <summary>
/// <para>IncomeVerificationPrecheckResponse defines the response schema for <c>/income/verification/precheck</c>.</para>
/// </summary>
public record IncomeVerificationPrecheckResponse : ResponseBase
{
	/// <summary>
	/// <para>ID of the precheck.</para>
	/// </summary>
	[JsonPropertyName("precheck_id")]
	public string PrecheckId { get; init; } = default!;

	/// <summary>
	/// <para>The confidence that Plaid can support the user in the income verification flow. One of the following:</para>
	/// </summary>
	[JsonPropertyName("confidence")]
	public Entity.IncomeVerificationPrecheckResponseConfidenceEnum Confidence { get; init; } = default!;
}