namespace Going.Plaid.Transactions;

/// <summary>
/// <para>TransactionsGetRequest defines the request schema for <c>/transactions/get</c></para>
/// </summary>
public partial class TransactionsGetRequest : RequestBase
{
	/// <summary>
	/// <para>An optional object to be used with the request. If specified, <c>options</c> must not be <c>null</c>.</para>
	/// </summary>
	[JsonPropertyName("options")]
	public Entity.TransactionsGetRequestOptions Options { get; set; } = default!;

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