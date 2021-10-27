namespace Going.Plaid.Entity;

/// <summary>
/// <para>Message indicating the reason as to why the verification failed</para>
/// </summary>
public enum FraudAttributesTypeEnum
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "FRAUD_ATTRIBUTES_AMOUNT_MISMATCH")]
	FraudAttributesAmountMismatch,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "FRAUD_ATTRIBUTES_DATE_MISMATCH")]
	FraudAttributesDateMismatch,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "FRAUD_ATTRIBUTES_UNKNOWN_ERROR")]
	FraudAttributesUnknownError,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}