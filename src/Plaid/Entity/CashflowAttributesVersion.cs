namespace Going.Plaid.Entity;

/// <summary>
/// <para>The versions of cashflow attributes</para>
/// </summary>
public enum CashflowAttributesVersion
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "v1.0")]
	V10,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
