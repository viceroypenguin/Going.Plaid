namespace Going.Plaid.Entity;

/// <summary>
/// <para>An optional object for <c>/credit/bank_income/refresh</c> request options.</para>
/// </summary>
public class CreditBankIncomeRefreshRequestOptions
{
	/// <summary>
	/// <para>How many days of data to include in the refresh. If not specified, this will default to the days requested in the most recently generated bank income report for the user.</para>
	/// </summary>
	[JsonPropertyName("days_requested")]
	public int DaysRequested { get; set; } = default!;

	/// <summary>
	/// <para>The URL where Plaid will send the bank income webhook.</para>
	/// </summary>
	[JsonPropertyName("webhook")]
	public string Webhook { get; set; } = default!;
}