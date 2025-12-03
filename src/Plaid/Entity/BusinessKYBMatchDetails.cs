namespace Going.Plaid.Entity;

/// <summary>
/// <para>Detailed information about the business from data provider results</para>
/// </summary>
public record BusinessKYBMatchDetails
{
	/// <summary>
	/// <para>The business name from the data provider</para>
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; init; } = default!;

	/// <summary>
	/// <para>The legal structure or type of business entity</para>
	/// </summary>
	[JsonPropertyName("entity_type")]
	public Entity.BusinessEntityType EntityType { get; init; } = default!;

	/// <summary>
	/// <para>Addresses associated with the business</para>
	/// </summary>
	[JsonPropertyName("addresses")]
	public IReadOnlyList<Entity.ProviderBusinessAddress> Addresses { get; init; } = default!;

	/// <summary>
	/// <para>Phone numbers associated with the business</para>
	/// </summary>
	[JsonPropertyName("phone_numbers")]
	public IReadOnlyList<Entity.BusinessPhoneNumber> PhoneNumbers { get; init; } = default!;

	/// <summary>
	/// <para>Email addresses associated with the business</para>
	/// </summary>
	[JsonPropertyName("email_addresses")]
	public IReadOnlyList<Entity.BusinessEmailAddress> EmailAddresses { get; init; } = default!;

	/// <summary>
	/// <para>Websites associated with the business</para>
	/// </summary>
	[JsonPropertyName("websites")]
	public IReadOnlyList<Entity.BusinessWebsite> Websites { get; init; } = default!;

	/// <summary>
	/// <para>A date in the format YYYY-MM-DD (RFC 3339 Section 5.6).</para>
	/// </summary>
	[JsonPropertyName("formation_date")]
	public DateOnly? FormationDate { get; init; } = default!;

}
