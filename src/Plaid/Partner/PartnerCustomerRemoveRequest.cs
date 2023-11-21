namespace Going.Plaid.Partner;

/// <summary>
/// <para>Request schema for <c>/partner/customer/remove</c>.</para>
/// </summary>
public partial class PartnerCustomerRemoveRequest : RequestBase
{
	/// <summary>
	/// <para>The <c>client_id</c> of the end customer to be removed.</para>
	/// </summary>
	[JsonPropertyName("end_customer_client_id")]
	public string EndCustomerClientId { get; set; } = default!;
}