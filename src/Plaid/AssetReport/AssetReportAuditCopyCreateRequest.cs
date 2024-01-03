namespace Going.Plaid.AssetReport;

/// <summary>
/// <para>AssetReportAuditCopyCreateRequest defines the request schema for <c>/asset_report/audit_copy/get</c></para>
/// </summary>
public partial class AssetReportAuditCopyCreateRequest : RequestBase
{
	/// <summary>
	/// <para>A token that can be provided to endpoints such as <c>/asset_report/get</c> or <c>/asset_report/pdf/get</c> to fetch or update an Asset Report.</para>
	/// </summary>
	[JsonPropertyName("asset_report_token")]
	public string AssetReportToken { get; set; } = default!;

	/// <summary>
	/// <para>The <c>auditor_id</c> of the third party with whom you would like to share the Asset Report.</para>
	/// </summary>
	[JsonPropertyName("auditor_id")]
	public string? AuditorId { get; set; } = default!;

}
