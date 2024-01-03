namespace Going.Plaid.DepositSwitch;

/// <summary>
/// <para>DepositSwitchCreateResponse defines the response schema for <c>/deposit_switch/create</c></para>
/// </summary>
public record DepositSwitchCreateResponse : ResponseBase
{
	/// <summary>
	/// <para>ID of the deposit switch. This ID is persisted throughout the lifetime of the deposit switch.</para>
	/// </summary>
	[JsonPropertyName("deposit_switch_id")]
	public string DepositSwitchId { get; init; } = default!;

}
