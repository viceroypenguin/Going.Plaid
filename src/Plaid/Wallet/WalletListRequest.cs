namespace Going.Plaid.Wallet;

/// <summary>
/// <para>WalletListRequest defines the request schema for <c>/wallet/list</c></para>
/// </summary>
public partial class WalletListRequest : RequestBase
{
	/// <summary>
	/// <para>An ISO-4217 currency code, used with e-wallets and transactions.</para>
	/// </summary>
	[JsonPropertyName("iso_currency_code")]
	public Entity.IsoCurrencyCode? IsoCurrencyCode { get; set; } = default!;

	/// <summary>
	/// <para>A base64 value representing the latest e-wallet that has already been requested. Set this to <c>next_cursor</c> received from the previous <c>/wallet/list</c> request. If provided, the response will only contain e-wallets created before that e-wallet. If omitted, the response will contain e-wallets starting from the most recent, and in descending order.</para>
	/// </summary>
	[JsonPropertyName("cursor")]
	public string? Cursor { get; set; } = default!;

	/// <summary>
	/// <para>The number of e-wallets to fetch</para>
	/// </summary>
	[JsonPropertyName("count")]
	public int? Count { get; set; } = default!;
}