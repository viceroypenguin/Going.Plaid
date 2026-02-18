namespace Going.Plaid.Entity;

/// <summary>
/// <para>Describes the reason you are generating a Consumer Report for this user.</para>
/// </summary>
public enum ConsumerReportPermissiblePurpose
{
	/// <summary>
	/// <para>In connection with a consumer credit transaction for the review or collection of an account pursuant to FCRA Section 604(a)(3)(A).</para>
	/// </summary>
	[EnumMember(Value = "ACCOUNT_REVIEW_CREDIT")]
	AccountReviewCredit,

	/// <summary>
	/// <para>For a legitimate business need of the information to review a non-credit account provided primarily for personal, family, or household purposes to determine whether the consumer continues to meet the terms of the account pursuant to FCRA Section 604(a)(3)(F)(2).</para>
	/// </summary>
	[EnumMember(Value = "ACCOUNT_REVIEW_NON_CREDIT")]
	AccountReviewNonCredit,

	/// <summary>
	/// <para>In connection with a credit transaction initiated by and involving the consumer pursuant to FCRA Section 604(a)(3)(A).</para>
	/// </summary>
	[EnumMember(Value = "EXTENSION_OF_CREDIT")]
	ExtensionOfCredit,

	/// <summary>
	/// <para>For a legitimate business need in connection with a business transaction initiated by the consumer primarily for personal, family, or household purposes in connection with a property rental assessment pursuant to FCRA Section 604(a)(3)(F)(i).</para>
	/// </summary>
	[EnumMember(Value = "LEGITIMATE_BUSINESS_NEED_TENANT_SCREENING")]
	LegitimateBusinessNeedTenantScreening,

	/// <summary>
	/// <para>For a legitimate business need in connection with a business transaction made primarily for personal, family, or household initiated by the consumer pursuant to FCRA Section 604(a)(3)(F)(i).</para>
	/// </summary>
	[EnumMember(Value = "LEGITIMATE_BUSINESS_NEED_OTHER")]
	LegitimateBusinessNeedOther,

	/// <summary>
	/// <para>In accordance with the written instructions of the consumer pursuant to FCRA Section 604(a)(2), to evaluate an application’s profile to make an offer to the consumer.</para>
	/// </summary>
	[EnumMember(Value = "WRITTEN_INSTRUCTION_PREQUALIFICATION")]
	WrittenInstructionPrequalification,

	/// <summary>
	/// <para>In accordance with the written instructions of the consumer pursuant to FCRA Section 604(a)(2), such as when an individual agrees to act as a guarantor or assumes personal liability for a consumer, business, or commercial loan.</para>
	/// </summary>
	[EnumMember(Value = "WRITTEN_INSTRUCTION_OTHER")]
	WrittenInstructionOther,

	/// <summary>
	/// <para>In connection with an eligibility determination for a government benefit where the entity is required to consider an applicant’s financial status pursuant to FCRA Section 604(a)(3)(D).</para>
	/// </summary>
	[EnumMember(Value = "ELIGIBILITY_FOR_GOVT_BENEFITS")]
	EligibilityForGovtBenefits,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
