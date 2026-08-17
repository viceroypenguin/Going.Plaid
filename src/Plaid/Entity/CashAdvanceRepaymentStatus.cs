namespace Going.Plaid.Entity;

/// <summary>
/// <para>The repayment status of a cash-advance.</para>
/// </summary>
public enum CashAdvanceRepaymentStatus
{
	/// <summary>
	/// <para>The cash-advance has been fully repaid.</para>
	/// </summary>
	[EnumMember(Value = "REPAID")]
	Repaid,

	/// <summary>
	/// <para>The cash-advance has been disbursed to the user and is still outstanding, but its due date has not yet passed.</para>
	/// </summary>
	[EnumMember(Value = "DELIVERED")]
	Delivered,

	/// <summary>
	/// <para>The cash-advance is past its due date and has not been repaid; the user is delinquent.</para>
	/// </summary>
	[EnumMember(Value = "UNPAID")]
	Unpaid,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
