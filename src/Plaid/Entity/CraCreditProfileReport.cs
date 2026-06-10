namespace Going.Plaid.Entity;

/// <summary>
/// <para>Contains data for the CRA Credit Profile Report.</para>
/// </summary>
public record CraCreditProfileReport
{
	/// <summary>
	/// <para>The time when the report was retrieved.</para>
	/// </summary>
	[JsonPropertyName("date_retrieved")]
	public DateTimeOffset DateRetrieved { get; init; } = default!;

	/// <summary>
	/// <para>The inquiry type of credit profile report.</para>
	/// </summary>
	[JsonPropertyName("inquiry_type")]
	public Entity.CraCreditProfileInquiryType InquiryType { get; init; } = default!;

	/// <summary>
	/// <para>Client-generated identifier, which can be used by lenders to track loan applications.</para>
	/// </summary>
	[JsonPropertyName("client_report_id")]
	public string ClientReportId { get; init; } = default!;

	/// <summary>
	/// <para>The LendScore results for the credit profile report.</para>
	/// </summary>
	[JsonPropertyName("lend_scores")]
	public IReadOnlyList<Entity.CraCreditProfileLendScore> LendScores { get; init; } = default!;

	/// <summary>
	/// <para>A map of cash flow attributes, where the key is a string, and the value is a float, int, or boolean. The specific list of attributes will depend on the cash flow attributes version used. For a full list of attributes, contact your account manager.</para>
	/// </summary>
	[JsonPropertyName("cashflow_insights_attributes")]
	public Entity.CraCreditProfileCashflowAttributes? CashflowInsightsAttributes { get; init; } = default!;

	/// <summary>
	/// <para>A map of network attributes, where the key is a string, and the value is a float, int, or boolean. For a full list of attributes, contact your account manager.</para>
	/// </summary>
	[JsonPropertyName("network_insights_attributes")]
	public Entity.CraCreditProfileNetworkInsights? NetworkInsightsAttributes { get; init; } = default!;

	/// <summary>
	/// <para>Metadata about the CRA Credit Profile Report.</para>
	/// </summary>
	[JsonPropertyName("metadata")]
	public Entity.CraCreditProfileReportMetadata? Metadata { get; init; } = default!;

}
