namespace Going.Plaid.Entity;

/// <summary>
/// <para>The details of a cash-advance associated with the decision. Required when <c>is_taken</c> is <c>true</c>.</para>
/// </summary>
public class CashAdvanceInfo
{
	/// <summary>
	/// <para>The amount a user was approved for in a cash-advance.</para>
	/// </summary>
	[JsonPropertyName("amount_approved")]
	public Entity.Amount AmountApproved { get; set; } = default!;

	/// <summary>
	/// <para>The amount a user is required to pay, including any fees or additional amounts. Required if <c>is_taken</c> is <c>true</c>.</para>
	/// </summary>
	[JsonPropertyName("amount_due")]
	public Entity.Amount? AmountDue { get; set; } = default!;

	/// <summary>
	/// <para>The date the cash-advance is due, in ISO 8601 format (<c>YYYY-MM-DD</c>). Required if <c>is_taken</c> is <c>true</c>.</para>
	/// </summary>
	[JsonPropertyName("due_date")]
	public DateOnly? DueDate { get; set; } = default!;

}
