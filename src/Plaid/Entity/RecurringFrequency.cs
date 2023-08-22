namespace Going.Plaid.Entity;

/// <summary>
/// <para>Describes the frequency of the transaction stream.</para>
/// </summary>
public enum RecurringFrequency
{
	/// <summary>
	/// <para>Assigned to a transaction stream that isn't recurring in nature.</para>
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
	/// <para>Assigned to a transaction stream that occurs approximately every year.</para>
	/// </summary>
	[EnumMember(Value = "ANNUALLY")]
	Annually,

	/// <summary>
	/// <para>Assigned to a transaction stream that occurs approximately every day.</para>
	/// </summary>
	[EnumMember(Value = "DAILY")]
	Daily,

	/// <summary>
	/// <para>Assigned to a transaction stream that varies in recurrence frequency. This frequency is typically seen for inflow streams in the gig economy.</para>
	/// </summary>
	[EnumMember(Value = "DYNAMIC")]
	Dynamic,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}