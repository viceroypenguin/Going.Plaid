namespace Going.Plaid.Entity;

/// <summary>
/// <para>The possible types of auth data that may have changed.</para>
/// </summary>
public enum AuthUpdateTypes
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ACCOUNT_NUMBER")]
	AccountNumber,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ROUTING_NUMBER")]
	RoutingNumber,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
