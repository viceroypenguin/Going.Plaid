namespace Going.Plaid.Entity;

/// <summary>
/// <para>The repayment details for a cash-advance.</para>
/// </summary>
public class CashAdvanceRepayment
{
	/// <summary>
	/// <para>The amount a user paid. Required if there was a payment made.</para>
	/// </summary>
	[JsonPropertyName("amount_paid")]
	public Entity.Amount? AmountPaid { get; set; } = default!;

	/// <summary>
	/// <para>The amount a user is required to pay, including any fees or additional amounts.</para>
	/// </summary>
	[JsonPropertyName("amount_due")]
	public Entity.Amount AmountDue { get; set; } = default!;

	/// <summary>
	/// <para>The date the cash-advance is due, in ISO 8601 format (<c>YYYY-MM-DD</c>).</para>
	/// </summary>
	[JsonPropertyName("due_date")]
	public DateOnly DueDate { get; set; } = default!;

}
