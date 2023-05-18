namespace Going.Plaid.Entity;

/// <summary>
/// <para>Object containing fraud risk data for a set of income documents.</para>
/// </summary>
public record DocumentRiskSignalsObject
{
	/// <summary>
	/// <para>ID of the payroll provider account.</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string? AccountId { get; init; } = default!;

	/// <summary>
	/// <para>Array of document metadata and associated risk signals per document</para>
	/// </summary>
	[JsonPropertyName("single_document_risk_signals")]
	public IReadOnlyList<Entity.SingleDocumentRiskSignal> SingleDocumentRiskSignals { get; init; } = default!;

	/// <summary>
	/// <para>Array of risk signals computed from a set of uploaded documents and the associated documents' metadata</para>
	/// </summary>
	[JsonPropertyName("multi_document_risk_signals")]
	public IReadOnlyList<Entity.MultiDocumentRiskSignal> MultiDocumentRiskSignals { get; init; } = default!;
}