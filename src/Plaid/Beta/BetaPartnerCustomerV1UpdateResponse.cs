namespace Going.Plaid.Beta;

/// <summary>
/// <para>Response schema for <c>/beta/partner/customer/v1/update</c>.</para>
/// </summary>
public record BetaPartnerCustomerV1UpdateResponse : ResponseBase
{
	/// <summary>
	/// <para>The details for an end customer.</para>
	/// </summary>
	[JsonPropertyName("end_customer")]
	public Entity.BetaPartnerEndCustomer? EndCustomer { get; init; } = default!;

}
