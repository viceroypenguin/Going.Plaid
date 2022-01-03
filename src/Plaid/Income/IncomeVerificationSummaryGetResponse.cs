namespace Going.Plaid.Income;

/// <summary>
/// <para>IncomeVerificationSummaryGetResponse defines the response schema for <c>/income/verification/summary/get</c>.</para>
/// </summary>
public record IncomeVerificationSummaryGetResponse : ResponseBase
{
	/// <summary>
	/// <para>A list of income summaries.</para>
	/// </summary>
	[JsonPropertyName("income_summaries")]
	public IReadOnlyList<Entity.IncomeSummary> IncomeSummaries { get; init; } = default!;
}
