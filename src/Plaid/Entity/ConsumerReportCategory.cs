namespace Going.Plaid.Entity;

/// <summary>
/// <para>Type of data being disputed by the consumer</para>
/// </summary>
public enum ConsumerReportCategory
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "TRANSACTION")]
	Transaction,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "BALANCE")]
	Balance,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "IDENTITY")]
	Identity,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "OTHER")]
	Other,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
