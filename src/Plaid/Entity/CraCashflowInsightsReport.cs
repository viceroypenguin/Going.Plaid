namespace Going.Plaid.Entity;

/// <summary>
/// <para>Contains data for the CRA Cashflow Insights Report.</para>
/// </summary>
public record CraCashflowInsightsReport
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
	/// <para>The results of the Plaid Check score</para>
	/// </summary>
	[JsonPropertyName("plaid_check_score")]
	public Entity.PlaidCheckScore? PlaidCheckScore { get; init; } = default!;

	/// <summary>
	/// <para>A map of cashflow attributes, where the key is a string, and the value is a float, int, or boolean.</para>
	/// </summary>
	[JsonPropertyName("attributes")]
	public Entity.CashflowAttributes? Attributes { get; init; } = default!;

}
