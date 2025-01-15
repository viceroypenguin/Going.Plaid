namespace Going.Plaid.Entity;

/// <summary>
/// <para>Details about the fraud analysis performed on the document.</para>
/// </summary>
public record FraudAnalysisDetails
{
	/// <summary>
	/// <para>The outcome of the fraud check.</para>
	/// </summary>
	[JsonPropertyName("type_supported")]
	public Entity.FraudCheckOutcome TypeSupported { get; init; } = default!;

	/// <summary>
	/// <para>The outcome of the fraud check.</para>
	/// </summary>
	[JsonPropertyName("portrait_presence_check")]
	public Entity.FraudCheckOutcome PortraitPresenceCheck { get; init; } = default!;

	/// <summary>
	/// <para>The outcome of the fraud check.</para>
	/// </summary>
	[JsonPropertyName("portrait_details_check")]
	public Entity.FraudCheckOutcome PortraitDetailsCheck { get; init; } = default!;

	/// <summary>
	/// <para>The outcome of the fraud check.</para>
	/// </summary>
	[JsonPropertyName("image_composition_check")]
	public Entity.FraudCheckOutcome ImageCompositionCheck { get; init; } = default!;

	/// <summary>
	/// <para>The outcome of the fraud check.</para>
	/// </summary>
	[JsonPropertyName("integrity_check")]
	public Entity.FraudCheckOutcome IntegrityCheck { get; init; } = default!;

	/// <summary>
	/// <para>The outcome of the fraud check.</para>
	/// </summary>
	[JsonPropertyName("detail_check")]
	public Entity.FraudCheckOutcome DetailCheck { get; init; } = default!;

	/// <summary>
	/// <para>The outcome of the fraud check, when available.</para>
	/// </summary>
	[JsonPropertyName("issue_date_check")]
	public Entity.FraudCheckOutcomeWithNoData IssueDateCheck { get; init; } = default!;

}
