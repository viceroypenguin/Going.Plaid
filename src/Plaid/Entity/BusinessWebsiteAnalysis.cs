namespace Going.Plaid.Entity;

/// <summary>
/// <para>Website analysis details if a website is found for the provided website in the search terms.</para>
/// </summary>
public record BusinessWebsiteAnalysis
{
	/// <summary>
	/// <para>Tri-state boolean status, where <c>no_data</c> indicates the check could not determine a value.</para>
	/// </summary>
	[JsonPropertyName("is_parked")]
	public Entity.BusinessCheckBooleanStatus IsParked { get; init; } = default!;

	/// <summary>
	/// <para>Tri-state boolean status, where <c>no_data</c> indicates the check could not determine a value.</para>
	/// </summary>
	[JsonPropertyName("email_is_deliverable")]
	public Entity.BusinessCheckBooleanStatus EmailIsDeliverable { get; init; } = default!;

	/// <summary>
	/// <para>Build status of the business website.</para>
	/// </summary>
	[JsonPropertyName("website_build_status")]
	public Entity.BusinessWebsiteBuildStatus WebsiteBuildStatus { get; init; } = default!;

	/// <summary>
	/// <para>WHOIS metadata for the business website domain.</para>
	/// </summary>
	[JsonPropertyName("whois_record")]
	public Entity.BusinessWhoisRecord WhoisRecord { get; init; } = default!;

	/// <summary>
	/// <para>SSL status for the business website.</para>
	/// </summary>
	[JsonPropertyName("ssl")]
	public Entity.BusinessWebsiteSSL Ssl { get; init; } = default!;

}
