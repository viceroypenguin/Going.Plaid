namespace Going.Plaid.Entity;

/// <summary>
/// <para>The status of the given end customer.</para>
/// </summary>
public enum PartnerEndCustomerStatus
{
	/// <summary>
	/// <para>The end customer has been created and enabled in the non-Production environments. The end customer must be manually reviewed by the Plaid team before it can be enabled in production, at which point its status will automatically transition to <c>PENDING_ENABLEMENT</c> or <c>DENIED</c>.</para>
	/// </summary>
	[EnumMember(Value = "UNDER_REVIEW")]
	UnderReview,

	/// <summary>
	/// <para>The end customer is ready to be enabled in the Production environment. Call the <c>/partner/customer/enable</c> endpoint to enable the end customer in Production.</para>
	/// </summary>
	[EnumMember(Value = "PENDING_ENABLEMENT")]
	PendingEnablement,

	/// <summary>
	/// <para>The end customer has been enabled in all environments.</para>
	/// </summary>
	[EnumMember(Value = "ACTIVE")]
	Active,

	/// <summary>
	/// <para>The end customer has been created and enabled in the non-Production environments, but it did not pass review by the Plaid team and therefore cannot be enabled in the Production environment. Talk to your Account Manager for more information.</para>
	/// </summary>
	[EnumMember(Value = "DENIED")]
	Denied,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
