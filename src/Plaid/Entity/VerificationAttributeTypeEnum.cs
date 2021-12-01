namespace Going.Plaid.Entity;

/// <summary>
/// <para>Message indicating the reason as to why the verification failed</para>
/// </summary>
public enum VerificationAttributeTypeEnum
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "VERIFICATION_ATTRIBUTE_TYPE_UNKNOWN")]
	VerificationAttributeTypeUnknown,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "VERIFICATION_ATTRIBUTE_TYPE_AMOUNT_MATCH")]
	VerificationAttributeTypeAmountMatch,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "VERIFICATION_ATTRIBUTE_TYPE_DATE_MATCH")]
	VerificationAttributeTypeDateMatch,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "VERIFICATION_ATTRIBUTE_TYPE_DATE_MISMATCH")]
	VerificationAttributeTypeDateMismatch,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "VERIFICATION_ATTRIBUTE_TYPE_FILE_TAMPERING")]
	VerificationAttributeTypeFileTampering,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "VERIFICATION_ATTRIBUTE_TYPE_DESCRIPTION_MATCH")]
	VerificationAttributeTypeDescriptionMatch,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "VERIFICATION_ATTRIBUTE_TYPE_DESCRIPTION_MISMATCH")]
	VerificationAttributeTypeDescriptionMismatch,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "VERIFICATION_ATTRIBUTE_TYPE_FIRST_NAME_MATCH")]
	VerificationAttributeTypeFirstNameMatch,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "VERIFICATION_ATTRIBUTE_TYPE_FIRST_NAME_MISMATCH")]
	VerificationAttributeTypeFirstNameMismatch,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "VERIFICATION_ATTRIBUTE_TYPE_LAST_NAME_MATCH")]
	VerificationAttributeTypeLastNameMatch,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "VERIFICATION_ATTRIBUTE_TYPE_LAST_NAME_MISMATCH")]
	VerificationAttributeTypeLastNameMismatch,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}