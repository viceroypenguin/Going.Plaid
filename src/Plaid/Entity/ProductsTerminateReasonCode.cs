namespace Going.Plaid.Entity;

/// <summary>
/// <para>The reason for terminating products.</para>
/// </summary>
public enum ProductsTerminateReasonCode
{
	/// <summary>
	/// <para>The end user who owns the connected bank account committed fraud</para>
	/// </summary>
	[EnumMember(Value = "FRAUD_FIRST_PARTY")]
	FraudFirstParty,

	/// <summary>
	/// <para>The end user created the connection using false identity information or stolen credentials</para>
	/// </summary>
	[EnumMember(Value = "FRAUD_FALSE_IDENTITY")]
	FraudFalseIdentity,

	/// <summary>
	/// <para>The end user is abusing the client's service or platform through their connected account</para>
	/// </summary>
	[EnumMember(Value = "FRAUD_ABUSE")]
	FraudAbuse,

	/// <summary>
	/// <para>Other fraud-related reasons involving the end user not covered by the specific fraud categories</para>
	/// </summary>
	[EnumMember(Value = "FRAUD_OTHER")]
	FraudOther,

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
	/// <para>The user is offboarding from the service or platform</para>
	/// </summary>
	[EnumMember(Value = "USER_OFFBOARDING")]
	UserOffboarding,

	/// <summary>
	/// <para>The connection is a duplicate of another existing connection for the same user</para>
	/// </summary>
	[EnumMember(Value = "DUPLICATE_ITEM")]
	DuplicateItem,

	/// <summary>
	/// <para>The user's billing or subscription relationship has ended</para>
	/// </summary>
	[EnumMember(Value = "BILLING_TERMINATION")]
	BillingTermination,

	/// <summary>
	/// <para>Any other reason for terminating products not covered by the above categories</para>
	/// </summary>
	[EnumMember(Value = "OTHER")]
	Other,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
