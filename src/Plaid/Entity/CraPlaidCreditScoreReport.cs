namespace Going.Plaid.Entity;

/// <summary>
/// <para>Contains data for the CRA Plaid Credit Score Report.</para>
/// </summary>
public record CraPlaidCreditScoreReport
{
	/// <summary>
	/// <para>The unique identifier associated with the Network Attributes report object.</para>
	/// </summary>
	[JsonPropertyName("report_id")]
	public string ReportId { get; init; } = default!;

	/// <summary>
	/// <para>The time when the Network Attributes Report was generated.</para>
	/// </summary>
	[JsonPropertyName("generated_time")]
	public DateTimeOffset GeneratedTime { get; init; } = default!;

	/// <summary>
	/// <para>The results of the Plaid Credit Score</para>
	/// </summary>
	[JsonPropertyName("plaid_credit_score")]
	public Entity.PlaidCreditScore? PlaidCreditScore { get; init; } = default!;

}
