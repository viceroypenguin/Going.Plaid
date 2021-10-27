namespace Going.Plaid.Entity;

/// <summary>
/// <para>Derived verification status.</para>
/// </summary>
public enum PaystubFraudVerificationVerificationStatusEnum
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PAYSTUB_VERIFICATION_COMPLETE")]
	PaystubVerificationComplete,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PAYSTUB_VERIFICATION_IN_PROGRESS")]
	PaystubVerificationInProgress,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PAYSTUB_VERIFICATION_UNKNOWN")]
	PaystubVerificationUnknown,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}