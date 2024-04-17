namespace Going.Plaid.Entity;

/// <summary>
/// <para>Risk signals tied to the document</para>
/// </summary>
public record IdentityDocumentUploadRiskSignal
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("type")]
	public string? Type { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("has_fraud_risk")]
	public bool? HasFraudRisk { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("signal_description")]
	public string? SignalDescription { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("page_number")]
	public int? PageNumber { get; init; } = default!;

}
