namespace Going.Plaid.Entity;

/// <summary>
/// <para>Details regarding authorization usage.</para>
/// </summary>
public record TransferMetricsGetAuthorizationUsage
{
	/// <summary>
	/// <para>The daily credit utilization formatted as a decimal.</para>
	/// </summary>
	[JsonPropertyName("daily_credit_utilization")]
	public string? DailyCreditUtilization { get; init; } = default!;

	/// <summary>
	/// <para>The daily debit utilization formatted as a decimal.</para>
	/// </summary>
	[JsonPropertyName("daily_debit_utilization")]
	public string? DailyDebitUtilization { get; init; } = default!;

	/// <summary>
	/// <para>The monthly credit utilization formatted as a decimal.</para>
	/// </summary>
	[JsonPropertyName("monthly_credit_utilization")]
	public string? MonthlyCreditUtilization { get; init; } = default!;

	/// <summary>
	/// <para>The monthly debit utilization formatted as a decimal.</para>
	/// </summary>
	[JsonPropertyName("monthly_debit_utilization")]
	public string? MonthlyDebitUtilization { get; init; } = default!;

}
