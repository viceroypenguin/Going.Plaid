namespace Going.Plaid.Entity;

/// <summary>
/// <para>The customer-facing resolution state of an issue.</para>
/// </summary>
public enum BetaIssuesV1IssueStatus
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "USER_ACTION_REQUIRED")]
	UserActionRequired,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "BACKLOGGED")]
	Backlogged,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "LIKELY_TO_BE_PRIORITIZED")]
	LikelyToBePrioritized,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "IN_PROGRESS")]
	InProgress,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "RESOLVED")]
	Resolved,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PENDING_NOTIFICATION")]
	PendingNotification,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "DATA_PARTNER_NOTIFIED")]
	DataPartnerNotified,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "DATA_PARTNER_FIX_IN_PROGRESS")]
	DataPartnerFixInProgress,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
