namespace Going.Plaid.Entity;

/// <summary>
/// <para>Contains the payment information for a loan payment period.</para>
/// </summary>
public class CraLoanPaymentHistory
{
	/// <summary>
	/// <para>The index to identify the loan's payment period, starting from 1.</para>
	/// <para>For example:</para>
	/// <para>  1 means the period between the loan's opening date and the 1st payment due date.</para>
	/// <para>  2 means the period between the loan's 1st payment due date and 2nd payment due date.</para>
	/// </summary>
	[JsonPropertyName("period")]
	public int Period { get; set; } = default!;

	/// <summary>
	/// <para>The payment due date or end date of the payment period. The date should be in ISO 8601 format (YYYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("due_date")]
	public DateOnly DueDate { get; set; } = default!;

	/// <summary>
	/// <para>The number of days the loan was delinquent at the end of the pay period.</para>
	/// <para>If specified, should be greater of equal to 0.</para>
	/// </summary>
	[JsonPropertyName("days_past_due")]
	public int DaysPastDue { get; set; } = default!;

	/// <summary>
	/// <para>The amount past due or the charge-off amount of the loan at the end of the payment period.</para>
	/// </summary>
	[JsonPropertyName("amount_past_due")]
	public decimal? AmountPastDue { get; set; } = default!;

	/// <summary>
	/// <para>The balance remaining on the loan at the end of the payment period.</para>
	/// </summary>
	[JsonPropertyName("balance_remaining")]
	public decimal? BalanceRemaining { get; set; } = default!;

}
