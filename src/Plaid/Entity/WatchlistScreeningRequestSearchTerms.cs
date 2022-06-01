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
	/// 
	/// </summary>
	[JsonPropertyName("date_of_birth")]
	public string? DateOfBirth { get; set; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("document_number")]
	public string? DocumentNumber { get; set; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("country")]
	public string? Country { get; set; } = default!;
}