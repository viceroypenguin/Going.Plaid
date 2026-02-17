namespace Going.Plaid.Cra;

/// <summary>
/// <para>CraCheckReportVerificationGetResponse defines the response schema for <c>/cra/check_report/verification/get</c>.</para>
/// </summary>
public record CraCheckReportVerificationGetResponse : ResponseBase
{
	/// <summary>
	/// <para>Contains data for the CRA Home Lending Report.</para>
	/// </summary>
	[JsonPropertyName("report")]
	public Entity.CraVerificationReport Report { get; init; } = default!;

	/// <summary>
	/// <para>If the home lending report generation was successful but a subset of data could not be retrieved, this array will contain information about the errors causing information to be missing.</para>
	/// </summary>
	[JsonPropertyName("warnings")]
	public IReadOnlyList<Entity.CraReportWarning> Warnings { get; init; } = default!;

}
