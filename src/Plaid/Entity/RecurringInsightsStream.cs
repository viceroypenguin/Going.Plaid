namespace Going.Plaid.Entity;

/// <summary>
/// <para>Insights object for recurring transactions streams.</para>
/// </summary>
public record RecurringInsightsStream
{
	/// <summary>
	/// <para>A unique id for the stream.</para>
	/// </summary>
	[JsonPropertyName("stream_id")]
	public string StreamId { get; init; } = default!;

	/// <summary>
	/// <para>The client-provided raw description of the most recent transaction in the stream.</para>
	/// </summary>
	[JsonPropertyName("description")]
	public string? Description { get; init; } = default!;

	/// <summary>
	/// <para>The merchant or primary counterparty associated with the transaction stream.</para>
	/// </summary>
	[JsonPropertyName("merchant_name")]
	public string MerchantName { get; init; } = default!;

	/// <summary>
	/// <para>The posted date of the earliest transaction in the stream.</para>
	/// </summary>
	[JsonPropertyName("oldest_transaction_date")]
	public DateOnly? OldestTransactionDate { get; init; } = default!;

	/// <summary>
	/// <para>The posted date of the latest transaction in the stream.</para>
	/// </summary>
	[JsonPropertyName("newest_transaction_date")]
	public DateOnly? NewestTransactionDate { get; init; } = default!;

	/// <summary>
	/// <para>The average number of days between each of the recurring transactions.</para>
	/// </summary>
	[JsonPropertyName("average_days_apart")]
	public decimal AverageDaysApart { get; init; } = default!;

	/// <summary>
	/// <para>Describes the frequency of the transaction stream.</para>
	/// </summary>
	[JsonPropertyName("frequency")]
	public Entity.RecurringTransactionFrequency? Frequency { get; init; } = default!;

	/// <summary>
	/// <para>The number of transactions in this stream.</para>
	/// </summary>
	[JsonPropertyName("transaction_count")]
	public int? TransactionCount { get; init; } = default!;

	/// <summary>
	/// <para>An array of Plaid transaction IDs belonging to the stream, sorted by posted date.</para>
	/// </summary>
	[JsonPropertyName("transaction_ids")]
	public IReadOnlyList<string>? TransactionIds { get; init; } = default!;

	/// <summary>
	/// <para>Object with data pertaining to an amount on the transaction stream.</para>
	/// </summary>
	[JsonPropertyName("average_amount")]
	public Entity.TransactionStreamAmount? AverageAmount { get; init; } = default!;

	/// <summary>
	/// <para>Object with data pertaining to an amount on the transaction stream.</para>
	/// </summary>
	[JsonPropertyName("newest_transaction_amount")]
	public Entity.TransactionStreamAmount? NewestTransactionAmount { get; init; } = default!;

	/// <summary>
	/// <para>Indicates whether the transaction stream is still live.</para>
	/// </summary>
	[JsonPropertyName("is_active")]
	public bool IsActive { get; init; } = default!;

	/// <summary>
	/// <para>The current status of the transaction stream.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.TransactionStreamStatus? Status { get; init; } = default!;

	/// <summary>
	/// <para>The primary category associated with the transaction stream.</para>
	/// </summary>
	[JsonPropertyName("personal_finance_category_primary")]
	public string? PersonalFinanceCategoryPrimary { get; init; } = default!;

	/// <summary>
	/// <para>The detailed category associated with the transaction stream.</para>
	/// </summary>
	[JsonPropertyName("personal_finance_category_detailed")]
	public string? PersonalFinanceCategoryDetailed { get; init; } = default!;
}