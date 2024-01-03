namespace Going.Plaid.Entity;

/// <summary>
/// 
/// </summary>
public enum DepositSwitchGetResponseSwitchMethodEnum
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "instant")]
	Instant,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "mail")]
	Mail,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "pdf")]
	Pdf,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
