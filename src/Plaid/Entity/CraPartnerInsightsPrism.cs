namespace Going.Plaid.Entity;

/// <summary>
/// <para>The Prism insights for the user.</para>
/// </summary>
public record CraPartnerInsightsPrism
{
	/// <summary>
	/// <para>The data from the Insights product returned by Prism.</para>
	/// </summary>
	[JsonPropertyName("insights")]
	public Entity.PrismInsights? Insights { get; init; } = default!;

	/// <summary>
	/// <para>The data from the Cash Score product returned by Prism.</para>
	/// </summary>
	[JsonPropertyName("cash_score")]
	public Entity.PrismCashScore? CashScore { get; init; } = default!;

	/// <summary>
	/// <para>The data from the Detect product returned by Prism.</para>
	/// </summary>
	[JsonPropertyName("detect")]
	public Entity.PrismDetect? Detect { get; init; } = default!;

	/// <summary>
	/// <para>Details on whether the Prism attributes succeeded or failed to be generated.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public string Status { get; init; } = default!;

}
