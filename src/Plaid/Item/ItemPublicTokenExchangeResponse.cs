namespace Going.Plaid.Item;

/// <summary>
/// <para>ItemPublicTokenExchangeResponse defines the response schema for <c>/item/public_token/exchange</c></para>
/// </summary>
public record ItemPublicTokenExchangeResponse : ResponseBase
{
	/// <summary>
	/// <para>The <c>item_id</c> value of the Item associated with the returned <c>access_token</c></para>
	/// </summary>
	[JsonPropertyName("item_id")]
	public string ItemId { get; init; } = default!;
}