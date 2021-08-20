namespace Going.Plaid.Processor;

/// <summary>
/// <para>ProcessorIdentityGetRequest defines the request schema for <c>/processor/identity/get</c></para>
/// </summary>
public class ProcessorIdentityGetRequest : RequestBase
{
	/// <summary>
	/// <para>The processor token obtained from the Plaid integration partner. Processor tokens are in the format: <c>processor-environment-identifier</c></para>
	/// </summary>
	[JsonPropertyName("processor_token")]
	public string ProcessorToken { get; set; } = default!;
}