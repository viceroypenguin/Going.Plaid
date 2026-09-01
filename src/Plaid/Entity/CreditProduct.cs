namespace Going.Plaid.Entity;

/// <summary>
/// <para>A product included in a CRA report, along with the version that was generated.</para>
/// </summary>
public record CreditProduct
{
	/// <summary>
	/// <para>A list of products that an institution can support. All Items must be initialized with at least one product. The Balance product is always available and does not need to be specified during initialization.</para>
	/// </summary>
	[JsonPropertyName("product")]
	public Entity.Products Product { get; init; } = default!;

	/// <summary>
	/// <para>The version of the product that was generated.</para>
	/// </summary>
	[JsonPropertyName("version")]
	public string Version { get; init; } = default!;

}
