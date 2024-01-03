namespace Going.Plaid.Entity;

/// <summary>
/// <para>A status of a Beacon User.</para>
/// </summary>
public enum BeaconUserStatus
{
	/// <summary>
	/// <para>The Beacon User has been rejected for fraud. Users can be automatically or manually rejected.</para>
	/// </summary>
	[EnumMember(Value = "rejected")]
	Rejected,

	/// <summary>
	/// <para>The Beacon User has been marked for review.</para>
	/// </summary>
	[EnumMember(Value = "pending_review")]
	PendingReview,

	/// <summary>
	/// <para>The Beacon User has been cleared of fraud.</para>
	/// </summary>
	[EnumMember(Value = "cleared")]
	Cleared,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
