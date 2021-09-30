namespace Going.Plaid.Entity;

/// <summary>
/// <para>Contains details about a mortgage account.</para>
/// </summary>
public record MortgageLiability
{
	/// <summary>
	/// <para>The ID of the account that this liability belongs to.</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string AccountId { get; init; } = default!;

	/// <summary>
	/// <para>The account number of the loan.</para>
	/// </summary>
	[JsonPropertyName("account_number")]
	public string AccountNumber { get; init; } = default!;

	/// <summary>
	/// <para>The current outstanding amount charged for late payment.</para>
	/// </summary>
	[JsonPropertyName("current_late_fee")]
	public decimal? CurrentLateFee { get; init; } = default!;

	/// <summary>
	/// <para>Total amount held in escrow to pay taxes and insurance on behalf of the borrower.</para>
	/// </summary>
	[JsonPropertyName("escrow_balance")]
	public decimal? EscrowBalance { get; init; } = default!;

	/// <summary>
	/// <para>Indicates whether the borrower has private mortgage insurance in effect.</para>
	/// </summary>
	[JsonPropertyName("has_pmi")]
	public bool? HasPmi { get; init; } = default!;

	/// <summary>
	/// <para>Indicates whether the borrower will pay a penalty for early payoff of mortgage.</para>
	/// </summary>
	[JsonPropertyName("has_prepayment_penalty")]
	public bool? HasPrepaymentPenalty { get; init; } = default!;

	/// <summary>
	/// <para>Object containing metadata about the interest rate for the mortgage.</para>
	/// </summary>
	[JsonPropertyName("interest_rate")]
	public Entity.MortgageInterestRate InterestRate { get; init; } = default!;

	/// <summary>
	/// <para>The amount of the last payment.</para>
	/// </summary>
	[JsonPropertyName("last_payment_amount")]
	public decimal? LastPaymentAmount { get; init; } = default!;

	/// <summary>
	/// <para>The date of the last payment. Dates are returned in an <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format (YYYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("last_payment_date")]
	public DateOnly? LastPaymentDate { get; init; } = default!;

	/// <summary>
	/// <para>Description of the type of loan, for example <c>conventional</c>, <c>fixed</c>, or <c>variable</c>. This field is provided directly from the loan servicer and does not have an enumerated set of possible values.</para>
	/// </summary>
	[JsonPropertyName("loan_type_description")]
	public string? LoanTypeDescription { get; init; } = default!;

	/// <summary>
	/// <para>Full duration of mortgage as at origination (e.g. <c>10 year</c>).</para>
	/// </summary>
	[JsonPropertyName("loan_term")]
	public string? LoanTerm { get; init; } = default!;

	/// <summary>
	/// <para>Original date on which mortgage is due in full. Dates are returned in an <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format (YYYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("maturity_date")]
	public DateOnly? MaturityDate { get; init; } = default!;

	/// <summary>
	/// <para>The amount of the next payment.</para>
	/// </summary>
	[JsonPropertyName("next_monthly_payment")]
	public decimal? NextMonthlyPayment { get; init; } = default!;

	/// <summary>
	/// <para>The due date for the next payment. Dates are returned in an <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format (YYYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("next_payment_due_date")]
	public DateOnly? NextPaymentDueDate { get; init; } = default!;

	/// <summary>
	/// <para>The date on which the loan was initially lent. Dates are returned in an <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format (YYYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("origination_date")]
	public DateOnly? OriginationDate { get; init; } = default!;

	/// <summary>
	/// <para>The original principal balance of the mortgage.</para>
	/// </summary>
	[JsonPropertyName("origination_principal_amount")]
	public decimal? OriginationPrincipalAmount { get; init; } = default!;

	/// <summary>
	/// <para>Amount of loan (principal + interest) past due for payment.</para>
	/// </summary>
	[JsonPropertyName("past_due_amount")]
	public decimal? PastDueAmount { get; init; } = default!;

	/// <summary>
	/// <para>Object containing fields describing property address.</para>
	/// </summary>
	[JsonPropertyName("property_address")]
	public Entity.MortgagePropertyAddress PropertyAddress { get; init; } = default!;

	/// <summary>
	/// <para>The year to date (YTD) interest paid.</para>
	/// </summary>
	[JsonPropertyName("ytd_interest_paid")]
	public decimal? YtdInterestPaid { get; init; } = default!;

	/// <summary>
	/// <para>The YTD principal paid.</para>
	/// </summary>
	[JsonPropertyName("ytd_principal_paid")]
	public decimal? YtdPrincipalPaid { get; init; } = default!;
}