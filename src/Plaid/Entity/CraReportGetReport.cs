namespace Going.Plaid.Entity;

/// <summary>
/// <para>The Consumer Report returned by <c>/cra/report/get</c>.</para>
/// </summary>
public record CraReportGetReport
{
	/// <summary>
	/// <para>The identifier of the report that was returned. Pass this value to <c>/cra/report/get</c> to retrieve the same report again. <c>null</c> if the returned report has no stored identifier.</para>
	/// </summary>
	[JsonPropertyName("report_id")]
	public string? ReportId { get; init; } = default!;

	/// <summary>
	/// <para>Client-generated identifier, which can be used by lenders to track loan applications.</para>
	/// </summary>
	[JsonPropertyName("client_report_id")]
	public string? ClientReportId { get; init; } = default!;

	/// <summary>
	/// <para>The date and time the report was retrieved.</para>
	/// </summary>
	[JsonPropertyName("retrieved_time")]
	public DateTimeOffset RetrievedTime { get; init; } = default!;

	/// <summary>
	/// <para>Determines whose items are used. <c>PLAID_NETWORK</c> (default) uses the Plaid Network view of the user's profile. <c>CLIENT_USER</c> uses only the items linked by this client.</para>
	/// </summary>
	[JsonPropertyName("scope")]
	public Entity.CraReportScope Scope { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("decision_stage")]
	public Entity.CraReportDecisionStage DecisionStage { get; init; } = default!;

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
	public Entity.ConsumerReportPermissiblePurpose ConsumerReportPermissiblePurpose { get; init; } = default!;

	/// <summary>
	/// <para>Per-product report data. Each entry corresponds to one requested product.</para>
	/// </summary>
	[JsonPropertyName("products")]
	public IReadOnlyList<Entity.CraReportGetResponseProduct> Products { get; init; } = default!;

}
