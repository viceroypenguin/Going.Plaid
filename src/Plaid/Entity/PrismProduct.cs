namespace Going.Plaid.Entity;

/// <summary>
/// <para>The Prism products that can be returned by the Plaid API</para>
/// </summary>
public enum PrismProduct
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "insights")]
	Insights,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "scores")]
	Scores,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
