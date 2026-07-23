namespace Going.Plaid.Entity;

/// <summary>
/// <para>Per-product report data. <c>attributes</c> is an opaque map of key-value pairs; for a full list of attributes per product and version, see the data dictionary.</para>
/// </summary>
public record CraReportGetResponseProduct
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

	/// <summary>
	/// <para>A map of product report metadata, where the key is a string and the value varies by product. For a full list of metadata fields per product, see the data dictionary. May be <c>null</c> if metadata was not available.</para>
	/// </summary>
	[JsonPropertyName("metadata")]
	public Entity.CraReportGetProductMetadata? Metadata { get; init; } = default!;

	/// <summary>
	/// <para>A map of product attributes, where the key is a string and the value is a float, int, or boolean. The specific list of attributes depends on the product and version. For a full list, see the data dictionary. May be <c>null</c> if attributes were not available.</para>
	/// </summary>
	[JsonPropertyName("attributes")]
	public Entity.CraReportGetProductAttributes? Attributes { get; init; } = default!;

	/// <summary>
	/// <para>Product-level errors. Non-empty when this product failed to generate; empty on success.</para>
	/// </summary>
	[JsonPropertyName("errors")]
	public IReadOnlyList<Entity.PlaidError> Errors { get; init; } = default!;

}
