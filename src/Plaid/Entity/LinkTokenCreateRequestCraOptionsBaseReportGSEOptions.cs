namespace Going.Plaid.Entity;

/// <summary>
/// <para>Specifies options for initializing Link to create reports that can be shared with GSEs for mortgage verification.</para>
/// </summary>
public class LinkTokenCreateRequestCraOptionsBaseReportGSEOptions
{
	/// <summary>
	/// <para>Specifies which types of reports should be made available to GSEs.</para>
	/// </summary>
	[JsonPropertyName("report_types")]
	public IReadOnlyList<Entity.GSEReportType> ReportTypes { get; set; } = default!;

}
