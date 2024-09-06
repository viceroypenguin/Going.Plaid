namespace Going.Plaid.Entity;

/// <summary>
/// <para>Configuration parameters for the Transactions product</para>
/// </summary>
public class LinkTokenTransactions
{
	/// <summary>
	/// <para>The maximum number of days of transaction history to request for the Transactions product. The more transaction history is requested, the longer the historical update poll will take. The default value is 90 days. If a value under 30 is provided, a minimum of 30 days of history will be requested. Once Transactions has been added to an Item, this value cannot be updated.</para>
	/// <para>Customers using <a href="https://plaid.com/docs/api/products/transactions/#transactionsrecurringget">Recurring Transactions</a> should request at least 180 days of history for optimal results.</para>
	/// </summary>
	[JsonPropertyName("days_requested")]
	public int? DaysRequested { get; set; } = default!;

}
