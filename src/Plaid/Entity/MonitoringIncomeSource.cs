namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object representing an income source</para>
/// </summary>
public record MonitoringIncomeSource
{
	/// <summary>
	/// <para>A unique identifier for an income source</para>
	/// </summary>
	[JsonPropertyName("income_source_id")]
	public string IncomeSourceId { get; init; } = default!;

	/// <summary>
	/// <para>The most common name or original description for the underlying income transactions</para>
	/// </summary>
	[JsonPropertyName("income_description")]
	public string IncomeDescription { get; init; } = default!;

	/// <summary>
	/// <para>The income category. Note that the <c>CASH</c> value has been deprecated and is used only for existing legacy implementations. It has been replaced by the new categories <c>CASH_DEPOSIT</c> (representing cash or check deposits) and <c>TRANSFER_FROM_APPLICATION</c> (representing cash transfers originating from apps, such as Zelle or Venmo).</para>
	/// </summary>
	[JsonPropertyName("income_category")]
	public Entity.CreditBankIncomeCategory IncomeCategory { get; init; } = default!;

	/// <summary>
	/// <para>The last detected transaction date for this income source</para>
	/// </summary>
	[JsonPropertyName("last_transaction_date")]
	public DateOnly LastTransactionDate { get; init; } = default!;

	/// <summary>
	/// <para>This represents if the income source is believed to be missing any recent income</para>
	/// </summary>
	[JsonPropertyName("is_missing_income")]
	public bool IsMissingIncome { get; init; } = default!;

}
