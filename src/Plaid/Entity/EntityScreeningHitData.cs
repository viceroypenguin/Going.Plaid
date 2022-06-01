namespace Going.Plaid.Entity;

/// <summary>
/// <para>Information associated with the entity watchlist hit</para>
/// </summary>
public record EntityScreeningHitData
{
	/// <summary>
	/// <para>Documents associated with the watchlist hit</para>
	/// </summary>
	[JsonPropertyName("documents")]
	public IReadOnlyList<Entity.EntityScreeningHitDocumentsItems> Documents { get; init; } = default!;

	/// <summary>
	/// <para>Email addresses associated with the watchlist hit</para>
	/// </summary>
	[JsonPropertyName("email_addresses")]
	public IReadOnlyList<Entity.EntityScreeningHitEmailsItems> EmailAddresses { get; init; } = default!;

	/// <summary>
	/// <para>Locations associated with the watchlist hit</para>
	/// </summary>
	[JsonPropertyName("locations")]
	public IReadOnlyList<Entity.GenericScreeningHitLocationItems> Locations { get; init; } = default!;

	/// <summary>
	/// <para>Names associated with the watchlist hit</para>
	/// </summary>
	[JsonPropertyName("names")]
	public IReadOnlyList<Entity.EntityScreeningHitNamesItems> Names { get; init; } = default!;

	/// <summary>
	/// <para>Phone numbers associated with the watchlist hit</para>
	/// </summary>
	[JsonPropertyName("phone_numbers")]
	public IReadOnlyList<Entity.EntityScreeningHitsPhoneNumberItems> PhoneNumbers { get; init; } = default!;

	/// <summary>
	/// <para>URLs associated with the watchlist hit</para>
	/// </summary>
	[JsonPropertyName("urls")]
	public IReadOnlyList<Entity.EntityScreeningHitUrlsItems> Urls { get; init; } = default!;
}