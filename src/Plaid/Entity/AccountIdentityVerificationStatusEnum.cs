namespace Going.Plaid.Entity;

/// <summary>
/// <para>The current verification status of an Auth Item initiated through micro-deposits or database verification. Returned for Auth Items only.</para>
/// </summary>
public enum AccountIdentityVerificationStatusEnum
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
	/// <para>The Item is pending micro-deposit verification, but Plaid has not yet sent the micro-deposit.</para>
	/// </summary>
	[EnumMember(Value = "unsent")]
	Unsent,

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
	/// <para>The Item has successfully been verified using Plaid's data sources. Only returned for Auth Items created via Database Match.</para>
	/// </summary>
	[EnumMember(Value = "database_matched")]
	DatabaseMatched,

	/// <summary>
	/// <para>The Item's numbers have been verified using Plaid's data sources: the routing and account number match a routing and account number of an account recognized on the Plaid network, and the account is not known by Plaid to be frozen or closed. Only returned for Auth Items created via Database Auth.</para>
	/// </summary>
	[EnumMember(Value = "database_insights_pass")]
	DatabaseInsightsPass,

	/// <summary>
	/// <para>The Item's numbers have been verified using Plaid's data sources and have some signal for being valid: the routing and account number were not recognized on the Plaid network, but the routing number is valid and the account number is a potential valid account number for that routing number. Only returned for Auth Items created via Database Auth.</para>
	/// </summary>
	[EnumMember(Value = "database_insights_pass_with_caution")]
	DatabaseInsightsPassWithCaution,

	/// <summary>
	/// <para>The Item's numbers have been verified using Plaid's data sources and have signal for being invalid and/or have no signal for being valid. Typically this indicates that the routing number is invalid, the account number does not match the account number format associated with the routing number, or the account has been reported as closed or frozen. Only returned for Auth Items created via Database Auth.</para>
	/// </summary>
	[EnumMember(Value = "database_insights_fail")]
	DatabaseInsightsFail,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
