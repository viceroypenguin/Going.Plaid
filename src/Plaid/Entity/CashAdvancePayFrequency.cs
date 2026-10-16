namespace Going.Plaid.Entity;

/// <summary>
/// <para>The pay cadence of an income stream. <c>DYNAMIC</c> means the income recurs, but not on a regular schedule. <c>null</c> if the pay frequency could not be determined.</para>
/// </summary>
public enum CashAdvancePayFrequency
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "WEEKLY")]
	Weekly,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "BIWEEKLY")]
	Biweekly,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "SEMI_MONTHLY")]
	SemiMonthly,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "MONTHLY")]
	Monthly,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ANNUALLY")]
	Annually,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "DAILY")]
	Daily,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "DYNAMIC")]
	Dynamic,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
