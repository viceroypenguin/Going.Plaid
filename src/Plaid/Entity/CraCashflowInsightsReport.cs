namespace Going.Plaid.Entity;

/// <summary>
/// <para>Contains data for the CRA Cashflow Insights Report.</para>
/// </summary>
public record CraCashflowInsightsReport
{
	/// <summary>
	/// <para>The unique identifier associated with the report object.</para>
	/// </summary>
	[JsonPropertyName("report_id")]
	public string ReportId { get; init; } = default!;

	/// <summary>
	/// <para>The time when the report was generated.</para>
	/// </summary>
	[JsonPropertyName("generated_time")]
	public DateTimeOffset GeneratedTime { get; init; } = default!;

	/// <summary>
	/// <para>A map of cash flow attributes, where the key is a string, and the value is a float, int, or boolean. The specific list of attributes will depend on the cash flow attributes version used. For a full list of attributes, contact your account manager.</para>
	/// </summary>
	[JsonPropertyName("attributes")]
	public Entity.CashflowAttributes? Attributes { get; init; } = default!;

}
