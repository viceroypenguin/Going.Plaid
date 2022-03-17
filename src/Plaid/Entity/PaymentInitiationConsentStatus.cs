namespace Going.Plaid.Entity;

/// <summary>
/// <para>The status of the payment consent.</para>
/// </summary>
public enum PaymentInitiationConsentStatus
{
	/// <summary>
	/// <para>Consent created, but requires user authorisation.</para>
	/// </summary>
	[EnumMember(Value = "UNAUTHORISED")]
	Unauthorised,

	/// <summary>
	/// <para>Consent is active and ready to be used.</para>
	/// </summary>
	[EnumMember(Value = "AUTHORISED")]
	Authorised,

	/// <summary>
	/// <para>Consent has been revoked and can no longer be used.</para>
	/// </summary>
	[EnumMember(Value = "REVOKED")]
	Revoked,

	/// <summary>
	/// <para>Consent authorisation was rejected by the user and/or the bank.</para>
	/// </summary>
	[EnumMember(Value = "REJECTED")]
	Rejected,

	/// <summary>
	/// <para>Consent is no longer valid.</para>
	/// </summary>
	[EnumMember(Value = "EXPIRED")]
	Expired,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}