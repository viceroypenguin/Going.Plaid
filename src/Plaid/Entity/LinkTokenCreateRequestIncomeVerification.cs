namespace Going.Plaid.Entity;

/// <summary>
/// <para>Specifies options for initializing Link for use with the Income product. This field is required if <c>income_verification</c> is included in the <c>products</c> array.</para>
/// </summary>
public class LinkTokenCreateRequestIncomeVerification
{
	/// <summary>
	/// <para>The <c>income_verification_id</c> of the verification instance, as provided by <c>/income/verification/create</c>. Replaced by the user token.</para>
	/// </summary>
	[JsonPropertyName("income_verification_id")]
	public string? IncomeVerificationId { get; set; } = default!;

	/// <summary>
	/// <para>The <c>asset_report_id</c> of an asset report associated with the user, as provided by <c>/asset_report/create</c>. Providing an <c>asset_report_id</c> is optional and can be used to verify the user through a streamlined flow. If provided, the bank linking flow will be skipped.</para>
	/// </summary>
	[JsonPropertyName("asset_report_id")]
	public string? AssetReportId { get; set; } = default!;

	/// <summary>
	/// <para>An array of access tokens corresponding to Items that a user has previously connected with. Data from these institutions will be cross-referenced with document data received during the Document Income flow to help verify that the uploaded documents are accurate. If the <c>transactions</c> product was not initialized for these Items during link, it will be initialized after this Link session.</para>
	/// <para>This field should only be used with the <c>payroll</c> income source type.</para>
	/// </summary>
	[JsonPropertyName("access_tokens")]
	public IReadOnlyList<string>? AccessTokens { get; set; } = default!;

	/// <summary>
	/// <para>The types of source income data that users will be permitted to share. Options include <c>bank</c> and <c>payroll</c>. Currently you can only specify one of these options.</para>
	/// </summary>
	[JsonPropertyName("income_source_types")]
	public IReadOnlyList<Entity.IncomeVerificationSourceType>? IncomeSourceTypes { get; set; } = default!;

	/// <summary>
	/// <para>Specifies options for initializing Link for use with Bank Income. This field is required if <c>income_verification</c> is included in the <c>products</c> array and <c>bank</c> is specified in <c>income_source_types</c>.</para>
	/// </summary>
	[JsonPropertyName("bank_income")]
	public Entity.LinkTokenCreateRequestIncomeVerificationBankIncome? BankIncome { get; set; } = default!;

	/// <summary>
	/// <para>Specifies options for initializing Link for use with Payroll Income (including Document Income). Further customization options for Document Income, such as customizing which document types may be uploaded, are also available via the <a href="https://dashboard.plaid.com/link">Link Customization pane</a> in the Dashboard. (Requires Production enablement.)</para>
	/// </summary>
	[JsonPropertyName("payroll_income")]
	public Entity.LinkTokenCreateRequestIncomeVerificationPayrollIncome? PayrollIncome { get; set; } = default!;

	/// <summary>
	/// <para>A list of user stated income sources</para>
	/// </summary>
	[JsonPropertyName("stated_income_sources")]
	public IReadOnlyList<Entity.LinkTokenCreateRequestUserStatedIncomeSource>? StatedIncomeSources { get; set; } = default!;

}
