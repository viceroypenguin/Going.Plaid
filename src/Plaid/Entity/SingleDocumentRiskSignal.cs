namespace Going.Plaid.Entity;

/// <summary>
/// <para>Object containing all risk signals and relevant metadata for a single document</para>
/// </summary>
public record SingleDocumentRiskSignal
{
	/// <summary>
	/// <para>Object containing metadata for the document</para>
	/// </summary>
	[JsonPropertyName("document_reference")]
	public Entity.RiskSignalDocumentReference DocumentReference { get; init; } = default!;

	/// <summary>
	/// <para>Array of attributes that indicate whether or not there is fraud risk with a document</para>
	/// </summary>
	[JsonPropertyName("risk_signals")]
	public IReadOnlyList<Entity.DocumentRiskSignal> RiskSignals { get; init; } = default!;

	/// <summary>
	/// <para>A summary across all risk signals associated with a document</para>
	/// </summary>
	[JsonPropertyName("risk_summary")]
	public Entity.DocumentRiskSummary RiskSummary { get; init; } = default!;

}
