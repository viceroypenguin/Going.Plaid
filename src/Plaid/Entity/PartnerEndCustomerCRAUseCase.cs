namespace Going.Plaid.Entity;

/// <summary>
/// <para>A CRA use case under a permissible purpose.</para>
/// </summary>
public enum PartnerEndCustomerCRAUseCase
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "CREDIT_UNDERWRITING")]
	CreditUnderwriting,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "TENANT_SCREENING")]
	TenantScreening,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "INVESTOR_OR_SERVICER_OF_CREDIT")]
	InvestorOrServicerOfCredit,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "UTILITIES")]
	Utilities,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "BANK_ACCOUNT_OPENING")]
	BankAccountOpening,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "IDENTITY_VERIFICATION_FRAUD_PREVENTION")]
	IdentityVerificationFraudPrevention,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "COLLECTIONS_DEBT_RECOVERY")]
	CollectionsDebtRecovery,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
