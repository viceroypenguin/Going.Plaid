namespace Going.Plaid.Entity;

/// <summary>
/// <para>Names that are explicitly marked as low quality either by their <c>source</c> list, or by <c>plaid</c> by a series of additional checks done by Plaid. Plaid does not ever surface a hit as a result of a weak name alone. If a name has no quality issues, this value will be <c>none</c>.</para>
/// </summary>
public enum WeakAliasDetermination
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "none")]
	None,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "source")]
	Source,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "plaid")]
	Plaid,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}