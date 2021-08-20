namespace Going.Plaid.Entity;

/// <summary>
/// <para>Information about the student's eligibility in the Public Service Loan Forgiveness program. This is only returned if the institution is Fedloan (<c>ins_116527</c>).</para>
/// </summary>
public record PSLFStatus
{
	/// <summary>
	/// <para>The estimated date borrower will have completed 120 qualifying monthly payments. Returned in ISO 8601 format (YYYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("estimated_eligibility_date")]
	public DateOnly? EstimatedEligibilityDate { get; init; } = default!;

	/// <summary>
	/// <para>The number of qualifying payments that have been made.</para>
	/// </summary>
	[JsonPropertyName("payments_made")]
	public decimal? PaymentsMade { get; init; } = default!;

	/// <summary>
	/// <para>The number of qualifying payments remaining.</para>
	/// </summary>
	[JsonPropertyName("payments_remaining")]
	public decimal? PaymentsRemaining { get; init; } = default!;
}