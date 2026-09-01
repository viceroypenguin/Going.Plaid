namespace Going.Plaid.Entity;

/// <summary>
/// <para>An optional set of parameters corresponding to transactions options.</para>
/// </summary>
public class SandboxPublicTokenCreateRequestOptionsTransactions
{
	/// <summary>
	/// <para>Use <c>days_requested</c> instead. This field has no effect on the amount of transaction history available on the Item.</para>
	/// </summary>
	[JsonPropertyName("start_date")]
	[Obsolete]
	public DateOnly? StartDate { get; set; } = default!;

	/// <summary>
	/// <para>Use <c>days_requested</c> instead. This field has no effect on the amount of transaction history available on the Item.</para>
	/// </summary>
	[JsonPropertyName("end_date")]
	[Obsolete]
	public DateOnly? EndDate { get; set; } = default!;

	/// <summary>
	/// <para>The maximum number of days of transaction history to request for the Transactions product, matching <a href="https://plaid.com/docs/api/link/#link-token-create-request-transactions-days-requested"><c>transactions.days_requested</c></a> on <c>/link/token/create</c>. If no value is specified, this defaults to 90 days. Once Transactions has been added to an Item, this value cannot be updated.</para>
	/// </summary>
	[JsonPropertyName("days_requested")]
	public int? DaysRequested { get; set; } = default!;

}
