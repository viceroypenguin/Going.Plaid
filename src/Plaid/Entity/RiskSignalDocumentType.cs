namespace Going.Plaid.Entity;

/// <summary>
/// <para>Type of a document for risk signal analysis</para>
/// </summary>
public enum RiskSignalDocumentType
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "UNKNOWN")]
	Unknown,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "BANK_STATEMENT")]
	BankStatement,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "BENEFITS_STATEMENT")]
	BenefitsStatement,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "BUSINESS_FILING")]
	BusinessFiling,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "CHECK")]
	Check,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "DRIVING_LICENSE")]
	DrivingLicense,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "FINANCIAL_STATEMENT")]
	FinancialStatement,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "INVOICE")]
	Invoice,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PAYSLIP")]
	Payslip,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "SOCIAL_SECURITY_CARD")]
	SocialSecurityCard,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "TAX_FORM")]
	TaxForm,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "UTILITY_BILL")]
	UtilityBill,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
