namespace Going.Plaid.Partner;

/// <summary>
/// <para>Response schema for <c>/partner/customer/enable</c>.</para>
/// </summary>
public record PartnerCustomerEnableResponse : ResponseBase
{
	/// <summary>
	/// <para>The end customer's secret key for the Production environment.</para>
	/// </summary>
	[JsonPropertyName("production_secret")]
	public string? ProductionSecret { get; init; } = default!;

}
