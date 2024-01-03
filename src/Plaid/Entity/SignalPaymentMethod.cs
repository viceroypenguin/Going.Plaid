namespace Going.Plaid.Entity;

/// <summary>
/// <para>The payment method to complete the transaction after the risk assessment. It may be different from the default payment method.</para>
/// </summary>
public enum SignalPaymentMethod
{
	/// <summary>
	/// <para>Same Day ACH by NACHA. The debit transaction is processed and settled on the same day</para>
	/// </summary>
	[EnumMember(Value = "SAME_DAY_ACH")]
	SameDayAch,

	/// <summary>
	/// <para>Next Day ACH settlement for debit transactions, offered by some payment processors</para>
	/// </summary>
	[EnumMember(Value = "NEXT_DAY_ACH")]
	NextDayAch,

	/// <summary>
	/// <para>standard ACH by NACHA</para>
	/// </summary>
	[EnumMember(Value = "STANDARD_ACH")]
	StandardAch,

	/// <summary>
	/// <para>real-time payments such as RTP and FedNow</para>
	/// </summary>
	[EnumMember(Value = "REAL_TIME_PAYMENTS")]
	RealTimePayments,

	/// <summary>
	/// <para>if the default payment is over debit card networks</para>
	/// </summary>
	[EnumMember(Value = "DEBIT_CARD")]
	DebitCard,

	/// <summary>
	/// <para>if there is no default debit rail or there are multiple payment methods</para>
	/// </summary>
	[EnumMember(Value = "MULTIPLE_PAYMENT_METHODS")]
	MultiplePaymentMethods,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
