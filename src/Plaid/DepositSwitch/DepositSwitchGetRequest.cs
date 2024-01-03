namespace Going.Plaid.DepositSwitch;

/// <summary>
/// <para>DepositSwitchGetRequest defines the request schema for <c>/deposit_switch/get</c></para>
/// </summary>
public partial class DepositSwitchGetRequest : RequestBase
{
	/// <summary>
	/// <para>The ID of the deposit switch</para>
	/// </summary>
	[JsonPropertyName("deposit_switch_id")]
	public string DepositSwitchId { get; set; } = default!;

}
