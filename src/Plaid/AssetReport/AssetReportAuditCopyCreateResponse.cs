namespace Going.Plaid.AssetReport;

/// <summary>
/// <para>AssetReportAuditCopyCreateResponse defines the response schema for <c>/asset_report/audit_copy/get</c></para>
/// </summary>
public record AssetReportAuditCopyCreateResponse : ResponseBase
{
	/// <summary>
	/// <para>A token that can be shared with a third party auditor to allow them to obtain access to the Asset Report. This token should be stored securely.</para>
	/// </summary>
	[JsonPropertyName("audit_copy_token")]
	public string AuditCopyToken { get; init; } = default!;

}
