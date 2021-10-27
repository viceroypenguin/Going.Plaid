namespace Going.Plaid.Processor;

/// <summary>
/// <para>ProcessorBalanceGetResponse defines the response schema for <c>/processor/balance/get</c></para>
/// </summary>
public record ProcessorBalanceGetResponse : ResponseBase
{
	/// <summary>
	/// <para>A single account at a financial institution.</para>
	/// </summary>
	[JsonPropertyName("account")]
	public Entity.Account Account { get; init; } = default!;
}