namespace Going.Plaid.Partner;

/// <summary>
/// <para>Request schema for <c>/partner/customer/create</c>.</para>
/// </summary>
public partial class PartnerCustomerCreateRequest : RequestBase
{
	/// <summary>
	/// <para>The company name of the end customer being created.</para>
	/// </summary>
	[JsonPropertyName("company_name")]
	public string CompanyName { get; set; } = default!;

	/// <summary>
	/// <para>Denotes whether or not the partner has completed attestation of diligence for the end customer to be created.</para>
	/// </summary>
	[JsonPropertyName("is_diligence_attested")]
	public bool IsDiligenceAttested { get; set; } = default!;

	/// <summary>
	/// <para>The products to be enabled for the end customer.</para>
	/// </summary>
	[JsonPropertyName("products")]
	public IReadOnlyList<Entity.Products> Products { get; set; } = default!;

	/// <summary>
	/// <para>If true, the end customer's default Link customization will be set to match the partner's.</para>
	/// </summary>
	[JsonPropertyName("create_link_customization")]
	public bool CreateLinkCustomization { get; set; } = default!;

	/// <summary>
	/// <para>Base64-encoded representation of the end customer's logo. Defaults to the partner's logo if omitted.</para>
	/// </summary>
	[JsonPropertyName("logo")]
	public string Logo { get; set; } = default!;

	/// <summary>
	/// <para>The end customer's legal name.</para>
	/// </summary>
	[JsonPropertyName("legal_entity_name")]
	public string LegalEntityName { get; set; } = default!;

	/// <summary>
	/// <para>The end customer's website.</para>
	/// </summary>
	[JsonPropertyName("website")]
	public string Website { get; set; } = default!;

	/// <summary>
	/// <para>The name of the end customer's application.</para>
	/// </summary>
	[JsonPropertyName("application_name")]
	public string ApplicationName { get; set; } = default!;

	/// <summary>
	/// <para>The technical contact for the end customer. Defaults to partner's technical contact if omitted.</para>
	/// </summary>
	[JsonPropertyName("technical_contact")]
	public Entity.PartnerEndCustomerTechnicalContact TechnicalContact { get; set; } = default!;

	/// <summary>
	/// <para>The billing contact for the end customer. Defaults to partner's technical contact if omitted.</para>
	/// </summary>
	[JsonPropertyName("billing_contact")]
	public Entity.PartnerEndCustomerBillingContact BillingContact { get; set; } = default!;

	/// <summary>
	/// <para>The end customer's address.</para>
	/// </summary>
	[JsonPropertyName("address")]
	public Entity.PartnerEndCustomerAddress Address { get; set; } = default!;

	/// <summary>
	/// <para>Denotes whether the partner has forwarded the Plaid bank addendum to the end customer.</para>
	/// </summary>
	[JsonPropertyName("is_bank_addendum_completed")]
	public bool IsBankAddendumCompleted { get; set; } = default!;
}