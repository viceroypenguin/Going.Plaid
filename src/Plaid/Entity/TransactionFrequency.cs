namespace Going.Plaid.Entity;

/// <summary>
/// <para>Best guess frequency of transactions of the end customer.</para>
/// </summary>
public enum TransactionFrequency
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "once_per_month")]
	OncePerMonth,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "twice_per_month")]
	TwicePerMonth,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "four_times_per_month")]
	FourTimesPerMonth,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "daily")]
	Daily,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}