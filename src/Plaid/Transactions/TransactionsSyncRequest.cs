namespace Going.Plaid.Transactions;

/// <summary>
/// <para>TransactionsSyncRequest defines the request schema for <c>/transactions/sync</c></para>
/// </summary>
public partial class TransactionsSyncRequest : RequestBase
{
	/// <summary>
	/// <para>The cursor value represents the last update requested. Providing it will cause the response to only return changes after this update.</para>
	/// <para>If omitted, the entire history of updates will be returned, starting with the first-added transactions on the item.</para>
	/// <para>Note: The upper-bound length of this cursor is 256 characters of base64.</para>
	/// </summary>
	[JsonPropertyName("cursor")]
	public string? Cursor { get; set; } = default!;

	/// <summary>
	/// <para>The number of transaction updates to fetch.</para>
	/// </summary>
	[JsonPropertyName("count")]
	public int? Count { get; set; } = default!;

	/// <summary>
	/// <para>An optional object to be used with the request. If specified, <c>options</c> must not be <c>null</c>.</para>
	/// </summary>
	[JsonPropertyName("options")]
	public Entity.TransactionsSyncRequestOptions? Options { get; set; } = default!;
}