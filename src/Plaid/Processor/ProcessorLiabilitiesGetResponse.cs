namespace Going.Plaid.Processor;

/// <summary>
/// <para>ProcessorLiabilitiesGetResponse defines the response schema for <c>/processor/liabilities/get</c></para>
/// </summary>
public record ProcessorLiabilitiesGetResponse : ResponseBase
{
	/// <summary>
	/// <para>A single account at a financial institution.</para>
	/// </summary>
	[JsonPropertyName("account")]
	public Entity.Account Account { get; init; } = default!;

	/// <summary>
	/// <para>An object containing liability accounts</para>
	/// </summary>
	[JsonPropertyName("liabilities")]
	public Entity.LiabilitiesObject Liabilities { get; init; } = default!;

}
