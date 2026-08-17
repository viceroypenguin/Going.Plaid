namespace Going.Plaid.Entity;

/// <summary>
/// <para>If set, skip report generation and instead fire a <c>CRA_REPORT_UPDATED</c> error webhook carrying this code.</para>
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
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
