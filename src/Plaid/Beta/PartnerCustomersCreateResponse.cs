namespace Going.Plaid.Beta;

/// <summary>
/// <para>Response schema for <c>/partner/v1/customers/create</c>.</para>
/// </summary>
public record PartnerCustomersCreateResponse : ResponseBase
{
	/// <summary>
	/// <para>The end customer details for the newly-created customer client.</para>
	/// </summary>
	[JsonPropertyName("end_customer")]
	public Entity.PartnerEndCustomerClient EndCustomer { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("production_secret")]
	public string ProductionSecret { get; init; } = default!;
}