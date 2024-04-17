namespace Going.Plaid.Partner;

/// <summary>
/// <para>Request schema for <c>/partner/customer/create</c>.</para>
/// </summary>
public partial class PartnerCustomerCreateRequest : RequestBase
{
	/// <summary>
	/// <para>The company name of the end customer being created. This will be used to display the end customer in the Plaid Dashboard. It will not be shown to end users.</para>
	/// </summary>
	[JsonPropertyName("company_name")]
	public string CompanyName { get; set; } = default!;

	/// <summary>
	/// <para>Denotes whether or not the partner has completed attestation of diligence for the end customer to be created.</para>
	/// </summary>
	[JsonPropertyName("is_diligence_attested")]
	public bool IsDiligenceAttested { get; set; } = default!;

	/// <summary>
	/// <para>The products to be enabled for the end customer. If empty or <c>null</c>, this field will default to the products enabled for the reseller at the time this endpoint is called.</para>
	/// </summary>
	[JsonPropertyName("products")]
	public IReadOnlyList<Entity.Products>? Products { get; set; } = default!;

	/// <summary>
	/// <para>If <c>true</c>, the end customer's default Link customization will be set to match the partner's. You can always change the end customer's Link customization in the Plaid Dashboard. See the <a href="https://plaid.com/docs/link/customization/">Link Customization docs</a> for more information.</para>
	/// </summary>
	[JsonPropertyName("create_link_customization")]
	public bool? CreateLinkCustomization { get; set; } = default!;

	/// <summary>
	/// <para>Base64-encoded representation of the end customer's logo. Must be a PNG of size 1024x1024 under 4MB. The logo will be shared with financial institutions and shown to the end user during Link flows. A logo is required if <c>create_link_customization</c> is <c>true</c>. If <c>create_link_customization</c> is <c>false</c> and the logo is omitted, the partner's logo will be used if one exists, otherwise a stock logo will be used.</para>
	/// </summary>
	[JsonPropertyName("logo")]
	public string? Logo { get; set; } = default!;

	/// <summary>
	/// <para>The end customer's legal name. This will be shared with financial institutions as part of the OAuth registration process. It will not be shown to end users.</para>
	/// </summary>
	[JsonPropertyName("legal_entity_name")]
	public string LegalEntityName { get; set; } = default!;

	/// <summary>
	/// <para>The end customer's website.</para>
	/// </summary>
	[JsonPropertyName("website")]
	public string Website { get; set; } = default!;

	/// <summary>
	/// <para>The name of the end customer's application. This will be shown to end users when they go through the Plaid Link flow.</para>
	/// </summary>
	[JsonPropertyName("application_name")]
	public string ApplicationName { get; set; } = default!;

	/// <summary>
	/// <para>The technical contact for the end customer. Defaults to partner's technical contact if omitted.</para>
	/// </summary>
	[JsonPropertyName("technical_contact")]
	public Entity.PartnerEndCustomerTechnicalContact? TechnicalContact { get; set; } = default!;

	/// <summary>
	/// <para>The billing contact for the end customer. Defaults to partner's billing contact if omitted.</para>
	/// </summary>
	[JsonPropertyName("billing_contact")]
	public Entity.PartnerEndCustomerBillingContact? BillingContact { get; set; } = default!;

	/// <summary>
	/// <para>This information is public. Users of your app will see this information when managing connections between your app and their bank accounts in Plaid Portal. Defaults to partner's customer support info if omitted.</para>
	/// </summary>
	[JsonPropertyName("customer_support_info")]
	public Entity.PartnerEndCustomerCustomerSupportInfo? CustomerSupportInfo { get; set; } = default!;

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
	public Entity.PartnerEndCustomerAssetsUnderManagement? AssetsUnderManagement { get; set; } = default!;

	/// <summary>
	/// <para>A list of URIs indicating the destination(s) where a user can be forwarded after completing the Link flow; used to support OAuth authentication flows when launching Link in the browser or another app. URIs should not contain any query parameters. When used in Production or Development, URIs must use https. To specify any subdomain, use <c>*</c> as a wildcard character, e.g. <c>https://*.example.com/oauth.html</c>. To modify redirect URIs for an end customer after creating them, go to the end customer's <a href="https://dashboard.plaid.com/team/api">API page</a> in the Dashboard.</para>
	/// </summary>
	[JsonPropertyName("redirect_uris")]
	public IReadOnlyList<string>? RedirectUris { get; set; } = default!;

	/// <summary>
	/// <para>The unique identifier assigned to a financial institution by regulatory authorities, if applicable. For banks, this is the FDIC Certificate Number. For credit unions, this is the Credit Union Charter Number.</para>
	/// </summary>
	[JsonPropertyName("registration_number")]
	public string? RegistrationNumber { get; set; } = default!;

}
