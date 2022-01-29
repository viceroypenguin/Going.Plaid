namespace Going.Plaid.Entity;

/// <summary>
/// <para>Specifies options for initializing Link for use with the Income (beta) product. This field is required if <c>income_verification</c> is included in the <c>products</c> array.</para>
/// </summary>
public class LinkTokenCreateRequestIncomeVerification
{
	/// <summary>
	/// <para>The <c>income_verification_id</c> of the verification instance, as provided by <c>/income/verification/create</c>.</para>
	/// </summary>
	[JsonPropertyName("income_verification_id")]
	public string IncomeVerificationId { get; set; } = default!;

	/// <summary>
	/// <para>The <c>asset_report_id</c> of an asset report associated with the user, as provided by <c>/asset_report/create</c>. Providing an <c>asset_report_id</c> is optional and can be used to verify the user through a streamlined flow. If provided, the bank linking flow will be skipped.</para>
	/// </summary>
	[JsonPropertyName("asset_report_id")]
	public string AssetReportId { get; set; } = default!;

	/// <summary>
	/// <para>The ID of a precheck created with <c>/income/verification/precheck</c>. Will be used to improve conversion of the income verification flow by streamlining the Link interface presented to the end user.</para>
	/// </summary>
	[JsonPropertyName("precheck_id")]
	public string PrecheckId { get; set; } = default!;

	/// <summary>
	/// <para>An array of access tokens corresponding to the Items that will be cross-referenced with the product data. If the <c>transactions</c> product was not initialized for the Items during link, it will be initialized after this Link session.</para>
	/// </summary>
	[JsonPropertyName("access_tokens")]
	public IReadOnlyList<string> AccessTokens { get; set; } = default!;
}