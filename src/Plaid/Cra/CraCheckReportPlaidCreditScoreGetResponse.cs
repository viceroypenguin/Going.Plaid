namespace Going.Plaid.Cra;

/// <summary>
/// <para>CraCheckReportPlaidCreditScoreGetResponse defines the response schema for <c>/cra/check_report/plaid_credit_score/get</c>.</para>
/// </summary>
public record CraCheckReportPlaidCreditScoreGetResponse : ResponseBase
{
	/// <summary>
	/// <para>Contains data for the CRA Plaid Credit Score Report.</para>
	/// </summary>
	[JsonPropertyName("report")]
	public Entity.CraPlaidCreditScoreReport Report { get; init; } = default!;

	/// <summary>
	/// <para>If the Plaid Credit Score generation was successful but a subset of data could not be retrieved, this array will contain information about the errors causing information to be missing</para>
	/// </summary>
	[JsonPropertyName("warnings")]
	public IReadOnlyList<Entity.CraReportWarning>? Warnings { get; init; } = default!;

}
