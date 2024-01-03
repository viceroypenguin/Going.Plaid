namespace Going.Plaid.Entity;

/// <summary>
/// <para>The status of this Identity Verification attempt.</para>
/// </summary>
public enum IdentityVerificationStatus
{
	/// <summary>
	/// <para>The Identity Verification attempt is incomplete. The user may have completed part of the session, but has neither failed or passed.</para>
	/// </summary>
	[EnumMember(Value = "active")]
	Active,

	/// <summary>
	/// <para>The Identity Verification attempt has completed, passing all steps defined to the associated Identity Verification template</para>
	/// </summary>
	[EnumMember(Value = "success")]
	Success,

	/// <summary>
	/// <para>The user failed one or more steps in the session and was told to contact support.</para>
	/// </summary>
	[EnumMember(Value = "failed")]
	Failed,

	/// <summary>
	/// <para>The Identity Verification attempt was active for a long period of time without being completed and was automatically marked as expired. Note that sessions currently do not expire. Automatic expiration is expected to be enabled in the future.</para>
	/// </summary>
	[EnumMember(Value = "expired")]
	Expired,

	/// <summary>
	/// <para>The Identity Verification attempt was canceled, either via the dashboard by a user, or via API. The user may have completed part of the session, but has neither failed or passed.</para>
	/// </summary>
	[EnumMember(Value = "canceled")]
	Canceled,

	/// <summary>
	/// <para>The Identity Verification attempt template was configured to perform a screening that had one or more hits needing review.</para>
	/// </summary>
	[EnumMember(Value = "pending_review")]
	PendingReview,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
