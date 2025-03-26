namespace Going.Plaid.Entity;

/// <summary>
/// <para>The Check Income Insights Report for an end user.</para>
/// </summary>
public record CraIncomeInsights
{
	/// <summary>
	/// <para>The unique identifier associated with the Check Income Insights Report.</para>
	/// </summary>
	[JsonPropertyName("report_id")]
	public string? ReportId { get; init; } = default!;

	/// <summary>
	/// <para>The time when the Check Income Insights Report was generated.</para>
	/// </summary>
	[JsonPropertyName("generated_time")]
	public DateTimeOffset? GeneratedTime { get; init; } = default!;

	/// <summary>
	/// <para>The number of days requested by the customer for the Check Income Insights Report.</para>
	/// </summary>
	[JsonPropertyName("days_requested")]
	public int? DaysRequested { get; init; } = default!;

	/// <summary>
	/// <para>Client-generated identifier, which can be used by lenders to track loan applications.</para>
	/// </summary>
	[JsonPropertyName("client_report_id")]
	public string? ClientReportId { get; init; } = default!;

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
