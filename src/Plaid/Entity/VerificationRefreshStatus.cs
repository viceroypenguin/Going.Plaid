namespace Going.Plaid.Entity;

/// <summary>
/// <para>The verification refresh status. One of the following:</para>
/// </summary>
public enum VerificationRefreshStatus
{
	/// <summary>
	/// <para>User presence is required to refresh an income verification.</para>
	/// </summary>
	[EnumMember(Value = "VERIFICATION_REFRESH_STATUS_USER_PRESENCE_REQUIRED")]
	VerificationRefreshStatusUserPresenceRequired,
}