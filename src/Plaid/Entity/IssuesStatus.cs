namespace Going.Plaid.Entity;

/// <summary>
/// <para>The current status of the issue.</para>
/// </summary>
public enum IssuesStatus
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "REPORTED")]
	Reported,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "AWAITING_RESOLUTION")]
	AwaitingResolution,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "FIX_IN_PROGRESS")]
	FixInProgress,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "FIX_PENDING_VALIDATION")]
	FixPendingValidation,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "CANNOT_FIX")]
	CannotFix,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "RESOLVED")]
	Resolved,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
