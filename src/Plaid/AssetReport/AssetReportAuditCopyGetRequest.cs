namespace Going.Plaid.AssetReport;

/// <summary>
/// <para>AssetReportAuditCopyGetRequest defines the request schema for <c>/asset_report/audit_copy/get</c></para>
/// </summary>
public class AssetReportAuditCopyGetRequest : RequestBase
{
	/// <summary>
	/// <para>The <c>audit_copy_token</c> granting access to the Audit Copy you would like to get.</para>
	/// </summary>
	[JsonPropertyName("audit_copy_token")]
	public string AuditCopyToken { get; set; } = default!;
}