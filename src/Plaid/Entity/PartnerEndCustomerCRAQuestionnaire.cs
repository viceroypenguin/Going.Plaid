namespace Going.Plaid.Entity;

/// <summary>
/// <para>The CRA questionnaire for the end customer.</para>
/// </summary>
public class PartnerEndCustomerCRAQuestionnaire
{
	/// <summary>
	/// <para>A map of permissible purposes to their corresponding use cases.</para>
	/// </summary>
	[JsonPropertyName("purposes")]
	public Entity.PartnerEndCustomerCRAPurposes? Purposes { get; set; } = default!;

	/// <summary>
	/// <para>Denotes whether the third party is involved.</para>
	/// </summary>
	[JsonPropertyName("is_third_party_involved")]
	public bool? IsThirdPartyInvolved { get; set; } = default!;

	/// <summary>
	/// <para>Denotes whether the technical service provider is involved.</para>
	/// </summary>
	[JsonPropertyName("is_technical_service_provider_involved")]
	public bool? IsTechnicalServiceProviderInvolved { get; set; } = default!;

}
