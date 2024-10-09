namespace Going.Plaid.Entity;

/// <summary>
/// <para>Details about a certain reason as to why a document could potentially be fraudulent.</para>
/// </summary>
public record DocumentRiskSignal
{
	/// <summary>
	/// <para>The type of risk found in the risk signal check.</para>
	/// </summary>
	[JsonPropertyName("type")]
	public string? Type { get; init; } = default!;

	/// <summary>
	/// <para>The field which the risk signal was computed for</para>
	/// </summary>
	[JsonPropertyName("field")]
	public string? Field { get; init; } = default!;

	/// <summary>
	/// <para>A flag used to quickly identify if the signal indicates that this field is authentic or fraudulent</para>
	/// </summary>
	[JsonPropertyName("has_fraud_risk")]
	public bool? HasFraudRisk { get; init; } = default!;

	/// <summary>
	/// <para>An object which contains additional metadata about the institution used to compute the verification attribute</para>
	/// </summary>
	[JsonPropertyName("institution_metadata")]
	public Entity.DocumentRiskSignalInstitutionMetadata? InstitutionMetadata { get; init; } = default!;

	/// <summary>
	/// <para>The expected value of the field, as seen on the document</para>
	/// </summary>
	[JsonPropertyName("expected_value")]
	public string? ExpectedValue { get; init; } = default!;

	/// <summary>
	/// <para>The derived value obtained in the risk signal calculation process for this field</para>
	/// </summary>
	[JsonPropertyName("actual_value")]
	public string? ActualValue { get; init; } = default!;

	/// <summary>
	/// <para>A human-readable explanation providing more detail into the particular risk signal</para>
	/// </summary>
	[JsonPropertyName("signal_description")]
	public string? SignalDescription { get; init; } = default!;

	/// <summary>
	/// <para>The relevant page associated with the risk signal. If the risk signal is not associated with a specific page, the value will be 0.</para>
	/// </summary>
	[JsonPropertyName("page_number")]
	public int? PageNumber { get; init; } = default!;

}
