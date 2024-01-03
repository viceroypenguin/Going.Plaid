namespace Going.Plaid.Entity;

/// <summary>
/// <para>Specifies options for initializing Link for use with the Deposit Switch (beta) product. This field is required if <c>deposit_switch</c> is included in the <c>products</c> array.</para>
/// </summary>
public class LinkTokenCreateRequestDepositSwitch
{
	/// <summary>
	/// <para>The <c>deposit_switch_id</c> provided by the <c>/deposit_switch/create</c> endpoint.</para>
	/// </summary>
	[JsonPropertyName("deposit_switch_id")]
	public string DepositSwitchId { get; set; } = default!;

}
