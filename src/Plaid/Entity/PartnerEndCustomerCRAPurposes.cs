namespace Going.Plaid.Entity;

/// <summary>
/// <para>A map of permissible purposes to their corresponding use cases.</para>
/// </summary>
public class PartnerEndCustomerCRAPurposes
{
	/// <summary>
	/// <para>The list of use cases associated with a given permissible purpose.</para>
	/// </summary>
	[JsonPropertyName("WRITTEN_INSTRUCTION")]
	public Entity.PartnerEndCustomerCRAUseCases? WrittenInstruction { get; set; } = default!;

	/// <summary>
	/// <para>The list of use cases associated with a given permissible purpose.</para>
	/// </summary>
	[JsonPropertyName("EXTENSION_OF_CREDIT_OR_ACCOUNT_REVIEW")]
	public Entity.PartnerEndCustomerCRAUseCases? ExtensionOfCreditOrAccountReview { get; set; } = default!;

	/// <summary>
	/// <para>The list of use cases associated with a given permissible purpose.</para>
	/// </summary>
	[JsonPropertyName("EMPLOYMENT")]
	public Entity.PartnerEndCustomerCRAUseCases? Employment { get; set; } = default!;

	/// <summary>
	/// <para>The list of use cases associated with a given permissible purpose.</para>
	/// </summary>
	[JsonPropertyName("INSURANCE_UNDERWRITING")]
	public Entity.PartnerEndCustomerCRAUseCases? InsuranceUnderwriting { get; set; } = default!;

	/// <summary>
	/// <para>The list of use cases associated with a given permissible purpose.</para>
	/// </summary>
	[JsonPropertyName("LICENSE_ELIGIBILITY")]
	public Entity.PartnerEndCustomerCRAUseCases? LicenseEligibility { get; set; } = default!;

	/// <summary>
	/// <para>The list of use cases associated with a given permissible purpose.</para>
	/// </summary>
	[JsonPropertyName("RISK_ASSESSMENT")]
	public Entity.PartnerEndCustomerCRAUseCases? RiskAssessment { get; set; } = default!;

	/// <summary>
	/// <para>The list of use cases associated with a given permissible purpose.</para>
	/// </summary>
	[JsonPropertyName("BUSINESS_NEED_TRANSACTION")]
	public Entity.PartnerEndCustomerCRAUseCases? BusinessNeedTransaction { get; set; } = default!;

	/// <summary>
	/// <para>The list of use cases associated with a given permissible purpose.</para>
	/// </summary>
	[JsonPropertyName("BUSINESS_NEED_ACCOUNT_REVIEW")]
	public Entity.PartnerEndCustomerCRAUseCases? BusinessNeedAccountReview { get; set; } = default!;

}
