namespace Going.Plaid.Entity;

/// <summary>
/// <para>The channel used to make a payment.</para>
/// </summary>
public enum PaymentChannel
{
	/// <summary>
	/// <para>transactions that took place online.</para>
	/// </summary>
	[EnumMember(Value = "online")]
	Online,

	/// <summary>
	/// <para>transactions that were made at a physical location.</para>
	/// </summary>
	[EnumMember(Value = "in store")]
	InStore,

	/// <summary>
	/// <para>transactions that relate to banks, e.g. fees or deposits.</para>
	/// </summary>
	[EnumMember(Value = "other")]
	Other,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
