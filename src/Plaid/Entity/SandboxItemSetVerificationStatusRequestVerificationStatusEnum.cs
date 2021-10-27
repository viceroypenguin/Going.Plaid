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

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}