namespace Going.Plaid.Beta;

/// <summary>
/// <para>Response schema for <c>/beta/partner/customer/v1/enable</c>.</para>
/// </summary>
public record BetaPartnerCustomerV1EnableResponse : ResponseBase
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("end_customer_client_id")]
	public string? EndCustomerClientId { get; init; } = default!;

	/// <summary>
	/// <para>The status of the given end customer.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.PartnerEndCustomerStatus? Status { get; init; } = default!;

	/// <summary>
	/// <para>Mapping of product names to their current status.</para>
	/// </summary>
	[JsonPropertyName("product_statuses")]
	public Entity.PartnerEndCustomerProductStatuses? ProductStatuses { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("production_secret")]
	public string? ProductionSecret { get; init; } = default!;

}
