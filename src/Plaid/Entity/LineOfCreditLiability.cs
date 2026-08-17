namespace Going.Plaid.Entity;

/// <summary>
/// <para>Contains details about a line of credit account.</para>
/// </summary>
public record LineOfCreditLiability
{
	/// <summary>
	/// <para>The ID of the account that this liability belongs to.</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string AccountId { get; init; } = default!;

	/// <summary>
	/// <para>Information about the interest rate on a loan or line of credit.</para>
	/// </summary>
	[JsonPropertyName("interest_rate")]
	public Entity.LoanInterestRate? InterestRate { get; init; } = default!;

	/// <summary>
	/// <para>The maximum amount of credit available on the account.</para>
	/// </summary>
	[JsonPropertyName("credit_limit")]
	public decimal? CreditLimit { get; init; } = default!;

	/// <summary>
	/// <para>The amount of credit currently available on the account.</para>
	/// </summary>
	[JsonPropertyName("available_credit")]
	public decimal? AvailableCredit { get; init; } = default!;

	/// <summary>
	/// <para>The outstanding principal balance on the account.</para>
	/// </summary>
	[JsonPropertyName("principal_balance")]
	public decimal? PrincipalBalance { get; init; } = default!;

	/// <summary>
	/// <para>The minimum payment due for the next billing cycle.</para>
	/// </summary>
	[JsonPropertyName("minimum_payment_amount")]
	public decimal? MinimumPaymentAmount { get; init; } = default!;

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
	/// <para>The total amount owed as of the last statement issued.</para>
	/// </summary>
	[JsonPropertyName("last_statement_balance")]
	public decimal? LastStatementBalance { get; init; } = default!;

	/// <summary>
	/// <para>The date of the last statement, in ISO 8601 format (YYYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("last_statement_issue_date")]
	public DateOnly? LastStatementIssueDate { get; init; } = default!;

	/// <summary>
	/// <para>The amount of the payment that is currently past due.</para>
	/// </summary>
	[JsonPropertyName("past_due_amount")]
	public decimal? PastDueAmount { get; init; } = default!;

	/// <summary>
	/// <para>The finance charges assessed on the account.</para>
	/// </summary>
	[JsonPropertyName("finance_charges")]
	public decimal? FinanceCharges { get; init; } = default!;

	/// <summary>
	/// <para>The date on which the draw period ends, in ISO 8601 format (YYYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("draw_period_end_date")]
	public DateOnly? DrawPeriodEndDate { get; init; } = default!;

	/// <summary>
	/// <para>The various interest rates that apply to the account.</para>
	/// </summary>
	[JsonPropertyName("aprs")]
	public IReadOnlyList<Entity.Apr> Aprs { get; init; } = default!;

}
