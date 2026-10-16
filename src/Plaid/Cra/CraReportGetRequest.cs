namespace Going.Plaid.Cra;

/// <summary>
/// <para>CraReportGetRequest defines the request schema for <c>/cra/report/get</c>.</para>
/// </summary>
public partial class CraReportGetRequest : RequestBase
{
	/// <summary>
	/// <para>A unique user identifier, created by <c>/user/create</c>. Integrations that began using <c>/user/create</c> after December 10, 2025 use this field to identify a user instead of the <c>user_token</c>. For more details, see <a href="https://plaid.com/docs/api/users/user-apis">New User APIs</a>.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string UserId { get; set; } = default!;

	/// <summary>
	/// <para>The requested products and their versions, e.g. <c>[{"product":"cra_income_insights","version":"V2"}]</c>.</para>
	/// </summary>
	[JsonPropertyName("products")]
	public IReadOnlyList<Entity.CraReportGetRequestProduct> Products { get; set; } = default!;

	/// <summary>
	/// <para>Determines whose items are used. <c>PLAID_NETWORK</c> (default) uses the Plaid Network view of the user's profile. <c>CLIENT_USER</c> uses only the items linked by this client.</para>
	/// </summary>
	[JsonPropertyName("scope")]
	public Entity.CraReportScope? Scope { get; set; } = default!;

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
	/// <para>A unique ID identifying a Consumer Report. Like all Plaid identifiers, this ID is case sensitive. When provided, that specific report is returned; when omitted, the most recent report matching the request is returned. Omit this field when retrieving a report without a prior <c>/cra/report/create</c> or <c>/link/token/create</c> request.</para>
	/// </summary>
	[JsonPropertyName("report_id")]
	public string? ReportId { get; set; } = default!;

}
