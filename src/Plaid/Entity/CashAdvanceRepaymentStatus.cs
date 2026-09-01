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
	/// <para>A payment has been made on the cash-advance, but there is still an outstanding balance.</para>
	/// </summary>
	[EnumMember(Value = "PARTIAL_PAYMENT")]
	PartialPayment,

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
