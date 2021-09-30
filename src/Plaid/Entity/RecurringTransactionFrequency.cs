namespace Going.Plaid.Entity;

/// <summary>
/// <para>describes the frequency of the transaction stream.</para>
/// </summary>
public enum RecurringTransactionFrequency
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "UNKNOWN")]
	Unknown,

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
}