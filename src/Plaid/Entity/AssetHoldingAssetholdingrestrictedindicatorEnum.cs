namespace Going.Plaid.Entity;

/// <summary>
/// <para>Whether or not the stock is restricted, i.e. "Restricted" or "Not Restricted"</para>
/// </summary>
public enum AssetHoldingAssetholdingrestrictedindicatorEnum
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "Yes")]
	Yes,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "No")]
	No,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
