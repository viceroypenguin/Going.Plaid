namespace Going.Plaid.Partner;

/// <summary>
/// <para>Response schema for <c>/partner/customer/create</c>.</para>
/// </summary>
public record PartnerCustomerCreateResponse : ResponseBase
{
	/// <summary>
	/// <para>The details for the newly created end customer, including secrets for Sandbox and Limited Production.</para>
	/// </summary>
	[JsonPropertyName("end_customer")]
	public Entity.PartnerEndCustomerWithSecrets? EndCustomer { get; init; } = default!;

}
