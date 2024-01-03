namespace Going.Plaid.Entity;

/// <summary>
/// <para>Location information for the associated individual watchlist hit</para>
/// </summary>
public record WatchlistScreeningHitLocations
{
	/// <summary>
	/// <para>The full location string, potentially including elements like street, city, postal codes and country codes. Note that this is not necessarily a complete or well-formatted address.</para>
	/// </summary>
	[JsonPropertyName("full")]
	public string Full { get; init; } = default!;

	/// <summary>
	/// <para>Valid, capitalized, two-letter ISO code representing the country of this object. Must be in ISO 3166-1 alpha-2 form.</para>
	/// </summary>
	[JsonPropertyName("country")]
	public string Country { get; init; } = default!;

}
