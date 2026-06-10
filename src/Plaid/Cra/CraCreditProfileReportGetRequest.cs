namespace Going.Plaid.Cra;

/// <summary>
/// <para>CraCreditProfileReportGetRequest defines the request schema for <c>/cra/credit_profile/report/get</c>.</para>
/// </summary>
public partial class CraCreditProfileReportGetRequest : RequestBase
{
	/// <summary>
	/// <para>A unique user identifier, created by <c>/user/create</c>. Integrations that began using <c>/user/create</c> after December 10, 2025 use this field to identify a user instead of the <c>user_token</c>. For more details, see <a href="https://plaid.com/docs/api/users/user-apis">New User APIs</a>.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string UserId { get; set; } = default!;

	/// <summary>
	/// <para>Describes the reason you are generating a Consumer Report for this user. When calling <c>/link/token/create</c>, this field is required when using Plaid Check (CRA) products; invalid if not using Plaid Check (CRA) products.</para>
	/// </summary>
	[JsonPropertyName("consumer_report_permissible_purpose")]
	public Entity.ConsumerReportPermissiblePurpose ConsumerReportPermissiblePurpose { get; set; } = default!;

	/// <summary>
	/// <para>Client-generated identifier, which can be used by lenders to track loan applications.</para>
	/// </summary>
	[JsonPropertyName("client_report_id")]
	public string ClientReportId { get; set; } = default!;

	/// <summary>
	/// <para>The product type for the credit profile report request.</para>
	/// </summary>
	[JsonPropertyName("report_type")]
	public Entity.CraCreditProfileReportType ReportType { get; set; } = default!;

	/// <summary>
	/// <para>The inquiry type of credit profile report.</para>
	/// </summary>
	[JsonPropertyName("inquiry_type")]
	public Entity.CraCreditProfileInquiryType InquiryType { get; set; } = default!;

	/// <summary>
	/// <para>The version of the credit profile report to retrieve.</para>
	/// </summary>
	[JsonPropertyName("version")]
	public Entity.CraCreditProfileReportVersion Version { get; set; } = default!;

}
