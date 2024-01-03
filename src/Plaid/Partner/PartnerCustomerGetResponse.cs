namespace Going.Plaid.Partner;

/// <summary>
/// <para>Response schema for <c>/partner/customer/get</c>.</para>
/// </summary>
public record PartnerCustomerGetResponse : ResponseBase
{
	/// <summary>
	/// <para>The details for an end customer.</para>
	/// </summary>
	[JsonPropertyName("end_customer")]
	public Entity.PartnerEndCustomer? EndCustomer { get; init; } = default!;

}
