namespace Going.Plaid.Entity;

/// <summary>
/// <para>The versions of Prism products to evaluate</para>
/// </summary>
public class PrismVersions
{
	/// <summary>
	/// <para>The version of Prism FirstDetect. If <c>prism_versions</c> is omitted entirely, FirstDetect v3 is generated when your client's configured default Prism version is v3 or no default is configured; it is not generated if the default is v4 or v4.1. If other Prism versions are specified but this one is not, this product is not generated.</para>
	/// </summary>
	[JsonPropertyName("firstdetect")]
	public Entity.PrismFirstDetectVersion? Firstdetect { get; set; } = default!;

	/// <summary>
	/// <para>The version of Prism Detect</para>
	/// </summary>
	[JsonPropertyName("detect")]
	public Entity.PrismDetectVersion? Detect { get; set; } = default!;

	/// <summary>
	/// <para>The version of Prism CashScore. If <c>prism_versions</c> is omitted entirely, your client's configured default Prism version is used (v3 if none is configured). If other Prism versions are specified but this one is not, this product is not generated.</para>
	/// </summary>
	[JsonPropertyName("cashscore")]
	public Entity.PrismCashScoreVersion? Cashscore { get; set; } = default!;

	/// <summary>
	/// <para>The version of Prism Extend</para>
	/// </summary>
	[JsonPropertyName("extend")]
	public Entity.PrismExtendVersion? Extend { get; set; } = default!;

	/// <summary>
	/// <para>The version of Prism Insights. If <c>prism_versions</c> is omitted entirely, your client's configured default Prism version is used (v3 if none is configured). If other Prism versions are specified but this one is not, this product is not generated.</para>
	/// </summary>
	[JsonPropertyName("insights")]
	public Entity.PrismInsightsVersion? Insights { get; set; } = default!;

}
