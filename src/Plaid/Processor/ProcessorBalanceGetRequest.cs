namespace Going.Plaid.Processor;

/// <summary>
/// <para>ProcessorBalanceGetRequest defines the request schema for <c>/processor/balance/get</c></para>
/// </summary>
public partial class ProcessorBalanceGetRequest : RequestBase
{
	/// <summary>
	/// <para>The processor token obtained from the Plaid integration partner. Processor tokens are in the format: <c>processor-environment-identifier</c></para>
	/// </summary>
	[JsonPropertyName("processor_token")]
	public string ProcessorToken { get; set; } = default!;

	/// <summary>
	/// <para>An optional object to filter <c>/processor/balance/get</c> results.</para>
	/// </summary>
	[JsonPropertyName("options")]
	public Entity.ProcessorBalanceGetRequestOptions? Options { get; set; } = default!;
}