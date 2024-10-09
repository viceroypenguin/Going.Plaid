namespace Going.Plaid.Entity;

/// <summary>
/// <para>Risk signals tied to the document</para>
/// </summary>
public record IdentityDocumentUploadRiskSignal
{
	/// <summary>
	/// <para>The type of risk found.</para>
	/// </summary>
	[JsonPropertyName("type")]
	public string? Type { get; init; } = default!;

	/// <summary>
	/// <para>Indicates whether fraud risk was detected on the field.</para>
	/// </summary>
	[JsonPropertyName("has_fraud_risk")]
	public bool? HasFraudRisk { get; init; } = default!;

	/// <summary>
	/// <para>A human-readable explanation providing more detail about the specific risk signal.</para>
	/// </summary>
	[JsonPropertyName("signal_description")]
	public string? SignalDescription { get; init; } = default!;

	/// <summary>
	/// <para>The relevant page associated with the risk signal. If the risk signal is not associated with a specific page, the value will be 0.</para>
	/// </summary>
	[JsonPropertyName("page_number")]
	public int? PageNumber { get; init; } = default!;

}
