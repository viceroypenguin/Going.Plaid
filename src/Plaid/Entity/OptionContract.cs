namespace Going.Plaid.Entity;

/// <summary>
/// <para>Details about the option security.</para>
/// <para>For the Sandbox environment, this data is currently only available if the item is using a custom configuration object, and the <c>ticker</c> field of the custom security follows the <a href="https://en.wikipedia.org/wiki/Option_symbol#The_OCC_Option_Symbol">OCC Option Symbol</a> standard with no spaces.</para>
/// </summary>
public record OptionContract
{
	/// <summary>
	/// <para>The type of this option contract. It is one of:</para>
	/// <para><c>put</c>: for Put option contracts</para>
	/// <para><c>call</c>: for Call option contracts</para>
	/// </summary>
	[JsonPropertyName("contract_type")]
	public string ContractType { get; init; } = default!;

	/// <summary>
	/// <para>The expiration date for this option contract, in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format.</para>
	/// </summary>
	[JsonPropertyName("expiration_date")]
	public DateOnly ExpirationDate { get; init; } = default!;

	/// <summary>
	/// <para>The strike price for this option contract, per share of security.</para>
	/// </summary>
	[JsonPropertyName("strike_price")]
	public decimal StrikePrice { get; init; } = default!;

	/// <summary>
	/// <para>The ticker of the underlying security for this option contract.</para>
	/// </summary>
	[JsonPropertyName("underlying_security_ticker")]
	public string UnderlyingSecurityTicker { get; init; } = default!;

}
