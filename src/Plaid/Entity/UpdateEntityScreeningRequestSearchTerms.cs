namespace Going.Plaid.Entity;

/// <summary>
/// <para>Search terms for editing an entity watchlist screening</para>
/// </summary>
public class UpdateEntityScreeningRequestSearchTerms
{
	/// <summary>
	/// <para>ID of the associated entity program.</para>
	/// </summary>
	[JsonPropertyName("entity_watchlist_program_id")]
	public string EntityWatchlistProgramId { get; set; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("legal_name")]
	public string? LegalName { get; set; } = default!;

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

	/// <summary>
	/// <para>Your Plaid API <c>client_id</c>. The <c>client_id</c> is required and may be provided either in the <c>PLAID-CLIENT-ID</c> header or as part of a request body.</para>
	/// </summary>
	[JsonPropertyName("client_id")]
	public string ClientId { get; set; } = default!;

	/// <summary>
	/// <para>Your Plaid API <c>secret</c>. The <c>secret</c> is required and may be provided either in the <c>PLAID-SECRET</c> header or as part of a request body.</para>
	/// </summary>
	[JsonPropertyName("secret")]
	public string Secret { get; set; } = default!;
}