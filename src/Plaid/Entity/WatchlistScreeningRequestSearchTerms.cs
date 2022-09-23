namespace Going.Plaid.Entity;

/// <summary>
/// <para>Search inputs for creating a watchlist screening</para>
/// </summary>
public class WatchlistScreeningRequestSearchTerms
{
	/// <summary>
	/// <para>ID of the associated program.</para>
	/// </summary>
	[JsonPropertyName("watchlist_program_id")]
	public string WatchlistProgramId { get; set; } = default!;

	/// <summary>
	/// <para>The legal name of the individual being screened.</para>
	/// </summary>
	[JsonPropertyName("legal_name")]
	public string LegalName { get; set; } = default!;

	/// <summary>
	/// <para>A date in the format YYYY-MM-DD (RFC 3339 Section 5.6).</para>
	/// </summary>
	[JsonPropertyName("date_of_birth")]
	public DateOnly DateOfBirth { get; set; } = default!;

	/// <summary>
	/// <para>The numeric or alphanumeric identifier associated with this document.</para>
	/// </summary>
	[JsonPropertyName("document_number")]
	public string DocumentNumber { get; set; } = default!;

	/// <summary>
	/// <para>Valid, capitalized, two-letter ISO code representing the country of this object. Must be in ISO 3166-1 alpha-2 form.</para>
	/// </summary>
	[JsonPropertyName("country")]
	public string Country { get; set; } = default!;
}