namespace Going.Plaid.Entity;

/// <summary>
/// <para>The details of an item add in link</para>
/// </summary>
public record CreditSessionItemAddResult
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("item_id")]
	public string ItemId { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("public_token")]
	public string PublicToken { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("institution_id")]
	public string InstitutionId { get; init; } = default!;
}