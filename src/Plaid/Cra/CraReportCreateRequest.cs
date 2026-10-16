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
	/// <para>Determines which Items are used to generate the report. <c>PLAID_NETWORK</c> uses the Plaid Network view of the user's profile. <c>CLIENT_USER</c> uses only the Items linked by this client.</para>
	/// </summary>
	[JsonPropertyName("scope")]
	public Entity.CraReportScope Scope { get; set; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("decision_stage")]
	public Entity.CraReportDecisionStage DecisionStage { get; set; } = default!;

	/// <summary>
	/// <para>Describes the reason you are generating a Consumer Report for this user. The purpose must be one of the allowable permissible purposes for the <c>decision_stage</c>.</para>
	/// <para><c>EXTENSION_OF_CREDIT</c>: In connection with a credit transaction initiated by and involving the consumer pursuant to FCRA Section 604(a)(3)(A).</para>
	/// <para><c>LEGITIMATE_BUSINESS_NEED_TENANT_SCREENING</c>: For a legitimate business need in connection with a business transaction initiated by the consumer primarily for personal, family, or household purposes in connection with a property rental assessment pursuant to FCRA Section 604(a)(3)(F)(i).</para>
	/// <para><c>LEGITIMATE_BUSINESS_NEED_OTHER</c>: For a legitimate business need in connection with a business transaction made primarily for personal, family, or household initiated by the consumer pursuant to FCRA Section 604(a)(3)(F)(i).</para>
	/// <para><c>WRITTEN_INSTRUCTION_PREQUALIFICATION</c>: In accordance with the written instructions of the consumer pursuant to FCRA Section 604(a)(2), to evaluate an application's profile to make an offer to the consumer.</para>
	/// <para><c>WRITTEN_INSTRUCTION_OTHER</c>: In accordance with the written instructions of the consumer pursuant to FCRA Section 604(a)(2), such as when an individual agrees to act as a guarantor or assumes personal liability for a consumer, business, or commercial loan.</para>
	/// <para><c>ELIGIBILITY_FOR_GOVT_BENEFITS</c>: In connection with an eligibility determination for a government benefit where the entity is required to consider an applicant's financial status pursuant to FCRA Section 604(a)(3)(D).</para>
	/// <para><c>INSURANCE_UNDERWRITING</c>: In connection with the underwriting of insurance involving the consumer pursuant to FCRA Section 604(a)(3)(C).</para>
	/// </summary>
	[JsonPropertyName("consumer_report_permissible_purpose")]
	public Entity.ConsumerReportPermissiblePurpose ConsumerReportPermissiblePurpose { get; set; } = default!;

	/// <summary>
	/// <para>Client-generated identifier, which can be used by lenders to track loan applications.</para>
	/// </summary>
	[JsonPropertyName("client_report_id")]
	public string? ClientReportId { get; set; } = default!;

	/// <summary>
	/// <para>The number of days of history to include in Plaid Check products. Maximum is 731. If a value lower than 180 is provided, a minimum of 180 days of history will be requested.</para>
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
	/// <para>Indicates that identity match results should be included for all products in the report that contain identity information. Defaults to <c>false</c>.</para>
	/// </summary>
	[JsonPropertyName("include_identity_match")]
	public bool? IncludeIdentityMatch { get; set; } = default!;

	/// <summary>
	/// <para>The destination URL to which the report's webhooks will be sent.</para>
	/// </summary>
	[JsonPropertyName("webhook")]
	public string? Webhook { get; set; } = default!;

}
