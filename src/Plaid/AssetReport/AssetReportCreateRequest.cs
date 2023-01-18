namespace Going.Plaid.AssetReport;

/// <summary>
/// <para>AssetReportCreateRequest defines the request schema for <c>/asset_report/create</c></para>
/// </summary>
public partial class AssetReportCreateRequest : RequestBase
{
	/// <summary>
	/// <para>An array of access tokens corresponding to the Items that will be included in the report. The <c>assets</c> product must have been initialized for the Items during link; the Assets product cannot be added after initialization.</para>
	/// </summary>
	[JsonPropertyName("access_tokens")]
	public IReadOnlyList<string> AccessTokens { get; set; } = default!;

	/// <summary>
	/// <para>The maximum integer number of days of history to include in the Asset Report. If using Fannie Mae Day 1 Certainty, <c>days_requested</c> must be at least 61 for new originations or at least 31 for refinancings.</para>
	/// <para>An Asset Report requested with "Additional History" (that is, with more than 61 days of transaction history) will incur an Additional History fee.</para>
	/// </summary>
	[JsonPropertyName("days_requested")]
	public int DaysRequested { get; set; } = default!;

	/// <summary>
	/// <para>An optional object to filter <c>/asset_report/create</c> results. If provided, must be non-<c>null</c>. The optional <c>user</c> object is required for the report to be eligible for Fannie Mae's Day 1 Certainty program.</para>
	/// </summary>
	[JsonPropertyName("options")]
	public Entity.AssetReportCreateRequestOptions Options { get; set; } = default!;

	/// <summary>
	/// <para>When set to VERIFICATION_OF_EMPLOYMENT and the Asset Report is added to an Audit Copy Token, the Asset Report will be retrieved by Freddie Mac in the Verification Of Employment (VOE) version instead of the default Verification Of Assets (VOA) version.</para>
	/// </summary>
	[JsonPropertyName("report_type")]
	public Entity.FreddieReportType ReportType { get; set; } = default!;
}