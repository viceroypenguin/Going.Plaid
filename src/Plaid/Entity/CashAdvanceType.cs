namespace Going.Plaid.Entity;

/// <summary>
/// <para>Required when <c>is_taken</c> is <c>true</c>.</para>
/// </summary>
public enum CashAdvanceType
{
	/// <summary>
	/// <para>A user's first cash-advance.</para>
	/// </summary>
	[EnumMember(Value = "FIRST")]
	First,

	/// <summary>
	/// <para>A user has previously taken out a cash-advance.</para>
	/// </summary>
	[EnumMember(Value = "REPEAT")]
	Repeat,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
