namespace Going.Plaid.AssetReport;

/// <summary>
/// <para>AssetReportGetResponse defines the response schema for <c>/asset_report/get</c></para>
/// </summary>
public record AssetReportGetResponse : ResponseBase
{
	/// <summary>
	/// <para>An object representing an Asset Report</para>
	/// </summary>
	[JsonPropertyName("report")]
	public Entity.AssetReport Report { get; init; } = default!;

	/// <summary>
	/// <para>If the Asset Report generation was successful but identity information cannot be returned, this array will contain information about the errors causing identity information to be missing</para>
	/// </summary>
	[JsonPropertyName("warnings")]
	public IReadOnlyList<Entity.Warning> Warnings { get; init; } = default!;
}