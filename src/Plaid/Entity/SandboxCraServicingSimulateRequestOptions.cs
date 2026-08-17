namespace Going.Plaid.Entity;

/// <summary>
/// <para>Optional parameters controlling the simulated report.</para>
/// </summary>
public class SandboxCraServicingSimulateRequestOptions
{
	/// <summary>
	/// <para>The end of the synthesized transaction window ("the present"), as a YYYY-MM-DD date. Accepts past or future dates up to 180 days ahead; defaults to today. A later value appends newer transactions without churning earlier ones.</para>
	/// </summary>
	[JsonPropertyName("transactions_end_date")]
	public DateOnly? TransactionsEndDate { get; set; } = default!;

	/// <summary>
	/// <para>If set, skip report generation and instead fire a <c>CRA_REPORT_UPDATED</c> error webhook carrying this code.</para>
	/// </summary>
	[JsonPropertyName("error_webhook_code")]
	public Entity.SandboxCraServicingSimulateErrorWebhookCode? ErrorWebhookCode { get; set; } = default!;

}
