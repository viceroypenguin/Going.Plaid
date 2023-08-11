namespace Going.Plaid.Cra;

/// <summary>
/// <para>BaseReportGetResponse defines the response schema for <c>/cra/base_report/get</c></para>
/// </summary>
public record BaseReportGetResponse : ResponseBase
{
	/// <summary>
	/// <para>An object representing a Base Report</para>
	/// </summary>
	[JsonPropertyName("report")]
	public Entity.BaseReport Report { get; init; } = default!;
}