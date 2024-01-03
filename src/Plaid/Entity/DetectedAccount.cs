namespace Going.Plaid.Entity;

/// <summary>
/// <para>A possible account detected to be associated with a transaction user.</para>
/// </summary>
public record DetectedAccount
{
	/// <summary>
	/// <para>The detected account type (depository, credit, loan, investment etc.).</para>
	/// </summary>
	[JsonPropertyName("account_type")]
	public string? AccountType { get; init; } = default!;

	/// <summary>
	/// <para>The detected subtype of the account, based on the transactions to/from the institution.</para>
	/// </summary>
	[JsonPropertyName("account_subtype")]
	public string? AccountSubtype { get; init; } = default!;

	/// <summary>
	/// <para>The number of transactions associated with this detected account type at this financial institution.</para>
	/// </summary>
	[JsonPropertyName("transaction_count")]
	public int TransactionCount { get; init; } = default!;

	/// <summary>
	/// <para>The date of the oldest transaction associated with this detected account type at this financial institution.</para>
	/// </summary>
	[JsonPropertyName("oldest_transaction_date")]
	public DateOnly? OldestTransactionDate { get; init; } = default!;

	/// <summary>
	/// <para>The date of the newest transaction associated with this detected account type at this financial institution.</para>
	/// </summary>
	[JsonPropertyName("newest_transaction_date")]
	public DateOnly? NewestTransactionDate { get; init; } = default!;

	/// <summary>
	/// <para>Amount of the most recent transaction associated with this detected account type at this financial institution.</para>
	/// </summary>
	[JsonPropertyName("newest_transaction_amount")]
	public decimal? NewestTransactionAmount { get; init; } = default!;

	/// <summary>
	/// <para>Sum of outflow amounts associated with this detected account type at this financial institution.</para>
	/// </summary>
	[JsonPropertyName("total_outflows")]
	public decimal TotalOutflows { get; init; } = default!;

	/// <summary>
	/// <para>Sum of inflow amounts associated with this detected account type at this financial institution.</para>
	/// </summary>
	[JsonPropertyName("total_inflows")]
	public decimal TotalInflows { get; init; } = default!;

}
