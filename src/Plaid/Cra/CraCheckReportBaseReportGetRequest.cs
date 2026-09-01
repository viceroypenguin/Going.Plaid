namespace Going.Plaid.Cra;

/// <summary>
/// <para>CraCheckReportBaseReportGetRequest defines the request schema for <c>/cra/check_report/base_report/get</c></para>
/// </summary>
public partial class CraCheckReportBaseReportGetRequest : RequestBase
{
	/// <summary>
	/// <para>A unique user identifier, created by <c>/user/create</c>. Integrations that began using <c>/user/create</c> after December 10, 2025 use this field to identify a user instead of the <c>user_token</c>. For more details, see <a href="https://plaid.com/docs/api/users/user-apis">New User APIs</a>.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string? UserId { get; set; } = default!;

	/// <summary>
	/// <para>The third-party user token associated with the requested User data.</para>
	/// </summary>
	[JsonPropertyName("third_party_user_token")]
	public string? ThirdPartyUserToken { get; set; } = default!;

	/// <summary>
	/// <para>The Item IDs to include in the Base Report. If not provided, all Items associated with the user will be included.</para>
	/// </summary>
	[JsonPropertyName("item_ids")]
	public IReadOnlyList<string>? ItemIds { get; set; } = default!;

	/// <summary>
	/// <para>The user token associated with the user for which data is being requested. This field is used only by customers with pre-existing integrations that already use the <c>user_token</c> field. All other customers should use the <c>user_id</c> instead. For more details, see <a href="https://plaid.com/docs/api/users/user-apis">New User APIs</a>.</para>
	/// </summary>
	[JsonPropertyName("user_token")]
	public string? UserToken { get; set; } = default!;

	/// <summary>
	/// <para>The tier of the user.</para>
	/// </summary>
	[JsonPropertyName("user_tier")]
	public Entity.CraUserTier? UserTier { get; set; } = default!;

	/// <summary>
	/// <para>The CRA report token (formatted <c>cra-report-&lt;env&gt;-&lt;uuid&gt;</c>) identifying a specific consumer report. When provided alongside <c>consumer_report_permissible_purpose</c>, pins retrieval to that report and stamps its permissible purpose. If omitted, the most recently generated report for the user is returned.</para>
	/// </summary>
	[JsonPropertyName("report_id")]
	public string? ReportId { get; set; } = default!;

	/// <summary>
	/// <para>The permissible purpose under which the consumer report is being retrieved.</para>
	/// </summary>
	[JsonPropertyName("consumer_report_permissible_purpose")]
	public Entity.CraCheckReportPermissiblePurpose? ConsumerReportPermissiblePurpose { get; set; } = default!;

}
