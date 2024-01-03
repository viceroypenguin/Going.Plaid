namespace Going.Plaid.Entity;

/// <summary>
/// <para>The current state of review. All watchlist screening hits begin in a <c>pending_review</c> state but can be changed by creating a review. When a hit is in the <c>pending_review</c> state, it will always show the latest version of the watchlist data Plaid has available and be compared against the latest customer information saved in the watchlist screening. Once a hit has been marked as <c>confirmed</c> or <c>dismissed</c> it will no longer be updated so that the state is as it was when the review was first conducted.</para>
/// </summary>
public enum WatchlistScreeningHitStatus
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "confirmed")]
	Confirmed,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "pending_review")]
	PendingReview,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "dismissed")]
	Dismissed,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
