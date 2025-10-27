namespace Going.Plaid.Beta;

/// <summary>
/// <para>Request schema for <c>/beta/partner/customer/v1/enable</c>.</para>
/// </summary>
public partial class BetaPartnerCustomerV1EnableRequest : RequestBase
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("end_customer_client_id")]
	public string EndCustomerClientId { get; set; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("products")]
	public IReadOnlyList<Entity.Products>? Products { get; set; } = default!;

}
