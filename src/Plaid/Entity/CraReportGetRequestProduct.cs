namespace Going.Plaid.Entity;

/// <summary>
/// <para>CraReportGetRequestProduct specifies a product and version for a <c>/cra/report/get</c> call.</para>
/// </summary>
public class CraReportGetRequestProduct
{
	/// <summary>
	/// <para>A list of products that an institution can support. All Items must be initialized with at least one product. The Balance product is always available and does not need to be specified during initialization.</para>
	/// </summary>
	[JsonPropertyName("product")]
	public Entity.Products Product { get; set; } = default!;

	/// <summary>
	/// <para>The version of the product that was generated.</para>
	/// </summary>
	[JsonPropertyName("version")]
	public string Version { get; set; } = default!;

}
