namespace Going.Plaid.AssetReport;

/// <summary>
/// <para>AssetReportAuditCopyRemoveResponse defines the response schema for <c>/asset_report/audit_copy/remove</c></para>
/// </summary>
public record AssetReportAuditCopyRemoveResponse : ResponseBase
{
	/// <summary>
	/// <para><c>true</c> if the Audit Copy was successfully removed.</para>
	/// </summary>
	[JsonPropertyName("removed")]
	public bool Removed { get; init; } = default!;
}