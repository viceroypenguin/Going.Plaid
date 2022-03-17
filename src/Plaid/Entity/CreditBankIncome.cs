namespace Going.Plaid.Entity;

/// <summary>
/// <para>The report of the Bank Income data for an end user.</para>
/// </summary>
public record CreditBankIncome
{
	/// <summary>
	/// <para>The unique identifier associated with the Bank Income Report.</para>
	/// </summary>
	[JsonPropertyName("bank_income_id")]
	public string BankIncomeId { get; init; } = default!;

	/// <summary>
	/// <para>The time when the Bank Income Report was generated.</para>
	/// </summary>
	[JsonPropertyName("generated_time")]
	public DateTimeOffset GeneratedTime { get; init; } = default!;

	/// <summary>
	/// <para>The number of days requested by the customer for the Bank Income Report.</para>
	/// </summary>
	[JsonPropertyName("days_requested")]
	public int DaysRequested { get; init; } = default!;

	/// <summary>
	/// <para>The list of Items in the report along with the associated metadata about the Item.</para>
	/// </summary>
	[JsonPropertyName("items")]
	public IReadOnlyList<Entity.CreditBankIncomeItem> Items { get; init; } = default!;

	/// <summary>
	/// <para>Summary for bank income across all income sources and items (max history of 730 days).</para>
	/// </summary>
	[JsonPropertyName("bank_income_summary")]
	public Entity.CreditBankIncomeSummary BankIncomeSummary { get; init; } = default!;

	/// <summary>
	/// <para>If data from the Bank Income report was unable to be retrieved, the warnings will contain information about the error that caused the data to be incomplete.</para>
	/// </summary>
	[JsonPropertyName("warnings")]
	public IReadOnlyList<Entity.CreditBankIncomeWarning> Warnings { get; init; } = default!;
}