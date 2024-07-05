namespace Going.Plaid.Entity;

/// <summary>
/// <para>An Item created during a Layer authorization session.</para>
/// </summary>
public record UserAccountItem
{
	/// <summary>
	/// <para>The Plaid Item ID. The <c>item_id</c> is always unique; linking the same account at the same institution twice will result in two Items with different <c>item_id</c> values. Like all Plaid identifiers, the <c>item_id</c> is case-sensitive.</para>
	/// </summary>
	[JsonPropertyName("item_id")]
	public string? ItemId { get; init; } = default!;

	/// <summary>
	/// <para>The access token associated with the Item data is being requested for.</para>
	/// </summary>
	[JsonPropertyName("access_token")]
	public string? AccessToken { get; init; } = default!;

}
