namespace Going.Plaid.Entity;

/// <summary>
/// <para>The reason for terminating products.</para>
/// </summary>
public enum ProductsTerminateReasonCode
{
	/// <summary>
	/// <para>The end user who owns the connected bank account committed fraud using their real identity</para>
	/// </summary>
	[EnumMember(Value = "FRAUD_FIRST_PARTY")]
	FraudFirstParty,

	/// <summary>
	/// <para>The connection was created using a false or stolen identity</para>
	/// </summary>
	[EnumMember(Value = "FRAUD_FALSE_IDENTITY")]
	FraudFalseIdentity,

	/// <summary>
	/// <para>The end user is abusing the client's service or platform (for example, automation or excessive retries) through their connected account</para>
	/// </summary>
	[EnumMember(Value = "FRAUD_ABUSE")]
	FraudAbuse,

	/// <summary>
	/// <para>Fraud-related, but not covered by the specific fraud categories above; <c>reason_note</c> should clarify</para>
	/// </summary>
	[EnumMember(Value = "FRAUD_OTHER")]
	FraudOther,

	/// <summary>
	/// <para>Fraud occurred at the transaction level, such as an unauthorized transaction, card testing, chargeback, ACH return, or dispute</para>
	/// </summary>
	[EnumMember(Value = "FRAUD_TRANSACTION")]
	FraudTransaction,

	/// <summary>
	/// <para>The end user paid off their loan and no longer needs the product</para>
	/// </summary>
	[EnumMember(Value = "CONSUMER_LOAN_PAID_OFF")]
	ConsumerLoanPaidOff,

	/// <summary>
	/// <para>The end user closed their account with the client and no longer needs the product</para>
	/// </summary>
	[EnumMember(Value = "CONSUMER_ACCOUNT_CLOSED")]
	ConsumerAccountClosed,

	/// <summary>
	/// <para>The end user's account has been charged off</para>
	/// </summary>
	[EnumMember(Value = "CONSUMER_CHARGE_OFF")]
	ConsumerChargeOff,

	/// <summary>
	/// <para>The end user switched to a different payment method and no longer needs the product</para>
	/// </summary>
	[EnumMember(Value = "CONSUMER_PAYMENT_METHOD_SWITCHED")]
	ConsumerPaymentMethodSwitched,

	/// <summary>
	/// <para>The user is offboarding from the client's service or platform</para>
	/// </summary>
	[EnumMember(Value = "USER_OFFBOARDING")]
	UserOffboarding,

	/// <summary>
	/// <para>This Item is a duplicate of another active Item for the same user</para>
	/// </summary>
	[EnumMember(Value = "DUPLICATE_ITEM")]
	DuplicateItem,

	/// <summary>
	/// <para>The client's billing or subscription relationship with the end user has ended</para>
	/// </summary>
	[EnumMember(Value = "BILLING_TERMINATION")]
	BillingTermination,

	/// <summary>
	/// <para>None of the above; <c>reason_note</c> should clarify</para>
	/// </summary>
	[EnumMember(Value = "OTHER")]
	Other,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
