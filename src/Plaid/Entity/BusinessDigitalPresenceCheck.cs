namespace Going.Plaid.Entity;

/// <summary>
/// <para>Results from the digital presence check.</para>
/// </summary>
public record BusinessDigitalPresenceCheck
{
	/// <summary>
	/// <para>Status of the digital presence check</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.BusinessVerificationStatus Status { get; init; } = default!;

	/// <summary>
	/// <para>A score from 0 to 100 indicating digital presence confidence.</para>
	/// </summary>
	[JsonPropertyName("score")]
	public int Score { get; init; } = default!;

	/// <summary>
	/// <para>Summary of how a specific business field matched against data provider results</para>
	/// </summary>
	[JsonPropertyName("address")]
	public Entity.BusinessFieldMatchSummary Address { get; init; } = default!;

	/// <summary>
	/// <para>Summary of how a specific business field matched against data provider results</para>
	/// </summary>
	[JsonPropertyName("phone_number")]
	public Entity.BusinessFieldMatchSummary PhoneNumber { get; init; } = default!;

	/// <summary>
	/// <para>Summary of how a specific business field matched against data provider results</para>
	/// </summary>
	[JsonPropertyName("email_address")]
	public Entity.BusinessFieldMatchSummary EmailAddress { get; init; } = default!;

	/// <summary>
	/// <para>Summary of how a specific business field matched against data provider results</para>
	/// </summary>
	[JsonPropertyName("website")]
	public Entity.BusinessFieldMatchSummary Website { get; init; } = default!;

	/// <summary>
	/// <para>Website analysis details if a website is found for the provided website in the search terms.</para>
	/// </summary>
	[JsonPropertyName("website_analysis")]
	public Entity.BusinessWebsiteAnalysis? WebsiteAnalysis { get; init; } = default!;

}
