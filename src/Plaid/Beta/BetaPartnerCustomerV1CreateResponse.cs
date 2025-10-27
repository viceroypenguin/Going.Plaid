namespace Going.Plaid.Beta;

/// <summary>
/// <para>Response schema for <c>/beta/partner/customer/v1/create</c>.</para>
/// </summary>
public record BetaPartnerCustomerV1CreateResponse : ResponseBase
{
	/// <summary>
	/// <para>The details for the newly created end customer, including secrets for Sandbox and Limited Production.</para>
	/// </summary>
	[JsonPropertyName("end_customer")]
	public Entity.BetaPartnerEndCustomerWithSecrets? EndCustomer { get; init; } = default!;

}
