namespace Going.Plaid.Processor;

/// <summary>
/// <para>ProcessorTransactionsSyncResponse defines the response schema for <c>/processor/transactions/sync</c></para>
/// </summary>
public record ProcessorTransactionsSyncResponse : ResponseBase
{
	/// <summary>
	/// <para>A description of the update status for transaction pulls of an Item. This field contains the same information provided by transactions webhooks, and may be helpful for webhook troubleshooting or when recovering from missed webhooks.</para>
	/// </summary>
	[JsonPropertyName("transactions_update_status")]
	public Entity.TransactionsUpdateStatus TransactionsUpdateStatus { get; init; } = default!;

	/// <summary>
	/// <para>A single account at a financial institution.</para>
	/// </summary>
	[JsonPropertyName("account")]
	public Entity.Account Account { get; init; } = default!;

	/// <summary>
	/// <para>Transactions that have been added to the Item since <c>cursor</c> ordered by ascending last modified time.</para>
	/// </summary>
	[JsonPropertyName("added")]
	public IReadOnlyList<Entity.Transaction> Added { get; init; } = default!;

	/// <summary>
	/// <para>Transactions that have been modified on the Item since <c>cursor</c> ordered by ascending last modified time.</para>
	/// </summary>
	[JsonPropertyName("modified")]
	public IReadOnlyList<Entity.Transaction> Modified { get; init; } = default!;

	/// <summary>
	/// <para>Transactions that have been removed from the Item since <c>cursor</c> ordered by ascending last modified time.</para>
	/// </summary>
	[JsonPropertyName("removed")]
	public IReadOnlyList<Entity.RemovedTransaction> Removed { get; init; } = default!;

	/// <summary>
	/// <para>Cursor used for fetching any future updates after the latest update provided in this response. The cursor obtained after all pages have been pulled (indicated by <c>has_more</c> being <c>false</c>) will be valid for at least 1 year. This cursor should be persisted for later calls. If transactions are not yet available, this will be an empty string.</para>
	/// </summary>
	[JsonPropertyName("next_cursor")]
	public string NextCursor { get; init; } = default!;

	/// <summary>
	/// <para>Represents if more than requested count of transaction updates exist. If true, the additional updates can be fetched by making an additional request with <c>cursor</c> set to <c>next_cursor</c>. If <c>has_more</c> is true, it’s important to pull all available pages, to make it less likely for underlying data changes to conflict with pagination.</para>
	/// </summary>
	[JsonPropertyName("has_more")]
	public bool HasMore { get; init; } = default!;

}
