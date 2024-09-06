namespace Going.Plaid.Entity;

/// <summary>
/// <para>Search terms associated with an entity used for searching against watchlists</para>
/// </summary>
public record EntityWatchlistScreeningSearchTerms
{
	/// <summary>
	/// <para>ID of the associated entity program.</para>
	/// </summary>
	[JsonPropertyName("entity_watchlist_program_id")]
	public string EntityWatchlistProgramId { get; init; } = default!;

	/// <summary>
	/// <para>The name of the organization being screened. Must have at least one alphabetical character, have a maximum length of 100 characters, and not include leading or trailing spaces.</para>
	/// </summary>
	[JsonPropertyName("legal_name")]
	public string LegalName { get; init; } = default!;

	/// <summary>
	/// <para>The numeric or alphanumeric identifier associated with this document. Must be between 4 and 32 characters long, and cannot have leading or trailing spaces.</para>
	/// </summary>
	[JsonPropertyName("document_number")]
	public string? DocumentNumber { get; init; } = default!;

	/// <summary>
	/// <para>A valid email address. Must not have leading or trailing spaces.</para>
	/// </summary>
	[JsonPropertyName("email_address")]
	public string? EmailAddress { get; init; } = default!;

	/// <summary>
	/// <para>Valid, capitalized, two-letter ISO code representing the country of this object. Must be in ISO 3166-1 alpha-2 form.</para>
	/// </summary>
	[JsonPropertyName("country")]
	public string? Country { get; init; } = default!;

	/// <summary>
	/// <para>A phone number in E.164 format.</para>
	/// </summary>
	[JsonPropertyName("phone_number")]
	public string? PhoneNumber { get; init; } = default!;

	/// <summary>
	/// <para>An 'http' or 'https' URL (must begin with either of those).</para>
	/// </summary>
	[JsonPropertyName("url")]
	public string? Url { get; init; } = default!;

	/// <summary>
	/// <para>The current version of the search terms. Starts at <c>1</c> and increments with each edit to <c>search_terms</c>.</para>
	/// </summary>
	[JsonPropertyName("version")]
	public int Version { get; init; } = default!;

}
