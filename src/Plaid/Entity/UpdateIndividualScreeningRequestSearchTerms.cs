namespace Going.Plaid.Entity;

/// <summary>
/// <para>Search terms for editing an individual watchlist screening</para>
/// </summary>
public class UpdateIndividualScreeningRequestSearchTerms
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("watchlist_program_id")]
	public string? WatchlistProgramId { get; set; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("legal_name")]
	public string? LegalName { get; set; } = default!;

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