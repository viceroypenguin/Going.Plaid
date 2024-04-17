namespace Going.Plaid.Entity;

/// <summary>
/// <para>Risk summary of an uploaded document</para>
/// </summary>
public record IdentityDocumentUploadRiskSummary
{
	/// <summary>
	/// <para>Integer value representing the risk score of the document</para>
	/// </summary>
	[JsonPropertyName("risk_score")]
	public int? RiskScore { get; init; } = default!;

}
