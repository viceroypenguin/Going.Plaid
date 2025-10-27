namespace Going.Plaid.Beta;

/// <summary>
/// <para>Request schema for <c>/beta/partner/customer/v1/get</c>.</para>
/// </summary>
public partial class BetaPartnerCustomerV1GetRequest : RequestBase
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("end_customer_client_id")]
	public string EndCustomerClientId { get; set; } = default!;

}
