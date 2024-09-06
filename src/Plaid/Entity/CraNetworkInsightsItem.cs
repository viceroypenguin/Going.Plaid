namespace Going.Plaid.Entity;

/// <summary>
/// <para>Contains data about the connected Item.</para>
/// </summary>
public record CraNetworkInsightsItem
{
	/// <summary>
	/// <para>The ID for the institution the user linked.</para>
	/// </summary>
	[JsonPropertyName("institution_id")]
	public string InstitutionId { get; init; } = default!;

	/// <summary>
	/// <para>The name of the institution the user linked.</para>
	/// </summary>
	[JsonPropertyName("institution_name")]
	public string InstitutionName { get; init; } = default!;

	/// <summary>
	/// <para>The identifier for the Item.</para>
	/// </summary>
	[JsonPropertyName("item_id")]
	public string ItemId { get; init; } = default!;

}
