namespace Going.Plaid.Entity;

/// <summary>
/// <para>Details about the number of income sources</para>
/// </summary>
public record IncomeSourcesCounts
{
	/// <summary>
	/// <para>The number of income sources detected at the subscription date</para>
	/// </summary>
	[JsonPropertyName("baseline_count")]
	public decimal BaselineCount { get; init; } = default!;

	/// <summary>
	/// <para>The number of income sources currently detected</para>
	/// </summary>
	[JsonPropertyName("current_count")]
	public decimal CurrentCount { get; init; } = default!;

}
