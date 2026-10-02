namespace Going.Plaid.Cra;

/// <summary>
/// <para>CraReportCreateResponse defines the response schema for <c>/cra/report/create</c>.</para>
/// </summary>
public record CraReportCreateResponse : ResponseBase
{
	/// <summary>
	/// <para>The identifier of the report being generated. Use it to retrieve the report once its products are ready.</para>
	/// </summary>
	[JsonPropertyName("report_id")]
	public string ReportId { get; init; } = default!;

}
