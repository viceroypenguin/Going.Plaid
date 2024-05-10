namespace Going.Plaid.Entity;

/// <summary>
/// <para>Contains loan data to update.</para>
/// </summary>
public class CraLoanUpdate
{
	/// <summary>
	/// <para>A unique identifier for the loan. </para>
	/// <para>Personally identifiable information, such as an email address or phone number, should not be used in the <c>loan_id</c>.</para>
	/// </summary>
	[JsonPropertyName("loan_id")]
	public string? LoanId { get; set; } = default!;

	/// <summary>
	/// <para>A list of status update history of the loan.</para>
	/// </summary>
	[JsonPropertyName("status_history")]
	public IReadOnlyList<Entity.CraLoanStatusHistoryUpdate>? StatusHistory { get; set; } = default!;

	/// <summary>
	/// <para>The updates to the payment history for the loan.</para>
	/// </summary>
	[JsonPropertyName("payment_history")]
	public IReadOnlyList<Entity.CraLoanPaymentHistory>? PaymentHistory { get; set; } = default!;

}
