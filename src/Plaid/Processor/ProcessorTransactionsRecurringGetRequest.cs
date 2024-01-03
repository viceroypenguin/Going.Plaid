namespace Going.Plaid.Processor;

/// <summary>
/// <para>ProcessorTransactionsRecurringGetRequest defines the request schema for <c>/processor/transactions/recurring/get</c></para>
/// </summary>
public partial class ProcessorTransactionsRecurringGetRequest : RequestBase
{
	/// <summary>
	/// <para>The processor token obtained from the Plaid integration partner. Processor tokens are in the format: <c>processor-&lt;environment&gt;-&lt;identifier&gt;</c></para>
	/// </summary>
	[JsonPropertyName("processor_token")]
	public string ProcessorToken { get; set; } = default!;

	/// <summary>
	/// <para>An optional object to be used with the request. If specified, <c>options</c> must not be <c>null</c>.</para>
	/// </summary>
	[JsonPropertyName("options")]
	public Entity.TransactionsRecurringGetRequestOptions? Options { get; set; } = default!;

}
