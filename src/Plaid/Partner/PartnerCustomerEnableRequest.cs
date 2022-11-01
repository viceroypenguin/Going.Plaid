namespace Going.Plaid.Partner;

/// <summary>
/// <para>Request schema for <c>/partner/customer/enable</c>.</para>
/// </summary>
public partial class PartnerCustomerEnableRequest : RequestBase
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("end_customer_client_id")]
	public string EndCustomerClientId { get; set; } = default!;
}