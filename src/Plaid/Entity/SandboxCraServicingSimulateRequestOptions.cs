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
	/// <para>If set, skip report generation and instead fire a <c>CRA_REPORT_UPDATED</c> error webhook carrying this code. The accepted values depend on the <c>scope</c> of the subscription being simulated, since a simulation can only fire a webhook that scope would send in Production. A <c>CLIENT_USER</c> subscription accepts <c>USER_NOT_FOUND</c> and <c>PRODUCT_GENERATION_FAILED</c>; a <c>PLAID_NETWORK</c> subscription accepts <c>UNMATCH</c>, <c>DATA_UNAVAILABLE</c>, <c>NO_ELIGIBLE_ITEMS_ON_PROFILE</c>, and <c>PRODUCT_GENERATION_ERROR</c>. Supplying a code that does not match the subscription's scope returns an <c>INVALID_FIELD</c> error.</para>
	/// </summary>
	[JsonPropertyName("error_webhook_code")]
	public Entity.SandboxCraServicingSimulateErrorWebhookCode? ErrorWebhookCode { get; set; } = default!;

}
