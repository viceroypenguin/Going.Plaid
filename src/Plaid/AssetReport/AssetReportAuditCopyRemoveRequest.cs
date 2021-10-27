namespace Going.Plaid.AssetReport;

/// <summary>
/// <para>AssetReportAuditCopyRemoveRequest defines the request schema for <c>/asset_report/audit_copy/remove</c></para>
/// </summary>
public partial class AssetReportAuditCopyRemoveRequest : RequestBase
{
	/// <summary>
	/// <para>The <c>audit_copy_token</c> granting access to the Audit Copy you would like to revoke.</para>
	/// </summary>
	[JsonPropertyName("audit_copy_token")]
	public string AuditCopyToken { get; set; } = default!;
}