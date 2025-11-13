namespace Going.Plaid.Cra;

/// <summary>
/// <para>CraCheckReportBaseReportGetResponse defines the response schema for <c>/cra/check_report/base_report/get</c></para>
/// </summary>
public record CraCheckReportBaseReportGetResponse : ResponseBase
{
	/// <summary>
	/// <para>An object representing a Base Report</para>
	/// </summary>
	[JsonPropertyName("report")]
	public Entity.BaseReport Report { get; init; } = default!;

	/// <summary>
	/// <para>This array contains any information about errors or alerts related to the Base Report that did not block generation of the report.</para>
	/// </summary>
	[JsonPropertyName("warnings")]
	public IReadOnlyList<Entity.BaseReportWarning> Warnings { get; init; } = default!;

}
