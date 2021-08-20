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
}