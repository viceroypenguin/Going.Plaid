namespace Going.Plaid.Entity;

/// <summary>
/// <para>In closed beta. Object representing fraud risk data of the document</para>
/// </summary>
public record IdentityDocumentUploadRiskInsights
{
	/// <summary>
	/// <para>Risk summary of an uploaded document</para>
	/// </summary>
	[JsonPropertyName("risk_summary")]
	public Entity.IdentityDocumentUploadRiskSummary? RiskSummary { get; init; } = default!;

	/// <summary>
	/// <para>an array of risk signals</para>
	/// </summary>
	[JsonPropertyName("risk_signals")]
	public IReadOnlyList<Entity.IdentityDocumentUploadRiskSignal>? RiskSignals { get; init; } = default!;

}
