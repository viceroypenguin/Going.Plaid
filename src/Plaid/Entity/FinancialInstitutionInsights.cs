namespace Going.Plaid.Entity;

/// <summary>
/// <para>Insights surrounding external financial institution counterparties associated with a user.</para>
/// </summary>
public record FinancialInstitutionInsights
{
	/// <summary>
	/// <para>Name of the financial institution counterparty.</para>
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; init; } = default!;

	/// <summary>
	/// <para>A unique, stable, Plaid-generated id that maps to the counterparty.</para>
	/// </summary>
	[JsonPropertyName("entity_id")]
	public string? EntityId { get; init; } = default!;

	/// <summary>
	/// <para>The website associated with the counterparty.</para>
	/// </summary>
	[JsonPropertyName("website")]
	public string? Website { get; init; } = default!;

	/// <summary>
	/// <para>Associated accounts, detected based on the nature of transfers to/from this institution.</para>
	/// </summary>
	[JsonPropertyName("detected_accounts")]
	public IReadOnlyList<Entity.DetectedAccount> DetectedAccounts { get; init; } = default!;

}
