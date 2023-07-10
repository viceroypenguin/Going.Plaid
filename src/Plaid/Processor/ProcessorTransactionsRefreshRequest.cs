namespace Going.Plaid.Processor;

/// <summary>
/// <para>ProcessorTransactionsRefreshRequest defines the request schema for <c>/processor/transactions/refresh</c></para>
/// </summary>
public partial class ProcessorTransactionsRefreshRequest : RequestBase
{
	/// <summary>
	/// <para>The processor token obtained from the Plaid integration partner. Processor tokens are in the format: <c>processor-&lt;environment&gt;-&lt;identifier&gt;</c></para>
	/// </summary>
	[JsonPropertyName("processor_token")]
	public string ProcessorToken { get; set; } = default!;
}