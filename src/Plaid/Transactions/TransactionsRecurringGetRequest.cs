namespace Going.Plaid.Transactions;

/// <summary>
/// <para>TransactionsRecurringGetRequest defines the request schema for <c>/transactions/recurring/get</c></para>
/// </summary>
public partial class TransactionsRecurringGetRequest : RequestBase
{
	/// <summary>
	/// <para>An optional object to be used with the request. If specified, <c>options</c> must not be <c>null</c>.</para>
	/// </summary>
	[JsonPropertyName("options")]
	public Entity.TransactionsRecurringGetRequestOptions? Options { get; set; } = default!;

	/// <summary>
	/// <para>An optional list of <c>account_ids</c> to retrieve for the Item. Retrieves all active accounts on item if no <c>account_id</c>s are provided.</para>
	/// <para>Note: An error will be returned if a provided <c>account_id</c> is not associated with the Item.</para>
	/// </summary>
	[JsonPropertyName("account_ids")]
	public IReadOnlyList<string>? AccountIds { get; set; } = default!;

}
