namespace Going.Plaid.Entity;

/// <summary>
/// <para>The report of the Plaid Check Income Insights data for an end user.</para>
/// </summary>
public record CraBankIncome
{
	/// <summary>
	/// <para>The unique identifier associated with the report.</para>
	/// </summary>
	[JsonPropertyName("bank_income_id")]
	public string? BankIncomeId { get; init; } = default!;

	/// <summary>
	/// <para>The time when the report was generated.</para>
	/// </summary>
	[JsonPropertyName("generated_time")]
	public DateTimeOffset? GeneratedTime { get; init; } = default!;

	/// <summary>
	/// <para>The number of days requested by the customer for the report.</para>
	/// </summary>
	[JsonPropertyName("days_requested")]
	public int? DaysRequested { get; init; } = default!;

	/// <summary>
	/// <para>The list of Items in the report along with the associated metadata about the Item.</para>
	/// </summary>
	[JsonPropertyName("items")]
	public IReadOnlyList<Entity.CraBankIncomeItem>? Items { get; init; } = default!;

	/// <summary>
	/// <para>Summary for income across all income sources and items (max history of 730 days).</para>
	/// </summary>
	[JsonPropertyName("bank_income_summary")]
	public Entity.CraBankIncomeSummary? BankIncomeSummary { get; init; } = default!;

	/// <summary>
	/// <para>If data from the report was unable to be retrieved, the warnings object will contain information about the error that caused the data to be incomplete.</para>
	/// </summary>
	[JsonPropertyName("warnings")]
	public IReadOnlyList<Entity.CraBankIncomeWarning>? Warnings { get; init; } = default!;

}
