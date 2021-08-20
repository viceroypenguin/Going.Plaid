namespace Going.Plaid.Entity;

/// <summary>
/// <para>The verification status to set the account to.</para>
/// </summary>
public enum SandboxItemSetVerificationStatusRequestVerificationStatusEnum
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "automatically_verified")]
	AutomaticallyVerified,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "verification_expired")]
	VerificationExpired,
}