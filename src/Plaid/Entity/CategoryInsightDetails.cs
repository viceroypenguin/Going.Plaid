namespace Going.Plaid.Entity;

/// <summary>
/// <para>Insights object for categories.</para>
/// </summary>
public record CategoryInsightDetails
{
	/// <summary>
	/// <para>Category name.</para>
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; init; } = default!;

	/// <summary>
	/// <para>The number of transactions associated with this category.</para>
	/// </summary>
	[JsonPropertyName("transaction_count")]
	public int TransactionCount { get; init; } = default!;

	/// <summary>
	/// <para>Sum of outflow amounts.</para>
	/// </summary>
	[JsonPropertyName("total_outflows")]
	public decimal TotalOutflows { get; init; } = default!;

	/// <summary>
	/// <para>Sum of inflow amounts.</para>
	/// </summary>
	[JsonPropertyName("total_inflows")]
	public decimal TotalInflows { get; init; } = default!;

	/// <summary>
	/// <para>The most common counterparties associated with this category sorted by outflow.</para>
	/// </summary>
	[JsonPropertyName("top_counterparties")]
	public IReadOnlyList<string>? TopCounterparties { get; init; } = default!;
}