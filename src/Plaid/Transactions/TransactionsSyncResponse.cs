namespace Going.Plaid.Transactions;

/// <summary>
/// <para>TransactionsSyncResponse defines the response schema for <c>/transactions/sync</c></para>
/// </summary>
public record TransactionsSyncResponse : ResponseBase
{
	/// <summary>
	/// <para>Transactions that have been added to the item since <c>cursor</c> ordered by ascending last modified time.</para>
	/// </summary>
	[JsonPropertyName("added")]
	public IReadOnlyList<Entity.Transaction> Added { get; init; } = default!;

	/// <summary>
	/// <para>Transactions that have been modified on the item since <c>cursor</c> ordered by ascending last modified time.</para>
	/// </summary>
	[JsonPropertyName("modified")]
	public IReadOnlyList<Entity.Transaction> Modified { get; init; } = default!;

	/// <summary>
	/// <para>Transactions that have been removed from the item since <c>cursor</c> ordered by ascending last modified time.</para>
	/// </summary>
	[JsonPropertyName("removed")]
	public IReadOnlyList<Entity.RemovedTransaction> Removed { get; init; } = default!;

	/// <summary>
	/// <para>Cursor used for fetching any future updates after the latest update provided in this response.</para>
	/// </summary>
	[JsonPropertyName("next_cursor")]
	public string NextCursor { get; init; } = default!;

	/// <summary>
	/// <para>Represents if more than requested count of transaction updates exist. If true, the additional updates can be fetched by making an additional request with <c>cursor</c> set to <c>next_cursor</c>.</para>
	/// </summary>
	[JsonPropertyName("has_more")]
	public bool HasMore { get; init; } = default!;
}