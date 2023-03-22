namespace Going.Plaid.Entity;

/// <summary>
/// <para>An optional object for <c>/credit/payroll_income/refresh</c> request options.</para>
/// </summary>
public class CreditPayrollIncomeRefreshRequestOptions
{
	/// <summary>
	/// <para>An array of <c>item_id</c>s to be refreshed. Each <c>item_id</c> should uniquely identify a payroll income item.</para>
	/// </summary>
	[JsonPropertyName("item_ids")]
	public IReadOnlyList<string> ItemIds { get; set; } = default!;

	/// <summary>
	/// <para>The URL where Plaid will send the payroll income refresh webhook.</para>
	/// </summary>
	[JsonPropertyName("webhook")]
	public string Webhook { get; set; } = default!;
}