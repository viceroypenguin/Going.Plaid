namespace Going.Plaid.Entity;

/// <summary>
/// <para>Analysis options to enable for document parsing</para>
/// </summary>
public enum IncomeVerificationDocParsingConfig
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ocr")]
	Ocr,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "fraud_risk")]
	FraudRisk,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}