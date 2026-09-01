namespace Going.Plaid.Entity;

/// <summary>
/// <para>If set, skip report generation and instead fire a <c>CRA_REPORT_UPDATED</c> error webhook carrying this code. The accepted values depend on the <c>scope</c> of the subscription being simulated, since a simulation can only fire a webhook that scope would send in Production. A <c>CLIENT_USER</c> subscription accepts <c>USER_NOT_FOUND</c> and <c>PRODUCT_GENERATION_FAILED</c>; a <c>PLAID_NETWORK</c> subscription accepts <c>UNMATCH</c>, <c>DATA_UNAVAILABLE</c>, <c>NO_ELIGIBLE_ITEMS_ON_PROFILE</c>, and <c>PRODUCT_GENERATION_ERROR</c>. Supplying a code that does not match the subscription's scope returns an <c>INVALID_FIELD</c> error.</para>
/// </summary>
public enum SandboxCraServicingSimulateErrorWebhookCode
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "USER_NOT_FOUND")]
	UserNotFound,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PRODUCT_GENERATION_FAILED")]
	ProductGenerationFailed,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "UNMATCH")]
	Unmatch,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "DATA_UNAVAILABLE")]
	DataUnavailable,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "NO_ELIGIBLE_ITEMS_ON_PROFILE")]
	NoEligibleItemsOnProfile,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PRODUCT_GENERATION_ERROR")]
	ProductGenerationError,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
