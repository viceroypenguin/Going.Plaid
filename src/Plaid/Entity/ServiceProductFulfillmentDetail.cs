namespace Going.Plaid.Entity;

/// <summary>
/// <para>Documentation not found in the MISMO model viewer and not provided by Freddie Mac.</para>
/// </summary>
public record ServiceProductFulfillmentDetail
{
	/// <summary>
	/// <para>A string that uniquely identifies a type of order Verification of Asset.</para>
	/// </summary>
	[JsonPropertyName("VendorOrderIdentifier")]
	public string? Vendororderidentifier { get; init; } = default!;

	/// <summary>
	/// <para>Documentation not found in the MISMO model viewer and not provided by Freddie Mac.</para>
	/// </summary>
	[JsonPropertyName("ServiceProductFulfillmentIdentifier")]
	public Entity.ServiceProductFulfillmentIdentifier Serviceproductfulfillmentidentifier { get; init; } = default!;

}
