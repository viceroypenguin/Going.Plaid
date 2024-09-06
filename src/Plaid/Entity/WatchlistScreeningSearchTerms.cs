namespace Going.Plaid.Entity;

/// <summary>
/// <para>Search terms for creating an individual watchlist screening</para>
/// </summary>
public record WatchlistScreeningSearchTerms
{
	/// <summary>
	/// <para>ID of the associated program.</para>
	/// </summary>
	[JsonPropertyName("watchlist_program_id")]
	public string WatchlistProgramId { get; init; } = default!;

	/// <summary>
	/// <para>The legal name of the individual being screened. Must have at least one alphabetical character, have a maximum length of 100 characters, and not include leading or trailing spaces.</para>
	/// </summary>
	[JsonPropertyName("legal_name")]
	public string LegalName { get; init; } = default!;

	/// <summary>
	/// <para>A date in the format YYYY-MM-DD (RFC 3339 Section 5.6).</para>
	/// </summary>
	[JsonPropertyName("date_of_birth")]
	public DateOnly? DateOfBirth { get; init; } = default!;

	/// <summary>
	/// <para>The numeric or alphanumeric identifier associated with this document. Must be between 4 and 32 characters long, and cannot have leading or trailing spaces.</para>
	/// </summary>
	[JsonPropertyName("document_number")]
	public string? DocumentNumber { get; init; } = default!;

	/// <summary>
	/// <para>Valid, capitalized, two-letter ISO code representing the country of this object. Must be in ISO 3166-1 alpha-2 form.</para>
	/// </summary>
	[JsonPropertyName("country")]
	public string? Country { get; init; } = default!;

	/// <summary>
	/// <para>The current version of the search terms. Starts at <c>1</c> and increments with each edit to <c>search_terms</c>.</para>
	/// </summary>
	[JsonPropertyName("version")]
	public int Version { get; init; } = default!;

}
