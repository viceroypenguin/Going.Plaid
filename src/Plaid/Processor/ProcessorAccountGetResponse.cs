namespace Going.Plaid.Processor;

/// <summary>
/// <para>ProcessorAccountGetResponse defines the response schema for <c>/processor/account/get</c></para>
/// </summary>
public record ProcessorAccountGetResponse : ResponseBase
{
	/// <summary>
	/// <para>A single account at a financial institution.</para>
	/// </summary>
	[JsonPropertyName("account")]
	public Entity.Account Account { get; init; } = default!;

}
