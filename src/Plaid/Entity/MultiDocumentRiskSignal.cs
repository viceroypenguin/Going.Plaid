namespace Going.Plaid.Entity;

/// <summary>
/// <para>Object containing risk signals and relevant metadata for a set of uploaded documents</para>
/// </summary>
public record MultiDocumentRiskSignal
{
	/// <summary>
	/// <para>Array of objects containing attributes that could indicate if a document is fraudulent</para>
	/// </summary>
	[JsonPropertyName("document_references")]
	public IReadOnlyList<Entity.RiskSignalDocumentReference> DocumentReferences { get; init; } = default!;

	/// <summary>
	/// <para>Array of attributes that indicate whether or not there is fraud risk with a set of documents</para>
	/// </summary>
	[JsonPropertyName("risk_signals")]
	public IReadOnlyList<Entity.DocumentRiskSignal> RiskSignals { get; init; } = default!;

}
