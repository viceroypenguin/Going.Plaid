namespace Going.Plaid.Entity;

/// <summary>
/// <para>A field that may be required to be submitted for enablement.</para>
/// </summary>
public enum PartnerEndCustomerRequirementDue
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "legal_entity_name")]
	LegalEntityName,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "website")]
	Website,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "application_name")]
	ApplicationName,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "is_diligence_attested")]
	IsDiligenceAttested,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "technical_contact")]
	TechnicalContact,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "billing_contact")]
	BillingContact,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "address")]
	Address,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "bank_addendum_acceptance")]
	BankAddendumAcceptance,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "questionnaires.cra")]
	QuestionnairesCra,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
