namespace Going.Plaid.Item;

/// <summary>
/// <para>ItemPublicTokenExchangeRequest defines the request schema for <c>/item/public_token/exchange</c></para>
/// </summary>
public class ItemPublicTokenExchangeRequest : RequestBase
{
	/// <summary>
	/// <para>Your <c>public_token</c>, obtained from the Link <c>onSuccess</c> callback or <c>/sandbox/item/public_token/create</c>.</para>
	/// </summary>
	[JsonPropertyName("public_token")]
	public string PublicToken { get; set; } = default!;
}