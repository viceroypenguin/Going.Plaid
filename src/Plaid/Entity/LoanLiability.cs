namespace Going.Plaid.Entity;

/// <summary>
/// <para>Contains details about a closed-end loan account.</para>
/// </summary>
public record LoanLiability
{
	/// <summary>
	/// <para>The ID of the account that this liability belongs to.</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string AccountId { get; init; } = default!;

	/// <summary>
	/// <para>The account number of the loan. For some institutions, this may be a masked version of the number (e.g., the last 4 digits instead of the entire number).</para>
	/// </summary>
	[JsonPropertyName("account_number")]
	public string? AccountNumber { get; init; } = default!;

	/// <summary>
	/// <para>Information about the interest rate on a loan or line of credit.</para>
	/// </summary>
	[JsonPropertyName("interest_rate")]
	public Entity.LoanInterestRate? InterestRate { get; init; } = default!;

	/// <summary>
	/// <para>The outstanding principal balance of the loan.</para>
	/// </summary>
	[JsonPropertyName("principal_balance")]
	public decimal? PrincipalBalance { get; init; } = default!;

	/// <summary>
	/// <para>The original principal amount of the loan.</para>
	/// </summary>
	[JsonPropertyName("origination_principal_amount")]
	public decimal? OriginationPrincipalAmount { get; init; } = default!;

	/// <summary>
	/// <para>The date on which the loan was originated, in ISO 8601 format (YYYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("origination_date")]
	public DateOnly? OriginationDate { get; init; } = default!;

	/// <summary>
	/// <para>The length of the loan term in months.</para>
	/// </summary>
	[JsonPropertyName("loan_term_months")]
	public int? LoanTermMonths { get; init; } = default!;

	/// <summary>
	/// <para>The date on which the loan is scheduled to be fully paid, in ISO 8601 format (YYYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("maturity_date")]
	public DateOnly? MaturityDate { get; init; } = default!;

	/// <summary>
	/// <para>The total number of payments scheduled for the loan.</para>
	/// </summary>
	[JsonPropertyName("payment_count")]
	public int? PaymentCount { get; init; } = default!;

	/// <summary>
	/// <para>The frequency at which payments are scheduled.</para>
	/// </summary>
	[JsonPropertyName("payment_frequency")]
	public Entity.LoanPaymentFrequency? PaymentFrequency { get; init; } = default!;

	/// <summary>
	/// <para>The amount of the next scheduled payment.</para>
	/// </summary>
	[JsonPropertyName("next_payment_amount")]
	public decimal? NextPaymentAmount { get; init; } = default!;

	/// <summary>
	/// <para>The due date of the next payment, in ISO 8601 format (YYYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("next_payment_due_date")]
	public DateOnly? NextPaymentDueDate { get; init; } = default!;

	/// <summary>
	/// <para>The amount of the most recent payment.</para>
	/// </summary>
	[JsonPropertyName("last_payment_amount")]
	public decimal? LastPaymentAmount { get; init; } = default!;

	/// <summary>
	/// <para>The date of the most recent payment, in ISO 8601 format (YYYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("last_payment_date")]
	public DateOnly? LastPaymentDate { get; init; } = default!;

	/// <summary>
	/// <para>The amount required to fully pay off the loan.</para>
	/// </summary>
	[JsonPropertyName("payoff_amount")]
	public decimal? PayoffAmount { get; init; } = default!;

	/// <summary>
	/// <para>The year-to-date interest paid on the loan.</para>
	/// </summary>
	[JsonPropertyName("ytd_interest_paid")]
	public decimal? YtdInterestPaid { get; init; } = default!;

	/// <summary>
	/// <para>The frequency at which interest is compounded.</para>
	/// </summary>
	[JsonPropertyName("compounding_period")]
	public Entity.LoanCompoundingPeriod? CompoundingPeriod { get; init; } = default!;

}
