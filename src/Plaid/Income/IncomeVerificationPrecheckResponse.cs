namespace Going.Plaid.Income;

/// <summary>
/// <para>IncomeVerificationPrecheckResponse defines the response schema for <c>/income/verification/precheck</c>.</para>
/// </summary>
public record IncomeVerificationPrecheckResponse : ResponseBase
{
	/// <summary>
	/// <para>ID of the precheck. Provide this value when calling <c>/link/token/create</c> in order to optimize Link conversion.</para>
	/// </summary>
	[JsonPropertyName("precheck_id")]
	public string PrecheckId { get; init; } = default!;

	/// <summary>
	/// <para>The confidence that Plaid can support the user in the digital income verification flow instead of requiring a manual paystub upload. One of the following:</para>
	/// </summary>
	[JsonPropertyName("confidence")]
	public Entity.IncomeVerificationPrecheckConfidence Confidence { get; init; } = default!;

}
