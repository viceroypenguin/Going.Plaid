namespace Going.Plaid.Entity;

/// <summary>
/// <para>How Plaid should deliver the Plaid Link session to the customer. Only available to customers enabled for Link Delivery (beta). To request Link Delivery access, contact your account manager.</para>
/// </summary>
public enum HostedLinkDeliveryMethod
{
	/// <summary>
	/// <para>will deliver via SMS. Must pass <c>user.phone_number</c>.</para>
	/// </summary>
	[EnumMember(Value = "sms")]
	Sms,

	/// <summary>
	/// <para>will deliver via email. Must pass <c>user.email_address</c>. In the Sandbox environment, this field will be ignored; use the Production environment to test Link Delivery instead.</para>
	/// </summary>
	[EnumMember(Value = "email")]
	Email,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
