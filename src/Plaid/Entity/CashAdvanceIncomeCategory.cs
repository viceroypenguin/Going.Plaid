namespace Going.Plaid.Entity;

/// <summary>
/// <para>The category of an income stream.</para>
/// </summary>
public record CashAdvanceIncomeCategory
{
	/// <summary>
	/// <para>The primary income category, for example <c>EARNED_INCOME</c>, <c>RETIREMENT</c>, or <c>BENEFITS</c>. <c>null</c> if the category could not be determined.</para>
	/// </summary>
	[JsonPropertyName("primary")]
	public string? Primary { get; init; } = default!;

}
