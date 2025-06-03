namespace Going.Plaid.Entity;

/// <summary>
/// <para>The versions of Prism products to evaluate</para>
/// </summary>
public class PrismVersions
{
	/// <summary>
	/// <para>The version of Prism FirstDetect. If not specified, will default to v3.</para>
	/// </summary>
	[JsonPropertyName("firstdetect")]
	public Entity.PrismFirstDetectVersion? Firstdetect { get; set; } = default!;

	/// <summary>
	/// <para>The version of Prism Detect</para>
	/// </summary>
	[JsonPropertyName("detect")]
	public Entity.PrismDetectVersion? Detect { get; set; } = default!;

	/// <summary>
	/// <para>The version of Prism CashScore. If not specified, will default to v3.</para>
	/// </summary>
	[JsonPropertyName("cashscore")]
	public Entity.PrismCashScoreVersion? Cashscore { get; set; } = default!;

	/// <summary>
	/// <para>The version of Prism Extend</para>
	/// </summary>
	[JsonPropertyName("extend")]
	public Entity.PrismExtendVersion? Extend { get; set; } = default!;

	/// <summary>
	/// <para>The version of Prism Insights. If not specified, will default to v3.</para>
	/// </summary>
	[JsonPropertyName("insights")]
	public Entity.PrismInsightsVersion? Insights { get; set; } = default!;

}
