namespace Going.Plaid.Entity;

/// <summary>
/// <para>The income pay frequency.</para>
/// </summary>
public enum CraVerificationIncomePayFrequency
{
	/// <summary>
	/// <para>Weekly pay frequency.</para>
	/// </summary>
	[EnumMember(Value = "WEEKLY")]
	Weekly,

	/// <summary>
	/// <para>Biweekly pay frequency.</para>
	/// </summary>
	[EnumMember(Value = "BIWEEKLY")]
	Biweekly,

	/// <summary>
	/// <para>Semi-monthly pay frequency.</para>
	/// </summary>
	[EnumMember(Value = "SEMI_MONTHLY")]
	SemiMonthly,

	/// <summary>
	/// <para>Monthly pay frequency.</para>
	/// </summary>
	[EnumMember(Value = "MONTHLY")]
	Monthly,

	/// <summary>
	/// <para>Daily pay frequency.</para>
	/// </summary>
	[EnumMember(Value = "DAILY")]
	Daily,

	/// <summary>
	/// <para>Pay frequency is unknown.</para>
	/// </summary>
	[EnumMember(Value = "UNKNOWN")]
	Unknown,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
