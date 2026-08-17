namespace Going.Plaid.Sandbox;

/// <summary>
/// <para>SandboxCraServicingSimulateResponse defines the response schema for <c>/sandbox/cra/servicing/simulate</c></para>
/// </summary>
public record SandboxCraServicingSimulateResponse : ResponseBase
{
	/// <summary>
	/// <para>The <c>cra-report</c> token for the seeded snapshot. Pin as <c>report_id</c> on <c>/cra/check_report/base_report/get</c> or <c>/cra/check_report/income_insights/get</c>. Omitted when <c>error_webhook_code</c> was used.</para>
	/// </summary>
	[JsonPropertyName("report_id")]
	public string? ReportId { get; init; } = default!;

}
