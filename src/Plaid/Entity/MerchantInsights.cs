namespace Going.Plaid.Entity;

/// <summary>
/// <para>Insights into a user’s top merchants.</para>
/// </summary>
public record MerchantInsights
{
	/// <summary>
	/// <para>The counterparty name.</para>
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; init; } = default!;

	/// <summary>
	/// <para>A unique, stable, Plaid-generated id that maps to the merchant.</para>
	/// </summary>
	[JsonPropertyName("entity_id")]
	public string? EntityId { get; init; } = default!;

	/// <summary>
	/// <para>The website associated with the merchant.</para>
	/// </summary>
	[JsonPropertyName("website")]
	public string? Website { get; init; } = default!;

	/// <summary>
	/// <para>The number of transactions associated with merchant of this type.</para>
	/// </summary>
	[JsonPropertyName("transaction_count")]
	public int TransactionCount { get; init; } = default!;

	/// <summary>
	/// <para>The primary personal finance category associated with this merchant.</para>
	/// </summary>
	[JsonPropertyName("primary_personal_finance_category")]
	public string? PrimaryPersonalFinanceCategory { get; init; } = default!;

	/// <summary>
	/// <para>The detailed personal finance category associated with this merchant.</para>
	/// </summary>
	[JsonPropertyName("detailed_personal_finance_category")]
	public string? DetailedPersonalFinanceCategory { get; init; } = default!;

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
}