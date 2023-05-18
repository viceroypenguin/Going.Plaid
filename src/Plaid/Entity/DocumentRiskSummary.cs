namespace Going.Plaid.Entity;

/// <summary>
/// <para>A summary across all risk signals associated with a document</para>
/// </summary>
public record DocumentRiskSummary
{
	/// <summary>
	/// <para>A number between 0 and 100, inclusive, where a score closer to 0 indicates a document is likely to be trustworthy and a score closer to 100 indicates a document is likely to be fraudulent</para>
	/// </summary>
	[JsonPropertyName("risk_score")]
	public decimal? RiskScore { get; init; } = default!;
}