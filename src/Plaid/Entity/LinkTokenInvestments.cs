namespace Going.Plaid.Entity;

/// <summary>
/// <para>Configuration parameters for the Investments product</para>
/// </summary>
public class LinkTokenInvestments
{
	/// <summary>
	/// <para>If <c>true</c>, allow self-custody crypto wallets to be added without requiring signature verification. Defaults to <c>false</c>.</para>
	/// </summary>
	[JsonPropertyName("allow_unverified_crypto_wallets")]
	public bool? AllowUnverifiedCryptoWallets { get; set; } = default!;
}