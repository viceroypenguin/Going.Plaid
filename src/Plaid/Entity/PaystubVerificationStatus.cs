namespace Going.Plaid.Entity;

/// <summary>
/// <para>Derived verification status.</para>
/// </summary>
public enum PaystubVerificationStatus
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PAYSTUB_VERIFICATION_STATUS_UNKNOWN")]
	PaystubVerificationStatusUnknown,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PAYSTUB_VERIFICATION_STATUS_VERIFIED")]
	PaystubVerificationStatusVerified,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PAYSTUB_VERIFICATION_STATUS_FRAUDULENT")]
	PaystubVerificationStatusFraudulent,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}