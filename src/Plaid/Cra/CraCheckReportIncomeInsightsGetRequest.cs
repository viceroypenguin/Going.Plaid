namespace Going.Plaid.Cra;

/// <summary>
/// <para>Defines the request schema for <c>/cra/check_report/income_insights/get</c>.</para>
/// </summary>
public partial class CraCheckReportIncomeInsightsGetRequest : RequestBase
{
	/// <summary>
	/// <para>The user token associated with the user for which data is being requested. This field is used only by customers with pre-existing integrations that already use the <c>user_token</c> field. All other customers should use the <c>user_id</c> instead. For more details, see <a href="https://plaid.com/docs/api/users/user-apis">New User APIs</a>.</para>
	/// </summary>
	[JsonPropertyName("user_token")]
	public string? UserToken { get; set; } = default!;

	/// <summary>
	/// <para>The third-party user token associated with the requested User data.</para>
	/// </summary>
	[JsonPropertyName("third_party_user_token")]
	public string? ThirdPartyUserToken { get; set; } = default!;

	/// <summary>
	/// <para>A unique user identifier, created by <c>/user/create</c>. Integrations that began using <c>/user/create</c> after December 10, 2025 use this field to identify a user instead of the <c>user_token</c>. For more details, see <a href="https://plaid.com/docs/api/users/user-apis">New User APIs</a>.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string? UserId { get; set; } = default!;

	/// <summary>
	/// <para>Deprecated. This field is no longer accepted for new clients (created on or after 2026-07-01). New clients should specify required products when creating the Consumer Report. Existing integrations may continue to pass <c>options</c>.</para>
	/// </summary>
	[JsonPropertyName("options")]
	[Obsolete]
	public Entity.CraCheckReportIncomeInsightsGetOptions? Options { get; set; } = default!;

	/// <summary>
	/// <para>The CRA report token (formatted <c>cra-report-&lt;env&gt;-&lt;uuid&gt;</c>) identifying a specific consumer report. When provided alongside <c>consumer_report_permissible_purpose</c>, pins retrieval to that report and stamps its permissible purpose. If omitted, the most recently generated report for the user is returned.</para>
	/// </summary>
	[JsonPropertyName("report_id")]
	public string? ReportId { get; set; } = default!;

	/// <summary>
	/// <para>The permissible purpose under the FCRA for retrieving this consumer report. Restricted to permissible purposes related to loan servicing only. Required when <c>report_id</c> is provided.</para>
	/// </summary>
	[JsonPropertyName("consumer_report_permissible_purpose")]
	public Entity.CraCheckReportPermissiblePurpose? ConsumerReportPermissiblePurpose { get; set; } = default!;

}
