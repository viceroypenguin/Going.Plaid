namespace Going.Plaid.Wallet;

/// <summary>
/// <para>WalletCreateRequest defines the request schema for <c>/wallet/create</c></para>
/// </summary>
public partial class WalletCreateRequest : RequestBase
{
	/// <summary>
	/// <para>An ISO-4217 currency code, used with e-wallets and transactions.</para>
	/// </summary>
	[JsonPropertyName("iso_currency_code")]
	public Entity.WalletIsoCurrencyCode IsoCurrencyCode { get; set; } = default!;

}
