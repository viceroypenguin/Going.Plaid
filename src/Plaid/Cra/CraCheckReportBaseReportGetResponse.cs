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
	/// <para>If the Base Report generation was successful but identity information cannot be returned, this array will contain information about the errors causing identity information to be missing</para>
	/// </summary>
	[JsonPropertyName("warnings")]
	public IReadOnlyList<Entity.BaseReportWarning>? Warnings { get; init; } = default!;

}
