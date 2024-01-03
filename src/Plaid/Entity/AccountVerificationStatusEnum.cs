namespace Going.Plaid.Entity;

/// <summary>
/// <para>The current verification status of an Auth Item initiated through Automated or Manual micro-deposits.  Returned for Auth Items only.</para>
/// </summary>
public enum AccountVerificationStatusEnum
{
	/// <summary>
	/// <para>The Item has successfully been automatically verified</para>
	/// </summary>
	[EnumMember(Value = "automatically_verified")]
	AutomaticallyVerified,

	/// <summary>
	/// <para>The Item is pending automatic verification</para>
	/// </summary>
	[EnumMember(Value = "pending_automatic_verification")]
	PendingAutomaticVerification,

	/// <summary>
	/// <para>The Item is pending manual micro-deposit verification. Items remain in this state until the user successfully verifies the micro-deposit.</para>
	/// </summary>
	[EnumMember(Value = "pending_manual_verification")]
	PendingManualVerification,

	/// <summary>
	/// <para>The Item has successfully been manually verified</para>
	/// </summary>
	[EnumMember(Value = "manually_verified")]
	ManuallyVerified,

	/// <summary>
	/// <para>Plaid was unable to automatically verify the deposit within 7 calendar days and will no longer attempt to validate the Item. Users may retry by submitting their information again through Link.</para>
	/// </summary>
	[EnumMember(Value = "verification_expired")]
	VerificationExpired,

	/// <summary>
	/// <para>The Item failed manual micro-deposit verification because the user exhausted all 3 verification attempts. Users may retry by submitting their information again through Link.</para>
	/// </summary>
	[EnumMember(Value = "verification_failed")]
	VerificationFailed,

	/// <summary>
	/// <para>The Item has successfully been verified using Plaid's data sources. Note: Database Match is currently a beta feature, please contact your account manager for more information.</para>
	/// </summary>
	[EnumMember(Value = "database_matched")]
	DatabaseMatched,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
