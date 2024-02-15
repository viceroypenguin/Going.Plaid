namespace Going.Plaid.Entity;

/// <summary>
/// <para>The details and metadata for an end user's Item.</para>
/// </summary>
public record CraPartnerInsightsItem
{
	/// <summary>
	/// <para>The ID for the institution that the user linked.</para>
	/// </summary>
	[JsonPropertyName("institution_id")]
	public string? InstitutionId { get; init; } = default!;

	/// <summary>
	/// <para>The name of the institution the user linked.</para>
	/// </summary>
	[JsonPropertyName("institution_name")]
	public string? InstitutionName { get; init; } = default!;

	/// <summary>
	/// <para>The identifier for the item.</para>
	/// </summary>
	[JsonPropertyName("item_id")]
	public string? ItemId { get; init; } = default!;

	/// <summary>
	/// <para>A list of accounts in the item</para>
	/// </summary>
	[JsonPropertyName("accounts")]
	public IReadOnlyList<Entity.CraPartnerInsightsItemAccount>? Accounts { get; init; } = default!;

}
