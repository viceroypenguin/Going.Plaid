namespace Going.Plaid.Entity;

/// <summary>
/// <para>Insights relating to expenses and deposits that are predicted to occur on a scheduled basis, such as biweekly, monthly, or annually.</para>
/// <para>Common examples include loan payments, bill payments, subscriptions, and payroll income.</para>
/// <para>This is a beta field, available to all users.</para>
/// </summary>
public record Recurrence
{
	/// <summary>
	/// <para>Whether or not the transaction is periodically recurring.</para>
	/// </summary>
	[JsonPropertyName("is_recurring")]
	public bool? IsRecurring { get; init; } = default!;
}