namespace Going.Plaid.Entity;

/// <summary>
/// <para>Object representing fraud risk data of the uploaded document. Only provided when using Identity Document Upload with Fraud Risk enabled.</para>
/// </summary>
public record IdentityDocumentUploadRiskInsights
{
	/// <summary>
	/// <para>Risk summary of an uploaded document.</para>
	/// </summary>
	[JsonPropertyName("risk_summary")]
	public Entity.IdentityDocumentUploadRiskSummary? RiskSummary { get; init; } = default!;

	/// <summary>
	/// <para>An array of risk signals.</para>
	/// </summary>
	[JsonPropertyName("risk_signals")]
	public IReadOnlyList<Entity.IdentityDocumentUploadRiskSignal>? RiskSignals { get; init; } = default!;

}
