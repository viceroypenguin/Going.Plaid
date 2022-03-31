namespace Going.Plaid.Credit;

/// <summary>
/// <para>Defines the response schema for <c>/credit/payroll_income/precheck</c>.</para>
/// </summary>
public record CreditPayrollIncomePrecheckResponse : ResponseBase
{
	/// <summary>
	/// <para>The confidence that Plaid can support the user in the digital income verification flow instead of requiring a manual paystub upload. One of the following:</para>
	/// </summary>
	[JsonPropertyName("confidence")]
	public Entity.IncomeVerificationPrecheckConfidence Confidence { get; init; } = default!;
}