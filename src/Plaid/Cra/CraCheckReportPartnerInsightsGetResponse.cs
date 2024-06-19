namespace Going.Plaid.Cra;

/// <summary>
/// <para>CraPartnerInsightsGetResponse defines the response schema for <c>/cra/partner_insights/get</c>.</para>
/// </summary>
public record CraCheckReportPartnerInsightsGetResponse : ResponseBase
{
	/// <summary>
	/// <para>The Partner Insights report of the bank data for an end user.</para>
	/// </summary>
	[JsonPropertyName("report")]
	public Entity.CraPartnerInsights? Report { get; init; } = default!;

}
