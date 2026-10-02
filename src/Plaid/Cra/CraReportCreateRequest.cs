namespace Going.Plaid.Cra;

/// <summary>
/// <para>CraReportCreateRequest defines the request schema for <c>/cra/report/create</c>.</para>
/// </summary>
public partial class CraReportCreateRequest : RequestBase
{
	/// <summary>
	/// <para>A unique user identifier, created by <c>/user/create</c>. Integrations that began using <c>/user/create</c> after December 10, 2025 use this field to identify a user instead of the <c>user_token</c>. For more details, see <a href="https://plaid.com/docs/api/users/user-apis">New User APIs</a>.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string UserId { get; set; } = default!;

	/// <summary>
	/// <para>The Plaid Check products, versions, and options to generate for the report.</para>
	/// </summary>
	[JsonPropertyName("products")]
	public IReadOnlyList<Entity.CraReportProduct> Products { get; set; } = default!;

	/// <summary>
	/// <para>Determines whose items are used. <c>PLAID_NETWORK</c> (default) uses the Plaid Network view of the user's profile. <c>CLIENT_USER</c> uses only the items linked by this client.</para>
	/// </summary>
	[JsonPropertyName("scope")]
	public Entity.CraReportScope? Scope { get; set; } = default!;

	/// <summary>
	/// <para>The stage in the lending lifecycle that the report is for.</para>
	/// </summary>
	[JsonPropertyName("decision_stage")]
	public Entity.CraReportDecisionStage DecisionStage { get; set; } = default!;

	/// <summary>
	/// <para>Describes the reason you are generating a Consumer Report for this user. When calling <c>/link/token/create</c>, this field is required when using Plaid Check (CRA) products; invalid if not using Plaid Check (CRA) products.</para>
	/// </summary>
	[JsonPropertyName("consumer_report_permissible_purpose")]
	public Entity.ConsumerReportPermissiblePurpose ConsumerReportPermissiblePurpose { get; set; } = default!;

	/// <summary>
	/// <para>Client-generated identifier, which can be used by lenders to track loan applications.</para>
	/// </summary>
	[JsonPropertyName("client_report_id")]
	public string? ClientReportId { get; set; } = default!;

	/// <summary>
	/// <para>The number of days of history to include in Plaid Check products. Maximum is 731; minimum is 180. If a value lower than 180 is provided, a minimum of 180 days of history will be requested.</para>
	/// </summary>
	[JsonPropertyName("days_requested")]
	public int? DaysRequested { get; set; } = default!;

	/// <summary>
	/// <para>The minimum number of days of data required for the report to be successfully generated.</para>
	/// </summary>
	[JsonPropertyName("days_required")]
	public int? DaysRequired { get; set; } = default!;

	/// <summary>
	/// <para>Indicates that investment data should be extracted from the linked account(s).</para>
	/// </summary>
	[JsonPropertyName("include_investments")]
	public bool? IncludeInvestments { get; set; } = default!;

	/// <summary>
	/// <para>The destination URL to which the report's webhooks will be sent.</para>
	/// </summary>
	[JsonPropertyName("webhook")]
	public string? Webhook { get; set; } = default!;

}
