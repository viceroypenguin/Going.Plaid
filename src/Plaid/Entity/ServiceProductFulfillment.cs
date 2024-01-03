namespace Going.Plaid.Entity;

/// <summary>
/// <para>A collection of details related to a fulfillment service or product in terms of request, process and result.</para>
/// </summary>
public record ServiceProductFulfillment
{
	/// <summary>
	/// <para>Documentation not found in the MISMO model viewer and not provided by Freddie Mac.</para>
	/// </summary>
	[JsonPropertyName("SERVICE_PRODUCT_FULFILLMENT_DETAIL")]
	public Entity.ServiceProductFulfillmentDetail ServiceProductFulfillmentDetail { get; init; } = default!;

}
