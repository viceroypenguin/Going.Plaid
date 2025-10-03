namespace Going.Plaid.Cra;

/// <summary>
/// <para>CraCheckReportLendScoreGetResponse defines the response schema for <c>/cra/check_report/lend_score/get</c>.</para>
/// </summary>
public record CraCheckReportLendScoreGetResponse : ResponseBase
{
	/// <summary>
	/// <para>Contains data for the CRA Lend Score Report.</para>
	/// </summary>
	[JsonPropertyName("report")]
	public Entity.CraLendScoreReport Report { get; init; } = default!;

	/// <summary>
	/// <para>If the Lend Score generation was successful but a subset of data could not be retrieved, this array will contain information about the errors causing information to be missing</para>
	/// </summary>
	[JsonPropertyName("warnings")]
	public IReadOnlyList<Entity.CraReportWarning>? Warnings { get; init; } = default!;

}
