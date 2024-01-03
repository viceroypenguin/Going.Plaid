namespace Going.Plaid.DepositSwitch;

/// <summary>
/// <para>DepositSwitchTokenCreateRequest defines the request schema for <c>/deposit_switch/token/create</c></para>
/// </summary>
public partial class DepositSwitchTokenCreateRequest : RequestBase
{
	/// <summary>
	/// <para>The ID of the deposit switch</para>
	/// </summary>
	[JsonPropertyName("deposit_switch_id")]
	public string DepositSwitchId { get; set; } = default!;

}
