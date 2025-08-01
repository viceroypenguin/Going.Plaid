namespace Going.Plaid.CashflowReport;

/// <summary>
/// <para>CashflowReportGetResponse defines the response schema for <c>/cashflow_report/get</c></para>
/// </summary>
public record CashflowReportGetResponse : ResponseBase
{
	/// <summary>
	/// <para>An array containing the <c>accounts</c> associated with the Item for which transactions are being returned. Each transaction can be mapped to its corresponding account via the <c>account_id</c> field.</para>
	/// </summary>
	[JsonPropertyName("accounts")]
	public IReadOnlyList<Entity.BusinessAccount> Accounts { get; init; } = default!;

	/// <summary>
	/// <para>An array containing transactions from the account. Transactions are returned in reverse chronological order, with the most recent at the beginning of the array. The maximum number of transactions returned is determined by the <c>count</c> parameter.</para>
	/// </summary>
	[JsonPropertyName("transactions")]
	public IReadOnlyList<Entity.CashflowReportTransaction> Transactions { get; init; } = default!;

	/// <summary>
	/// <para>The total number of transactions available within the date range specified. If <c>total_transactions</c> is larger than the size of the <c>transactions</c> array, more transactions are available and can be fetched via manipulating the <c>offset</c> parameter.</para>
	/// </summary>
	[JsonPropertyName("total_transactions")]
	public int TotalTransactions { get; init; } = default!;

	/// <summary>
	/// <para>Metadata about the Item.</para>
	/// </summary>
	[JsonPropertyName("item")]
	public Entity.Item Item { get; init; } = default!;

	/// <summary>
	/// <para>Cursor used for fetching any future updates after the latest update provided in this response.</para>
	/// </summary>
	[JsonPropertyName("next_cursor")]
	public string NextCursor { get; init; } = default!;

	/// <summary>
	/// <para>Represents if more than requested count of transactions exists to be fetched</para>
	/// </summary>
	[JsonPropertyName("has_more")]
	public bool HasMore { get; init; } = default!;

	/// <summary>
	/// <para>The last successful update time in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format ( <c>YYYY-MM-DDTHH:mm:ssZ</c> )</para>
	/// </summary>
	[JsonPropertyName("last_successful_update_time")]
	public DateTimeOffset LastSuccessfulUpdateTime { get; init; } = default!;

}
