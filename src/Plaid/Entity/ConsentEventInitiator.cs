namespace Going.Plaid.Entity;

/// <summary>
/// <para>The entity that initiated collection of consent.</para>
/// </summary>
public enum ConsentEventInitiator
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PLAID")]
	Plaid,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "DATA_PROVIDER")]
	DataProvider,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "CUSTOMER")]
	Customer,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "END_USER")]
	EndUser,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
