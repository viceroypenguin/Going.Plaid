namespace Going.Plaid.Processor;

/// <summary>
/// <para>ProcessorTokenPermissionsGetResponse defines the response schema for <c>/processor/token/permissions/get</c></para>
/// </summary>
public record ProcessorTokenPermissionsGetResponse : ResponseBase
{
	/// <summary>
	/// <para>A list of products the processor token should have access to. An empty list means that the processor has access to all available products, including future products.</para>
	/// </summary>
	[JsonPropertyName("products")]
	public IReadOnlyList<Entity.Products> Products { get; init; } = default!;
}