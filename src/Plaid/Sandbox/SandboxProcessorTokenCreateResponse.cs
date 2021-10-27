namespace Going.Plaid.Sandbox;

/// <summary>
/// 
/// </summary>
public record SandboxProcessorTokenCreateResponse : ResponseBase
{
	/// <summary>
	/// <para>A processor token that can be used to call the <c>/processor/</c> endpoints.</para>
	/// </summary>
	[JsonPropertyName("processor_token")]
	public string ProcessorToken { get; init; } = default!;
}