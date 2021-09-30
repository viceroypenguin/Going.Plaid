namespace Going.Plaid.Transactions;

/// <summary>
/// <para>TransactionsRecurringGetRequest defines the request schema for <c>/transactions/recurring/get</c></para>
/// </summary>
public class TransactionsRecurringGetRequest : RequestBase
{
	/// <summary>
	/// <para>A list of <c>account_ids</c> to retrieve for the Item</para>
	/// <para>Note: An error will be returned if a provided <c>account_id</c> is not associated with the Item.</para>
	/// </summary>
	[JsonPropertyName("account_ids")]
	public IReadOnlyList<string> AccountIds { get; set; } = default!;
}