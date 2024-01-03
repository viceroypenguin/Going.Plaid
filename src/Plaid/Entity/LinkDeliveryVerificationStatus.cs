namespace Going.Plaid.Entity;

/// <summary>
/// <para>Indicates an Item's micro-deposit-based verification status.</para>
/// </summary>
public enum LinkDeliveryVerificationStatus
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "automatically_verified")]
	AutomaticallyVerified,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "pending_automatic_verification")]
	PendingAutomaticVerification,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "pending_manual_verification")]
	PendingManualVerification,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "manually_verified")]
	ManuallyVerified,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "verification_expired")]
	VerificationExpired,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "verification_failed")]
	VerificationFailed,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "database_matched")]
	DatabaseMatched,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
