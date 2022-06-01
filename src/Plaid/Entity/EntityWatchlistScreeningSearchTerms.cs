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
	/// <para>The name of the organization being screened.</para>
	/// </summary>
	[JsonPropertyName("legal_name")]
	public string LegalName { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("document_number")]
	public string? DocumentNumber { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("email_address")]
	public string? EmailAddress { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("country")]
	public string? Country { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("phone_number")]
	public string? PhoneNumber { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("url")]
	public string? Url { get; init; } = default!;

	/// <summary>
	/// <para>The current version of the search terms. Starts at <c>1</c> and increments with each edit to <c>search_terms</c>.</para>
	/// </summary>
	[JsonPropertyName("version")]
	public decimal Version { get; init; } = default!;
}