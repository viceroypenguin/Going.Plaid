namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object representing the e-wallet balance</para>
/// </summary>
public record WalletBalance
{
	/// <summary>
	/// <para>The ISO-4217 currency code of the balance</para>
	/// </summary>
	[JsonPropertyName("iso_currency_code")]
	public string IsoCurrencyCode { get; init; } = default!;

	/// <summary>
	/// <para>The total amount of funds in the account</para>
	/// </summary>
	[JsonPropertyName("current")]
	public decimal Current { get; init; } = default!;

	/// <summary>
	/// <para>The total amount of funds in the account after subtracting pending debit transaction amounts</para>
	/// </summary>
	[JsonPropertyName("available")]
	public decimal Available { get; init; } = default!;

}
