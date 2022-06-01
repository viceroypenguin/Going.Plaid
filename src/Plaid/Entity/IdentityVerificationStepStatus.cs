namespace Going.Plaid.Entity;

/// <summary>
/// <para>The status of a step in the identity verification process.</para>
/// </summary>
public enum IdentityVerificationStepStatus
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "success")]
	Success,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "active")]
	Active,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "failed")]
	Failed,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "waiting_for_prerequisite")]
	WaitingForPrerequisite,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "not_applicable")]
	NotApplicable,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "skipped")]
	Skipped,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "expired")]
	Expired,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "canceled")]
	Canceled,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "pending_review")]
	PendingReview,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "manually_approved")]
	ManuallyApproved,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "manually_rejected")]
	ManuallyRejected,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}