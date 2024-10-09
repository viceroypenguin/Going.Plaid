namespace Going.Plaid.DepositSwitch;

/// <summary>
/// <para>(Deprecated) DepositSwitchAltCreateResponse defines the response schema for <c>/deposit_switch/alt/create</c></para>
/// </summary>
public record DepositSwitchAltCreateResponse : ResponseBase
{
	/// <summary>
	/// <para>ID of the deposit switch. This ID is persisted throughout the lifetime of the deposit switch.</para>
	/// </summary>
	[JsonPropertyName("deposit_switch_id")]
	public string DepositSwitchId { get; init; } = default!;

}
