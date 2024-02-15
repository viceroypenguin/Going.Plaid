namespace Going.Plaid.Cra;

/// <summary>
/// <para>CraPartnerInsightsGetResponse defines the response schema for <c>/cra/partner_insights/get</c>.</para>
/// </summary>
public record CraPartnerInsightsGetResponse : ResponseBase
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("report")]
	public IReadOnlyList<Entity.CraPartnerInsights>? Report { get; init; } = default!;

}
