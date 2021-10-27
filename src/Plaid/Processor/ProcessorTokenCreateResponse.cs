namespace Going.Plaid.Processor;

/// <summary>
/// <para>ProcessorTokenCreateResponse defines the response schema for <c>/processor/token/create</c> and <c>/processor/apex/processor_token/create</c></para>
/// </summary>
public record ProcessorTokenCreateResponse : ResponseBase
{
	/// <summary>
	/// <para>The <c>processor_token</c> that can then be used by the Plaid partner to make API requests</para>
	/// </summary>
	[JsonPropertyName("processor_token")]
	public string ProcessorToken { get; init; } = default!;
}