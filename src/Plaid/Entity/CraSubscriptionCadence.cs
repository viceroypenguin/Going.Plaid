namespace Going.Plaid.Entity;

/// <summary>
/// <para>The cadence at which products are generated and webhooks are fired. If the Qualify product is requested, cadence must be null or omitted, because Qualify's generation cadence is controlled by Plaid.</para>
/// </summary>
public enum CraSubscriptionCadence
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "DAILY")]
	Daily,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
