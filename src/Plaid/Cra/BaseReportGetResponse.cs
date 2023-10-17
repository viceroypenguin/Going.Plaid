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

	/// <summary>
	/// <para>If the Base Report generation was successful but identity information cannot be returned, this array will contain information about the errors causing identity information to be missing</para>
	/// </summary>
	[JsonPropertyName("warnings")]
	public IReadOnlyList<Entity.BaseReportWarning>? Warnings { get; init; } = default!;
}