namespace Going.Plaid.Entity;

/// <summary>
/// <para>Configuration parameters for the Transactions product</para>
/// </summary>
public class LinkTokenTransactions
{
	/// <summary>
	/// <para>The maximum number of days of transaction history to request for the Transactions product. For developer accounts created after December 3, 2023, if no value is specified, this will default to 90 days. For developer accounts created on December 3, 2023 or earlier, if no value is specified, this will default to 730 days until June 24, 2024, at which point it will default to 90 days.</para>
	/// <para>We strongly recommend that customers utilizing <a href="https://plaid.com/docs/api/products/transactions/#transactionsrecurringget">Recurring Transactions</a> request at least 180 days of history for optimal results.</para>
	/// </summary>
	[JsonPropertyName("days_requested")]
	public int? DaysRequested { get; set; } = default!;

}
