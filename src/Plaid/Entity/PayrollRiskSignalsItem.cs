namespace Going.Plaid.Entity;

/// <summary>
/// <para>Object containing fraud risk data pertaining to the Item linked as part of the verification.</para>
/// </summary>
public record PayrollRiskSignalsItem
{
	/// <summary>
	/// <para>The <c>item_id</c> of the Item associated with this webhook, warning, or error</para>
	/// </summary>
	[JsonPropertyName("item_id")]
	public string ItemId { get; init; } = default!;

	/// <summary>
	/// <para>Array of payroll income document authenticity data retrieved for each of the user's accounts.</para>
	/// </summary>
	[JsonPropertyName("verification_risk_signals")]
	public IReadOnlyList<Entity.DocumentRiskSignalsObject> VerificationRiskSignals { get; init; } = default!;

}
