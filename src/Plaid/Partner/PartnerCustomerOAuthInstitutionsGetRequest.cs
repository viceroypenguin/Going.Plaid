namespace Going.Plaid.Partner;

/// <summary>
/// <para>Request schema for <c>/partner/customer/oauth_institutions/get</c>.</para>
/// </summary>
public partial class PartnerCustomerOAuthInstitutionsGetRequest : RequestBase
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("end_customer_client_id")]
	public string EndCustomerClientId { get; set; } = default!;

}
