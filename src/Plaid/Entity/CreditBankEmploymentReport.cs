namespace Going.Plaid.Entity;

/// <summary>
/// <para>The report of the Bank Employment data for an end user.</para>
/// </summary>
public record CreditBankEmploymentReport
{
	/// <summary>
	/// <para>The unique identifier associated with the Bank Employment Report.</para>
	/// </summary>
	[JsonPropertyName("bank_employment_report_id")]
	public string BankEmploymentReportId { get; init; } = default!;

	/// <summary>
	/// <para>The time when the Bank Employment Report was generated, in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format (e.g. "2018-04-12T03:32:11Z").</para>
	/// </summary>
	[JsonPropertyName("generated_time")]
	public DateTimeOffset GeneratedTime { get; init; } = default!;

	/// <summary>
	/// <para>The number of days requested by the customer for the Bank Employment Report.</para>
	/// </summary>
	[JsonPropertyName("days_requested")]
	public int DaysRequested { get; init; } = default!;

	/// <summary>
	/// <para>The list of Items in the report along with the associated metadata about the Item.</para>
	/// </summary>
	[JsonPropertyName("items")]
	public IReadOnlyList<Entity.CreditBankEmploymentItem> Items { get; init; } = default!;

	/// <summary>
	/// <para>If data from the Bank Employment report was unable to be retrieved, the warnings will contain information about the error that caused the data to be incomplete.</para>
	/// </summary>
	[JsonPropertyName("warnings")]
	public IReadOnlyList<Entity.CreditBankEmploymentWarning> Warnings { get; init; } = default!;
}