namespace Going.Plaid.DepositSwitch;

/// <summary>
/// <para>DepositSwitchTokenCreateResponse defines the response schema for <c>/deposit_switch/token/create</c></para>
/// </summary>
public record DepositSwitchTokenCreateResponse : ResponseBase
{
	/// <summary>
	/// <para>Deposit switch token, used to initialize Link for the Deposit Switch product</para>
	/// </summary>
	[JsonPropertyName("deposit_switch_token")]
	public string DepositSwitchToken { get; init; } = default!;

	/// <summary>
	/// <para>Expiration time of the token, in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format</para>
	/// </summary>
	[JsonPropertyName("deposit_switch_token_expiration_time")]
	public DateTimeOffset DepositSwitchTokenExpirationTime { get; init; } = default!;
}