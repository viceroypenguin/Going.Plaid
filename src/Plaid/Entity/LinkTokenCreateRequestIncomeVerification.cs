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
}