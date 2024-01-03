namespace Going.Plaid.Processor;

/// <summary>
/// <para>ProcessorSignalPrepareRequest defines the request schema for <c>/processor/signal/prepare</c></para>
/// </summary>
public partial class ProcessorSignalPrepareRequest : RequestBase
{
	/// <summary>
	/// <para>The processor token obtained from the Plaid integration partner. Processor tokens are in the format: <c>processor-&lt;environment&gt;-&lt;identifier&gt;</c></para>
	/// </summary>
	[JsonPropertyName("processor_token")]
	public string ProcessorToken { get; set; } = default!;

}
