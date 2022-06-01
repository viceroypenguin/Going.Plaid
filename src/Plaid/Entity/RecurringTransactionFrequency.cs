namespace Going.Plaid.Entity;

/// <summary>
/// <para>Describes the frequency of the transaction stream.</para>
/// </summary>
public enum RecurringTransactionFrequency
{
	/// <summary>
	/// <para>Assigned to a transaction stream that does not fit any of the pre-defined frequencies.</para>
	/// </summary>
	[EnumMember(Value = "UNKNOWN")]
	Unknown,

	/// <summary>
	/// <para>Assigned to a transaction stream that occurs approximately every week.</para>
	/// </summary>
	[EnumMember(Value = "WEEKLY")]
	Weekly,

	/// <summary>
	/// <para>Assigned to a transaction stream that occurs approximately every 2 weeks.</para>
	/// </summary>
	[EnumMember(Value = "BIWEEKLY")]
	Biweekly,

	/// <summary>
	/// <para>Assigned to a transaction stream that occurs approximately twice per month. This frequency is typically seen for inflow transaction streams.</para>
	/// </summary>
	[EnumMember(Value = "SEMI_MONTHLY")]
	SemiMonthly,

	/// <summary>
	/// <para>Assigned to a transaction stream that occurs approximately every month.</para>
	/// </summary>
	[EnumMember(Value = "MONTHLY")]
	Monthly,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}