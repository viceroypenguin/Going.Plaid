namespace Going.Plaid.Beta;

/// <summary>
/// <para>Request schema for <c>/partner/v1/customers/create</c>.</para>
/// </summary>
public partial class PartnerCustomersCreateRequest : RequestBase
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
	/// <para>The products to be enabled on for the end customer.</para>
	/// </summary>
	[JsonPropertyName("products")]
	public IReadOnlyList<Entity.Products> Products { get; set; } = default!;

	/// <summary>
	/// <para>If true, sets end customer's link customization to match partner's link customization.</para>
	/// </summary>
	[JsonPropertyName("create_link_customization")]
	public bool CreateLinkCustomization { get; set; } = default!;
}