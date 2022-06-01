namespace Going.Plaid.Entity;

/// <summary>
/// <para>Search inputs for creating an entity watchlist screening</para>
/// </summary>
public class EntityWatchlistSearchTerms
{
	/// <summary>
	/// <para>ID of the associated entity program.</para>
	/// </summary>
	[JsonPropertyName("entity_watchlist_program_id")]
	public string EntityWatchlistProgramId { get; set; } = default!;

	/// <summary>
	/// <para>The name of the organization being screened.</para>
	/// </summary>
	[JsonPropertyName("legal_name")]
	public string LegalName { get; set; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("document_number")]
	public string? DocumentNumber { get; set; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("email_address")]
	public string? EmailAddress { get; set; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("country")]
	public string? Country { get; set; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("phone_number")]
	public string? PhoneNumber { get; set; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("url")]
	public string? Url { get; set; } = default!;
}