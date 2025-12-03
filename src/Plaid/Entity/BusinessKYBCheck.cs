namespace Going.Plaid.Entity;

/// <summary>
/// <para>Results from the KYB (Know Your Business) identity verification check</para>
/// </summary>
public record BusinessKYBCheck
{
	/// <summary>
	/// <para>Status of the KYB (Know Your Business) identity assessment check</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.BusinessVerificationStatus Status { get; init; } = default!;

	/// <summary>
	/// <para>A score from 0 to 100 indicating the confidence in KYB (Know Your Business) identity assessment for the business</para>
	/// </summary>
	[JsonPropertyName("score")]
	public int Score { get; init; } = default!;

	/// <summary>
	/// <para>Summary of how a specific business field matched against data provider results</para>
	/// </summary>
	[JsonPropertyName("name")]
	public Entity.BusinessFieldMatchSummary Name { get; init; } = default!;

	/// <summary>
	/// <para>Summary of how a specific business field matched against data provider results</para>
	/// </summary>
	[JsonPropertyName("address")]
	public Entity.BusinessFieldMatchSummary Address { get; init; } = default!;

	/// <summary>
	/// <para>Summary of how a specific business field matched against data provider results</para>
	/// </summary>
	[JsonPropertyName("website")]
	public Entity.BusinessFieldMatchSummary Website { get; init; } = default!;

	/// <summary>
	/// <para>Detailed information about the business from data provider results</para>
	/// </summary>
	[JsonPropertyName("match_details")]
	public Entity.BusinessKYBMatchDetails? MatchDetails { get; init; } = default!;

}
