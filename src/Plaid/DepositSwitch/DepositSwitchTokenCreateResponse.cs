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
	/// <para>Expiration time of the token, in ISO 8601 format</para>
	/// </summary>
	[JsonPropertyName("deposit_switch_token_expiration_time")]
	public DateTimeOffset DepositSwitchTokenExpirationTime { get; init; } = default!;
}