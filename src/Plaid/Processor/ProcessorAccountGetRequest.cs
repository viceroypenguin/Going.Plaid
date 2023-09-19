namespace Going.Plaid.Processor;

/// <summary>
/// <para>ProcessorAccountGetRequest defines the request schema for <c>/processor/account/get</c></para>
/// </summary>
public partial class ProcessorAccountGetRequest : RequestBase
{
	/// <summary>
	/// <para>The processor token obtained from the Plaid integration partner. Processor tokens are in the format: <c>processor-&lt;environment&gt;-&lt;identifier&gt;</c></para>
	/// </summary>
	[JsonPropertyName("processor_token")]
	public string ProcessorToken { get; set; } = default!;
}