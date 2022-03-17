namespace Going.Plaid.Entity;

/// <summary>
/// <para>The income pay frequency.</para>
/// </summary>
public enum CreditBankIncomePayFrequency
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
	[EnumMember(Value = "UNKNOWN")]
	Unknown,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}