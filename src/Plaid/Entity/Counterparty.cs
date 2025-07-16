namespace Going.Plaid.Entity;

/// <summary>
/// <para>The counterparty, such as the merchant or financial institution, is extracted by Plaid from the raw description.</para>
/// </summary>
public record Counterparty
{
	/// <summary>
	/// <para>The name of the counterparty, such as the merchant or the financial institution, as extracted by Plaid from the raw description.</para>
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; init; } = default!;

	/// <summary>
	/// <para>A unique, stable, Plaid-generated ID that maps to the counterparty.</para>
	/// </summary>
	[JsonPropertyName("entity_id")]
	public string? EntityId { get; init; } = default!;

	/// <summary>
	/// <para>The counterparty type.</para>
	/// </summary>
	[JsonPropertyName("type")]
	public Entity.CounterpartyType Type { get; init; } = default!;

	/// <summary>
	/// <para>The website associated with the counterparty.</para>
	/// </summary>
	[JsonPropertyName("website")]
	public string? Website { get; init; } = default!;

	/// <summary>
	/// <para>The URL of a logo associated with the counterparty, if available. The logo will always be 100×100 pixel PNG file.</para>
	/// </summary>
	[JsonPropertyName("logo_url")]
	public string? LogoUrl { get; init; } = default!;

	/// <summary>
	/// <para>A description of how confident we are that the provided counterparty is involved in the transaction.</para>
	/// <para><c>VERY_HIGH</c>: We recognize this counterparty and we are more than 98% confident that it is involved in this transaction.</para>
	/// <para><c>HIGH</c>: We recognize this counterparty and we are more than 90% confident that it is involved in this transaction.</para>
	/// <para><c>MEDIUM</c>: We are moderately confident that this counterparty was involved in this transaction, but some details may differ from our records.</para>
	/// <para><c>LOW</c>: We didn’t find a matching counterparty in our records, so we are returning a cleansed name parsed out of the request description.</para>
	/// <para><c>UNKNOWN</c>: We don’t know the confidence level for this counterparty.</para>
	/// </summary>
	[JsonPropertyName("confidence_level")]
	public string? ConfidenceLevel { get; init; } = default!;

	/// <summary>
	/// <para>Account numbers associated with the counterparty, when available.</para>
	/// <para>This field is currently only filled in for select financial institutions in Europe.</para>
	/// </summary>
	[JsonPropertyName("account_numbers")]
	public Entity.CounterpartyNumbers? AccountNumbers { get; init; } = default!;

}
