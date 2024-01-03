namespace Going.Plaid.Entity;

/// <summary>
/// <para>A status enum indicating whether a screening is still pending review, has been rejected, or has been cleared.</para>
/// </summary>
public enum WatchlistScreeningStatus
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "rejected")]
	Rejected,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "pending_review")]
	PendingReview,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "cleared")]
	Cleared,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
