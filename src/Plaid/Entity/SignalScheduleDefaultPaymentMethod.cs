namespace Going.Plaid.Entity;

/// <summary>
/// <para>The payment method specified in the <c>default_payment_method</c> field directly impacts the timing recommendations provided by the API for submitting the debit entry to your processor or ODFI. If unspecified, defaults to <c>STANDARD_ACH</c>.</para>
/// </summary>
public enum SignalScheduleDefaultPaymentMethod
{
	/// <summary>
	/// <para>Same Day ACH (as defined by Nacha). The API assumes the settlement will occur on the same business day if the <c>/signal/schedule</c> request is submitted by 6:00 PM UTC. Note: The actual cutoff time can vary depending on your payment processor or ODFI. Nacha has established three processing windows for Same Day ACH (UTC): 2:30 PM, 6:45 PM, and 8:45 PM.</para>
	/// </summary>
	[EnumMember(Value = "SAME_DAY_ACH")]
	SameDayAch,

	/// <summary>
	/// <para>Standard ACH (as defined by Nacha), typically settled one to three business days after submission.</para>
	/// </summary>
	[EnumMember(Value = "STANDARD_ACH")]
	StandardAch,

	/// <summary>
	/// <para>Indicates that there is no default debit rail or multiple payment methods are available, and the transaction could use any of them based on customer policy or availability.</para>
	/// </summary>
	[EnumMember(Value = "MULTIPLE_PAYMENT_METHODS")]
	MultiplePaymentMethods,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
