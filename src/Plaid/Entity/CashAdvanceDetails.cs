namespace Going.Plaid.Entity;

/// <summary>
/// <para>The details of a cash-advance associated with an approved cash-advance decision. Required when a cash-advance has been approved.</para>
/// </summary>
public class CashAdvanceDetails
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

	/// <summary>
	/// <para>Whether the end user took the approved cash-advance. <c>True</c> if taken, <c>False</c> if not.</para>
	/// </summary>
	[JsonPropertyName("is_taken")]
	public bool IsTaken { get; set; } = default!;

}
