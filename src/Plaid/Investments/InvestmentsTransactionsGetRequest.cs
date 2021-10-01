namespace Going.Plaid.Investments;

/// <summary>
/// <para>InvestmentsTransactionsGetRequest defines the request schema for <c>/investments/transactions/get</c></para>
/// </summary>
public partial class InvestmentsTransactionsGetRequest : RequestBase
{
	/// <summary>
	/// <para>The earliest date for which to fetch transaction history. Dates should be formatted as YYYY-MM-DD.</para>
	/// </summary>
	[JsonPropertyName("start_date")]
	public DateOnly StartDate { get; set; } = default!;

	/// <summary>
	/// <para>The most recent date for which to fetch transaction history. Dates should be formatted as YYYY-MM-DD.</para>
	/// </summary>
	[JsonPropertyName("end_date")]
	public DateOnly EndDate { get; set; } = default!;

	/// <summary>
	/// <para>An optional object to filter <c>/investments/transactions/get</c> results. If provided, must be non-<c>null</c>.</para>
	/// </summary>
	[JsonPropertyName("options")]
	public Entity.InvestmentsTransactionsGetRequestOptions Options { get; set; } = default!;
}