namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object representing a credit card account.</para>
/// </summary>
public record CreditCardLiability
{
	/// <summary>
	/// <para>The ID of the account that this liability belongs to.</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string? AccountId { get; init; } = default!;

	/// <summary>
	/// <para>The various interest rates that apply to the account.</para>
	/// </summary>
	[JsonPropertyName("aprs")]
	public IReadOnlyList<Entity.Apr> Aprs { get; init; } = default!;

	/// <summary>
	/// <para>true if a payment is currently overdue. Availability for this field is limited.</para>
	/// </summary>
	[JsonPropertyName("is_overdue")]
	public bool? IsOverdue { get; init; } = default!;

	/// <summary>
	/// <para>The amount of the last payment.</para>
	/// </summary>
	[JsonPropertyName("last_payment_amount")]
	public decimal LastPaymentAmount { get; init; } = default!;

	/// <summary>
	/// <para>The date of the last payment. Dates are returned in an ISO 8601 format (YYYY-MM-DD). Availability for this field is limited.</para>
	/// </summary>
	[JsonPropertyName("last_payment_date")]
	public DateOnly LastPaymentDate { get; init; } = default!;

	/// <summary>
	/// <para>The date of the last statement. Dates are returned in an ISO 8601 format (YYYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("last_statement_issue_date")]
	public DateOnly LastStatementIssueDate { get; init; } = default!;

	/// <summary>
	/// <para>The minimum payment due for the next billing cycle.</para>
	/// </summary>
	[JsonPropertyName("minimum_payment_amount")]
	public decimal MinimumPaymentAmount { get; init; } = default!;

	/// <summary>
	/// <para>The due date for the next payment. The due date is <c>null</c> if a payment is not expected. Dates are returned in an ISO 8601 format (YYYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("next_payment_due_date")]
	public DateOnly? NextPaymentDueDate { get; init; } = default!;
}