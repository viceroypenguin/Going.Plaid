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
	/// <para>Base64-encoded representation of the end customer's logo. Must be a PNG of size 1024x1024 under 4MB. The logo will be shared with financial institutions and shown to the end user during Link flows. A logo is required if <c>create_link_customization</c> is <c>true</c>. If <c>create_link_customization</c> is <c>false</c> and the logo is omitted, a stock logo will be used.</para>
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

	/// <summary>
	/// <para>Assets under management for the given end customer. Required for end customers with monthly service commitments.</para>
	/// </summary>
	[JsonPropertyName("assets_under_management")]
	public Entity.PartnerEndCustomerAssetsUnderManagement AssetsUnderManagement { get; set; } = default!;
}