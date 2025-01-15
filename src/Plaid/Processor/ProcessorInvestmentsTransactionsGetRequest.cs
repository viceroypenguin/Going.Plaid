namespace Going.Plaid.Processor;

/// <summary>
/// <para>ProcessorInvestmentsTransactionsGetRequest defines the request schema for <c>/processor/investments/transactions/get</c></para>
/// </summary>
public partial class ProcessorInvestmentsTransactionsGetRequest : RequestBase
{
	/// <summary>
	/// <para>An optional object to filter <c>/investments/transactions/get</c> results. If provided, must be non-<c>null</c>.</para>
	/// </summary>
	[JsonPropertyName("options")]
	public Entity.InvestmentsTransactionsGetRequestOptions? Options { get; set; } = default!;

	/// <summary>
	/// <para>The processor token obtained from the Plaid integration partner. Processor tokens are in the format: <c>processor-&lt;environment&gt;-&lt;identifier&gt;</c></para>
	/// </summary>
	[JsonPropertyName("processor_token")]
	public string ProcessorToken { get; set; } = default!;

	/// <summary>
	/// <para>The earliest date for which data should be returned. Dates should be formatted as YYYY-MM-DD.</para>
	/// </summary>
	[JsonPropertyName("start_date")]
	public DateOnly StartDate { get; set; } = default!;

	/// <summary>
	/// <para>The latest date for which data should be returned. Dates should be formatted as YYYY-MM-DD.</para>
	/// </summary>
	[JsonPropertyName("end_date")]
	public DateOnly EndDate { get; set; } = default!;

}
