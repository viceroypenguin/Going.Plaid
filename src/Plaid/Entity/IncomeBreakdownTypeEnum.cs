namespace Going.Plaid.Entity;

/// <summary>
/// <para>The type of income. Possible values include:</para>
/// </summary>
public enum IncomeBreakdownTypeEnum
{
	/// <summary>
	/// <para>bonus income</para>
	/// </summary>
	[EnumMember(Value = "bonus")]
	Bonus,

	/// <summary>
	/// <para>overtime income</para>
	/// </summary>
	[EnumMember(Value = "overtime")]
	Overtime,

	/// <summary>
	/// <para>regular income</para>
	/// </summary>
	[EnumMember(Value = "regular")]
	Regular,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}