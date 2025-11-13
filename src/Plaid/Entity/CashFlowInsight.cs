namespace Going.Plaid.Entity;

/// <summary>
/// <para>An insight that can be detected by the Cash Flow Updates product</para>
/// </summary>
public enum CashFlowInsight
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "LARGE_DEPOSIT_DETECTED")]
	LargeDepositDetected,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "LOW_BALANCE_DETECTED")]
	LowBalanceDetected,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "NEW_LOAN_PAYMENT_DETECTED")]
	NewLoanPaymentDetected,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "NSF_OVERDRAFT_DETECTED")]
	NsfOverdraftDetected,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
