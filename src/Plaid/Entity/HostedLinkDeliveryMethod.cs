namespace Going.Plaid.Entity;

/// <summary>
/// 
/// </summary>
public enum HostedLinkDeliveryMethod
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "sms")]
	Sms,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "email")]
	Email,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
