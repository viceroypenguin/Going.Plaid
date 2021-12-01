namespace Going.Plaid.Wallet;

/// <summary>
/// <para>WalletGetRequest defines the request schema for <c>/wallet/get</c></para>
/// </summary>
public partial class WalletGetRequest : RequestBase
{
	/// <summary>
	/// <para>The ID of the e-wallet</para>
	/// </summary>
	[JsonPropertyName("wallet_id")]
	public string WalletId { get; set; } = default!;
}