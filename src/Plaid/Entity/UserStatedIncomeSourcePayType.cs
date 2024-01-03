namespace Going.Plaid.Entity;

/// <summary>
/// <para>The pay type - <c>GROSS</c>, <c>NET</c>, or <c>UNKNOWN</c> for a specified income source</para>
/// </summary>
public enum UserStatedIncomeSourcePayType
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "UNKNOWN")]
	Unknown,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "GROSS")]
	Gross,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "NET")]
	Net,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
