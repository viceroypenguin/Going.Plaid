namespace Going.Plaid.Entity;

/// <summary>
/// <para>Information associated with the watchlist hit</para>
/// </summary>
public record ScreeningHitData
{
	/// <summary>
	/// <para>Dates of birth associated with the watchlist hit</para>
	/// </summary>
	[JsonPropertyName("dates_of_birth")]
	public IReadOnlyList<Entity.ScreeningHitDateOfBirthItem>? DatesOfBirth { get; init; } = default!;

	/// <summary>
	/// <para>Documents associated with the watchlist hit</para>
	/// </summary>
	[JsonPropertyName("documents")]
	public IReadOnlyList<Entity.ScreeningHitDocumentsItems>? Documents { get; init; } = default!;

	/// <summary>
	/// <para>Locations associated with the watchlist hit</para>
	/// </summary>
	[JsonPropertyName("locations")]
	public IReadOnlyList<Entity.GenericScreeningHitLocationItems>? Locations { get; init; } = default!;

	/// <summary>
	/// <para>Names associated with the watchlist hit</para>
	/// </summary>
	[JsonPropertyName("names")]
	public IReadOnlyList<Entity.ScreeningHitNamesItems>? Names { get; init; } = default!;
}