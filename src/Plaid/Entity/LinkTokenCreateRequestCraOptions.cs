namespace Going.Plaid.Entity;

/// <summary>
/// <para>Specifies options for initializing Link for use with Plaid Check products</para>
/// </summary>
public class LinkTokenCreateRequestCraOptions
{
	/// <summary>
	/// <para>The maximum integer number of days of history to include in Plaid Check products</para>
	/// </summary>
	[JsonPropertyName("days_requested")]
	public int DaysRequested { get; set; } = default!;

	/// <summary>
	/// <para>Specifies options for initializing Link for use with the Credit Partner Insights product.</para>
	/// </summary>
	[JsonPropertyName("partner_insights")]
	public Entity.LinkTokenCreateRequestCraOptionsPartnerInsights? PartnerInsights { get; set; } = default!;

	/// <summary>
	/// <para>Specifies options for initializing Link for use with the Base Report product.</para>
	/// </summary>
	[JsonPropertyName("base_report")]
	public Entity.LinkTokenCreateRequestCraOptionsBaseReport? BaseReport { get; set; } = default!;

}
