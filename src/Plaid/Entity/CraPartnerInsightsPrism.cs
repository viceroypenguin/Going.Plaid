namespace Going.Plaid.Entity;

/// <summary>
/// <para>The Prism Data insights for the user.</para>
/// </summary>
public record CraPartnerInsightsPrism
{
	/// <summary>
	/// <para>The data from the Insights product returned by Prism Data.</para>
	/// </summary>
	[JsonPropertyName("insights")]
	public Entity.PrismInsights? Insights { get; init; } = default!;

	/// <summary>
	/// <para>The data from the CashScore® product returned by Prism Data.</para>
	/// </summary>
	[JsonPropertyName("cash_score")]
	public Entity.PrismCashScore? CashScore { get; init; } = default!;

	/// <summary>
	/// <para>The data from the CashScore® Extend product returned by Prism Data.</para>
	/// </summary>
	[JsonPropertyName("extend")]
	public Entity.PrismExtend? Extend { get; init; } = default!;

	/// <summary>
	/// <para>The data from the FirstDetect product returned by Prism Data.</para>
	/// </summary>
	[JsonPropertyName("first_detect")]
	public Entity.PrismFirstDetect? FirstDetect { get; init; } = default!;

	/// <summary>
	/// <para>The data from the CashScore® Detect product returned by Prism Data.</para>
	/// </summary>
	[JsonPropertyName("detect")]
	public Entity.PrismDetect? Detect { get; init; } = default!;

	/// <summary>
	/// <para>Details on whether the Prism Data attributes succeeded or failed to be generated.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public string Status { get; init; } = default!;

}
