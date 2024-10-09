namespace Going.Plaid.Entity;

/// <summary>
/// <para>Risk summary of an uploaded document.</para>
/// </summary>
public record IdentityDocumentUploadRiskSummary
{
	/// <summary>
	/// <para>A number between 0 and 100, inclusive, where a score closer to 0 indicates a document is likely to be trustworthy and a score closer to 100 indicates a document is likely to be fraudulent.</para>
	/// </summary>
	[JsonPropertyName("risk_score")]
	public int? RiskScore { get; init; } = default!;

}
